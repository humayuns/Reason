﻿Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDrawForm_Click(sender As Object, e As EventArgs) Handles btnDrawForm.Click
        DrawForm.Show()
    End Sub

    Private Sub btnChart_Click(sender As Object, e As EventArgs) Handles btnChart.Click
        ChartForm.Show()
    End Sub
End Class
