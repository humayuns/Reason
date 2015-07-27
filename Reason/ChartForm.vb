Imports System.Windows.Forms.DataVisualization.Charting

Public Class ChartForm
    Private Sub ChartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Series.Clear()
        Chart1.Titles.Add("Demo")
        'Create a new series and add data points to it.
        Dim s As New Series
        s.Name = "aline"
        'Change to a line graph.
        s.ChartType = SeriesChartType.Line
        s.Points.AddXY(10, 27)
        s.Points.AddXY(20, 15)
        s.Points.AddXY(30, 17)
        'Add the series to the Chart1 control.
        Chart1.Series.Add(s)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click

        Chart1.Series.RemoveAt(0)
        'Create a new series and add data points to it.
        Dim s As New Series
        s.Name = "aline"
        'Change to a line graph.
        s.ChartType = SeriesChartType.Column

        For i = 0 To TextBox1.Text.Split(",").Count - 1
            s.Points.AddXY(10 * i, TextBox1.Text.Split(",")(i))
        Next
        'Add the series to the Chart1 control.
        Chart1.Series.Add(s)
    End Sub
End Class