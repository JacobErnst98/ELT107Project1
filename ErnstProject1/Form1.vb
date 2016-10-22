Public Class Form1
    'define C and F as Decimal values
    Dim C, F As Decimal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Take the valuse form textbox 1 and convert it to Celsius
        C = Val(TextBox1.Text)
        F = C * 9 / 5 + 32
        'Write the new value to textbox 2 with one decimal
        TextBox2.Text = FormatNumber(F, 1)
        'Make the button pressed disappear
        Button1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Take the valuse form textbox 2 and convert it to Celsius
        F = Val(TextBox2.Text)
        C = (F - 32) * (5 / 9)
        'Write the new value to textbox 1 with one decimal
        TextBox1.Text = FormatNumber(C, 1)
        'Make the button pressed disappear
        Button2.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Make the buttons re-appear
        Button1.Visible = True
        Button2.Visible = True
        'Clear both the   textbox
        TextBox2.Text = ""
        TextBox1.Text = ""
    End Sub

End Class
