Imports System.Data.OleDb

Public Class Auta
    Private Function CreateConnection() As OleDb.OleDbConnection
        Dim con As New MyOleDbConnection()
        Return New OleDb.OleDbConnection(con.connection)
    End Function
    Private Sub Auta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAutaToGridView1()
    End Sub

    Private Sub LoadAutaToGridView1()
        Try
            Dim conn As OleDb.OleDbConnection = CreateConnection()
            Dim strSql As String = "SELECT * FROM Auta"
            Dim dadapter As OleDbDataAdapter
            dadapter = New OleDbDataAdapter()
            dadapter.SelectCommand = New OleDbCommand(strSql, conn)
            Dim dset As DataSet = New DataSet()
            dadapter.Fill(dset, "Auta")
            If dset.Tables("Auta").Rows.Count > 0 Then
                DataGridView1.DataSource = dset.Tables(0)
                'MessageBox.Show(dset.Tables.Count) 'Count
                'MessageBox.Show(dset.Tables("Auta").Rows(0)("Marka")) 'get ime
            End If
            DataGridView2.DataSource = New DataTable()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim selectedGR As DataGridViewRow
            selectedGR = DataGridView1.Rows(e.RowIndex)
            'MessageBox.Show(selectedGR.Cells(0).Value)

            Dim conn As OleDb.OleDbConnection = CreateConnection()
            Dim strSql As String = "SELECT AutaNajam.DatumPreuzimanja, AutaNajam.MjestoPreuzimanja, AutaNajam.DatumVracanja, AutaNajam.MjestoVracanjaVozila
                                    FROM AutaNajam
                                    WHERE (((AutaNajam.[Vozilo])=" + selectedGR.Cells(0).Value.ToString() + "))
                                    ORDER BY AutaNajam.DatumVracanja DESC"
            Dim dadapter As OleDbDataAdapter
            dadapter = New OleDbDataAdapter()
            dadapter.SelectCommand = New OleDbCommand(strSql, conn)
            Dim dset As DataSet = New DataSet()
            dadapter.Fill(dset, "Auta")
            If dset.Tables("Auta").Rows.Count > 0 Then
                DataGridView2.DataSource = dset.Tables(0)
                'MessageBox.Show(dset.Tables.Count) 'Count
                'MessageBox.Show(dset.Tables("Auta").Rows(0)("Marka")) 'get ime
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim conn As OleDb.OleDbConnection = CreateConnection()
            conn.Open()
            Dim strSql As String = "INSERT INTO Auta ( Marka, Model, Cijena )
                                    VALUES('" + TextBoxMarka.Text + "','" + TextBoxModel.Text + "'," + TextBoxCijena.Text + ")"
            Dim dadapter As OleDbDataAdapter
            dadapter = New OleDbDataAdapter()
            dadapter.InsertCommand = New OleDbCommand(strSql, conn)
            dadapter.InsertCommand.ExecuteNonQuery()
            conn.Close()

            TextBoxCijena.Text = ""
            TextBoxMarka.Text = ""
            TextBoxModel.Text = ""

            LoadAutaToGridView1()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class