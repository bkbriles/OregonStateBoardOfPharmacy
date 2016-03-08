'**************************************************
' Programmer: Briles, Brian
' Date: 2/26/2016
' File Name: Form1.vb
' Decription: This program is a Practice Test for
' the Oregon State Board of Pharmacy. It's designed
' for someone to review before taking the test.
'**************************************************

Imports System.IO

Public Class Form1 ' Assuming this is not a default name.
    ' Class level declarations
    Const intMAX_SUBSCRIPT As Integer = 50          ' Max subscript for the arrays
    Dim intCounter As Integer = 0                   ' Counter for the arrays
    Dim intCorrectAnswers As Integer = 0            ' Counter for how many answer are correct
    Dim decPercentageCorrect As Decimal             ' Holds the percentage correct when the test is done
    Dim strQuestion(intMAX_SUBSCRIPT) As String     ' Holds the questions
    Dim strAnswer(intMAX_SUBSCRIPT) As String       ' Holds the answers
    Dim strOptions(intMAX_SUBSCRIPT, 4) As String   ' Holds the A, B, C, D options for each question (0 = A, 1 = B, 2 = C, 3 = D)
    Private strFilename As String = String.Empty    ' Document filename

    ' The OpenTest procedure opens a file and loads it into the parallel arrays
    Sub OpenTest()
        Dim inputFile As StreamReader               ' Object var
        Dim dummyText As String                     ' Holds on to dummy text from the test file

        Try
            ' Open the file
            inputFile = File.OpenText("testQA.txt")

            ' Read the file's contents the parallel arrays
            For i = 0 To 49
                dummyText = inputFile.ReadLine
                strQuestion(i) = inputFile.ReadLine
                strAnswer(i) = inputFile.ReadLine
                For k = 0 To 3
                    strOptions(i, k) = inputFile.ReadLine
                Next
            Next

            ' Close the file
            inputFile.Close()

            ' Activate labels and radio buttons
            lblTextQuestion.Visible = True
            lblQuestionNumber.Visible = True
            radAnswerA.Visible = True
            radAnswerB.Visible = True
            radAnswerC.Visible = True
            radAnswerD.Visible = True
        Catch ex As Exception
            ' Error message for file open error
            MessageBox.Show("Error opening the test file. Ensure ""testQA.txt"" is in the same folder as the executable.")
            Me.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the parallel arrays and update labels/buttons
        OpenTest()

        ' Update new question and question number
        lblQuestionNumber.Text = (intCounter + 1).ToString() & " of 50:"
        lblQuestion.Text = strQuestion(intCounter)

        ' Update new set of answer selections
        radAnswerA.Text = strOptions(intCounter, 0)
        radAnswerB.Text = strOptions(intCounter, 1)
        radAnswerC.Text = strOptions(intCounter, 2)
        radAnswerD.Text = strOptions(intCounter, 3)
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        ' Display a simple About box explaining the program and such
        Dim frmAboutBox As New frmAboutBox
        frmAboutBox.ShowDialog()
    End Sub

    Private Sub btnNextQuestion_Click(sender As Object, e As EventArgs) Handles btnNextQuestion.Click
        ' If intCOunter is 49, Finish button is now visible, calculate percentage correct
        If intCounter = 48 Then
            btnNextQuestion.Visible = False
            btnFinish.Visible = True
        End If

        ' Test answer for current question
        TestAnswer()

        ' Move to the next question
        GetNextQuestion()
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        ' Test answer for the current question
        TestAnswer()

        ' Calculate and display the user's score
        ShowPercentage()

        ' Close the form
        Me.Close()
    End Sub

    Private Sub btnSubmitEarly_Click(sender As Object, e As EventArgs) Handles btnSubmitEarly.Click
        ' Calculate and display the user's score
        If intCounter = 0 Then
            Me.Close()              ' This prevents division by zero
        Else
            ShowPercentage()
        End If

        ' Close the form
        Me.Close()
    End Sub

    Private Sub GetNextQuestion()
        ' Increment the counter for the arrays
        intCounter += 1

        ' Update new question and question number
        lblQuestionNumber.Text = (intCounter + 1).ToString() & " of 50:"
        lblQuestion.Text = strQuestion(intCounter)

        ' Update new set of answer selections
        radAnswerA.Text = strOptions(intCounter, 0)
        radAnswerB.Text = strOptions(intCounter, 1)
        radAnswerC.Text = strOptions(intCounter, 2)
        radAnswerD.Text = strOptions(intCounter, 3)
    End Sub

    Private Sub ShowPercentage()
        ' Calculate and display the user's score
        decPercentageCorrect = (intCorrectAnswers / intCounter) * 100
        MessageBox.Show("You scored " & intCorrectAnswers.ToString() & " out of " & intCounter.ToString() &
                            vbCrLf & decPercentageCorrect.ToString() & " %")
    End Sub

    Private Sub TestAnswer()
        ' Test the current answer for the question
        ' Flag for a correct answer to move on
        Dim blnCorrect As Boolean = False

        ' Test answer for the current question
        If radAnswerA.Checked = True And strAnswer(intCounter) = "A" Then
            blnCorrect = True
        ElseIf radAnswerB.Checked = True And strAnswer(intCounter) = "B" Then
            blnCorrect = True
        ElseIf radAnswerC.Checked = True And strAnswer(intCounter) = "C" Then
            blnCorrect = True
        ElseIf radAnswerD.Checked = True And strAnswer(intCounter) = "D" Then
            blnCorrect = True
        Else
            ' Display a message that shows the correct answer and get the next question
            MessageBox.Show("Sorry, the correct answer was: " & strAnswer(intCounter))
        End If

        ' Increment intCounter if the index is at the end
        If intCounter = 49 Then
            intCounter += 1                 ' This prevents an incorrect number of questions shown
        End If

        If blnCorrect = True Then
            ' Increment the number of questions answered correctly and get next question
            intCorrectAnswers += 1
        End If
    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs)

    End Sub
End Class
