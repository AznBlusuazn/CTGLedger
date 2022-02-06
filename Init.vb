Imports ClarkTribeGames
Public Class Init
    Public Shared Sub Start()
        Folders()
        Settings.Check()
        Database.Check()
    End Sub
    Private Shared Sub Folders()
        FilesFolders.CreateDirectory(Mem.LogDir)
        FilesFolders.CreateDirectory(Mem.DBDir)
    End Sub
End Class
