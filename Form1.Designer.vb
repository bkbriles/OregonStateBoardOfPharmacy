<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTextQuestion = New System.Windows.Forms.Label()
        Me.radAnswerA = New System.Windows.Forms.RadioButton()
        Me.radAnswerB = New System.Windows.Forms.RadioButton()
        Me.radAnswerC = New System.Windows.Forms.RadioButton()
        Me.radAnswerD = New System.Windows.Forms.RadioButton()
        Me.btnSubmitEarly = New System.Windows.Forms.Button()
        Me.btnNextQuestion = New System.Windows.Forms.Button()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(478, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(146, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuHelpAbout.Text = "&About"
        '
        'lblTextQuestion
        '
        Me.lblTextQuestion.AutoSize = True
        Me.lblTextQuestion.Location = New System.Drawing.Point(19, 37)
        Me.lblTextQuestion.Name = "lblTextQuestion"
        Me.lblTextQuestion.Size = New System.Drawing.Size(49, 13)
        Me.lblTextQuestion.TabIndex = 1
        Me.lblTextQuestion.Text = "Question"
        Me.lblTextQuestion.Visible = False
        '
        'radAnswerA
        '
        Me.radAnswerA.AutoSize = True
        Me.radAnswerA.Location = New System.Drawing.Point(51, 108)
        Me.radAnswerA.Name = "radAnswerA"
        Me.radAnswerA.Size = New System.Drawing.Size(32, 17)
        Me.radAnswerA.TabIndex = 2
        Me.radAnswerA.TabStop = True
        Me.radAnswerA.Text = "A"
        Me.radAnswerA.UseVisualStyleBackColor = True
        Me.radAnswerA.Visible = False
        '
        'radAnswerB
        '
        Me.radAnswerB.AutoSize = True
        Me.radAnswerB.Location = New System.Drawing.Point(51, 131)
        Me.radAnswerB.Name = "radAnswerB"
        Me.radAnswerB.Size = New System.Drawing.Size(32, 17)
        Me.radAnswerB.TabIndex = 3
        Me.radAnswerB.TabStop = True
        Me.radAnswerB.Text = "B"
        Me.radAnswerB.UseVisualStyleBackColor = True
        Me.radAnswerB.Visible = False
        '
        'radAnswerC
        '
        Me.radAnswerC.AutoSize = True
        Me.radAnswerC.Location = New System.Drawing.Point(51, 154)
        Me.radAnswerC.Name = "radAnswerC"
        Me.radAnswerC.Size = New System.Drawing.Size(32, 17)
        Me.radAnswerC.TabIndex = 4
        Me.radAnswerC.TabStop = True
        Me.radAnswerC.Text = "C"
        Me.radAnswerC.UseVisualStyleBackColor = True
        Me.radAnswerC.Visible = False
        '
        'radAnswerD
        '
        Me.radAnswerD.AutoSize = True
        Me.radAnswerD.Location = New System.Drawing.Point(51, 177)
        Me.radAnswerD.Name = "radAnswerD"
        Me.radAnswerD.Size = New System.Drawing.Size(33, 17)
        Me.radAnswerD.TabIndex = 5
        Me.radAnswerD.TabStop = True
        Me.radAnswerD.Text = "D"
        Me.radAnswerD.UseVisualStyleBackColor = True
        Me.radAnswerD.Visible = False
        '
        'btnSubmitEarly
        '
        Me.btnSubmitEarly.Location = New System.Drawing.Point(329, 217)
        Me.btnSubmitEarly.Name = "btnSubmitEarly"
        Me.btnSubmitEarly.Size = New System.Drawing.Size(109, 35)
        Me.btnSubmitEarly.TabIndex = 8
        Me.btnSubmitEarly.Text = "&Stop Here"
        Me.btnSubmitEarly.UseVisualStyleBackColor = True
        '
        'btnNextQuestion
        '
        Me.btnNextQuestion.Location = New System.Drawing.Point(51, 217)
        Me.btnNextQuestion.Name = "btnNextQuestion"
        Me.btnNextQuestion.Size = New System.Drawing.Size(109, 35)
        Me.btnNextQuestion.TabIndex = 7
        Me.btnNextQuestion.Text = "&Next Question"
        Me.btnNextQuestion.UseVisualStyleBackColor = True
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.Location = New System.Drawing.Point(65, 37)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(64, 13)
        Me.lblQuestionNumber.TabIndex = 10
        Me.lblQuestionNumber.Text = "1 of 50:"
        Me.lblQuestionNumber.Visible = False
        '
        'lblQuestion
        '
        Me.lblQuestion.Location = New System.Drawing.Point(48, 70)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(390, 33)
        Me.lblQuestion.TabIndex = 11
        Me.lblQuestion.Text = "Question goes here."
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(191, 217)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(109, 35)
        Me.btnFinish.TabIndex = 12
        Me.btnFinish.Text = "&Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        Me.btnFinish.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 264)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblQuestionNumber)
        Me.Controls.Add(Me.btnNextQuestion)
        Me.Controls.Add(Me.btnSubmitEarly)
        Me.Controls.Add(Me.radAnswerD)
        Me.Controls.Add(Me.radAnswerC)
        Me.Controls.Add(Me.radAnswerB)
        Me.Controls.Add(Me.radAnswerA)
        Me.Controls.Add(Me.lblTextQuestion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Oregon State Board of Pharmacy Review"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents lblTextQuestion As Label
    Friend WithEvents radAnswerA As RadioButton
    Friend WithEvents radAnswerB As RadioButton
    Friend WithEvents radAnswerC As RadioButton
    Friend WithEvents radAnswerD As RadioButton
    Friend WithEvents btnSubmitEarly As Button
    Friend WithEvents btnNextQuestion As Button
    Friend WithEvents lblQuestionNumber As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents btnFinish As Button
End Class
