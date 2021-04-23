Public Class createAccountForm

    Private password As String

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtPassword.Text.Equals(txtConfirm.Text) And txtPassword.Text <> Nothing Then
            Me.password = txtPassword.Text
            entryForm.Visible = True
            entryForm.setPassword(Me.password)

            Dim objWriter As New System.IO.StreamWriter("Password.txt")
            objWriter.WriteLine(Me.password)
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