Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class passwordManagerForm



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddPassword.Visible = True
        Me.Visible = False

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        editPassword.Visible = True
        Me.Visible = False

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        deletePassword.Visible = True
        Me.Visible = False
    End Sub

    Private Sub passwordManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Website As String = "Website.txt"
        Dim Username As String = "Username.txt"
        Dim Password As String = "Password.txt"
        Dim count As Integer = 0
        Dim webList As New List(Of String)
        Dim userList As New List(Of String)
        Dim passList As New List(Of String)

        webList = readFile(Website)
        userList = readFile(Username)
        passList = readFile(Password)

        For i As Integer = 0 To webList.Count - 1
            passwordViewDataGrid.Rows.Add("", webList(i), userList(i), passList(i))
        Next

    End Sub

    Private Sub passwordViewDataGrid_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles passwordViewDataGrid.RowPostPaint
        passwordViewDataGrid.Rows(e.RowIndex).Cells(0).Value = (e.RowIndex + 1)
    End Sub

    Private Sub passwordManagerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


        saveFiles()
        entryForm.Close()

    End Sub

    Public Sub saveFiles()
        Dim Website As String = "Website.txt"
        Dim Username As String = "Username.txt"
        Dim Password As String = "Password.txt"

        writeFile(Website, 1, True)
        writeFile(Username, 2, True)
        writeFile(Password, 3, True)
    End Sub

    Private Function readFile(ByRef file As String)

        Dim readInList As New List(Of String)
        Dim newReadInList As New List(Of String)

        If System.IO.File.Exists(file) = True Then

            Dim objReader As New System.IO.StreamReader(file)
            Dim hashedpassword As String = entryForm.getMasterPassword

            Dim decryptedString As String

            Do While objReader.Peek() <> -1
                readInList.Add(objReader.ReadLine())
            Loop
            objReader.Close()
            For i As Integer = 2 To readInList.Count - 1
                decryptedString = Decrypt(readInList.Item(i), hashedpassword)
                newReadInList.Add(decryptedString)
            Next
        Else
            MessageBox.Show("File Does Not Exist")
        End If

        Return newReadInList

    End Function

    Public Sub writeFile(ByRef file As String, ByRef cellNumb As Integer, ByRef check As Boolean)

        If System.IO.File.Exists(file) = True Then

            Dim objWriter As New System.IO.StreamWriter(file)
            Dim passSalt As String = entryForm.getSalt
            Dim hashedpassword As String = entryForm.getMasterPassword

            If check = True Then
                objWriter.WriteLine(passSalt)
                objWriter.WriteLine(hashedpassword)
            End If

            Dim encryptedString As String

            For i As Integer = 0 To passwordViewDataGrid.Rows.Count - 1
                encryptedString = Encrypt(passwordViewDataGrid.Rows(i).Cells(cellNumb).Value, hashedpassword)
                objWriter.WriteLine(encryptedString)
            Next
            objWriter.Close()
        Else
            MessageBox.Show("File Does Not Exist")
        End If

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        passwordGenerator.Visible = True
        Me.Visible = False
    End Sub


    Public Shared Function Encrypt(ByVal plainText As String, ByVal key As String) As String
        Dim bytesBuff As Byte() = Encoding.Unicode.GetBytes(plainText)
        Using aes__1 As Aes = Aes.Create()
            Dim crypto As New Rfc2898DeriveBytes(key, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            aes__1.Key = crypto.GetBytes(32)
            aes__1.IV = crypto.GetBytes(16)
            Using mStream As New MemoryStream()
                Using cStream As New CryptoStream(mStream, aes__1.CreateEncryptor(), CryptoStreamMode.Write)
                    cStream.Write(bytesBuff, 0, bytesBuff.Length)
                    cStream.Close()
                End Using
                plainText = Convert.ToBase64String(mStream.ToArray())
            End Using
        End Using
        Return plainText
    End Function
    'Decrypting a string
    Public Shared Function Decrypt(ByVal cypherText As String, ByVal key As String) As String
        cypherText = cypherText.Replace(" ", "+")
        Dim bytesBuff As Byte() = Convert.FromBase64String(cypherText)
        Using aes__1 As Aes = Aes.Create()
            Dim crypto As New Rfc2898DeriveBytes(key, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            aes__1.Key = crypto.GetBytes(32)
            aes__1.IV = crypto.GetBytes(16)
            Using mStream As New MemoryStream()
                Using cStream As New CryptoStream(mStream, aes__1.CreateDecryptor(), CryptoStreamMode.Write)
                    cStream.Write(bytesBuff, 0, bytesBuff.Length)
                    cStream.Close()
                End Using
                cypherText = Encoding.Unicode.GetString(mStream.ToArray())
                End Using
            End Using
            Return cypherText
    End Function


End Class