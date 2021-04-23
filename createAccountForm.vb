Imports System.IO

Public Class createAccountForm

    Private password As String

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtPassword.Text.Equals(txtConfirm.Text) And txtPassword.Text <> Nothing Then
            Me.password = txtPassword.Text
            entryForm.Visible = True


            If System.IO.File.Exists("Website.txt") = False Then
                File.Create("Website.txt").Dispose()
            End If
            If System.IO.File.Exists("Username.txt") = False Then
                File.Create("Username.txt").Dispose()
            End If
            If System.IO.File.Exists("Password.txt") = False Then
                File.Create("Password.txt").Dispose()
            End If


            Dim passSalt = entryForm.CreateNewSalt(entryForm.saltSize)
            Dim hashedPassword = entryForm.GetSaltedHash(Me.password, passSalt)
            entryForm.setPassword(hashedPassword)
            entryForm.setSalt(passSalt)

            Dim objWriter As New System.IO.StreamWriter("Password.txt")
            objWriter.WriteLine(passSalt)
            objWriter.WriteLine(hashedPassword)

            objWriter.Close()

            Me.Close()
        Else
            MsgBox("Please try again!")
        End If
    End Sub

    Private Sub createAccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        entryForm.Visible = False
    End Sub
End Class