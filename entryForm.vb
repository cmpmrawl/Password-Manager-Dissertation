Imports System.IO
Public Class entryForm

    Private masterPassword As String
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click


        If txtbox_password.Text = Me.masterPassword Then

            passwordManagerForm.Visible = True
            Me.Visible = False

        Else

            txtbox_password.Text = ""
            MessageBox.Show("Wrong password, please try again")

        End If



    End Sub

    Public Sub setPassword(ByRef password As String)
        Me.masterPassword = password
    End Sub

    Public Function getMasterPassword()
        Return Me.masterPassword
    End Function

    Private Sub entryForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown


        If System.IO.File.Exists("Password.txt") = False Then
            createAccountForm.Visible = True
            Me.Visible = False
        Else
            Dim objReader As New System.IO.StreamReader("Password.txt")
            Me.masterPassword = objReader.ReadLine()
            objReader.Close()
        End If
    End Sub


End Class