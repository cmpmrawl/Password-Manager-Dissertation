﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editPassword
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
        Me.cboxEdit = New System.Windows.Forms.ComboBox()
        Me.txtboxWebsite = New System.Windows.Forms.TextBox()
        Me.txtboxpass = New System.Windows.Forms.TextBox()
        Me.txtboxUser = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.lblWeb = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(422, 93)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(98, 20)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cboxEdit
        '
        Me.cboxEdit.FormattingEnabled = True
        Me.cboxEdit.Location = New System.Drawing.Point(128, 12)
        Me.cboxEdit.Name = "cboxEdit"
        Me.cboxEdit.Size = New System.Drawing.Size(185, 21)
        Me.cboxEdit.TabIndex = 2
        '
        'txtboxWebsite
        '
        Me.txtboxWebsite.Location = New System.Drawing.Point(128, 43)
        Me.txtboxWebsite.Name = "txtboxWebsite"
        Me.txtboxWebsite.Size = New System.Drawing.Size(184, 20)
        Me.txtboxWebsite.TabIndex = 3
        '
        'txtboxpass
        '
        Me.txtboxpass.Location = New System.Drawing.Point(128, 93)
        Me.txtboxpass.Name = "txtboxpass"
        Me.txtboxpass.Size = New System.Drawing.Size(184, 20)
        Me.txtboxpass.TabIndex = 4
        '
        'txtboxUser
        '
        Me.txtboxUser.Location = New System.Drawing.Point(128, 67)
        Me.txtboxUser.Name = "txtboxUser"
        Me.txtboxUser.Size = New System.Drawing.Size(184, 20)
        Me.txtboxUser.TabIndex = 5
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(318, 93)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(98, 20)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Submit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.Location = New System.Drawing.Point(24, 15)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(111, 15)
        Me.lblChoose.TabIndex = 7
        Me.lblChoose.Text = "Choose row to edit:"
        '
        'lblWeb
        '
        Me.lblWeb.AutoSize = True
        Me.lblWeb.Location = New System.Drawing.Point(3, 43)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(130, 15)
        Me.lblWeb.TabIndex = 8
        Me.lblWeb.Text = "New Website / Source:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(39, 70)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(96, 15)
        Me.lblUser.TabIndex = 9
        Me.lblUser.Text = "New Username:"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(41, 96)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(92, 15)
        Me.lblPass.TabIndex = 10
        Me.lblPass.Text = "New Password:"
        '
        'editPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 136)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblWeb)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtboxUser)
        Me.Controls.Add(Me.txtboxpass)
        Me.Controls.Add(Me.txtboxWebsite)
        Me.Controls.Add(Me.cboxEdit)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "editPassword"
        Me.Text = "Edit Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents cboxEdit As ComboBox
    Friend WithEvents txtboxWebsite As TextBox
    Friend WithEvents txtboxpass As TextBox
    Friend WithEvents txtboxUser As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblChoose As Label
    Friend WithEvents lblWeb As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
End Class
