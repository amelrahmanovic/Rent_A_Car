Public Class MyOleDbConnection
    Public connection As String
    Public Sub New()
        connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb"
    End Sub
End Class
