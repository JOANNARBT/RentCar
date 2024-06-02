<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Authentification
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
        Me.CLogin = New System.Windows.Forms.ComboBox()
        Me.TPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimerAuth = New System.Windows.Forms.Timer(Me.components)
        Me.PanelProgress = New System.Windows.Forms.Panel()
        Me.P1 = New System.Windows.Forms.ProgressBar()
        Me.PanelProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'CLogin
        '
        Me.CLogin.BackColor = System.Drawing.Color.Black
        Me.CLogin.ForeColor = System.Drawing.Color.Red
        Me.CLogin.FormattingEnabled = True
        Me.CLogin.Location = New System.Drawing.Point(85, 24)
        Me.CLogin.Name = "CLogin"
        Me.CLogin.Size = New System.Drawing.Size(205, 21)
        Me.CLogin.TabIndex = 0
        '
        'TPass
        '
        Me.TPass.BackColor = System.Drawing.Color.Black
        Me.TPass.ForeColor = System.Drawing.Color.Red
        Me.TPass.Location = New System.Drawing.Point(85, 82)
        Me.TPass.MaxLength = 4
        Me.TPass.Name = "TPass"
        Me.TPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.TPass.Size = New System.Drawing.Size(205, 20)
        Me.TPass.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gabriola", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gabriola", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'TimerAuth
        '
        '
        'PanelProgress
        '
        Me.PanelProgress.Controls.Add(Me.P1)
        Me.PanelProgress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelProgress.Location = New System.Drawing.Point(0, 107)
        Me.PanelProgress.Name = "PanelProgress"
        Me.PanelProgress.Size = New System.Drawing.Size(320, 31)
        Me.PanelProgress.TabIndex = 4
        '
        'P1
        '
        Me.P1.BackColor = System.Drawing.Color.Black
        Me.P1.ForeColor = System.Drawing.Color.Red
        Me.P1.Location = New System.Drawing.Point(12, 5)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(296, 23)
        Me.P1.TabIndex = 0
        '
        'Authentification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(320, 138)
        Me.Controls.Add(Me.PanelProgress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TPass)
        Me.Controls.Add(Me.CLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Authentification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authentification"
        Me.PanelProgress.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CLogin As System.Windows.Forms.ComboBox
    Friend WithEvents TPass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TimerAuth As System.Windows.Forms.Timer
    Friend WithEvents PanelProgress As System.Windows.Forms.Panel
    Friend WithEvents P1 As System.Windows.Forms.ProgressBar
End Class
