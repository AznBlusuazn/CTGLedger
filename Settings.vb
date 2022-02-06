Imports ClarkTribeGames
Imports Newtonsoft.Json
Imports System.IO
Imports System.Text
Public Class Settings
    Public Shared Sub Check()
        If Not (File.Exists(Mem.Settings)) Then BuildSettings()
        GetSettings()
    End Sub
    Private Shared Sub BuildSettings()
        Dim fs As FileStream = File.Create(Mem.Settings)
        Dim JsonData As String = SettingsData({$"{Mem.DBName}{Mem.DBExt}", Mem.AutoLoad})
        Dim X As New Coder((New Coder(Mem.Phoenix)).DecryptData(Mem.Teddy))
        Dim data As Byte() = New UTF8Encoding(True).GetBytes(X.EncryptData(JsonData))
        fs.Write(data, 0, data.Length)
        fs.Close()
        fs.Dispose()
    End Sub

    Public Shared Sub UpdateSettings()
        FilesFolders.DeleteFile(Mem.Settings)
        BuildSettings()
    End Sub
    Private Shared Function SettingsData(data() As String) As String
        Dim DataSet As New SetData() With {.LastFile = data(0), .AutoLoad = data(1)}
        'Add more with this format:
        Dim SetFinal As New List(Of SetData)() From {DataSet}
        Return JsonConvert.SerializeObject(SetFinal)
    End Function
    Private Shared Sub GetSettings()
        Dim X As New Coder(New Coder(Mem.Phoenix).DecryptData(Mem.Teddy))
        Dim reader As StreamReader
        reader = My.Computer.FileSystem.OpenTextFileReader($"{Mem.Settings}")
        Dim Encrypted As String = reader.ReadToEnd()
        reader.Close()
        reader.Dispose()
        Dim RawData As String = X.DecryptData(Encrypted)
        Dim Converted = JsonConvert.DeserializeObject(Of List(Of SetData))(RawData)
        'Last Database Loaded Setting
        Mem.DBName = Converted(0).LastFile.ToString.Split(".")(0)
        Mem.FullDB = $"{Mem.DBDir}\{Mem.DBName}{Mem.DBExt}"
        MainMenu.UpdateDBName($"{Mem.DBName}")
        'AutoLoad Last Database setting
        If Converted(0).AutoLoad.ToString.Equals("True") Then Mem.AutoLoad = True Else Mem.AutoLoad = False
        If Mem.AutoLoad Then MainMenu.MainALCheck.CheckState = CheckState.Checked Else MainMenu.MainALCheck.CheckState = CheckState.Unchecked
        'Add additional settings with x = Converted(0).NameOfSettings (with whatever else is needed)

    End Sub
End Class
Public Class SetData
    Public Property LastFile As String
    Public Property AutoLoad As String
    'Add additional Public Property items here for more Settings
End Class
