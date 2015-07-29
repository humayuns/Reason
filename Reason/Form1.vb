Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDrawForm_Click(sender As Object, e As EventArgs) Handles btnDrawForm.Click
        DrawForm.Show()
    End Sub

    Private Sub btnChart_Click(sender As Object, e As EventArgs) Handles btnChart.Click
        ChartForm.Show()
    End Sub

    Private Sub btnOpenGL_Click(sender As Object, e As EventArgs) Handles btnOpenGL.Click
        OpenGLForm.Show()
    End Sub

    Private Sub btnDirectX_Click(sender As Object, e As EventArgs) Handles btnDirectX.Click
        DirectXForm.Show()
    End Sub

    Private Sub btnPlot2D_Click(sender As Object, e As EventArgs) Handles btnPlot2D.Click
        Plot2DForm.Show()
    End Sub

    Private Sub btnPlot3D_Click(sender As Object, e As EventArgs) Handles btnPlot3D.Click
        Plot3DForm.Show()
    End Sub
End Class
