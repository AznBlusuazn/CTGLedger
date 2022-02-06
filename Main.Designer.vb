<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.MainTitleLabel = New System.Windows.Forms.Label()
        Me.MainGoButton = New System.Windows.Forms.Button()
        Me.MainDBText = New System.Windows.Forms.Label()
        Me.MainDBButton = New System.Windows.Forms.Button()
        Me.MainOButton = New System.Windows.Forms.Button()
        Me.MainExitButton = New System.Windows.Forms.Button()
        Me.MainCTGLabel = New System.Windows.Forms.Label()
        Me.MainALCheck = New System.Windows.Forms.CheckBox()
        Me.MainNewButton = New System.Windows.Forms.Button()
        Me.MainDelButton = New System.Windows.Forms.Button()
        Me.MainUpButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MainTitleLabel
        '
        Me.MainTitleLabel.Font = New System.Drawing.Font("Lucida Console", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTitleLabel.Location = New System.Drawing.Point(12, 9)
        Me.MainTitleLabel.Name = "MainTitleLabel"
        Me.MainTitleLabel.Size = New System.Drawing.Size(512, 43)
        Me.MainTitleLabel.TabIndex = 0
        Me.MainTitleLabel.Text = "CTGLedger"
        Me.MainTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainGoButton
        '
        Me.MainGoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainGoButton.Location = New System.Drawing.Point(182, 160)
        Me.MainGoButton.Name = "MainGoButton"
        Me.MainGoButton.Size = New System.Drawing.Size(175, 23)
        Me.MainGoButton.TabIndex = 1
        Me.MainGoButton.Text = "Launch Ledger"
        Me.MainGoButton.UseVisualStyleBackColor = True
        '
        'MainDBText
        '
        Me.MainDBText.Location = New System.Drawing.Point(15, 60)
        Me.MainDBText.Name = "MainDBText"
        Me.MainDBText.Size = New System.Drawing.Size(509, 13)
        Me.MainDBText.TabIndex = 3
        Me.MainDBText.Text = "[Selected Database Path Here]"
        Me.MainDBText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainDBButton
        '
        Me.MainDBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainDBButton.Location = New System.Drawing.Point(182, 210)
        Me.MainDBButton.Name = "MainDBButton"
        Me.MainDBButton.Size = New System.Drawing.Size(175, 23)
        Me.MainDBButton.TabIndex = 4
        Me.MainDBButton.Text = "Change Database"
        Me.MainDBButton.UseVisualStyleBackColor = True
        '
        'MainOButton
        '
        Me.MainOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainOButton.Location = New System.Drawing.Point(182, 360)
        Me.MainOButton.Name = "MainOButton"
        Me.MainOButton.Size = New System.Drawing.Size(175, 23)
        Me.MainOButton.TabIndex = 5
        Me.MainOButton.Text = "Options"
        Me.MainOButton.UseVisualStyleBackColor = True
        '
        'MainExitButton
        '
        Me.MainExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainExitButton.Location = New System.Drawing.Point(182, 460)
        Me.MainExitButton.Name = "MainExitButton"
        Me.MainExitButton.Size = New System.Drawing.Size(175, 23)
        Me.MainExitButton.TabIndex = 6
        Me.MainExitButton.Text = "Exit"
        Me.MainExitButton.UseVisualStyleBackColor = True
        '
        'MainCTGLabel
        '
        Me.MainCTGLabel.Location = New System.Drawing.Point(15, 525)
        Me.MainCTGLabel.Name = "MainCTGLabel"
        Me.MainCTGLabel.Size = New System.Drawing.Size(509, 13)
        Me.MainCTGLabel.TabIndex = 7
        Me.MainCTGLabel.Text = "ClarkTribeGames, LLC"
        Me.MainCTGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainALCheck
        '
        Me.MainALCheck.Location = New System.Drawing.Point(168, 110)
        Me.MainALCheck.Name = "MainALCheck"
        Me.MainALCheck.Size = New System.Drawing.Size(203, 17)
        Me.MainALCheck.TabIndex = 8
        Me.MainALCheck.Text = "AutoLoad This Database"
        Me.MainALCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MainALCheck.UseVisualStyleBackColor = True
        '
        'MainNewButton
        '
        Me.MainNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainNewButton.Location = New System.Drawing.Point(182, 260)
        Me.MainNewButton.Name = "MainNewButton"
        Me.MainNewButton.Size = New System.Drawing.Size(175, 23)
        Me.MainNewButton.TabIndex = 9
        Me.MainNewButton.Text = "New Database"
        Me.MainNewButton.UseVisualStyleBackColor = True
        '
        'MainDelButton
        '
        Me.MainDelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainDelButton.Location = New System.Drawing.Point(182, 310)
        Me.MainDelButton.Name = "MainDelButton"
        Me.MainDelButton.Size = New System.Drawing.Size(175, 23)
        Me.MainDelButton.TabIndex = 10
        Me.MainDelButton.Text = "Delete Database"
        Me.MainDelButton.UseVisualStyleBackColor = True
        '
        'MainUpButton
        '
        Me.MainUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainUpButton.Location = New System.Drawing.Point(182, 410)
        Me.MainUpButton.Name = "MainUpButton"
        Me.MainUpButton.Size = New System.Drawing.Size(175, 23)
        Me.MainUpButton.TabIndex = 11
        Me.MainUpButton.Text = "Check For Updates"
        Me.MainUpButton.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(539, 557)
        Me.Controls.Add(Me.MainUpButton)
        Me.Controls.Add(Me.MainDelButton)
        Me.Controls.Add(Me.MainNewButton)
        Me.Controls.Add(Me.MainALCheck)
        Me.Controls.Add(Me.MainCTGLabel)
        Me.Controls.Add(Me.MainExitButton)
        Me.Controls.Add(Me.MainOButton)
        Me.Controls.Add(Me.MainDBButton)
        Me.Controls.Add(Me.MainDBText)
        Me.Controls.Add(Me.MainGoButton)
        Me.Controls.Add(Me.MainTitleLabel)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CTGLedger"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainTitleLabel As Label
    Friend WithEvents MainGoButton As Button
    Friend WithEvents MainDBText As Label
    Friend WithEvents MainDBButton As Button
    Friend WithEvents MainOButton As Button
    Friend WithEvents MainExitButton As Button
    Friend WithEvents MainCTGLabel As Label
    Friend WithEvents MainALCheck As CheckBox
    Friend WithEvents MainNewButton As Button
    Friend WithEvents MainDelButton As Button
    Friend WithEvents MainUpButton As Button
End Class
