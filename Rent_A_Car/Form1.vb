Imports System.Data.OleDb

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Function CreateConnection() As OleDb.OleDbConnection
        Dim con As New MyOleDbConnection()
        Return New OleDb.OleDbConnection(con.connection)
    End Function

    Private Sub ButtonRegistracija_Click(sender As Object, e As EventArgs) Handles ButtonRegistracija.Click
        Using conn As OleDb.OleDbConnection = CreateConnection()
            Using comd As New OleDb.OleDbCommand("INSERT INTO Admin ([Ime], [Prezime], [Username], [Password]) VALUES (@Firstname, @Lastname, @Username, @Password)", conn)
                comd.Parameters.AddWithValue("@Ime", TextBoxIme.Text)
                comd.Parameters.AddWithValue("@Prezime", TextBoxPrezime.Text)
                comd.Parameters.AddWithValue("@Username", TextBoxUsernameRegister.Text)
                comd.Parameters.AddWithValue("@Password", TextBoxPasswordRegister.Text)
                Try
                    conn.Open()
                    comd.ExecuteNonQuery()
                    LabelPoruka.Text = "Novi korisnik sistema dodan."
                    conn.Close()
                Catch ex As Exception
                    LabelPoruka.Text = ex.ToString()
                End Try
            End Using
        End Using
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Try
            Dim conn As OleDb.OleDbConnection = CreateConnection()
            Dim strSql As String = "SELECT * FROM Admin WHERE Username Like '" + TextBoxUsername.Text + "' And Password Like '" + TextBoxPassword.Text + "'"
            Dim dadapter As OleDbDataAdapter
            dadapter = New OleDbDataAdapter()
            dadapter.SelectCommand = New OleDbCommand(strSql, conn)
            Dim dset As DataSet = New DataSet()
            dadapter.Fill(dset, "Admin")
            If dset.Tables("Admin").Rows.Count > 0 Then
                Me.Hide()
                Home.Show()
                'MessageBox.Show(dset.Tables.Count) 'Count
                'MessageBox.Show(dset.Tables("Admin").Rows(0)("Ime")) 'get ime
            End If
        Catch ex As Exception
            LabelPoruka.Text = ex.ToString()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("
Rent a Car Exclusive je renomirana agencija, pozicionirana u samom vrhu bosansko-hercegovačkog tržišta, koja svoje postojanje zasniva na dugogodišnjem školovanju, iskustvu, znanju i radu menadžmenta i uposlenika. Vodeću poziciju osiguravaju nam znanje, pouzdanost, iskustvo, tradicija, inovativnost i praćenje svjetskih trendova automobilske industrije i ugodnog/sigurnog putovanja. Mi smo stručan i ljubazan, mladi tim ljudi, koji će u svakom trenutku izaći u susret klijentu i učiniti sve da bude zadovoljan nasim uslugama. U prilog ovome govori veliki broj stalnih klijenata, koji nam redovno ukazuju svoje povjerenje birajući vozilo iz naše ponude.

Naš vozni park se sastoji od potpuno novih vozila svih kategorija. Sva vozila su full kasko osigurana, bez učešća u šteti, posjeduju opstu i mobilnu garanciju, svu zakonom propisanu opremu i ne prelaze starosnu dob od 2 godine. U našoj floti na raspolaganju Vam nudimo putničke automobile renomiranih svjetskih proizvođača koji pružaju apsolutni komfor, sigurnost i brzinu, kako u gradskoj, tako i vangradskoj vožnji. Sva vozila su pripremljena za potpuno uživanje: klima A/C, muzika (Bluetooth, USB, MP3 player), alarm, centralna brava sa daljinskom komandom, AIR BAG za vozača i suvozača, električni podizači stakala…
Ukoliko želite najpovoljniju rent a car agenciju u BiH – pozovite nas
Tel/Fax: +387(0) 35 555
ili pošaljite e-mail info@exclusive.ba
Gdje god da odete mi brinemo za vas! Sa nama ste sigurni! I ne samo to. Na raspolaganju smo Vam 24 sata dnevno svih 365 dana u godini, pri čemu Vam garantujemo vrhunsku uslugu i kompletnu tehničku podršku!
Misija:
•	Zadovoljstvo klijenata
•	Ljubaznost osoblja
•	Prihvatljive cijene
•	Dostupnost usluga 24h dnevno
•	Poslovnost bez granica


")
    End Sub
End Class
