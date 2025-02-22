Public Class HalamanUtama

    Sub Terkunci() 'Menentukan strip menu yang ditampilkan ketika belum login
        LoginToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = False
        MasterToolStripMenuItem.Visible = False
        TransaksiToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = False
        UtilityToolStripMenuItem.Visible = False
    End Sub


    'Melakukan load konten pada HalamanUtama (), disini karena belum login makanya memanggil Terkunci()
    Private Sub HalamanUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub


    'Close aplikasi ketika memilih strip menu "Keluar"
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub


    'Menuju halaman login
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub


    'Menuju aplikasi Crud
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
    End Sub
End Class