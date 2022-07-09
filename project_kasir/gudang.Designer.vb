<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gudang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kode_barang = New System.Windows.Forms.TextBox()
        Me.nama_barang = New System.Windows.Forms.TextBox()
        Me.stok_barang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Tambah = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label_jumlah = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.harga_barang = New System.Windows.Forms.TextBox()
        Me.tambajenis_text = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(104, 295)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1297, 602)
        Me.DataGridView1.TabIndex = 0
        '
        'kode_barang
        '
        Me.kode_barang.Location = New System.Drawing.Point(167, 38)
        Me.kode_barang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.Size = New System.Drawing.Size(103, 22)
        Me.kode_barang.TabIndex = 1
        '
        'nama_barang
        '
        Me.nama_barang.Location = New System.Drawing.Point(167, 119)
        Me.nama_barang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.Size = New System.Drawing.Size(132, 22)
        Me.nama_barang.TabIndex = 2
        '
        'stok_barang
        '
        Me.stok_barang.Location = New System.Drawing.Point(167, 159)
        Me.stok_barang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.stok_barang.Name = "stok_barang"
        Me.stok_barang.Size = New System.Drawing.Size(132, 22)
        Me.stok_barang.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 209)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Harga"
        '
        'btn_Tambah
        '
        Me.btn_Tambah.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_Tambah.Location = New System.Drawing.Point(200, 238)
        Me.btn_Tambah.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Tambah.Name = "btn_Tambah"
        Me.btn_Tambah.Size = New System.Drawing.Size(100, 44)
        Me.btn_Tambah.TabIndex = 6
        Me.btn_Tambah.Text = "Tambah"
        Me.btn_Tambah.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Kode"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(279, 23)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 49)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Generate"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Button3.Location = New System.Drawing.Point(324, 238)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 44)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Crimson
        Me.Button4.Location = New System.Drawing.Point(439, 238)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 44)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(875, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "TOTAL PRODUK"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(167, 80)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(115, 84)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Jenis"
        '
        'label_jumlah
        '
        Me.label_jumlah.AutoSize = True
        Me.label_jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_jumlah.Location = New System.Drawing.Point(1073, 11)
        Me.label_jumlah.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_jumlah.Name = "label_jumlah"
        Me.label_jumlah.Size = New System.Drawing.Size(48, 25)
        Me.label_jumlah.TabIndex = 15
        Me.label_jumlah.Text = "999"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 162)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "stok"
        '
        'harga_barang
        '
        Me.harga_barang.Location = New System.Drawing.Point(167, 206)
        Me.harga_barang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.harga_barang.Name = "harga_barang"
        Me.harga_barang.Size = New System.Drawing.Size(132, 22)
        Me.harga_barang.TabIndex = 17
        '
        'tambajenis_text
        '
        Me.tambajenis_text.Location = New System.Drawing.Point(495, 33)
        Me.tambajenis_text.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tambajenis_text.Name = "tambajenis_text"
        Me.tambajenis_text.Size = New System.Drawing.Size(132, 22)
        Me.tambajenis_text.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(389, 38)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Tambah Jenis"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(636, 22)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 44)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.YellowGreen
        Me.Button5.Location = New System.Drawing.Point(324, 148)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(215, 44)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Tambah Stok"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(92, 47)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(387, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Untuk menambah Stok Cukup Isikan Kode Product Dan Stok"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(957, 84)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 123)
        Me.Panel1.TabIndex = 23
        '
        'gudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1540, 912)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tambajenis_text)
        Me.Controls.Add(Me.harga_barang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.label_jumlah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_Tambah)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.stok_barang)
        Me.Controls.Add(Me.nama_barang)
        Me.Controls.Add(Me.kode_barang)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "gudang"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents kode_barang As System.Windows.Forms.TextBox
    Friend WithEvents nama_barang As System.Windows.Forms.TextBox
    Friend WithEvents stok_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Tambah As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents label_jumlah As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents harga_barang As System.Windows.Forms.TextBox
    Friend WithEvents tambajenis_text As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
