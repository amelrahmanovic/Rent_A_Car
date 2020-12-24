Public Class Home
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Dim s As String = e.ClickedItem.Text
        If s Like "Auta" Then
            Dim f As New Auta
            f.MdiParent = Me
            f.Show()
        End If

        If s Like "Korisnici" Then
            Dim f As New Korisnici
            f.MdiParent = Me
            f.Show()
        End If

        If s Like "Dodatna oprema" Then
            Dim f As New DodatnaOprema
            f.MdiParent = Me
            f.Show()
        End If


    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class