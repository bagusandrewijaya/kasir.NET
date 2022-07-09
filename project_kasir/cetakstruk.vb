Public Class cetakstruk

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Barang Sukse di tambah", "SUKSES", MessageBoxButtons.OK)
        If result = DialogResult.OK Then
            kasir.Show()
            kasir.Refresh()
            Me.Hide()
            MsgBox("refresh Halaman Kasir Sebelum membuat transaksi baru")
        End If
    End Sub
End Class