Public Class MainMenu
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init.Start()
    End Sub
    Private Sub MainALCheck_CheckedChanged(sender As Object, e As EventArgs) Handles MainALCheck.CheckStateChanged
        If (MainALCheck.CheckState = CheckState.Checked) Then Mem.AutoLoad = True Else Mem.AutoLoad = False
        Settings.UpdateSettings()
    End Sub
    Private Sub MainGoButton_Click(sender As Object, e As EventArgs) Handles MainGoButton.Click
        'launch ledger here
    End Sub
    Private Sub MainDBButton_Click(sender As Object, e As EventArgs) Handles MainDBButton.Click
        'opens change database dialog
    End Sub
    Private Sub MainNewButton_Click(sender As Object, e As EventArgs) Handles MainNewButton.Click
        'open new database dialog
    End Sub
    Private Sub MainDelButton_Click(sender As Object, e As EventArgs) Handles MainDelButton.Click
        'open delete database dialog
    End Sub
    Private Sub MainOButton_Click(sender As Object, e As EventArgs) Handles MainOButton.Click
        'opens options dialog
    End Sub
    Private Sub MainUpButton_Click(sender As Object, e As EventArgs) Handles MainUpButton.Click
        'launch update check
    End Sub
    Private Sub MainExitButton_Click(sender As Object, e As EventArgs) Handles MainExitButton.Click
        OnExit()
    End Sub
    Private Sub MainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Settings.UpdateSettings()
        If AskIt() = vbNo Then e.Cancel = True
    End Sub

    Private Sub MainCTGLabel_Click(sender As Object, e As EventArgs) Handles MainCTGLabel.Click
        Process.Start("https://www.clarktribegames.com")
    End Sub
    Public Shared Sub UpdateDBName(dbname As String)
        MainMenu.MainDBText.Text = $"Database Selected: {dbname}"
    End Sub
    Private Shared Function AskIt() As Integer
        Return MsgBox("Are you sure you want to exit?", vbYesNo)
    End Function
    Public Shared Sub OnExit()
        If AskIt() = vbYes Then
            Settings.UpdateSettings()
            Environment.Exit(0)
        End If

    End Sub
    Public Shared Sub FlipButton(button As Button, mode As Boolean)
        If mode = False Then
            button.ForeColor = Color.Black
            button.BackColor = Color.DarkGray
            button.Enabled = False
        Else
            button.ForeColor = Color.WhiteSmoke
            button.BackColor = Color.Black
            button.Enabled = True
        End If
    End Sub
End Class