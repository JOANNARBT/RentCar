<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmploye
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEmploye))
        Me.BtnFEmp = New System.Windows.Forms.PictureBox()
        Me.PanelEmp = New System.Windows.Forms.Panel()
        CType(Me.BtnFEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEmp.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFEmp
        '
        Me.BtnFEmp.BackgroundImage = CType(resources.GetObject("BtnFEmp.BackgroundImage"), System.Drawing.Image)
        Me.BtnFEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFEmp.Location = New System.Drawing.Point(55, 42)
        Me.BtnFEmp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnFEmp.Name = "BtnFEmp"
        Me.BtnFEmp.Size = New System.Drawing.Size(122, 131)
        Me.BtnFEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnFEmp.TabIndex = 0
        Me.BtnFEmp.TabStop = False
        '
        'PanelEmp
        '
        Me.PanelEmp.Controls.Add(Me.BtnFEmp)
        Me.PanelEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEmp.Location = New System.Drawing.Point(0, 0)
        Me.PanelEmp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelEmp.Name = "PanelEmp"
        Me.PanelEmp.Size = New System.Drawing.Size(993, 484)
        Me.PanelEmp.TabIndex = 1
        '
        'FormEmploye
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(993, 484)
        Me.Controls.Add(Me.PanelEmp)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormEmploye"
        Me.Text = "FormEmploye"
        CType(Me.BtnFEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEmp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnFEmp As System.Windows.Forms.PictureBox
    Friend WithEvents PanelEmp As System.Windows.Forms.Panel
End Class
