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
        Me.components = New System.ComponentModel.Container
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblcurtime = New System.Windows.Forms.Label
        Me.lblalarm = New System.Windows.Forms.Label
        Me.btnsetalarm = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblstatus = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(114, 89)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 47)
        Me.TextBox1.TabIndex = 15
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(147, 52)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(174, 29)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Alarm Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Current Time:"
        '
        'lblcurtime
        '
        Me.lblcurtime.AutoSize = True
        Me.lblcurtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurtime.Location = New System.Drawing.Point(160, 9)
        Me.lblcurtime.Name = "lblcurtime"
        Me.lblcurtime.Size = New System.Drawing.Size(77, 25)
        Me.lblcurtime.TabIndex = 11
        Me.lblcurtime.Text = "Label1"
        '
        'lblalarm
        '
        Me.lblalarm.AutoSize = True
        Me.lblalarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalarm.Location = New System.Drawing.Point(12, 89)
        Me.lblalarm.Name = "lblalarm"
        Me.lblalarm.Size = New System.Drawing.Size(106, 25)
        Me.lblalarm.TabIndex = 10
        Me.lblalarm.Text = "Message:"
        '
        'btnsetalarm
        '
        Me.btnsetalarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsetalarm.ForeColor = System.Drawing.Color.Red
        Me.btnsetalarm.Location = New System.Drawing.Point(201, 142)
        Me.btnsetalarm.Name = "btnsetalarm"
        Me.btnsetalarm.Size = New System.Drawing.Size(120, 40)
        Me.btnsetalarm.TabIndex = 9
        Me.btnsetalarm.Text = "Set Alarm"
        Me.btnsetalarm.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.ForeColor = System.Drawing.Color.Red
        Me.lblstatus.Location = New System.Drawing.Point(12, 170)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(120, 13)
        Me.lblstatus.TabIndex = 16
        Me.lblstatus.Text = "Status: Alarm is not set!."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 192)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblcurtime)
        Me.Controls.Add(Me.lblalarm)
        Me.Controls.Add(Me.btnsetalarm)
        Me.Name = "Form1"
        Me.Text = "Alarm Clock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblcurtime As System.Windows.Forms.Label
    Friend WithEvents lblalarm As System.Windows.Forms.Label
    Friend WithEvents btnsetalarm As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblstatus As System.Windows.Forms.Label

End Class
