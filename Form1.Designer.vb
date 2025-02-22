<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBoxNama = New TextBox()
        TextBoxLokasi = New TextBox()
        TextBoxJml = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label5 = New Label()
        TextBox1 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 263)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(776, 175)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Location = New Point(11, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 25)
        Label1.TabIndex = 1
        Label1.Text = "Nama Hutan"
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Location = New Point(10, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 25)
        Label2.TabIndex = 2
        Label2.Text = "Lokasi Hutan"
        ' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Location = New Point(12, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(180, 25)
        Label3.TabIndex = 3
        Label3.Text = "Jumlah Flora"
        ' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Location = New Point(12, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(180, 25)
        Label4.TabIndex = 4
        Label4.Text = "Tanggal Pencatatan"
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Location = New Point(221, 38)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(482, 27)
        TextBoxNama.TabIndex = 1
        ' 
        ' TextBoxLokasi
        ' 
        TextBoxLokasi.Location = New Point(221, 72)
        TextBoxLokasi.Name = "TextBoxLokasi"
        TextBoxLokasi.Size = New Size(482, 27)
        TextBoxLokasi.TabIndex = 2
        ' 
        ' TextBoxJml
        ' 
        TextBoxJml.Location = New Point(221, 110)
        TextBoxJml.Name = "TextBoxJml"
        TextBoxJml.Size = New Size(217, 27)
        TextBoxJml.TabIndex = 3
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(221, 151)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(221, 207)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 5
        Button1.Text = "INPUT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(344, 207)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(472, 207)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 7
        Button3.Text = "HAPUS"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(593, 207)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 8
        Button4.Text = "TUTUP"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Location = New Point(11, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(181, 25)
        Label5.TabIndex = 9
        Label5.Text = "Id Hutan"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(221, 7)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(140, 27)
        TextBox1.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBoxJml)
        Controls.Add(TextBoxLokasi)
        Controls.Add(TextBoxNama)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CRUD"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxLokasi As TextBox
    Friend WithEvents TextBoxJml As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox

End Class
