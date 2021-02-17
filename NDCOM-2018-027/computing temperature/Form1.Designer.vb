<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbls = New System.Windows.Forms.Label()
        Me.lblw = New System.Windows.Forms.Label()
        Me.txtt = New System.Windows.Forms.TextBox()
        Me.txth = New System.Windows.Forms.TextBox()
        Me.txtf = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(116, 227)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "forecast"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter temperature"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter humidity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter factor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "sum"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "weather"
        '
        'lbls
        '
        Me.lbls.AutoSize = True
        Me.lbls.Location = New System.Drawing.Point(83, 150)
        Me.lbls.Name = "lbls"
        Me.lbls.Size = New System.Drawing.Size(39, 13)
        Me.lbls.TabIndex = 7
        Me.lbls.Text = "Label6"
        '
        'lblw
        '
        Me.lblw.AutoSize = True
        Me.lblw.Location = New System.Drawing.Point(83, 197)
        Me.lblw.Name = "lblw"
        Me.lblw.Size = New System.Drawing.Size(39, 13)
        Me.lblw.TabIndex = 8
        Me.lblw.Text = "Label7"
        '
        'txtt
        '
        Me.txtt.Location = New System.Drawing.Point(110, 12)
        Me.txtt.Name = "txtt"
        Me.txtt.Size = New System.Drawing.Size(100, 20)
        Me.txtt.TabIndex = 9
        '
        'txth
        '
        Me.txth.Location = New System.Drawing.Point(92, 43)
        Me.txth.Name = "txth"
        Me.txth.Size = New System.Drawing.Size(100, 20)
        Me.txth.TabIndex = 10
        '
        'txtf
        '
        Me.txtf.Location = New System.Drawing.Point(74, 80)
        Me.txtf.Name = "txtf"
        Me.txtf.Size = New System.Drawing.Size(100, 20)
        Me.txtf.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtf)
        Me.Controls.Add(Me.txth)
        Me.Controls.Add(Me.txtt)
        Me.Controls.Add(Me.lblw)
        Me.Controls.Add(Me.lbls)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbls As System.Windows.Forms.Label
    Friend WithEvents lblw As System.Windows.Forms.Label
    Friend WithEvents txtt As System.Windows.Forms.TextBox
    Friend WithEvents txth As System.Windows.Forms.TextBox
    Friend WithEvents txtf As System.Windows.Forms.TextBox

End Class
