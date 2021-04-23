
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
        Dim newPassword As String = ""
        Dim symbolList As List(Of Char) = fillSymbols()
        Dim firstWord As String
        Dim randomNumber As Integer
        Dim newWord As String = ""

        If tboxLength.Text <> Nothing And IsNumeric(tboxLength.Text) Then

            Dim length As Integer
            If cboxSymb.Checked = True Or cboxNumb.Checked = True Then
                length = tboxLength.Text - 1
            Else
                length = tboxLength.Text
            End If


            Do
                randomNumber = Int(((wordList.Count - 1) * Rnd()) + 1)
                firstWord = wordList.ElementAt(randomNumber)
            Loop While firstWord.Length <> length

            lblRememberHeader.Visible = True
            lblOriginalWord.Visible = True
            lblNumbDesc.Visible = True
            lblCapitalDesc.Visible = True
            lblSymbDesc.Visible = True
            lblWord.Text = firstWord

            If cboxNumb.Checked = True Then
                Dim letter As Char
                Dim replace As Boolean = False

                For i As Integer = 0 To firstWord.Length - 1
                    letter = firstWord(i)
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
                    newWord = newWord & letter
                Next
                firstWord = newWord
                If replace = True Then
                    lblNumbers.Text = firstWord
                Else
                    randomNumber = Int((9 * Rnd()) + 1)
                    firstWord = firstWord & randomNumber.ToString
                    lblNumbers.Text = firstWord
                End If
            Else
                lblNumbers.Text = "N/A"
            End If

            newWord = ""
            If cboxCaps.Checked = True Then
                Dim checked As Boolean = True

                Do While checked = True

                    randomNumber = Int(((firstWord.Length - 1) * Rnd()) + 1)
                    checked = checkIsNumeric(firstWord, randomNumber)

                Loop

                For i As Integer = 0 To firstWord.Length - 1

                    If i = randomNumber Then
                        newWord = newWord & Char.ToUpper(firstWord(i))
                    Else
                        newWord = newWord & firstWord(i)
                    End If

                Next
                firstWord = newWord
                lblCapitals.Text = firstWord
            Else
                lblCapitals.Text = "N/A"
            End If


            newWord = ""
            If cboxSymb.Checked = True Then
                randomNumber = Int(((firstWord.Length - 1) * Rnd()) + 0)
                Dim newRandomNumber = Int(((symbolList.Count - 1) * Rnd()) + 1)
                For i As Integer = 0 To firstWord.Length - 1
                    If i = randomNumber Then
                        newWord = newWord & symbolList(newRandomNumber) & firstWord(i)
                    Else
                        newWord = newWord & firstWord(i)
                    End If
                Next
                firstWord = newWord
                lblSymbols.Text = firstWord
            Else
                lblSymbols.Text = "N/A"
            End If


            lblnewPassword.Text = firstWord

        Else

            MsgBox("Please enter a valid length!")

        End If

    End Sub

    Private Function checkIsNumeric(ByRef word As String, ByRef position As Integer)
        Dim checked As Boolean = False

        checked = IsNumeric(word(position))

        Return checked
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

End Class