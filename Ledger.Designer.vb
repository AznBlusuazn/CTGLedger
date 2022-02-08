<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ledger
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
        Me.LedgerGrid = New System.Windows.Forms.DataGridView()
        Me.LID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LCat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LedgerGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LedgerGrid
        '
        Me.LedgerGrid.AllowUserToAddRows = False
        Me.LedgerGrid.AllowUserToDeleteRows = False
        Me.LedgerGrid.BackgroundColor = System.Drawing.Color.Black
        Me.LedgerGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LedgerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LedgerGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LID, Me.LDate, Me.LDesc, Me.LCat, Me.LAmt, Me.LNotes})
        Me.LedgerGrid.GridColor = System.Drawing.Color.Gray
        Me.LedgerGrid.Location = New System.Drawing.Point(13, 82)
        Me.LedgerGrid.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LedgerGrid.Name = "LedgerGrid"
        Me.LedgerGrid.ReadOnly = True
        Me.LedgerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.LedgerGrid.Size = New System.Drawing.Size(1394, 289)
        Me.LedgerGrid.TabIndex = 0
        '
        'LID
        '
        Me.LID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LID.HeaderText = "ID"
        Me.LID.Name = "LID"
        Me.LID.ReadOnly = True
        Me.LID.Visible = False
        Me.LID.Width = 43
        '
        'LDate
        '
        Me.LDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LDate.HeaderText = "Date"
        Me.LDate.Name = "LDate"
        Me.LDate.ReadOnly = True
        Me.LDate.Width = 64
        '
        'LDesc
        '
        Me.LDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LDesc.HeaderText = "Description"
        Me.LDesc.Name = "LDesc"
        Me.LDesc.ReadOnly = True
        Me.LDesc.Width = 120
        '
        'LCat
        '
        Me.LCat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LCat.HeaderText = "Category"
        Me.LCat.Name = "LCat"
        Me.LCat.ReadOnly = True
        Me.LCat.Width = 96
        '
        'LAmt
        '
        Me.LAmt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LAmt.HeaderText = "Amount"
        Me.LAmt.Name = "LAmt"
        Me.LAmt.ReadOnly = True
        Me.LAmt.Width = 80
        '
        'LNotes
        '
        Me.LNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LNotes.HeaderText = "Notes"
        Me.LNotes.Name = "LNotes"
        Me.LNotes.ReadOnly = True
        Me.LNotes.Width = 72
        '
        'Ledger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1420, 557)
        Me.Controls.Add(Me.LedgerGrid)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Ledger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ledger"
        CType(Me.LedgerGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LedgerGrid As DataGridView
    Friend WithEvents LID As DataGridViewTextBoxColumn
    Friend WithEvents LDate As DataGridViewTextBoxColumn
    Friend WithEvents LDesc As DataGridViewTextBoxColumn
    Friend WithEvents LCat As DataGridViewTextBoxColumn
    Friend WithEvents LAmt As DataGridViewTextBoxColumn
    Friend WithEvents LNotes As DataGridViewTextBoxColumn
End Class
