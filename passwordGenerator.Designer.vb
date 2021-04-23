<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class passwordGenerator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboxCaps = New System.Windows.Forms.CheckBox()
        Me.lblCaps = New System.Windows.Forms.Label()
        Me.tboxLength = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblSymb = New System.Windows.Forms.Label()
        Me.cboxSymb = New System.Windows.Forms.CheckBox()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.cboxNumb = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblnewPasswordidentifier = New System.Windows.Forms.Label()
        Me.lblnewPassword = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblRememberHeader = New System.Windows.Forms.Label()
        Me.lblOriginalWord = New System.Windows.Forms.Label()
        Me.lblNumbDesc = New System.Windows.Forms.Label()
        Me.lblCapitalDesc = New System.Windows.Forms.Label()
        Me.lblSymbDesc = New System.Windows.Forms.Label()
        Me.lblSymbols = New System.Windows.Forms.Label()
        Me.lblCapitals = New System.Windows.Forms.Label()
        Me.lblNumbers = New System.Windows.Forms.Label()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboxCaps
        '
        Me.cboxCaps.AutoSize = True
        Me.cboxCaps.Location = New System.Drawing.Point(153, 63)
        Me.cboxCaps.Name = "cboxCaps"
        Me.cboxCaps.Size = New System.Drawing.Size(63, 17)
        Me.cboxCaps.TabIndex = 0
        Me.cboxCaps.Text = "Capitals"
        Me.cboxCaps.UseVisualStyleBackColor = True
        '
        'lblCaps
        '
        Me.lblCaps.AutoSize = True
        Me.lblCaps.Location = New System.Drawing.Point(69, 64)
        Me.lblCaps.Name = "lblCaps"
        Me.lblCaps.Size = New System.Drawing.Size(73, 13)
        Me.lblCaps.TabIndex = 1
        Me.lblCaps.Text = "Capital letters:"
        '
        'tboxLength
        '
        Me.tboxLength.Location = New System.Drawing.Point(153, 141)
        Me.tboxLength.Name = "tboxLength"
        Me.tboxLength.Size = New System.Drawing.Size(81, 20)
        Me.tboxLength.TabIndex = 2
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(148, 188)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(72, 20)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblSymb
        '
        Me.lblSymb.AutoSize = True
        Me.lblSymb.Location = New System.Drawing.Point(93, 91)
        Me.lblSymb.Name = "lblSymb"
        Me.lblSymb.Size = New System.Drawing.Size(49, 13)
        Me.lblSymb.TabIndex = 5
        Me.lblSymb.Text = "Symbols:"
        '
        'cboxSymb
        '
        Me.cboxSymb.AutoSize = True
        Me.cboxSymb.Location = New System.Drawing.Point(153, 90)
        Me.cboxSymb.Name = "cboxSymb"
        Me.cboxSymb.Size = New System.Drawing.Size(65, 17)
        Me.cboxSymb.TabIndex = 4
        Me.cboxSymb.Text = "Symbols"
        Me.cboxSymb.UseVisualStyleBackColor = True
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(90, 118)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(52, 13)
        Me.lblNum.TabIndex = 7
        Me.lblNum.Text = "Numbers:"
        '
        'cboxNumb
        '
        Me.cboxNumb.AutoSize = True
        Me.cboxNumb.Location = New System.Drawing.Point(153, 118)
        Me.cboxNumb.Name = "cboxNumb"
        Me.cboxNumb.Size = New System.Drawing.Size(68, 17)
        Me.cboxNumb.TabIndex = 6
        Me.cboxNumb.Text = "Numbers"
        Me.cboxNumb.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Length:"
        '
        'lblnewPasswordidentifier
        '
        Me.lblnewPasswordidentifier.AutoSize = True
        Me.lblnewPasswordidentifier.Location = New System.Drawing.Point(62, 165)
        Me.lblnewPasswordidentifier.Name = "lblnewPasswordidentifier"
        Me.lblnewPasswordidentifier.Size = New System.Drawing.Size(81, 13)
        Me.lblnewPasswordidentifier.TabIndex = 9
        Me.lblnewPasswordidentifier.Text = "New Password:"
        '
        'lblnewPassword
        '
        Me.lblnewPassword.AutoSize = True
        Me.lblnewPassword.Location = New System.Drawing.Point(149, 165)
        Me.lblnewPassword.Name = "lblnewPassword"
        Me.lblnewPassword.Size = New System.Drawing.Size(0, 13)
        Me.lblnewPassword.TabIndex = 10
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(226, 188)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(72, 20)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(96, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(282, 33)
        Me.lblHeader.TabIndex = 12
        Me.lblHeader.Text = "Password Generator"
        '
        'lblRememberHeader
        '
        Me.lblRememberHeader.AutoSize = True
        Me.lblRememberHeader.Location = New System.Drawing.Point(293, 51)
        Me.lblRememberHeader.Name = "lblRememberHeader"
        Me.lblRememberHeader.Size = New System.Drawing.Size(93, 13)
        Me.lblRememberHeader.TabIndex = 13
        Me.lblRememberHeader.Text = "How to remember:"
        Me.lblRememberHeader.Visible = False
        '
        'lblOriginalWord
        '
        Me.lblOriginalWord.AutoSize = True
        Me.lblOriginalWord.Location = New System.Drawing.Point(257, 68)
        Me.lblOriginalWord.Name = "lblOriginalWord"
        Me.lblOriginalWord.Size = New System.Drawing.Size(74, 13)
        Me.lblOriginalWord.TabIndex = 14
        Me.lblOriginalWord.Text = "Original Word:"
        Me.lblOriginalWord.Visible = False
        '
        'lblNumbDesc
        '
        Me.lblNumbDesc.AutoSize = True
        Me.lblNumbDesc.Location = New System.Drawing.Point(277, 94)
        Me.lblNumbDesc.Name = "lblNumbDesc"
        Me.lblNumbDesc.Size = New System.Drawing.Size(52, 13)
        Me.lblNumbDesc.TabIndex = 15
        Me.lblNumbDesc.Text = "Numbers:"
        Me.lblNumbDesc.Visible = False
        '
        'lblCapitalDesc
        '
        Me.lblCapitalDesc.AutoSize = True
        Me.lblCapitalDesc.Location = New System.Drawing.Point(257, 122)
        Me.lblCapitalDesc.Name = "lblCapitalDesc"
        Me.lblCapitalDesc.Size = New System.Drawing.Size(73, 13)
        Me.lblCapitalDesc.TabIndex = 16
        Me.lblCapitalDesc.Text = "Capital letters:"
        Me.lblCapitalDesc.Visible = False
        '
        'lblSymbDesc
        '
        Me.lblSymbDesc.AutoSize = True
        Me.lblSymbDesc.Location = New System.Drawing.Point(277, 150)
        Me.lblSymbDesc.Name = "lblSymbDesc"
        Me.lblSymbDesc.Size = New System.Drawing.Size(49, 13)
        Me.lblSymbDesc.TabIndex = 17
        Me.lblSymbDesc.Text = "Symbols:"
        Me.lblSymbDesc.Visible = False
        '
        'lblSymbols
        '
        Me.lblSymbols.AutoSize = True
        Me.lblSymbols.Location = New System.Drawing.Point(328, 150)
        Me.lblSymbols.Name = "lblSymbols"
        Me.lblSymbols.Size = New System.Drawing.Size(0, 13)
        Me.lblSymbols.TabIndex = 18
        '
        'lblCapitals
        '
        Me.lblCapitals.AutoSize = True
        Me.lblCapitals.Location = New System.Drawing.Point(328, 123)
        Me.lblCapitals.Name = "lblCapitals"
        Me.lblCapitals.Size = New System.Drawing.Size(0, 13)
        Me.lblCapitals.TabIndex = 19
        '
        'lblNumbers
        '
        Me.lblNumbers.AutoSize = True
        Me.lblNumbers.Location = New System.Drawing.Point(328, 94)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(0, 13)
        Me.lblNumbers.TabIndex = 20
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(328, 68)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(0, 13)
        Me.lblWord.TabIndex = 21
        '
        'passwordGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 229)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.lblNumbers)
        Me.Controls.Add(Me.lblCapitals)
        Me.Controls.Add(Me.lblSymbols)
        Me.Controls.Add(Me.lblSymbDesc)
        Me.Controls.Add(Me.lblCapitalDesc)
        Me.Controls.Add(Me.lblNumbDesc)
        Me.Controls.Add(Me.lblOriginalWord)
        Me.Controls.Add(Me.lblRememberHeader)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblnewPassword)
        Me.Controls.Add(Me.lblnewPasswordidentifier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.cboxNumb)
        Me.Controls.Add(Me.lblSymb)
        Me.Controls.Add(Me.cboxSymb)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.tboxLength)
        Me.Controls.Add(Me.lblCaps)
        Me.Controls.Add(Me.cboxCaps)
        Me.Name = "passwordGenerator"
        Me.Text = "Password Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboxCaps As CheckBox
    Friend WithEvents lblCaps As Label
    Friend WithEvents tboxLength As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblSymb As Label
    Friend WithEvents cboxSymb As CheckBox
    Friend WithEvents lblNum As Label
    Friend WithEvents cboxNumb As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblnewPasswordidentifier As Label
    Friend WithEvents lblnewPassword As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblRememberHeader As Label
    Friend WithEvents lblOriginalWord As Label
    Friend WithEvents lblNumbDesc As Label
    Friend WithEvents lblCapitalDesc As Label
    Friend WithEvents lblSymbDesc As Label
    Friend WithEvents lblSymbols As Label
    Friend WithEvents lblCapitals As Label
    Friend WithEvents lblNumbers As Label
    Friend WithEvents lblWord As Label
End Class
