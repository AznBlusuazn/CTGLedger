Imports ClarkTribeGames
Imports System.IO
Public Class Database
    Public Shared Sub Baseline(Optional filename As String = "")
        If (filename.Length < 1) Then filename = $"{Mem.DBName}{Mem.DBExt}"
        Try
            SQLite.CreateDB(".\", $"{Mem.DBDir}\{filename}",
                "CREATE TABLE ""Ledger"" (""ID"" INTEGER NOT NULL UNIQUE, " &
                """Date"" TEXT NOT NULL,""Desc""TEXT,""CatID"" INTEGER," &
                """Amt"" TEXT,""Notes"" TEXT, PRIMARY KEY(""ID"" AUTOINCREMENT));" &
                $"{vbCrLf}CREATE TABLE ""Categories"" (""ID"" INTEGER Not NULL " &
                "UNIQUE,""Name"" TEXT Not NULL,""Sub"" TEXT,""Active"" NUMERIC," &
                $"PRIMARY KEY(""ID"" AUTOINCREMENT));{vbCrLf}CREATE TABLE ""Rules""" &
                " (""ID"" INTEGER Not NULL UNIQUE,""Type"" INTEGER Not NULL," &
                """Keyword"" TEXT,""Amt"" TEXT Not NULL,""CatID"" INTEGER Not " &
                $"NULL, PRIMARY KEY(""ID"" AUTOINCREMENT));{vbCrLf}CREATE TABLE " &
                """Types"" (""ID"" INTEGER NOT NULL UNIQUE, ""Type"" TEXT Not NULL, " &
                $"PRIMARY KEY(""ID"" AUTOINCREMENT));")
        Catch ex As Exception
            Logger.WriteToLog("DB Baseline", "Failed to CreateDB", ex)
        End Try
    End Sub
    Public Shared Sub Check()
        Dim OGDB As String = Mem.DBName
        If Not File.Exists(Mem.FullDB) Then
            Mem.DBName = "Default"
            Mem.FullDB = $"{Mem.DBDir}\{Mem.DBName}{Mem.DBExt}"
            If Not File.Exists(Mem.FullDB) Then
                Baseline($"{Mem.DBName}{Mem.DBExt}")
                MsgBox($"{Mem.DBName}{Mem.DBExt} did not exist, so created empty DB.")
            Else
                MsgBox($"Could find {OGDB}{Mem.DBExt} did not exist, so switched to Default DB.")
            End If
        End If
        Settings.UpdateSettings()
    End Sub
End Class
