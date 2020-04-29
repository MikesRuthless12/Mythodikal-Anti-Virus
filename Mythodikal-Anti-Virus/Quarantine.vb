Option Explicit Off
Option Infer On
Option Strict Off
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Windows.Forms

Namespace AntiVirus_Project
    Class Quarantine
        Private _loc As String = String.Empty
        Private _enc As Encryption = New Encryption()
        Private _password As String = "MikeDoubleYou_4234232323@!!11aselkjasf"

        Public Sub New()
            _loc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            _loc = _loc & "\MikesVirusScanner\Quarantine\"

            If Not Directory.Exists(_loc) Then
                Directory.CreateDirectory(_loc)
            End If
        End Sub

        Public Function GetCRC32(ByVal sFileName As String) As String
            Try
                Dim FS As FileStream = New FileStream(sFileName, FileMode.Open, System.IO.FileAccess.Read, FileShare.Read, 8192)
                Dim CRC32Result As Integer = &HFFFFFFFF
                If FS.Length < 1024 Then
                    Dim blah As String = FS.Length
                    Dim Buffer(blah.ToString) As Byte
                    Dim ReadSize As Integer = FS.Length


                    Dim Count As Integer = FS.Read(Buffer, 0, ReadSize)
                    Dim CRC32Table(256) As Integer
                    Dim DWPolynomial As Integer = &HEDB88320
                    Dim DWCRC As Integer
                    Dim i As Integer, j As Integer, n As Integer

                    'Create CRC32 Table
                    For i = 0 To 255
                        DWCRC = i
                        For j = 8 To 1 Step -1
                            If (DWCRC And 1) Then
                                DWCRC = ((DWCRC And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                                DWCRC = DWCRC Xor DWPolynomial
                            Else
                                DWCRC = ((DWCRC And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                            End If
                        Next j
                        CRC32Table(i) = DWCRC
                    Next i

                    'Calcualting CRC32 Hash
                    Do While (Count > 0)
                        For i = 0 To Count - 1
                            n = (CRC32Result And &HFF) Xor Buffer(i)
                            CRC32Result = ((CRC32Result And &HFFFFFF00) \ &H100) And &HFFFFFF
                            CRC32Result = CRC32Result Xor CRC32Table(n)
                        Next i
                        Count = FS.Read(Buffer, 0, ReadSize)
                    Loop
                    Return Hex(Not (CRC32Result))
                Else
                    Dim Buffer(1024) As Byte
                    Dim ReadSize As Integer = 1024

                    Dim Count As Integer = FS.Read(Buffer, 0, ReadSize)
                    Dim CRC32Table(256) As Integer
                    Dim DWPolynomial As Integer = &HEDB88320
                    Dim DWCRC As Integer
                    Dim i As Integer, j As Integer, n As Integer

                    'Create CRC32 Table
                    For i = 0 To 255
                        DWCRC = i
                        For j = 8 To 1 Step -1
                            If (DWCRC And 1) Then
                                DWCRC = ((DWCRC And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                                DWCRC = DWCRC Xor DWPolynomial
                            Else
                                DWCRC = ((DWCRC And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                            End If
                        Next j
                        CRC32Table(i) = DWCRC
                    Next i

                    'Calcualting CRC32 Hash
                    Do While (Count > 0)
                        For i = 0 To Count - 1
                            n = (CRC32Result And &HFF) Xor Buffer(i)
                            CRC32Result = ((CRC32Result And &HFFFFFF00) \ &H100) And &HFFFFFF
                            CRC32Result = CRC32Result Xor CRC32Table(n)
                        Next i
                        Count = FS.Read(Buffer, 0, ReadSize)
                    Loop
                    Return Hex(Not (CRC32Result))
                End If

            Catch ex As Exception
                Return ""
            End Try

        End Function

        Public Function GetFileSize(ByVal TheFile As String) As String
            If TheFile.Length = 0 Then Return ""
            If Not System.IO.File.Exists(TheFile) Then Return ""
            '---
            Dim TheSize As ULong = My.Computer.FileSystem.GetFileInfo(TheFile).Length
            Dim SizeType As String = ""
            '---

            Try
                Select Case TheSize
                    Case Is >= 1099511627776
                        DoubleBytes = CDbl(TheSize / 1099511627776) 'TB
                        Return FormatNumber(DoubleBytes, 2) & " TB"
                    Case 1073741824 To 1099511627775
                        DoubleBytes = CDbl(TheSize / 1073741824) 'GB
                        Return FormatNumber(DoubleBytes, 2) & " GB"
                    Case 1048576 To 1073741823
                        DoubleBytes = CDbl(TheSize / 1048576) 'MB
                        Return FormatNumber(DoubleBytes, 2) & " MB"
                    Case 1024 To 1048575
                        DoubleBytes = CDbl(TheSize / 1024) 'KB
                        Return FormatNumber(DoubleBytes, 2) & " KB"
                    Case 0 To 1023
                        DoubleBytes = TheSize ' bytes
                        Return FormatNumber(DoubleBytes, 2) & " bytes"
                    Case Else
                        Return ""
                End Select
            Catch
                Return ""
            End Try
        End Function

        Public Function QuarantineItems(_location As String) As List(Of String)
            Dim item As List(Of String) = New List(Of String)()
            Dim d As DirectoryInfo = New DirectoryInfo(_location)
            For Each file As System.IO.FileInfo In d.GetFiles("*.*")
                AddQuarantine(file.FullName)
                Dim row As String() = New String() {file.FullName, GetCRC32(file.FullName), GetFileSize(file.FullName)}
                mainForm.quarantineGridView.Rows.Add(row)
            Next

            Return item
        End Function

        Public Function AddQuarantine(file As String) As String
            Dim file_name3 As String = Path.GetFileName(file)
            _enc.EncryptFile(file, _loc & file_name3, _password)
            Dim row As String() = New String() {file.ToString(), GetCRC32(file_name3.ToString()), GetFileSize(file_name3.ToString())}
            mainForm.quarantineGridView.Rows.Add(row)
            If System.IO.File.Exists(file) Then
                System.IO.File.Move(file, _loc)
            End If
            Return _loc & file_name3
        End Function

        Public Sub RestoreFromQuarantine(file As String, _loc As String)
            Dim des As String = _loc & "\" & Path.GetFileName(file)
            _enc.DecryptFile(file, des, _password)
            Try
                If mainForm.quarantineGridView.Rows.Count > 0 And mainForm.quarantineGridView.SelectedRows.Count > 0 Then
                    Dim FileToRestore As String
                    FileToRestore = (mainForm.quarantineGridView.CurrentRow.Cells(0).Value)
                    If System.IO.File.Exists(des) = True Then
                        System.IO.File.Move(des, (mainForm.quarantineGridView.CurrentRow.Cells(0).Value))
                        MessageBox.Show((mainForm.quarantineGridView.CurrentRow.Cells(0).Value) & " Has Been Restored", "Mike's Virus Scanner",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mainForm.quarantineGridView.Rows.Remove(mainForm.quarantineGridView.CurrentRow)
                    End If
                End If
            Catch ex As Exception
            End Try
        End Sub

        Public Sub RestoreAllFromQuarantine()
            Dim d As DirectoryInfo = New DirectoryInfo(_loc)
            For Each file2 As System.IO.FileInfo In d.GetFiles("*.*")
                Try
                    mainForm.quarantineGridView.Rows(0).Selected = True

                    If mainForm.quarantineGridView.Rows.Count > 0 Then
                        For i = 0 To mainForm.quarantineGridView.Rows.Count - 1
                            mainForm.quarantineGridView.Rows(0).Selected = True
                            If System.IO.File.Exists(file2.FullName) = True Then
                                System.IO.File.Move(file2.FullName, (mainForm.quarantineGridView.CurrentRow.Cells(0).Value))
                                'MessageBox.Show((file.FullName & " Has Been Restored", "Mike's Virus Scanner",
                                ' MessageBoxButtons.OK, MessageBoxIcon.Information)
                                mainForm.quarantineGridView.Rows.Remove(mainForm.quarantineGridView.CurrentRow)
                            End If
                        Next

                    End If
                Catch ex As Exception
                End Try
            Next
        End Sub

        Public Sub RemoveFromQuarantine(file As String, _loc As String)
            Dim des As String = _loc & "\" & Path.GetFileName(file)
            _enc.DecryptFile(file, des, _password)
            Try
                If mainForm.quarantineGridView.Rows.Count > 0 And mainForm.quarantineGridView.SelectedRows.Count > 0 Then
                    Dim FileToDelete As String
                    FileToDelete = (mainForm.quarantineGridView.CurrentRow.Cells(0).Value)
                    If System.IO.File.Exists(des) = True Then
                        System.IO.File.Delete(des)
                        MessageBox.Show((des) & " Has Been Deleted!", "Mike's Virus Scanner",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mainForm.quarantineGridView.Rows.Remove(mainForm.quarantineGridView.CurrentRow)
                    End If
                End If
            Catch
            End Try
        End Sub

        Public Sub ClearQuarantine()
            Dim d As DirectoryInfo = New DirectoryInfo(_loc)
            For Each file As System.IO.FileInfo In d.GetFiles("*.*")
                Try
                    mainForm.quarantineGridView.Rows(0).Selected = True
                    If mainForm.quarantineGridView.Rows.Count > 0 Then
                        For i = 0 To mainForm.quarantineGridView.Rows.Count - 1
                            mainForm.quarantineGridView.Rows(0).Selected = True
                            If System.IO.File.Exists(file.FullName) = True Then
                                System.IO.File.Delete(file.FullName)
                                'MessageBox.Show((file.FullName & " Has Been Deleted", "Mike's Virus Scanner",
                                ' MessageBoxButtons.OK, MessageBoxIcon.Information)
                                mainForm.quarantineGridView.Rows.Remove(mainForm.quarantineGridView.CurrentRow)
                            End If
                        Next
                    End If
                Catch ex As Exception
                End Try
            Next
        End Sub
    End Class

    Class Encryption
        Private ReadOnly _salt As Byte() = New Byte() {&H56, &H47, &H98, &H33, &H88, &H13, &H77, &H10}
        Private Const _iterations As Integer = 1042

        Public Sub DecryptFile(sourceFilename As String, destinationFilename As String, password As String)
            Dim aes As AesManaged = New AesManaged()
            aes.BlockSize = aes.LegalBlockSizes(0).MaxSize
            aes.KeySize = aes.LegalKeySizes(0).MaxSize
            ' NB: Rfc2898DeriveBytes initialization and subsequent calls to   GetBytes   must be eactly the same, including order, on both the encryption and decryption sides.
            Dim key As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(password, _salt, _iterations)
            aes.Key = key.GetBytes(aes.KeySize / 8)
            aes.IV = key.GetBytes(aes.BlockSize / 8)
            aes.Mode = CipherMode.CBC
            Dim transform As ICryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV)
            Using destination As FileStream = New FileStream(destinationFilename, FileMode.CreateNew, FileAccess.Write, FileShare.None)
                Using _cryptoStream As CryptoStream = New CryptoStream(destination, transform, CryptoStreamMode.Write)
                    Try

                        Using source As FileStream = New FileStream(sourceFilename, FileMode.Open, FileAccess.Read, FileShare.Read)
                            source.CopyTo(_cryptoStream)
                        End Using
                    Catch exception As CryptographicException

                        If exception.Message = "Padding is invalid and cannot be removed." Then
                            Throw New ApplicationException("Universal Microsoft Cryptographic Exception (Not to be believed!)", exception)
                        Else Throw
                        End If
                    End Try
                End Using
            End Using
        End Sub

        Public Sub EncryptFile(sourceFilename As String, destinationFilename As String, password As String)
            Dim aes As AesManaged = New AesManaged()
            aes.BlockSize = aes.LegalBlockSizes(0).MaxSize
            aes.KeySize = aes.LegalKeySizes(0).MaxSize
            ' NB: Rfc2898DeriveBytes initialization and subsequent calls to   GetBytes   must be exactly the same, including order, on both the encryption and decryption sides.
            Dim key As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(password, _salt, _iterations)
            aes.Key = key.GetBytes(aes.KeySize / 8)
            aes.IV = key.GetBytes(aes.BlockSize / 8)
            aes.Mode = CipherMode.CBC
            Dim transform As ICryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV)
            Using destination As FileStream = New FileStream(destinationFilename, FileMode.CreateNew, FileAccess.Write, FileShare.None)
                Using _cryptoStream As CryptoStream = New CryptoStream(destination, transform, CryptoStreamMode.Write)
                    Using source As FileStream = New FileStream(sourceFilename, FileMode.Open, FileAccess.Read, FileShare.Read)
                        source.CopyTo(_cryptoStream)
                    End Using
                End Using
            End Using
        End Sub
    End Class
End Namespace
