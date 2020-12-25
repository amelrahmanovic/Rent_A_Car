Imports System.Data.OleDb

Public Class Korisnici
    Private KorisnikId As Int32
    Private Function CreateConnection() As OleDb.OleDbConnection
        Dim con As New MyOleDbConnection()
        Return New OleDb.OleDbConnection(con.connection)
    End Function
    Private Sub Korisnici_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKorisnici()
        LoadDodatnaOpremaToComboBox()
        LoadVozilaToComboBox()
    End Sub

    Private Sub LoadVozilaToComboBox()
        Try
            Dim conn As OleDb.OleDbConnection = CreateConnection()
            Dim strSql As String = "SELECT * FROM Auta"
            Dim dadapter As OleDbDataAdapter
            dadapter = New OleDbDataAdapter()
            dadapter.SelectCommand = New OleDbCommand(strSql, conn)
            Dim dset As DataSet = New DataSet()
            dadapter.Fill(dset, "Auta")
            If dset.Tables("Auta").Rows.Count > 0 Then
                ComboBoxVozila.DataSource = dset.Tables(0)
                ComboBoxVozila.DisplayMember = "Model"
                ComboBoxVozila.ValueMember = "AutoId"
                'MessageBox.Show(dset.Tables.Count) 'Count
                'MessageBox.Show(dset.Tables("Auta").Rows(0)("Marka")) 'get ime
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoadDodatnaOpremaToComboBox()
        Try
            Dim conn As OleDb.OleDbConnection = CreateConnection()
            Dim strSql As String = "SELECT * FROM DodatnaOprema"
            Dim dadapter As OleDbDataAdapter
            dadapter = New OleDbDataAdapter()
            dadapter.SelectCommand = New OleDbCommand(strSql, conn)
            Dim dset As DataSet = New DataSet()
            dadapter.Fill(dset, "DodatnaOprema")
            If dset.Tables("DodatnaOprema").Rows.Count > 0 Then
                ComboBox1.DataSource = dset.Tables(0)
                ComboBox1.DisplayMember = "Naziv"
                ComboBox1.ValueMember = "DodatnaOpremaId"
                'MessageBox.Show(dset.Tables.Count) 'Count
                'MessageBox.Show(dset.Tables("Auta").Rows(0)("Marka")) 'get ime
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoadKorisnici()
        Try
            Dim conn As OleDb.OleDbConnection = CreateConnection()
            Dim strSql As String = "SELECT * FROM Korisnici"
            Dim dadapter As OleDbDataAdapter
            dadapter = New OleDbDataAdapter()
            dadapter.SelectCommand = New OleDbCommand(strSql, conn)
            Dim dset As DataSet = New DataSet()
            dadapter.Fill(dset, "Korisnici")
            If dset.Tables("Korisnici").Rows.Count > 0 Then
                DataGridView1.DataSource = dset.Tables(0)
                'MessageBox.Show(dset.Tables.Count) 'Count
                'MessageBox.Show(dset.Tables("Auta").Rows(0)("Marka")) 'get ime

                DataGridView2.Rows.Clear()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim selectedGR As DataGridViewRow
            selectedGR = DataGridView1.Rows(e.RowIndex)
            'MessageBox.Show(selectedGR.Cells(0).Value)
            KorisnikId = selectedGR.Cells(0).Value
            LoadGridViewHistorijaRentiranja()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub LoadGridViewHistorijaRentiranja()
        Try
            Dim conn As OleDb.OleDbConnection = CreateConnection()
            Dim strSql As String = "SELECT AutaNajam.ID, AutaNajam.MjestoPreuzimanja, AutaNajam.DatumPreuzimanja, AutaNajam.DatumVracanja, AutaNajam.MjestoVracanjaVozila, Auta.Marka, Auta.Model, Auta.Cijena
                                    FROM Auta INNER JOIN AutaNajam ON Auta.AutoId = AutaNajam.Vozilo
                                    WHERE (((AutaNajam.[Korisnik])=" + KorisnikId.ToString() + "))"
            Dim dadapter As OleDbDataAdapter
            dadapter = New OleDbDataAdapter()
            dadapter.SelectCommand = New OleDbCommand(strSql, conn)
            Dim dset As DataSet = New DataSet()
            dadapter.Fill(dset, "AutaNajam")
            If dset.Tables("AutaNajam").Rows.Count > 0 Then
                DataGridView2.DataSource = dset.Tables(0)
                'MessageBox.Show(dset.Tables.Count) 'Count
                'MessageBox.Show(dset.Tables("Auta").Rows(0)("Marka")) 'get ime
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim conn As OleDb.OleDbConnection = CreateConnection()
            conn.Open()
            Dim strSql As String = "INSERT INTO Korisnici ( Ime, Prezime, Adresa, KontaktBroj, JMBG )
                                    VALUES('" + TextBoxIme.Text + "','" + TextBoxPrezime.Text + "','" + TextBoxAdresa.Text + "','" + TextBoxKontaktBroj.Text + "','" + TextBoxJMBG.Text + "')"
            Dim dadapter As OleDbDataAdapter
            dadapter = New OleDbDataAdapter()
            'dadapter.SelectCommand = New OleDbCommand(strSql, conn)
            dadapter.InsertCommand = New OleDbCommand(strSql, conn)
            dadapter.InsertCommand.ExecuteNonQuery()
            conn.Close()

            TextBoxIme.Text = ""
            TextBoxPrezime.Text = ""
            TextBoxAdresa.Text = ""
            TextBoxKontaktBroj.Text = ""
            TextBoxJMBG.Text = ""
            TextBoxJMBG.Text = ""

            LoadKorisnici()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
                'MessageBox.Show(row.Cells(0).Value.ToString)
                LabelAutoNajamID.Text = row.Cells(0).Value.ToString()

                Dim conn As OleDb.OleDbConnection = CreateConnection()
                Dim strSql As String = "SELECT DodatnaOprema.Naziv, DodatnaOprema.Cijena
                                        FROM DodatnaOprema 
                                            INNER JOIN DodatnaOpremaNajam ON DodatnaOprema.DodatnaOpremaId = DodatnaOpremaNajam.DodatnaOprema
                                        WHERE DodatnaOpremaNajam.AutoNajam = " + row.Cells(0).Value.ToString() + ";"
                Dim dadapter As OleDbDataAdapter
                dadapter = New OleDbDataAdapter()
                dadapter.SelectCommand = New OleDbCommand(strSql, conn)
                Dim dset As DataSet = New DataSet()
                dadapter.Fill(dset, "DodatnaOpremaNajam")
                If dset.Tables("DodatnaOpremaNajam").Rows.Count > 0 Then
                    DataGridView3.DataSource = dset.Tables(0)
                    'MessageBox.Show(dset.Tables.Count) 'Count
                    'MessageBox.Show(dset.Tables("Auta").Rows(0)("Marka")) 'get ime
                End If
                If dset.Tables("DodatnaOpremaNajam").Rows.Count Like 0 Then
                    DataGridView3.DataSource = New DataSet()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonNovaDodatnaOprema_Click(sender As Object, e As EventArgs) Handles ButtonNovaDodatnaOprema.Click
        'MessageBox.Show(ComboBox1.SelectedValue.ToString())
        Try
            Dim conn As OleDb.OleDbConnection = CreateConnection()
            conn.Open()
            Dim strSql As String = "INSERT INTO DodatnaOpremaNajam ( AutoNajam, DodatnaOprema )
                                    VALUES(" + LabelAutoNajamID.Text.ToString() + "," + ComboBox1.SelectedValue.ToString() + ")"
            Dim dadapter As OleDbDataAdapter
            dadapter = New OleDbDataAdapter()
            dadapter.InsertCommand = New OleDbCommand(strSql, conn)
            dadapter.InsertCommand.ExecuteNonQuery()



            strSql = "SELECT DodatnaOprema.Naziv, DodatnaOprema.Cijena
                                        FROM DodatnaOprema 
                                            INNER JOIN DodatnaOpremaNajam ON DodatnaOprema.DodatnaOpremaId = DodatnaOpremaNajam.DodatnaOprema
                                        WHERE DodatnaOpremaNajam.AutoNajam = " + LabelAutoNajamID.Text.ToString() + ";"
            dadapter = New OleDbDataAdapter()
            dadapter.SelectCommand = New OleDbCommand(strSql, conn)
            Dim dset As DataSet = New DataSet()
            dadapter.Fill(dset, "DodatnaOpremaNajam")
            If dset.Tables("DodatnaOpremaNajam").Rows.Count > 0 Then
                DataGridView3.DataSource = dset.Tables(0)
                'MessageBox.Show(dset.Tables.Count) 'Count
                'MessageBox.Show(dset.Tables("Auta").Rows(0)("Marka")) 'get ime
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonNovoRentiranjeAuta.Click
        Try
            Dim conn As OleDb.OleDbConnection = CreateConnection()
            conn.Open()
            Dim strSql As String = "INSERT INTO AutaNajam ( MjestoPreuzimanja, DatumPreuzimanja, DatumVracanja, MjestoVracanjaVozila, Vozilo, Korisnik )
                                    VALUES('" + TextBoxMjestoPreuzimanja.Text + "'," + DateTime.Parse(TextBoxDatumPreuzimanja.Text.ToString()) + "," + DateTime.Parse(TextBoxDatumVracanja.Text) + ",'" + TextBoxMjestoVracanja.Text + "'," + ComboBox1.SelectedValue.ToString() + "," + KorisnikId.ToString() + ")"
            Dim dadapter As OleDbDataAdapter
            dadapter = New OleDbDataAdapter()
            dadapter.InsertCommand = New OleDbCommand(strSql, conn)
            dadapter.InsertCommand.ExecuteNonQuery()
            conn.Close()

            LoadGridViewHistorijaRentiranja()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class