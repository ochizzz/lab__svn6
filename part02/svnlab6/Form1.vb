Public Class Form1




    Private a, b, c, d As Double
    Private paper As Graphics
    Private mypen As Pen = New Pen(Color.Red)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        paper = PictureBox1.CreateGraphics()
        DrawGraph()
    End Sub
    Private Sub DrawGraph()
        a = CDbl(TextBox1.Text)
        b = CDbl(TextBox2.Text)
        c = CDbl(TextBox3.Text)
        d = CDbl(TextBox4.Text)
        paper.Clear(Color.White)
        Draw()
    End Sub
    Private Sub Draw()
        Dim x, y, nextX, nextY As Double
        Dim xpixel, ypixel, nextXPixeL, nextYPixel, nx, ny, q, w As Integer
        Dim horzFont As New Font("Verdana", 4, FontStyle.Regular)
        Dim horzBrush As New SolidBrush(Color.Blue)
        q = -10
        w = 10
        For xpixel = 0 To PictureBox1.Width
            x = ScaleX(xpixel)
            y = TheFunction(x)
            ypixel = ScaleY(y)
            nextXPixeL = xpixel + 1
            nextX = ScaleX(nextXPixeL)
            nextY = TheFunction(nextX)
            nextYPixel = ScaleY(nextY)
            paper.DrawLine(mypen, xpixel, ypixel, nextXPixeL, nextYPixel)
            paper.DrawLine(mypen, xpixel, 100, nextXPixeL, 100)
            paper.DrawLine(mypen, 100, ypixel, 100, nextYPixel)

        Next
        For xpixel = 0 To PictureBox1.Width Step 10
            x = ScaleX(xpixel)
            y = TheFunction(x)
            ypixel = ScaleY(y)
            nextXPixeL = xpixel + 1
            nx = xpixel + 1
            nextX = ScaleX(nextXPixeL)
            nextY = TheFunction(nextX)
            nextYPixel = ScaleY(nextY)
            paper.DrawString(q, horzFont, horzBrush, nx, 100)
            paper.DrawString(w, horzFont, horzBrush, 100, nx - 1)
            q = q + 1
            w = w - 1
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Function TheFunction(ByVal x As Double) As Double
        Return a * x * x * x + b * x * x + c * x + d
    End Function

    Private Function ScaleX(ByVal xPixel As Integer) As Double
        Dim xStart As Double = -5, xEnd As Double = 5
        Dim xScale As Double = PictureBox1.Width / (xEnd - xStart)
        Return (xPixel - (PictureBox1.Width / 2)) / xScale
    End Function

    Private Function ScaleY(ByVal y As Double) As Integer
        Dim yStart As Double = -5, yEnd As Double = 5
        Dim pixelCoord As Integer
        Dim yScale As Double = PictureBox1.Height / (yEnd - yStart)
        pixelCoord = CInt(-y * yScale) + CInt(PictureBox1.Height / 2)
        Return pixelCoord
    End Function
End Class
