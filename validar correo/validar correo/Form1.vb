Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsControl(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "@" Or e.KeyChar = "-" Or e.KeyChar = "_" Or (e.KeyChar >= "A" And (e.KeyChar <= "Z") Or (e.KeyChar >= "a") And (e.KeyChar <= "z")) Then

            e.Handled = False
        Else
            e.Handled = True
        End If

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsNumber(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "@" Or e.KeyChar = "-" Or e.KeyChar = "_" Or (e.KeyChar >= "A" And (e.KeyChar <= "Z") Or (e.KeyChar >= "a") And (e.KeyChar <= "z")) Then

        End If

        Exit Sub

    End Sub

    Private Sub TextBox1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Validated
        If TextBox1.Text.Length < 1 Then
            MsgBox("ingrese correo")
            Exit Sub
        End If

        Dim primera As Char = TextBox1.Text.Substring(0, 1)
        Dim ultima As Char = TextBox1.Text.Substring(TextBox1.Text.Length - 1, 1)
        If primera = "@" Or primera = "." Then

        End If
    End Sub
End Class
