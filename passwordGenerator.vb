
Public Class passwordGenerator
    Private wordList As New List(Of String)

    Private Sub passwordGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numb As Integer = 0
        If System.IO.File.Exists("text.txt") = True Then

            Dim objReader As New System.IO.StreamReader("text.txt")

            Do While objReader.Peek() <> -1
                Me.wordList.Add(objReader.ReadLine())
                numb = numb + 1
            Loop
            objReader.Close()
        Else
            MessageBox.Show("File Does Not Exist")
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        passwordManagerForm.Visible = True
        Me.Close()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Randomize()
        Dim twoPassword As String = ""
        Dim twoWords As Boolean = False
        Dim password As String
        Dim randomNumber As Integer
        Dim randomNumberTwo As Integer

        If tboxLength.Text <> Nothing And IsNumeric(tboxLength.Text) Then
            Dim length As Integer = tboxLength.Text
            If tboxLength.Text >= 8 Then
                If tboxLength.Text Mod 2 = 0 Then
                    length = tboxLength.Text / 2
                    twoWords = True
                Else
                    length = tboxLength.Text
                End If
            End If

            If cboxSymb.Checked = True Or cboxNumb.Checked = True Then
                length = length - 1
            End If

            If twoWords = True Then
                Do
                    randomNumber = Int(((wordList.Count - 1) * Rnd()) + 1)
                    password = wordList.ElementAt(randomNumber)
                Loop While password.Length <> length
                Do
                    randomNumberTwo = Int(((wordList.Count - 1) * Rnd()) + 1)
                    twoPassword = wordList.ElementAt(randomNumberTwo)
                Loop While twoPassword.Length <> length
            Else
                Do
                    randomNumber = Int(((wordList.Count - 1) * Rnd()) + 1)
                    password = wordList.ElementAt(randomNumber)
                Loop While password.Length <> length
            End If


            lblRememberHeader.Visible = True
            lblOriginalWord.Visible = True
            lblNumbDesc.Visible = True
            lblCapitalDesc.Visible = True
            lblSymbDesc.Visible = True
            lblWord.Text = password & " " & twoPassword

            If cboxNumb.Checked = True Then

                Dim replace As Boolean = False
                password = addNumbers(password, replace)

                If twoWords = True Then
                    Dim replaceTwo As Boolean = False
                    twoPassword = addNumbers(twoPassword, replaceTwo)
                    'copy below if statement here
                End If

                If replace = True Then
                    lblNumbers.Text = password & " " & twoPassword
                Else
                    If twoWords = True Then
                        randomNumberTwo = Int((9 * Rnd()) + 1)
                        twoPassword = twoPassword & randomNumberTwo.ToString
                    End If
                    randomNumber = Int((9 * Rnd()) + 1)
                    password = password & randomNumber.ToString
                    lblNumbers.Text = password & " " & twoPassword
                End If

            Else
                lblNumbers.Text = "N/A"
            End If

            If cboxCaps.Checked = True Then
                If twoWords = True Then
                    twoPassword = addCapitals(twoPassword)
                End If
                password = addCapitals(password)
                lblCapitals.Text = password & " " & twoPassword
            Else
                lblCapitals.Text = "N/A"
            End If


            If cboxSymb.Checked = True Then
                If twoWords = True Then
                    twoPassword = addSymbols(twoPassword)
                End If
                password = addSymbols(password)
                lblSymbols.Text = password & " " & twoPassword
            Else
                lblSymbols.Text = "N/A"
            End If


            lblnewPassword.Text = password & twoPassword

        Else

            MsgBox("Please enter a valid length!")

        End If

    End Sub

    Private Function checkIsNumeric(ByRef word As String, ByRef position As Integer)
        Dim checked As Boolean = False

        checked = IsNumeric(word(position))

        Return checked
    End Function

    Private Function addNumbers(ByRef password As String, ByVal replace As Boolean)
        Dim letter As Char
        Dim newPassword As String = ""

        For i As Integer = 0 To password.Length - 1
            letter = password(i)
            Select Case letter
                Case "o"
                    If Int((100 * Rnd()) + 1) < 25 Then
                        letter = "0"
                        replace = True
                    End If

                Case "i"
                    If Int((100 * Rnd()) + 1) < 25 Then
                        letter = "1"
                        replace = True
                    End If

                Case "e"
                    If Int((100 * Rnd()) + 1) < 25 Then
                        letter = "3"
                        replace = True
                    End If

                Case "a"
                    If Int((100 * Rnd()) + 1) < 25 Then
                        letter = "4"
                        replace = True
                    End If
                Case "s"
                    If Int((100 * Rnd()) + 1) < 25 Then
                        letter = "5"
                        replace = True
                    End If
                Case "z"
                    If Int((100 * Rnd()) + 1) < 25 Then
                        letter = "2"
                        replace = True
                    End If
                Case "g"
                    If Int((100 * Rnd()) + 1) < 25 Then
                        letter = "6"
                        replace = True
                    End If
                Case "t"
                    If Int((100 * Rnd()) + 1) < 25 Then
                        letter = "7"
                        replace = True
                    End If
            End Select
            newPassword = newPassword & letter
        Next
        Return newPassword
    End Function

    Private Function addSymbols(ByRef password As String)
        Dim randomNumber As Integer
        randomNumber = Int(((password.Length - 1) * Rnd()) + 0)
        Dim symbolList As List(Of Char) = fillSymbols()
        Dim newRandomNumber = Int(((symbolList.Count - 1) * Rnd()) + 1)
        Dim newPassword As String = ""


        For i As Integer = 0 To password.Length - 1
            If i = randomNumber Then
                newPassword = newPassword & symbolList(newRandomNumber) & password(i)
            Else
                newPassword = newPassword & password(i)
            End If
        Next

        Return newPassword
    End Function

    Private Function addCapitals(ByRef password As String)
        Dim checked As Boolean = True
        Dim newPassword As String = ""
        Dim randomNumber As Integer

        Do While checked = True

            randomNumber = Int(((password.Length - 1) * Rnd()) + 1)
            checked = checkIsNumeric(password, randomNumber)

        Loop

        For i As Integer = 0 To password.Length - 1

            If i = randomNumber Then
                newpassword = newpassword & Char.ToUpper(password(i))
            Else
                newpassword = newpassword & password(i)
            End If

        Next
        Return newPassword
    End Function


    Public Function fillSymbols()
        Dim symbolList As List(Of Char) = New List(Of Char)

        symbolList.Add("!")
        symbolList.Add("£")
        symbolList.Add("$")
        symbolList.Add("%")
        symbolList.Add("^")
        symbolList.Add("*")
        symbolList.Add("(")
        symbolList.Add(")")
        symbolList.Add("+")
        symbolList.Add("=")
        symbolList.Add("?")
        symbolList.Add("/")
        symbolList.Add("@")
        symbolList.Add("#")

        Return symbolList
    End Function

    Private Sub lblCopy_Click(sender As Object, e As EventArgs) Handles lblCopy.Click
        Clipboard.SetText(lblnewPassword.Text)
    End Sub

    Private Sub passwordGenerator_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        passwordManagerForm.Visible = True
    End Sub
End Class