Module koneksi
    Public conn As New ADODB.Connection
    Public rec As New ADODB.Recordset
    Public Sub open_con()
        conn.Open("DSN=alfaproto")
    End Sub
    Public Sub cls()
        conn.Close()
    End Sub
End Module

