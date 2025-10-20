Partial Class Form_TakeQuiz4
    Inherits System.Windows.Forms.Form

    Friend WithEvents txtUserName As TextBox
    Friend WithEvents lblInstructions As Label

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_TakeQuiz4))
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnStartQuiz = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(12, 297)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(154, 25)
        Me.txtUserName.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtUserName, "Enter your name")
        '
        'lblInstructions
        '
        Me.lblInstructions.BackColor = System.Drawing.Color.Transparent
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblInstructions.ForeColor = System.Drawing.Color.White
        Me.lblInstructions.Location = New System.Drawing.Point(41, 9)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(290, 73)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Type your name and press Start Quiz to begin." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You will see three questions with " &
    "pictures." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the correct image for each question."
        '
        'btnStartQuiz
        '
        Me.btnStartQuiz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartQuiz.Location = New System.Drawing.Point(172, 296)
        Me.btnStartQuiz.Name = "btnStartQuiz"
        Me.btnStartQuiz.Size = New System.Drawing.Size(79, 28)
        Me.btnStartQuiz.TabIndex = 1
        Me.btnStartQuiz.Text = "Start Quiz"
        Me.ToolTip1.SetToolTip(Me.btnStartQuiz, "Press to start quiz")
        Me.btnStartQuiz.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(257, 296)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 28)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.ToolTip1.SetToolTip(Me.btnClose, "Return to main menu")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Easy_English_Numbers_1_60_Edition.My.Resources.Resources.Quiz_4
        Me.PictureBox1.Location = New System.Drawing.Point(74, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 194)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'Form_TakeQuiz4
        '
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(356, 338)
        Me.Controls.Add(Me.btnStartQuiz)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblInstructions)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_TakeQuiz4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "English Numbers Quiz 4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStartQuiz As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Private components As System.ComponentModel.IContainer
End Class