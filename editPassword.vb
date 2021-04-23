Public Class editPassword
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        passwordManagerForm.Visible = True
        Me.Close()
    End Sub

    Private Sub editPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idData As String
        Dim webData As String
        For i As Integer = 0 To passwordManagerForm.passwordViewDataGrid.Rows.Count - 1
            idData = passwordManagerForm.passwordViewDataGrid.Rows(i).Cells(0).Value
            webData = passwordManagerForm.passwordViewDataGrid.Rows(i).Cells(1).Value
            cboxEdit.Items.Add(idData & " - " & webData)
        Next
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'passwordManagerForm.passwordViewDataGrid.Rows()
        Dim comboIndex As Integer = cboxEdit.SelectedIndex

        If txtboxWebsite.Text = "" Then

        Else
            passwordManagerForm.passwordViewDataGrid.Rows(comboIndex).Cells(1).Value = txtboxWebsite.Text
        End If

        If txtboxUser.Text = "" Then

        Else
            passwordManagerForm.passwordViewDataGrid.Rows(comboIndex).Cells(2).Value = txtboxUser.Text
        End If

        If txtboxpass.Text = "" Then

        Else
            passwordManagerForm.passwordViewDataGrid.Rows(comboIndex).Cells(3).Value = txtboxpass.Text
        End If

        txtboxWebsite.Text = ""
        txtboxUser.Text = ""
        txtboxpass.Text = ""

    End Sub

    Private Sub cboxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxEdit.SelectedIndexChanged
        txtboxWebsite.Text = passwordManagerForm.passwordViewDataGrid.Rows(cboxEdit.SelectedIndex).Cells(1).Value
        txtboxUser.Text = passwordManagerForm.passwordViewDataGrid.Rows(cboxEdit.SelectedIndex).Cells(2).Value
        txtboxpass.Text = passwordManagerForm.passwordViewDataGrid.Rows(cboxEdit.SelectedIndex).Cells(3).Value
    End Sub
End Class