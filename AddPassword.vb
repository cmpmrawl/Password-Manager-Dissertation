Public Class AddPassword
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        passwordManagerForm.Visible = True
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        passwordManagerForm.passwordViewDataGrid.Rows.Add("", txtWeb.Text, txtUser.Text, txtPass.Text)
        txtWeb.Text = ""
        txtUser.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub AddPassword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        passwordManagerForm.Visible = True
    End Sub
End Class