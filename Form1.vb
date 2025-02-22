Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    'deklarasi variabel dari odbc
    Dim Conn As OdbcConnection
    Dim Cmd As OdbcCommand
    Dim Ds As DataSet
    Dim Da As OdbcDataAdapter
    Dim Rd As OdbcDataReader
    Dim MyDB As String
    'Membuat Koneksi
    Sub Koneksi()
        ' Memanggil database yaitu nama database kita adalah users_table
        MyDB = "Driver={MySQL ODBC 9.2 ANSI Driver};Database=users_table;Server=localhost;Port=3307;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()

    End Sub

    Sub KondisiAwal()
        ' Textbox1, textbox2, textbox3, textbox4 kita kosongkan pertama kali
        TextBoxNama.Text = ""
        TextBoxLokasi.Text = ""
        TextBoxJml.Text = ""

        TextBox1.Enabled = False
        TextBoxNama.Enabled = False
        TextBoxLokasi.Enabled = False
        TextBoxJml.Enabled = False
        DateTimePicker1.Enabled = False

        ' Button1, Button2, Button3, Button4 kita tambahkan text masing - masing yaitu input, edit, hapus, tutup
        Button1.Text = "INPUT"
        Button2.Text = "EDIT"
        Button3.Text = "HAPUS"
        Button4.Text = "TUTUP"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

        Call Koneksi()
        Da = New OdbcDataAdapter("Select * from hutan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "hutan")
        DataGridView1.DataSource = Ds.Tables("hutan")
    End Sub

    Sub fieldAktifInput()
        TextBoxNama.Enabled = True
        TextBoxLokasi.Enabled = True
        TextBoxJml.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub

    Sub fieldAktifAll()
        TextBox1.Enabled = True
        TextBoxNama.Enabled = True
        TextBoxLokasi.Enabled = True
        TextBoxJml.Enabled = True
        DateTimePicker1.Enabled = True
        TextBox1.Focus()
    End Sub

    Sub fieldAktifHapus()
        TextBox1.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            Call fieldAktifInput()

        Else
            If TextBoxNama.Text = "" Or
            TextBoxLokasi.Text = "" Or
            TextBoxJml.Text = "" Then
                MsgBox("Pastikan semua kolom terisi")
            Else
                Call Koneksi()
                Dim formatTgl = Format(DateTimePicker1.Value, "yyyy-MM-dd")
                Dim InputData As String = "Insert into hutan (nama_hutan,lokasi_hutan,jml_flora,tgl_pencatatan) 
                values('" & TextBoxNama.Text & "','" & TextBoxLokasi.Text & "','" & TextBoxJml.Text & "','" & formatTgl & "')"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                Call KondisiAwal()

            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "EDIT" Then
            Button2.Text = "SIMPAN"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            Call fieldAktifAll()

        Else

            If TextBoxNama.Text = "" Or
            TextBoxLokasi.Text = "" Or
            TextBoxJml.Text = "" Then
                MsgBox("Pastikan semua kolom terisi")
            Else
                Call Koneksi()
                Dim formatTgl = Format(DateTimePicker1.Value, "yyyy-MM-dd")
                Dim EditData As String = "Update hutan set 
                                       nama_hutan = '" & TextBoxNama.Text & "',
                                       lokasi_hutan = '" & TextBoxLokasi.Text & "',
                                       jml_flora = '" & TextBoxJml.Text & "',
                                       tgl_pencatatan = '" & formatTgl & "'
                                        where id_hutan='" & TextBox1.Text & "'"

                Cmd = New OdbcCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Edit Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "TUTUP" Then
            End
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "HAPUS" Then
            Button3.Text = "YA"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "BATAL"
            Call fieldAktifHapus()

        Else
            If TextBox1.Text = "" Then
                MsgBox("Pastikan semua kolom terisi")
            Else
                Call Koneksi()
                Dim formatTgl = Format(DateTimePicker1.Value, "yyyy-MM-dd")
                Dim EditData As String = "delete from hutan 
                                        where id_hutan='" & TextBox1.Text & "'"

                Cmd = New OdbcCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub
End Class