﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDirectX = New System.Windows.Forms.Button()
        Me.btnChart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnOpenGL = New System.Windows.Forms.Button()
        Me.btnDrawForm = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPlot2D = New System.Windows.Forms.Button()
        Me.btnPlot3D = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "the power of the mind to think, understand, and form judgments by a process of lo" &
    "gic."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Reason"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPlot3D)
        Me.GroupBox1.Controls.Add(Me.btnPlot2D)
        Me.GroupBox1.Controls.Add(Me.btnDirectX)
        Me.GroupBox1.Controls.Add(Me.btnChart)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.btnOpenGL)
        Me.GroupBox1.Controls.Add(Me.btnDrawForm)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 329)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "The Stage"
        '
        'btnDirectX
        '
        Me.btnDirectX.Location = New System.Drawing.Point(168, 32)
        Me.btnDirectX.Name = "btnDirectX"
        Me.btnDirectX.Size = New System.Drawing.Size(75, 23)
        Me.btnDirectX.TabIndex = 5
        Me.btnDirectX.Text = "DirectX"
        Me.btnDirectX.UseVisualStyleBackColor = True
        '
        'btnChart
        '
        Me.btnChart.Location = New System.Drawing.Point(6, 61)
        Me.btnChart.Name = "btnChart"
        Me.btnChart.Size = New System.Drawing.Size(75, 23)
        Me.btnChart.TabIndex = 4
        Me.btnChart.Text = "Chart"
        Me.btnChart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(382, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Todo:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Area of Circle", "Slope of Curve", "Area under the Curve", "2D Plot", "3D Plot", "Ability to Save", "Web Connected", "Wolfram Alpha Integration"})
        Me.ListBox1.Location = New System.Drawing.Point(385, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(183, 290)
        Me.ListBox1.TabIndex = 2
        '
        'btnOpenGL
        '
        Me.btnOpenGL.Location = New System.Drawing.Point(87, 32)
        Me.btnOpenGL.Name = "btnOpenGL"
        Me.btnOpenGL.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenGL.TabIndex = 1
        Me.btnOpenGL.Text = "OpenGL"
        Me.btnOpenGL.UseVisualStyleBackColor = True
        '
        'btnDrawForm
        '
        Me.btnDrawForm.Location = New System.Drawing.Point(6, 32)
        Me.btnDrawForm.Name = "btnDrawForm"
        Me.btnDrawForm.Size = New System.Drawing.Size(75, 23)
        Me.btnDrawForm.TabIndex = 0
        Me.btnDrawForm.Text = "DrawForm"
        Me.btnDrawForm.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Reason.My.Resources.Resources.reason1
        Me.PictureBox1.Location = New System.Drawing.Point(551, 347)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 37)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnPlot2D
        '
        Me.btnPlot2D.Location = New System.Drawing.Point(87, 61)
        Me.btnPlot2D.Name = "btnPlot2D"
        Me.btnPlot2D.Size = New System.Drawing.Size(75, 23)
        Me.btnPlot2D.TabIndex = 6
        Me.btnPlot2D.Text = "Plot 2D"
        Me.btnPlot2D.UseVisualStyleBackColor = True
        '
        'btnPlot3D
        '
        Me.btnPlot3D.Location = New System.Drawing.Point(168, 61)
        Me.btnPlot3D.Name = "btnPlot3D"
        Me.btnPlot3D.Size = New System.Drawing.Size(75, 23)
        Me.btnPlot3D.TabIndex = 7
        Me.btnPlot3D.Text = "Plot 3D"
        Me.btnPlot3D.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 393)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Reason"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDrawForm As System.Windows.Forms.Button
    Friend WithEvents btnOpenGL As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnChart As Button
    Friend WithEvents btnDirectX As Button
    Friend WithEvents btnPlot3D As Button
    Friend WithEvents btnPlot2D As Button
End Class
