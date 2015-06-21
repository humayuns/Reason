<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DrawForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DrawControl1 = New Reason.DrawControl()
        Me.SuspendLayout()
        '
        'DrawControl1
        '
        Me.DrawControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DrawControl1.Location = New System.Drawing.Point(12, 12)
        Me.DrawControl1.Name = "DrawControl1"
        Me.DrawControl1.Size = New System.Drawing.Size(392, 302)
        Me.DrawControl1.TabIndex = 0
        '
        'DrawForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 330)
        Me.Controls.Add(Me.DrawControl1)
        Me.Name = "DrawForm"
        Me.Text = "DrawForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DrawControl1 As Reason.DrawControl
End Class
