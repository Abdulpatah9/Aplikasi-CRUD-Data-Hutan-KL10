Imports System.Data.Odbc
Public Class Login
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

    Sub Terbuka() 'Menentukan strip menu yang ditampilkan ketika telah login
        HalamanUtama.LoginToolStripMenuItem.Visible = False
        HalamanUtama.LogoutToolStripMenuItem.Visible = True
        HalamanUtama.MasterToolStripMenuItem.Visible = True
        HalamanUtama.TransaksiToolStripMenuItem.Visible = True
        HalamanUtama.LaporanToolStripMenuItem.Visible = True
        HalamanUtama.UtilityToolStripMenuItem.Visible = True
    End Sub

    'Tutup aplikasi
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    'Logic untuk pengecekan dan cek data ke db ketika melakukan login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Username dan Password Tidak Boleh Kosong")
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("select * from user where username='" & TextBox1.Text & "' and
                                    userpwd='" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then

                'If TextBox1.Text = "AA" And TextBox2.Text = "11" Then
                Me.Close()
                MsgBox("Anda Berhasil Login")
                Call Terbuka()
            Else
                MsgBox("Username atau Password Salah")
            End If
        End If
    End Sub

    'Membuat charakter password tidak terlihat dan diganti dengan karakter *
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"
    End Sub

    'Membuat pilihan show password pada tampilan login
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox1.PasswordChar = "*"
        End If
    End Sub
End Class