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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtShowPassword = New System.Windows.Forms.TextBox()
        Me.txtCharacters = New System.Windows.Forms.TextBox()
        Me.txtNumbers = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValidatePass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TimerCreatePass = New System.Windows.Forms.Timer(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.TimerTime = New System.Windows.Forms.Timer(Me.components)
        Me.TimerColor = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.Silver
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.Black
        Me.btnGenerate.Location = New System.Drawing.Point(12, 238)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(388, 60)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Start Generate Password"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'txtShowPassword
        '
        Me.txtShowPassword.BackColor = System.Drawing.Color.White
        Me.txtShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtShowPassword.ForeColor = System.Drawing.Color.Black
        Me.txtShowPassword.Location = New System.Drawing.Point(12, 142)
        Me.txtShowPassword.Name = "txtShowPassword"
        Me.txtShowPassword.ReadOnly = True
        Me.txtShowPassword.Size = New System.Drawing.Size(499, 35)
        Me.txtShowPassword.TabIndex = 1
        Me.txtShowPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCharacters
        '
        Me.txtCharacters.BackColor = System.Drawing.Color.Silver
        Me.txtCharacters.ForeColor = System.Drawing.Color.Black
        Me.txtCharacters.Location = New System.Drawing.Point(12, 62)
        Me.txtCharacters.Name = "txtCharacters"
        Me.txtCharacters.Size = New System.Drawing.Size(500, 20)
        Me.txtCharacters.TabIndex = 2
        Me.txtCharacters.Text = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz01!2@3#4$5%6&7*89"
        '
        'txtNumbers
        '
        Me.txtNumbers.BackColor = System.Drawing.Color.Silver
        Me.txtNumbers.ForeColor = System.Drawing.Color.Black
        Me.txtNumbers.Location = New System.Drawing.Point(406, 92)
        Me.txtNumbers.Name = "txtNumbers"
        Me.txtNumbers.Size = New System.Drawing.Size(106, 20)
        Me.txtNumbers.TabIndex = 3
        Me.txtNumbers.Text = "10"
        Me.txtNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Alphanumeric to be used"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Alphanumeric consisting of the code (eg 10), Minimum alphanumeric eight (8):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password created"
        '
        'txtValidatePass
        '
        Me.txtValidatePass.BackColor = System.Drawing.Color.Silver
        Me.txtValidatePass.ForeColor = System.Drawing.Color.Black
        Me.txtValidatePass.Location = New System.Drawing.Point(13, 207)
        Me.txtValidatePass.Name = "txtValidatePass"
        Me.txtValidatePass.ReadOnly = True
        Me.txtValidatePass.Size = New System.Drawing.Size(499, 20)
        Me.txtValidatePass.TabIndex = 7
        Me.txtValidatePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Verification basic safety rules" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TimerCreatePass
        '
        Me.TimerCreatePass.Interval = 5
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(406, 238)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 60)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.Color.Silver
        Me.txtTime.ForeColor = System.Drawing.Color.Black
        Me.txtTime.Location = New System.Drawing.Point(12, 304)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(499, 20)
        Me.txtTime.TabIndex = 19
        Me.txtTime.Text = "Time needed to generate a password:"
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimerTime
        '
        Me.TimerTime.Interval = 1000
        '
        'TimerColor
        '
        Me.TimerColor.Interval = 1500
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Chocolate
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(519, 33)
        Me.lblTitle.TabIndex = 22
        Me.lblTitle.Text = "Password Generator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(497, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 21)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "Χ"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(519, 338)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtValidatePass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumbers)
        Me.Controls.Add(Me.txtCharacters)
        Me.Controls.Add(Me.txtShowPassword)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Δημιουργία κωδικών"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents txtShowPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtCharacters As System.Windows.Forms.TextBox
    Friend WithEvents txtNumbers As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtValidatePass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TimerCreatePass As System.Windows.Forms.Timer
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents TimerTime As System.Windows.Forms.Timer
    Friend WithEvents TimerColor As System.Windows.Forms.Timer
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
