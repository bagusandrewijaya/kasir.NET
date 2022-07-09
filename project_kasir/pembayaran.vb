Public Class pembayaran
    Private Sub pembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_con()
        rec.Open("call tampil_payment ", conn, 3, 2)
        Do While Not rec.EOF

            ComboBox1.Items.Add(rec.Fields("payment").Value)
            rec.MoveNext()
        Loop

        conn.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim total_belanja As Integer = t_total.Text
        Dim pembayaran As Integer = membayar.Text
        open_con()
        rec.Open("call selesaikan_trx('" & tstruk.Text & "','" & total_belanja & "','" & pembayaran & "','" & ComboBox1.Text & "')", conn, 3, 2)
        cls()

        Dim result As DialogResult = MessageBox.Show("Apakah mau disimpan?", "Informasi", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            cetakstruk.struk1.SetParameterValue("kode_struk", tstruk.Text)
            cetakstruk.Show()
            Me.Hide()
        End If

    End Sub

 
End Class