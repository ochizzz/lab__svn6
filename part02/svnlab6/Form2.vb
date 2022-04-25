Public Class Form2
    Dim fn As Decimal
    Dim sn As Decimal
    Dim oper As Integer
    Dim operator_selector As Boolean = False
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text += "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text += "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text += "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text += "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text += "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text += "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text += "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text += "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text += "9"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Not (TextBox1.Text.Contains(",")) Then
            TextBox1.Text += ","
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        fn = TextBox1.Text
        TextBox1.Text = ""
        operator_selector = True
        oper = 1 '=-
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        fn = TextBox1.Text
        TextBox1.Text = ""
        operator_selector = True
        oper = 2 '=+
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        fn = TextBox1.Text
        TextBox1.Text = ""
        operator_selector = True
        oper = 3 '=*
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        fn = TextBox1.Text
        TextBox1.Text = ""
        operator_selector = True
        oper = 4 '=/
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If operator_selector = True Then
            sn = TextBox1.Text
            If oper = 1 Then
                TextBox1.Text = fn - sn
            ElseIf oper = 2 Then
                TextBox1.Text = fn + sn
            ElseIf oper = 3 Then
                TextBox1.Text = fn * sn
            ElseIf oper = 4 Then
                If sn = 0 Then
                    TextBox1.Text = "На ноль делить нельзя!"
                Else
                    TextBox1.Text = fn / sn
                End If
            ElseIf oper = 5 Then
                TextBox1.Text = fn Mod sn
            ElseIf oper = 6 Then
                TextBox1.Text = Math.Pow(fn, sn)
            End If
            operator_selector = False
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        fn = TextBox1.Text
        TextBox1.Text = -fn
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        fn = TextBox1.Text
        If fn < 0 Then
            TextBox1.Text = "Отрицательное число!"
        Else
            TextBox1.Text = Math.Sqrt(fn)
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        fn = TextBox1.Text
        TextBox1.Text = ""
        operator_selector = True
        oper = 5 'Mod

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        fn = TextBox1.Text
        TextBox1.Text = Math.Pow(fn, 2)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        fn = TextBox1.Text
        TextBox1.Text = ""
        operator_selector = True
        oper = 6 'x^y
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        fn = TextBox1.Text
        fn = (fn * Math.PI) / 180
        TextBox1.Text = Math.Sin(fn)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        fn = TextBox1.Text
        fn = (fn * Math.PI) / 180
        TextBox1.Text = Math.Cos(fn)
    End Sub
End Class