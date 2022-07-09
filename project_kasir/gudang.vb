Public Class gudang
    Public Sub loadProduct()
        Dim no As Integer
        Me.DataGridView1.Rows.Clear()
        conn.Open()
        rec.Open("call tampil_product()", conn, 3, 2)
        no = 1
        Do While Not rec.EOF
            Me.DataGridView1.Rows.Add(no, rec.Fields("id_produk").Value, rec.Fields("nama_produk").Value, rec.Fields("nama_jenis").Value, rec.Fields("stok").Value, FormatCurrency(rec.Fields("harga").Value))
            rec.MoveNext()
            no = no + 1

        Loop
        conn.Close()

    End Sub
    Private Sub gudang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MsgBox("Generate Terlebih Dahulu Kode Barang Sebelum Menambah Barang")
        open_con()
        rec.Open("Select nama_jenis from jenis_produk", conn, 3, 2)
        Do While Not rec.EOF

            ComboBox1.Items.Add(rec.Fields("nama_jenis").Value)
            rec.MoveNext()
        Loop

        conn.Close()
        open_con()
        rec.Open("call tampil_jumlah_produk()", conn, 3, 2)
        label_jumlah.Text = rec.Fields("id_produk").Value
        conn.Close()
        Dim namaKolom() As String = {"No", "Kode Barang", "Nama Produk", "Jenis", "Stok", "harga"}
        Dim lebarKolom() As String = {50, 100, 500, 150, 70, 100}
        Dim i As Integer
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ColumnCount = 6
        DataGridView1.RowCount = 1
        DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 11)

        For i = 0 To DataGridView1.ColumnCount - 1
            DataGridView1.Columns(i).HeaderText = namaKolom(i)
            DataGridView1.Columns(i).Width = lebarKolom(i)
            DataGridView1.Columns(i).DefaultCellStyle.Font = New Font("Arial", 11)
            DataGridView1.Columns(i).DefaultCellStyle.BackColor = Color.Orange

        Next
        loadProduct()



    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        open_con()
        rec.Open("call generate_kd_brg()", conn, 3, 2)
        If Not rec.EOF Then
            Me.kode_barang.Text = "BRG-" & rec.Fields("id_produk").Value
        End If
        conn.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Tambah.Click

        open_con()
        rec.Open("call tambah_product('" & kode_barang.Text & "','" & nama_barang.Text & "','" & ComboBox1.Text & "','" & stok_barang.Text & "','" & harga_barang.Text & "')", conn, 3, 2)
        conn.Close()

        Dim result As DialogResult = MessageBox.Show("Barang Sukse di tambah", "SUKSES", MessageBoxButtons.OK)
        If result = DialogResult.OK Then
            Me.Controls.Clear() 'menghapus semua controll
            InitializeComponent() 'mengembalikan kembali semua komponen controls
            gudang_Load(e, e)
            Refresh()

        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        conn.Open()
        rec.Open("call update_product('" & nama_barang.Text & "','" & ComboBox1.Text & "','" & stok_barang.Text & "','" & harga_barang.Text & "','" & kode_barang.Text & "')", conn, 3, 2)
        conn.Close()
        Dim result As DialogResult = MessageBox.Show("produk berhasil di edit", "SUKSES", MessageBoxButtons.OK)
        If result = DialogResult.OK Then
            Me.Controls.Clear() 'menghapus semua controll
            InitializeComponent() 'mengembalikan kembali semua komponen controls
            gudang_Load(e, e)
            Refresh()

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        conn.Open()

        rec.Open("call add_jenis('" & tambajenis_text.Text & "')", conn, 3, 2)
        conn.Close()
        Dim result As DialogResult = MessageBox.Show("kategori Jenis Ditambah", "SUKSES", MessageBoxButtons.OK)
        If result = DialogResult.OK Then
            Me.Controls.Clear() 'menghapus semua controll
            InitializeComponent() 'mengembalikan kembali semua komponen controls
            gudang_Load(e, e)
            Refresh()

        End If
    End Sub
    'page AUTO REFRES'

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        conn.Open()

        rec.Open("call delete_produk('" & kode_barang.Text & "')", conn, 3, 2)
        conn.Close()
        Dim result As DialogResult = MessageBox.Show("barang di hapus", "SUKSES", MessageBoxButtons.OK)
        If result = DialogResult.OK Then
            Me.Controls.Clear() 'menghapus semua controll
            InitializeComponent() 'mengembalikan kembali semua komponen controls
            gudang_Load(e, e)
            Refresh()

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        open_con()
        rec.Open("call tambah_Stok('" & stok_barang.Text & "','" & kode_barang.Text & "')", conn, 3, 2)
        cls()
        Dim result As DialogResult = MessageBox.Show("stok di update", "SUKSES", MessageBoxButtons.OK)
        If result = DialogResult.OK Then
            Me.Controls.Clear() 'menghapus semua controll
            InitializeComponent() 'mengembalikan kembali semua komponen controls
            gudang_Load(e, e)
            Refresh()

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class