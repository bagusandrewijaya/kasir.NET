Imports System.Globalization
Public Class kasir

    Public Sub tampil_data()
        Dim no As Integer
        Dim total As Integer
        Dim jumlah As Integer

        Me.DataGridView1.Rows.Clear()
        open_con()
        rec.Open("call get_data('" & kode_struk.Text & "')", conn, 3, 2)
        no = 1
        total = 0
        Do While Not rec.EOF

            Me.DataGridView1.Rows.Add(no, rec.Fields("nama_produk").Value, FormatCurrency(rec.Fields("harga").Value), rec.Fields("jumlah_beli").Value, FormatCurrency(rec.Fields("harga").Value * rec.Fields("jumlah_beli").Value), rec.Fields("id_transaksi").Value)

            no = no + 1
            jumlah = rec.Fields("harga").Value * rec.Fields("jumlah_beli").Value
            total = total + jumlah
            rec.MoveNext()
        Loop
        cls()

        total_harga.Text = FormatCurrency(total)
    End Sub
    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        open_con()
        rec.Open("call genereate_Strk()", conn, 3, 2)
        If Not rec.EOF Then
            Me.kode_struk.Text = "INV-" & rec.Fields("struk").Value
        End If
        cls()


        tampil_data()
    End Sub

    Public Sub kasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DataGridView1.Width = Me.Width
        Me.DataGridView1.Height = Me.Height
        Me.total_harga.Enabled = False
        Dim judul() As String = {"No", "Masukan kode barang", "Harga", "(masukan jumlah beli) Jumlah Beli", "Jumlah Bayar", "ID"}
        Dim lebar() As String = {50, 250, 500, 250, 170, 250}
        Dim i As Integer
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ColumnCount = 6
        DataGridView1.RowCount = 1
        DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 11)

        For i = 0 To DataGridView1.ColumnCount - 1
            DataGridView1.Columns(i).HeaderText = judul(i)
            DataGridView1.Columns(i).Width = lebar(i)
            DataGridView1.Columns(i).DefaultCellStyle.Font = New Font("Arial", 9)
            DataGridView1.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
        Next
        tampil_data()
    End Sub

    Public Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim iCol = DataGridView1.CurrentCell.ColumnIndex
        Dim iRow = DataGridView1.CurrentCell.RowIndex
        If iCol = DataGridView1.Columns.Count - 1 Then
            If iRow < DataGridView1.Rows.Count - 1 Then
                DataGridView1.CurrentCell = DataGridView1(0, iRow + 1)
            End If
        Else
            If iRow < DataGridView1.Rows.Count - 1 Then


                If kode_struk.Text <> "" And DataGridView1.Rows(e.RowIndex).Cells(1).Value <> "" And DataGridView1.Rows(e.RowIndex).Cells(3).Value <> 0 Then
                    open_con()
                    conn.Execute("call insert_trxheader('" & Convert.ToString(kode_struk.Text) & "','" & DataGridView1.Rows(e.RowIndex).Cells(1).Value & "','" & DataGridView1.Rows(e.RowIndex).Cells(3).Value & "')")
                    cls()

                    Dim result As DialogResult = MessageBox.Show("Apakah mau disimpan?", "Informasi", MessageBoxButtons.YesNo)

                    If (result = DialogResult.Yes) Then
                        tampil_data()
                    End If
                End If


            End If

        End If
    End Sub


    Public Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        pembayaran.tstruk.Text = kode_struk.Text
        pembayaran.t_total.Text = total_harga.Text
        Me.Hide()

        pembayaran.ShowDialog()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Controls.Clear() 'menghapus semua controll
        InitializeComponent() 'mengembalikan kembali semua komponen controls
        kasir_Load(e, e)
        Refresh()

    End Sub
End Class