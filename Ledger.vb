Public Class Ledger
    Private Sub Ledger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Shared Sub AddToL(data As String())
        '0:id , 1:date, 2: desc, 3:catid, 4:amt, 5: notes
        Ledger.LedgerGrid.Rows.Add(data(0), Convert.ToDateTime(data(1)).ToString("MM/dd/yyyy"), data(2), Database.GetCat(data(3)), data(4), data(5))
    End Sub

End Class