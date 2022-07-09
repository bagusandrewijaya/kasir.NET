Public Class LOGIN


    Private Sub LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub clik_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clik_login.Click
        open_con()
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("DATA TIDAK BOLEH KOSONG")
        Else
            rec.Open("call loginAdmin('" & TextBox1.Text & "','" & TextBox2.Text & "')", conn, 3, 2)
        End If
        If rec.EOF = False Then
            Me.Hide()
            cls()
            header.Show()


        Else
            MsgBox("USERNAME ATAU PASSWORD SALAH HUBUNGI TEKNISI", MsgBoxStyle.OkOnly)
            cls()
        End If

    End Sub
End Class
