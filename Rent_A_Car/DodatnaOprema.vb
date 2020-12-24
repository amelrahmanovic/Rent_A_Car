Imports System.Data.OleDb

Public Class DodatnaOprema
    Private Function CreateConnection() As OleDb.OleDbConnection
        Dim con As New MyOleDbConnection()
        Return New OleDb.OleDbConnection(con.connection)
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSnimi.Click
        Try
            Dim conn As OleDb.OleDbConnection = CreateConnection()
            conn.Open()
            Dim strSql As String = "INSERT INTO DodatnaOprema ( Naziv, Cijena )
                                    VALUES('" + TextBoxNaziv.Text + "'," + TextBoxCijena.Text + ")"
            Dim dadapter As OleDbDataAdapter
            dadapter = New OleDbDataAdapter()
            'dadapter.SelectCommand = New OleDbCommand(strSql, conn)
            dadapter.InsertCommand = New OleDbCommand(strSql, conn)
            dadapter.InsertCommand.ExecuteNonQuery()
            conn.Close()

            TextBoxNaziv.Text = ""
            TextBoxCijena.Text = ""

            LoadDodatnaOprema()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DodatnaOprema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDodatnaOprema()
    End Sub

    Private Sub LoadDodatnaOprema()
        Try
            Dim conn As OleDb.OleDbConnection = CreateConnection()
            Dim strSql As String = "SELECT * FROM DodatnaOprema"
            Dim dadapter As OleDbDataAdapter
            dadapter = New OleDbDataAdapter()
            dadapter.SelectCommand = New OleDbCommand(strSql, conn)
            Dim dset As DataSet = New DataSet()
            dadapter.Fill(dset, "DodatnaOprema")
            If dset.Tables("DodatnaOprema").Rows.Count > 0 Then
                DataGridView1.DataSource = dset.Tables(0)
                'MessageBox.Show(dset.Tables.Count) 'Count
                'MessageBox.Show(dset.Tables("Auta").Rows(0)("Marka")) 'get ime
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim selectedGR As DataGridViewRow
            selectedGR = DataGridView1.Rows(e.RowIndex)
            'MessageBox.Show(selectedGR.Cells(0).Value)

            Dim conn As OleDb.OleDbConnection = CreateConnection()
            Dim strSql As String = "SELECT DodatnaOpremaNajam.AutoNajam, DodatnaOprema.Naziv, DodatnaOprema.Cijena, AutaNajam.DatumPreuzimanja, AutaNajam.DatumVracanja
                                    FROM AutaNajam 
                                        INNER JOIN (DodatnaOprema 
                                        INNER JOIN DodatnaOpremaNajam 
                                            ON DodatnaOprema.DodatnaOpremaId = DodatnaOpremaNajam.DodatnaOprema) 
                                            ON AutaNajam.ID = DodatnaOpremaNajam.AutoNajam 
                                    WHERE (((DodatnaOpremaNajam.DodatnaOpremaNajamId)=" + selectedGR.Cells(0).Value.ToString() + "))
                                    ORDER BY AutaNajam.DatumVracanja DESC"
            Dim dadapter As OleDbDataAdapter
            dadapter = New OleDbDataAdapter()
            dadapter.SelectCommand = New OleDbCommand(strSql, conn)
            Dim dset As DataSet = New DataSet()
            dadapter.Fill(dset, "DodatnaOpremaNajam")
            If dset.Tables("DodatnaOpremaNajam").Rows.Count > 0 Then
                DataGridView2.DataSource = dset.Tables(0)
                'MessageBox.Show(dset.Tables.Count) 'Count
                'MessageBox.Show(dset.Tables("Auta").Rows(0)("Marka")) 'get ime
            End If

        Catch ex As Exception
        End Try
    End Sub
End Class