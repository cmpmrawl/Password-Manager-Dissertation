﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deletePassword
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.cboxRemove = New System.Windows.Forms.ComboBox()
        Me.lblWeb = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lbldesc1 = New System.Windows.Forms.Label()
        Me.lbldesc2 = New System.Windows.Forms.Label()
        Me.lbldesc3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(571, 117)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(147, 25)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.Location = New System.Drawing.Point(40, 21)
        Me.lblChoose.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(129, 17)
        Me.lblChoose.TabIndex = 17
        Me.lblChoose.Text = "Choose row to edit:"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(432, 117)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(131, 25)
        Me.btnRemove.TabIndex = 16
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'cboxRemove
        '
        Me.cboxRemove.FormattingEnabled = True
        Me.cboxRemove.Location = New System.Drawing.Point(179, 17)
        Me.cboxRemove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboxRemove.Name = "cboxRemove"
        Me.cboxRemove.Size = New System.Drawing.Size(245, 24)
        Me.cboxRemove.TabIndex = 12
        '
        'lblWeb
        '
        Me.lblWeb.AutoSize = True
        Me.lblWeb.Location = New System.Drawing.Point(175, 59)
        Me.lblWeb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(116, 17)
        Me.lblWeb.TabIndex = 18
        Me.lblWeb.Text = "Website / Source"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(175, 89)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(73, 17)
        Me.lblUser.TabIndex = 19
        Me.lblUser.Text = "Username"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(175, 117)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(69, 17)
        Me.lblPass.TabIndex = 20
        Me.lblPass.Text = "Password"
        '
        'lbldesc1
        '
        Me.lbldesc1.AutoSize = True
        Me.lbldesc1.Location = New System.Drawing.Point(49, 59)
        Me.lbldesc1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldesc1.Name = "lbldesc1"
        Me.lbldesc1.Size = New System.Drawing.Size(120, 17)
        Me.lbldesc1.TabIndex = 21
        Me.lbldesc1.Text = "Website / Source:"
        Me.lbldesc1.Visible = False
        '
        'lbldesc2
        '
        Me.lbldesc2.AutoSize = True
        Me.lbldesc2.Location = New System.Drawing.Point(49, 89)
        Me.lbldesc2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldesc2.Name = "lbldesc2"
        Me.lbldesc2.Size = New System.Drawing.Size(77, 17)
        Me.lbldesc2.TabIndex = 22
        Me.lbldesc2.Text = "Username:"
        Me.lbldesc2.Visible = False
        '
        'lbldesc3
        '
        Me.lbldesc3.AutoSize = True
        Me.lbldesc3.Location = New System.Drawing.Point(49, 117)
        Me.lbldesc3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldesc3.Name = "lbldesc3"
        Me.lbldesc3.Size = New System.Drawing.Size(73, 17)
        Me.lbldesc3.TabIndex = 23
        Me.lbldesc3.Text = "Password:"
        Me.lbldesc3.Visible = False
        '
        'deletePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 148)
        Me.Controls.Add(Me.lbldesc3)
        Me.Controls.Add(Me.lbldesc2)
        Me.Controls.Add(Me.lbldesc1)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblWeb)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.cboxRemove)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "deletePassword"
        Me.Text = "Remove Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblChoose As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents cboxRemove As ComboBox
    Friend WithEvents lblWeb As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lbldesc1 As Label
    Friend WithEvents lbldesc2 As Label
    Friend WithEvents lbldesc3 As Label
End Class
