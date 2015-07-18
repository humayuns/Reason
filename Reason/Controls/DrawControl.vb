Public Class DrawControl


    Dim x1 As Integer = 0
    Dim y1 As Integer = 0
    Private Sub DrawControl_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then

            Dim g = Me.CreateGraphics()


            'g.DrawPie(Pens.AliceBlue, New Rectangle(x1, y1, e.X, e.Y), 0, 360)

            If x1 = 0 And y1 = 0 Then
                x1 = e.X
                y1 = e.Y
            End If

            g.DrawLine(Pens.Black, x1, y1, e.X, e.Y)

            x1 = e.X
            y1 = e.Y

        End If
    End Sub
End Class
