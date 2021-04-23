Public Class deletePassword
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        passwordManagerForm.Visible = True
        Me.Close()
    End Sub

    Private Sub deletePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateCbox()
    End Sub

    Private Sub cboxRemove_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxRemove.SelectedIndexChanged
        lblWeb.Text = passwordManagerForm.passwordViewDataGrid.Rows(cboxRemove.SelectedIndex).Cells(1).Value
        lblUser.Text = passwordManagerForm.passwordViewDataGrid.Rows(cboxRemove.SelectedIndex).Cells(2).Value
        lblPass.Text = passwordManagerForm.passwordViewDataGrid.Rows(cboxRemove.SelectedIndex).Cells(3).Value
        lbldesc1.Visible = True
        lbldesc2.Visible = True
        lbldesc3.Visible = True
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If IsNothing(Me.cboxRemove.SelectedItem) Then
            MsgBox("Please select a password to remove!")
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this password, it will be permenantly deleted!", "Remove Password", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                passwordManagerForm.passwordViewDataGrid.Rows(cboxRemove.SelectedIndex).Selected = True
                passwordManagerForm.passwordViewDataGrid.Rows.Remove(passwordManagerForm.passwordViewDataGrid.SelectedRows(0))
            End If
            lblWeb.Text = "Website / Source"
            lblUser.Text = "Username"
            lblPass.Text = "Password"
            lbldesc1.Visible = False
            lbldesc2.Visible = False
            lbldesc3.Visible = False
            updateCbox()
        End If

    End Sub

    Private Sub updateCbox()
        Dim idData As String
        Dim webData As String
        cboxRemove.DataSource = Nothing
        cboxRemove.Items.Clear()
        cboxRemove.ResetText()
        cboxRemove.SelectedIndex = -1
        For i As Integer = 0 To passwordManagerForm.passwordViewDataGrid.Rows.Count - 1
            idData = passwordManagerForm.passwordViewDataGrid.Rows(i).Cells(0).Value
            webData = passwordManagerForm.passwordViewDataGrid.Rows(i).Cells(1).Value
            cboxRemove.Items.Add(idData & " - " & webData)
        Next
    End Sub

    Private Sub deletePassword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        passwordManagerForm.Visible = True
    End Sub
End Class