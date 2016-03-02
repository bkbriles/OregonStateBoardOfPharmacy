'**************************************************
' Programmer: Briles, Brian
' Date: 2/26/2016
' File Name: Form1.vb
' Decription: This program is a Practice Test for
' the Oregon State Board of Pharmacy. It's designed
' for someone to review before taking the test.
'**************************************************

Public Class Form1 ' Assuming this is not a default name.
    ' Declare parallel array to hold questions w/ corresponding answer
    Const intMAX_SUBSCRIPT As Integer = 50          ' Max subscript for the arrays
    Dim intCounter As Integer = 0                   ' Counter for the arrays
    Dim intCorrectAnswers As Integer = 0            ' Counter for how many answer are correct
    Dim decPercentageCorrect As Decimal             ' Holds the percentage correct when the test is done
    Dim strQuestion(intMAX_SUBSCRIPT) As String     ' Holds the questions
    Dim strAnswer(intMAX_SUBSCRIPT) As String       ' Holds the answers
    Dim strOptions(intMAX_SUBSCRIPT, 4) As String   ' Holds the A, B, C, D options for each question (0 = A, 1 = B, 2 = C, 3 = D)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the parallel arrays
        ' Q1
        strQuestion(0) = "Convert 400mcg to milligrams."
        strAnswer(0) = "A"
        strOptions(0, 0) = "0.4mg"
        strOptions(0, 1) = "0.04mg"
        strOptions(0, 2) = "0.004mg"
        strOptions(0, 3) = "4mg"

        ' Q2
        strQuestion(1) = "Which of the following terms best describes the solution in a TPN?"
        strAnswer(1) = "B"
        strOptions(1, 0) = "Hypertonic"
        strOptions(1, 1) = "Isotonic"
        strOptions(1, 2) = "Hypotonic"
        strOptions(1, 3) = "Tonic"

        ' Q3
        strQuestion(2) = "Which of the following is not needed on a pharmacy label for a finished IV admixture?"
        strAnswer(2) = "C"
        strOptions(2, 0) = "ingredients, concentrations, and final amount of solution."
        strOptions(2, 1) = "Patient name and room number"
        strOptions(2, 2) = "Equipment used in preparing the admixture"
        strOptions(2, 3) = "Date and time the admixture was made"

        ' Q4
        strQuestion(3) = "What is the purpose of a HEPA filter?"
        strAnswer(3) = "D"
        strOptions(3, 0) = "to filter IV solution"
        strOptions(3, 1) = "to monitor airborne contaminants"
        strOptions(3, 2) = "to filter IV suspensions"
        strOptions(3, 3) = "to filter Airborne contaminants"

        ' Q5
        strQuestion(4) = "Which of the following solutions are used most often as IVPB dilution?"
        strAnswer(4) = "D"
        strOptions(4, 0) = "D5W and normal Saline"
        strOptions(4, 1) = "D5 and 0.9Ns and 0.09%NaCl"
        strOptions(4, 2) = "Lactated Ringer's and D5"
        strOptions(4, 3) = "D50% and 9% Sodium Chloride"

        ' Q6
        strQuestion(5) = "Large-volume Parenterals (LVPs) are in what general size range?"
        strAnswer(5) = "B"
        strOptions(5, 0) = "2ml-50ml"
        strOptions(5, 1) = "250ml-3000ml"
        strOptions(5, 2) = "0.5ml-1ml"
        strOptions(5, 3) = "50ml-100ml"

        ' Q7
        strQuestion(6) = "Large volumes of IV solution may easily be transferred into a"
        strAnswer(6) = "C"
        strOptions(6, 0) = "Prefilled Syringe"
        strOptions(6, 1) = "Ampules and Vials"
        strOptions(6, 2) = "Premixed piggyback"
        strOptions(6, 3) = "Evacuated container"

        ' Q8
        strQuestion(7) = "Additives to a total Parenteral Nutrition solution include"
        strAnswer(7) = "D"
        strOptions(7, 0) = "Dextrose, Amino Acids, and Sterile water"
        strOptions(7, 1) = "Fluorouracil and Hydroxyurea"
        strOptions(7, 2) = "Tobramycin and Pyrogens"
        strOptions(7, 3) = "Vitamins, Minerals, and Compatible medications"

        ' Q9
        strQuestion(8) = "Intermittent infusions are most often given"
        strAnswer(8) = "A"
        strOptions(8, 0) = "at regular intervals"
        strOptions(8, 1) = "Continuously"
        strOptions(8, 2) = "By LVP"
        strOptions(8, 3) = "at a constant rate over a 24-Hr period"

        ' Q10
        strQuestion(9) = "Which of the following is considered controlled room temperature?"
        strAnswer(9) = "C"
        strOptions(9, 0) = "62-72 degrees Fahrenheit"
        strOptions(9, 1) = "0-32 degrees Fahrenheit"
        strOptions(9, 2) = "59-86 degrees Fahrenheit"
        strOptions(9, 3) = "36-46 degrees Fahrenheit"

        ' Q11
        strQuestion(10) = "Digitalis Drugs work directly on the cardiac muscle cells to __ their individual contractile activity"
        strAnswer(10) = "D"
        strOptions(10, 0) = "Stabilize"
        strOptions(10, 1) = "Eliminate"
        strOptions(10, 2) = "Decrease"
        strOptions(10, 3) = "Increase"

        ' Q12
        strQuestion(11) = "Onset time for a sedative to cause drowsiness by this route is 30min."
        strAnswer(11) = "A"
        strOptions(11, 0) = "Oral"
        strOptions(11, 1) = "intravenous"
        strOptions(11, 2) = "Skin Patch"
        strOptions(11, 3) = "Inhalation"

        ' Q13
        strQuestion(12) = "A drug that lowers high blood pressure by acting on the Peripheral blood vessels works on this substance."
        strAnswer(12) = "B"
        strOptions(12, 0) = "Beta-2 adrenergic receptors"
        strOptions(12, 1) = "Angiotensin- Converting enzymes"
        strOptions(12, 2) = "Cyclo-Oxygenase enzymes"
        strOptions(12, 3) = "H1 histamine receptors"

        ' Q14
        strQuestion(13) = "Drugs that act on enzymes to produce their therapeutic effect include all except"
        strAnswer(13) = "B"
        strOptions(13, 0) = "Aspirin"
        strOptions(13, 1) = "Contraceptive"
        strOptions(13, 2) = "Blood pressure medication"
        strOptions(13, 3) = "Anti-inflammatory medication"

        ' Q15
        strQuestion(14) = "Site of action in brain where anti psychotics work"
        strAnswer(14) = "C"
        strOptions(14, 0) = "Basal Ganglia"
        strOptions(14, 1) = "Cerebral Cortex"
        strOptions(14, 2) = "Limbic System"
        strOptions(14, 3) = "Chemo receptor trigger zone"

        ' Q16
        strQuestion(15) = "Maximum effect that can be achieved by a drug is called drug"
        strAnswer(15) = "B"
        strOptions(15, 0) = "circulation"
        strOptions(15, 1) = "Efficacy"
        strOptions(15, 2) = "Metabolism"
        strOptions(15, 3) = "Potency"

        ' Q17
        strQuestion(16) = "Site of action for Skeletal Relaxants"
        strAnswer(16) = "D"
        strOptions(16, 0) = "Limbic System"
        strOptions(16, 1) = "Cerebral Cortex"
        strOptions(16, 2) = "Chemo receptor trigger zone"
        strOptions(16, 3) = "Spinal Cord"

        ' Q18
        strQuestion(17) = "Which of the following for drugs is most potent as a pain relief"
        strAnswer(17) = "B"
        strOptions(17, 0) = "Advil 200mg"
        strOptions(17, 1) = "Orudis KT 12.5mg"
        strOptions(17, 2) = "Aspirin 325mg"
        strOptions(17, 3) = "Aleve 220mg"

        ' Q19
        strQuestion(18) = "Site of action of sleeping pills in the brain"
        strAnswer(18) = "C"
        strOptions(18, 0) = "Basal Ganglia"
        strOptions(18, 1) = "Chemo Receptors trigger zone"
        strOptions(18, 2) = "Cerebral Cortex"
        strOptions(18, 3) = "Limbic system"

        ' Q20
        strQuestion(19) = "Which of the following diuretic drugs act at the distal part of the nephron?"
        strAnswer(19) = "C"
        strOptions(19, 0) = "Anticoagulant"
        strOptions(19, 1) = "Potassium-Sparing Diuretics"
        strOptions(19, 2) = "Thiazides"
        strOptions(19, 3) = "Loop Diuretics"

        ' Q21
        strQuestion(20) = "Route of excretion of volatile drugs is through the"
        strAnswer(20) = "A"
        strOptions(20, 0) = "lungs"
        strOptions(20, 1) = "Intestine"
        strOptions(20, 2) = "Liver"
        strOptions(20, 3) = "Kidneys"

        ' Q22
        strQuestion(21) = "Onset time for an inhalation drug to cause drowsiness is"
        strAnswer(21) = "B"
        strOptions(21, 0) = "30sec"
        strOptions(21, 1) = "5min"
        strOptions(21, 2) = "30min"
        strOptions(21, 3) = "5sec"

        ' Q23
        strQuestion(22) = "Site of action for Furosemide (Lasix)"
        strAnswer(22) = "B"
        strOptions(22, 0) = "Blood"
        strOptions(22, 1) = "Kidney"
        strOptions(22, 2) = "Electrical conduction system"
        strOptions(22, 3) = "Cardiac Muscle"

        ' Q24
        strQuestion(23) = "The most important characteristic that a drug must have to freely pass from the GI Tract into circulation is to be"
        strAnswer(23) = "D"
        strOptions(23, 0) = "Bound to a receptor"
        strOptions(23, 1) = "Bound to a Protein"
        strOptions(23, 2) = "Fat Soluble"
        strOptions(23, 3) = "In salt form"

        ' Q25
        strQuestion(24) = "This is the major form in which drugs may be detected in the urine."
        strAnswer(24) = "A"
        strOptions(24, 0) = "Glucuronic Acid metabolite"
        strOptions(24, 1) = "Bond to plasma protein"
        strOptions(24, 2) = "Hydroxylati Derivative"
        strOptions(24, 3) = "Original parent compound"

        ' Q26
        strQuestion(25) = "Aspirin acts at this site of action."
        strAnswer(25) = "D"
        strOptions(25, 0) = "H1 histamine receptors"
        strOptions(25, 1) = "Beta-2 adrenergic receptors"
        strOptions(25, 2) = "Angiotensin-Converting enzyme"
        strOptions(25, 3) = "Cyclo-Oxygenase enzymes"

        ' Q27
        strQuestion(26) = "Site of action for antiarrhythmic drug is the"
        strAnswer(26) = "C"
        strOptions(26, 0) = "Basal Ganglia"
        strOptions(26, 1) = "Peripheral blood vessel"
        strOptions(26, 2) = "Electrical conduction system of cardiac muscle"
        strOptions(26, 3) = "Kidney and their functioning nephrons"

        ' Q28
        strQuestion(27) = "Nitroglycerin is used to  ___ the coronary blood vessels"
        strAnswer(27) = "B"
        strOptions(27, 0) = "Suppress"
        strOptions(27, 1) = "Dilate"
        strOptions(27, 2) = "Contract"
        strOptions(27, 3) = "Stop"

        ' Q29
        strQuestion(28) = "___ is the classic structural formula for all the addictive narcotics"
        strAnswer(28) = "D"
        strOptions(28, 0) = "Diazepam"
        strOptions(28, 1) = "Amitriptyline"
        strOptions(28, 2) = "Tetracycline"
        strOptions(28, 3) = "Codeine"

        ' Q30
        strQuestion(29) = "___ is a halogen that is easily combine with carbon compounds to provide new properties to the molecule"
        strAnswer(29) = "B"
        strOptions(29, 0) = "Potassium"
        strOptions(29, 1) = "Iodine"
        strOptions(29, 2) = "Lithium"
        strOptions(29, 3) = "Magnesium"


        ' Q31
        strQuestion(30) = "What is the molecular weight of Ethane?"
        strAnswer(30) = "D"
        strOptions(30, 0) = "6.06"
        strOptions(30, 1) = "24"
        strOptions(30, 2) = "1.01"
        strOptions(30, 3) = "30.06"

        ' Q32
        strQuestion(31) = "Which class of antibiotics has a specific ring structure within their molecules known as the beta-lactam ring?"
        strAnswer(31) = "C"
        strOptions(31, 0) = "Steroids"
        strOptions(31, 1) = "Tetracycline"
        strOptions(31, 2) = "Penicillin"
        strOptions(31, 3) = "Tricyclic anti depressant"

        ' Q33
        strQuestion(32) = "Compounds made of living sources all contain the element"
        strAnswer(32) = "A"
        strOptions(32, 0) = "Carbon"
        strOptions(32, 1) = "Magnesium"
        strOptions(32, 2) = "Zinc"
        strOptions(32, 3) = "Potassium"

        ' Q34
        strQuestion(33) = "The insulin molecule contains ___ amino acids"
        strAnswer(33) = "D"
        strOptions(33, 0) = "16"
        strOptions(33, 1) = "4"
        strOptions(33, 2) = "26"
        strOptions(33, 3) = "86"

        ' Q35
        strQuestion(34) = "__ are long chains of amino acid units"
        strAnswer(34) = "A"
        strOptions(34, 0) = "Proteins"
        strOptions(34, 1) = "Amines"
        strOptions(34, 2) = "Elements"
        strOptions(34, 3) = "Hydro Carbons"

        ' Q36
        strQuestion(35) = "What is the molecular weight of Lithium Carbonate"
        strAnswer(35) = "B"
        strOptions(35, 0) = "48"
        strOptions(35, 1) = "73.88"
        strOptions(35, 2) = "100.88"
        strOptions(35, 3) = "6.94"

        ' Q37
        strQuestion(36) = "__ Is a compound formed from combining a carboxylic acid and an alcohol"
        strAnswer(36) = "A"
        strOptions(36, 0) = "Ester"
        strOptions(36, 1) = "Ketone"
        strOptions(36, 2) = "Aldehyde"
        strOptions(36, 3) = "Ether"

        ' Q38
        strQuestion(37) = "Standard atomic weight is based on the weight of the element"
        strAnswer(37) = "B"
        strOptions(37, 0) = "Oxygen"
        strOptions(37, 1) = "Carbon"
        strOptions(37, 2) = "Magnesium"
        strOptions(37, 3) = "Hydrogen"

        ' Q39
        strQuestion(38) = "How many additional electrons does carbon need in it's outer shell to achieve the greatest stability as a atom?"
        strAnswer(38) = "A"
        strOptions(38, 0) = "4"
        strOptions(38, 1) = "1"
        strOptions(38, 2) = "2"
        strOptions(38, 3) = "3"

        ' Q40
        strQuestion(39) = "Phenol has a functional group known as the ___ group present in the molecule."
        strAnswer(39) = "D"
        strOptions(39, 0) = "Carbonyl"
        strOptions(39, 1) = "Methyl"
        strOptions(39, 2) = "Amine"
        strOptions(39, 3) = "Hydroxyl"

        ' Q41
        strQuestion(40) = "The Molecular weight of Citrate is"
        strAnswer(40) = "B"
        strOptions(40, 0) = "29.01"
        strOptions(40, 1) = "192.08"
        strOptions(40, 2) = "192"
        strOptions(40, 3) = "29.08"

        ' Q42
        strQuestion(41) = "__ is effective in the treatment of Psychosis and Schizophrenia"
        strAnswer(41) = "C"
        strOptions(41, 0) = "Tetracycline"
        strOptions(41, 1) = "Codeine"
        strOptions(41, 2) = "Chlorpromazine"
        strOptions(41, 3) = "Amitriptyline"

        ' Q43
        strQuestion(42) = "A carbon compound that contains oxygen between 2 hydrocarbon groups is known as"
        strAnswer(42) = "C"
        strOptions(42, 0) = "Ester"
        strOptions(42, 1) = "Amine"
        strOptions(42, 2) = "Ether"
        strOptions(42, 3) = "Ketone"

        ' Q44
        strQuestion(43) = "Benzene is a Cyclic structure containing how many Carbons?"
        strAnswer(43) = "D"
        strOptions(43, 0) = "8"
        strOptions(43, 1) = "4"
        strOptions(43, 2) = "0"
        strOptions(43, 3) = "6"

        ' Q45
        strQuestion(44) = "Which element is an Alkaline Earth Metal that combines more readily with inorganic compounds that with organic molecules?"
        strAnswer(44) = "C"
        strOptions(44, 0) = "Sodium"
        strOptions(44, 1) = "Iodine"
        strOptions(44, 2) = "Calcium"
        strOptions(44, 3) = "Chlorine"

        ' Q46
        strQuestion(45) = "Ephedrine Sulfate is a compound better known as a"
        strAnswer(45) = "D"
        strOptions(45, 0) = "Narcotic"
        strOptions(45, 1) = "Tranquilizer"
        strOptions(45, 2) = "Stimulant"
        strOptions(45, 3) = "Decongestant"

        ' Q47
        strQuestion(46) = "The two most well-known Alkaline Earth Metals are"
        strAnswer(46) = "B"
        strOptions(46, 0) = "Magnesium and Barium"
        strOptions(46, 1) = "Calcium and Magnesium"
        strOptions(46, 2) = "Calcium and Radium"
        strOptions(46, 3) = "Strontium and Radium"

        ' Q48
        strQuestion(47) = "What is the molecular weight of Calcium Chloride?"
        strAnswer(47) = "D"
        strOptions(47, 0) = "35.5"
        strOptions(47, 1) = "71"
        strOptions(47, 2) = "40.1"
        strOptions(47, 3) = "111.1"

        ' Q49
        strQuestion(48) = "The word 'Dispense' AKA 'Disp' is found in what part of prescription?"
        strAnswer(48) = "A"
        strOptions(48, 0) = "Directions to the pharmacist"
        strOptions(48, 1) = "Strength of medication"
        strOptions(48, 2) = "Name of medication"
        strOptions(48, 3) = "Directions for refill"

        ' Q50
        strQuestion(49) = "The word Sig, signifies what part of the prescription?"
        strAnswer(49) = "D"
        strOptions(49, 0) = "Strength of medication"
        strOptions(49, 1) = "Name of medication"
        strOptions(49, 2) = "Direction to the Pharmacis"
        strOptions(49, 3) = "Directions to the patient"


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
End Class
