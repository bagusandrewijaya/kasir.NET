Public Class header
    Public Sub loadstruk()

        Me.DataGridView1.Rows.Clear()
        conn.Open()
        rec.Open("call tampil_jumlah_Trx()", conn, 3, 2)

        Do While Not rec.EOF
            Me.DataGridView1.Rows.Add(rec.Fields("struk").Value, rec.Fields("payment").Value, FormatCurrency(rec.Fields("total_belanja").Value), FormatCurrency(rec.Fields("pembayaran").Value), FormatCurrency(rec.Fields("kembalian").Value))
            rec.MoveNext()

        Loop
        conn.Close()
    End Sub

    Private Sub header_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim total As Integer

        open_con()
        rec.Open("call total_pemasukan()", conn, 3, 2)
        total = FormatCurrency(rec.Fields("total").Value)
        Label6.Text = FormatCurrency(total)
        cls()
        Dim namaKolom() As String = {"ID STRUK", "PAYMENT METHODE", "TOTAL BELANJA", "PEMBAYARAN", "KEMBALIAN"}
        Dim lebarKolom() As String = {100, 200, 200, 150, 150}
        Dim i As Integer
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ColumnCount = 5
        DataGridView1.RowCount = 1
        DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 11)

        For i = 0 To DataGridView1.ColumnCount - 1
            DataGridView1.Columns(i).HeaderText = namaKolom(i)
            DataGridView1.Columns(i).Width = lebarKolom(i)
            DataGridView1.Columns(i).DefaultCellStyle.Font = New Font("Arial", 11)
            DataGridView1.Columns(i).DefaultCellStyle.BackColor = Color.Orange

        Next
        loadstruk()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gudang.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kasir.Show()
        Me.Hide()

    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim result As DialogResult = MessageBox.Show("APAKAH ANDA INGIN LOGUT", "WARNING", MessageBoxButtons.OK)
        If result = DialogResult.OK Then
            Me.Close()
            LOGIN.Show()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form3.Show()

    End Sub
End Class