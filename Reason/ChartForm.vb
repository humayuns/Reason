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
        s.Points.AddXY("1990", 27)
        s.Points.AddXY("1991", 15)
        s.Points.AddXY("1992", 17)
        'Add the series to the Chart1 control.
        Chart1.Series.Add(s)
    End Sub
End Class