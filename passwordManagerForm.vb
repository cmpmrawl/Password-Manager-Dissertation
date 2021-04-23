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

        For i As Integer = 1 To webList.Count - 1
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
        writeFile(Password, 3, False)
    End Sub

    Private Function readFile(ByRef file As String)

        Dim readInList As New List(Of String)

        If System.IO.File.Exists(file) = True Then

            Dim objReader As New System.IO.StreamReader(file)

            Do While objReader.Peek() <> -1
                readInList.Add(objReader.ReadLine())
            Loop
            objReader.Close()
        Else
            MessageBox.Show("File Does Not Exist")
        End If

        Return readInList

    End Function

    Public Sub writeFile(ByRef file As String, ByRef cellNumb As Integer, ByRef check As Boolean)

        If System.IO.File.Exists(file) = True Then

            Dim objWriter As New System.IO.StreamWriter(file)

            If check = True Then
                objWriter.WriteLine("1111")
            Else
                objWriter.WriteLine(entryForm.getMasterPassword())
            End If

            For i As Integer = 0 To passwordViewDataGrid.Rows.Count - 1
                objWriter.WriteLine(passwordViewDataGrid.Rows(i).Cells(cellNumb).Value)
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
End Class