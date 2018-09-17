Public Class frmProverbs

    ' Correct answer goes up by 1 if correct
    Dim correctAnswer As Integer = 0
    Dim proverbCounter As Integer = 0
    Dim currentProverb As String

    ' First letter is the correct value (T or F)
    Const Proverb1 As String = "TThe squeaky wheel gets the grease"
    Const Proverb2 As String = "TGiving is better than receiving"
    Const Proverb3 As String = "FOpposites Attract"
    Const Proverb4 As String = "FSpare the rod and spoil the child"
    Const Proverb5 As String = "TActions speak louder than words"
    Const Proverb6 As String = "FFlattery will get you nowhere"
    Const Proverb7 As String = "TMarry in haste, repent at leisure"

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Displays a proverb. Need method.
        proverbCounter += 1

        If proverbCounter <= 7 Then
            DisplayProverb(proverbCounter) ' Displays the proverb
            txtAnswer.Enabled = True ' Enables the text box for the answer
            btnDisplay.Enabled = False ' Disables the display proverb button
            btnRecord.Enabled = True ' Enables the answer button
        Else
            DisplayResults()
            proverbCounter = 0
            correctAnswer = 0
            txtAnswer.Enabled = False
            btnRecord.Enabled = False

        End If

    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        ' Records correct answer
        If txtAnswer.Text.ToUpper = "T" Or txtAnswer.Text.ToUpper = "F" Then
            AddAnswer()
            btnRecord.Enabled = False
            btnDisplay.Enabled = True
            txtAnswer.Enabled = False
            txtCorrectAnswer.Text = ""
            txtAnswer.Focus()
            txtAnswer.Clear()
        Else
            MessageBox.Show("Please enter valid input for the answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAnswer.Focus()
        End If
    End Sub

    Private Sub DisplayResults()
        Select Case correctAnswer
            Case 7
                MessageBox.Show($"Perfect. {correctAnswer} correct")
            Case 5, 6
                MessageBox.Show($"Excellent. {correctAnswer} correct")
            Case Else
                MessageBox.Show($"You might consider taking psychology 101. {correctAnswer} correct")
        End Select
    End Sub

    Private Sub AddAnswer()
        If currentProverb.Substring(0, 1) = txtAnswer.Text.ToUpper Then
            correctAnswer += 1
        End If
    End Sub

    Private Sub DisplayProverb(proverbCounter As Integer)

        Select Case proverbCounter
            Case 1
                currentProverb = Proverb1
            Case 2
                currentProverb = Proverb2
            Case 3
                currentProverb = Proverb3
            Case 4
                currentProverb = Proverb4
            Case 5
                currentProverb = Proverb5
            Case 6
                currentProverb = Proverb6
            Case 7
                currentProverb = Proverb7
        End Select
        txtCorrectAnswer.Text = currentProverb.Substring(1) ' Remember, the first letter is the answer
    End Sub



End Class
