Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class entryForm

    Public Const saltSize As Integer = 31
    Private masterPassword As String
    Private passSalt As String
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        Dim saltedEntry = GetSaltedHash(txtbox_password.Text, Me.passSalt)

        If String.Compare(Me.masterPassword, saltedEntry, False) = 0 Then

            passwordManagerForm.Visible = True
            Me.Visible = False

        Else

            txtbox_password.Text = ""
            MessageBox.Show("Wrong password, please try again")

        End If

    End Sub

    Public Sub setSalt(ByRef salt As String)
        Me.passSalt = salt
    End Sub

    Public Sub setPassword(ByRef password As String)
        Me.masterPassword = password
    End Sub

    Public Function getMasterPassword()
        Return Me.masterPassword
    End Function

    Public Function getSalt()
        Return Me.passSalt
    End Function

    Private Sub entryForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown


        If System.IO.File.Exists("Password.txt") = False Then
            createAccountForm.Visible = True
            Me.Visible = False
        Else
            Dim objReader As New System.IO.StreamReader("Username.txt")
            Me.passSalt = objReader.ReadLine()
            Me.masterPassword = objReader.ReadLine()
            objReader.Close()
        End If
    End Sub

    Private Sub entryForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If passwordManagerForm.Visible = True Then
            passwordManagerForm.saveFiles()
        End If

    End Sub

    Public Function CreateNewSalt(size As Integer) As String

        Using rng As New RNGCryptoServiceProvider

            Dim data(If(size < 7, 7, size)) As Byte

            rng.GetBytes(data)

            Return Convert.ToBase64String(data)
        End Using
    End Function

    Public Function GetSaltedHash(password As String, salt As String) As String
        Dim tmp As String = password & salt

        Using hash As HashAlgorithm = New SHA256Managed()

            Dim saltPass = Encoding.UTF8.GetBytes(tmp)

            Dim hashBytes = hash.ComputeHash(saltPass)

            Return Convert.ToBase64String(hashBytes)
        End Using

    End Function
End Class