

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class entryForm
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
        Me.txtbox_password = New System.Windows.Forms.TextBox()
        Me.lbl_passwordIndicator = New System.Windows.Forms.Label()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.lbl_passwordManagerHeader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtbox_password
        '
        Me.txtbox_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_password.Location = New System.Drawing.Point(158, 107)
        Me.txtbox_password.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbox_password.Name = "txtbox_password"
        Me.txtbox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_password.Size = New System.Drawing.Size(372, 23)
        Me.txtbox_password.TabIndex = 0
        '
        'lbl_passwordIndicator
        '
        Me.lbl_passwordIndicator.AutoSize = True
        Me.lbl_passwordIndicator.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_passwordIndicator.Location = New System.Drawing.Point(80, 110)
        Me.lbl_passwordIndicator.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_passwordIndicator.Name = "lbl_passwordIndicator"
        Me.lbl_passwordIndicator.Size = New System.Drawing.Size(73, 17)
        Me.lbl_passwordIndicator.TabIndex = 1
        Me.lbl_passwordIndicator.Text = "Password:"
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(540, 106)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(88, 23)
        Me.btn_submit.TabIndex = 2
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'lbl_passwordManagerHeader
        '
        Me.lbl_passwordManagerHeader.AutoSize = True
        Me.lbl_passwordManagerHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_passwordManagerHeader.Location = New System.Drawing.Point(224, 32)
        Me.lbl_passwordManagerHeader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_passwordManagerHeader.Name = "lbl_passwordManagerHeader"
        Me.lbl_passwordManagerHeader.Size = New System.Drawing.Size(247, 31)
        Me.lbl_passwordManagerHeader.TabIndex = 3
        Me.lbl_passwordManagerHeader.Text = "Password Manager"
        '
        'entryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 165)
        Me.Controls.Add(Me.lbl_passwordManagerHeader)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.lbl_passwordIndicator)
        Me.Controls.Add(Me.txtbox_password)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "entryForm"
        Me.Text = "Password Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents lbl_passwordIndicator As Label
    Friend WithEvents btn_submit As Button
    Friend WithEvents lbl_passwordManagerHeader As Label

End Class
