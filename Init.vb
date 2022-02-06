Imports ClarkTribeGames
Public Class Init
    Public Shared Sub Start()
        Folders()
        TempDisable()
        Settings.Check()
        Database.Check()
        'TODO:  Add AutoLoad function to go straight into Ledger

    End Sub
    Private Shared Sub Folders()
        FilesFolders.CreateDirectory(Mem.LogDir)
        FilesFolders.CreateDirectory(Mem.DBDir)
    End Sub

    Private Shared Sub TempDisable()
        'this is just for development
        MainMenu.FlipButton(MainMenu.MainDBButton, False)
        MainMenu.FlipButton(MainMenu.MainNewButton, False)
        MainMenu.FlipButton(MainMenu.MainDelButton, False)
        MainMenu.FlipButton(MainMenu.MainOButton, False)
        MainMenu.FlipButton(MainMenu.MainUpButton, False)
    End Sub
End Class