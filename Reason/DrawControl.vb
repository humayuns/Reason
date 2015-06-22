Public Class DrawControl


    Dim x1 As Integer
    Dim y1 As Integer
    Private Sub DrawControl_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then

            Dim g = Me.CreateGraphics()

            g.DrawLine(Pens.Black, x1, y1, e.X, e.Y)
            g.DrawPie(Pens.AliceBlue, New Rectangle(x1, y1, e.X, e.Y), 0, 360)

            x1 = e.X
            y1 = e.Y

        End If
    End Sub
End Class
