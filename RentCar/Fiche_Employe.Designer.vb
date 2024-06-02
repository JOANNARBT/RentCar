<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fiche_Employe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fiche_Employe))
        Me.GEMP = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CID = New System.Windows.Forms.ComboBox()
        Me.TNOM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TPRENOM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TTEL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TADRESSE = New System.Windows.Forms.TextBox()
        Me.LCODE = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTN_FERMER = New System.Windows.Forms.Button()
        Me.BTN_RAZ = New System.Windows.Forms.Button()
        Me.BTN_SUPPRIMER = New System.Windows.Forms.Button()
        Me.BTN_MODIFIER = New System.Windows.Forms.Button()
        Me.BTN_RECHERCHE = New System.Windows.Forms.Button()
        Me.BTN_AJOUT = New System.Windows.Forms.Button()
        Me.PEMP = New System.Windows.Forms.PictureBox()
        Me.OFD_EMP = New System.Windows.Forms.OpenFileDialog()
        CType(Me.GEMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PEMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GEMP
        '
        Me.GEMP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GEMP.BackgroundColor = System.Drawing.Color.Red
        Me.GEMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GEMP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.GEMP.GridColor = System.Drawing.Color.DarkRed
        Me.GEMP.Location = New System.Drawing.Point(34, 350)
        Me.GEMP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GEMP.Name = "GEMP"
        Me.GEMP.Size = New System.Drawing.Size(932, 136)
        Me.GEMP.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 46
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Nom"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 62
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Prénom"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 82
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Téléphone"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 101
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Adresse"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 85
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID"
        '
        'CID
        '
        Me.CID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CID.FormattingEnabled = True
        Me.CID.Location = New System.Drawing.Point(137, 28)
        Me.CID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CID.Name = "CID"
        Me.CID.Size = New System.Drawing.Size(331, 25)
        Me.CID.TabIndex = 7
        '
        'TNOM
        '
        Me.TNOM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TNOM.Location = New System.Drawing.Point(137, 75)
        Me.TNOM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TNOM.Name = "TNOM"
        Me.TNOM.Size = New System.Drawing.Size(331, 23)
        Me.TNOM.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(31, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nom"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Prénom"
        '
        'TPRENOM
        '
        Me.TPRENOM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TPRENOM.Location = New System.Drawing.Point(137, 124)
        Me.TPRENOM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TPRENOM.Name = "TPRENOM"
        Me.TPRENOM.Size = New System.Drawing.Size(331, 23)
        Me.TPRENOM.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(31, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Téléphone"
        '
        'TTEL
        '
        Me.TTEL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TTEL.Location = New System.Drawing.Point(137, 172)
        Me.TTEL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TTEL.MaxLength = 10
        Me.TTEL.Name = "TTEL"
        Me.TTEL.Size = New System.Drawing.Size(331, 23)
        Me.TTEL.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(31, 221)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Adresse"
        '
        'TADRESSE
        '
        Me.TADRESSE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TADRESSE.Location = New System.Drawing.Point(137, 217)
        Me.TADRESSE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TADRESSE.Name = "TADRESSE"
        Me.TADRESSE.Size = New System.Drawing.Size(331, 23)
        Me.TADRESSE.TabIndex = 14
        '
        'LCODE
        '
        Me.LCODE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LCODE.AutoSize = True
        Me.LCODE.Location = New System.Drawing.Point(555, 38)
        Me.LCODE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCODE.Name = "LCODE"
        Me.LCODE.Size = New System.Drawing.Size(39, 17)
        Me.LCODE.TabIndex = 16
        Me.LCODE.Text = "code"
        Me.LCODE.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BTN_FERMER)
        Me.GroupBox1.Controls.Add(Me.BTN_RAZ)
        Me.GroupBox1.Controls.Add(Me.BTN_SUPPRIMER)
        Me.GroupBox1.Controls.Add(Me.BTN_MODIFIER)
        Me.GroupBox1.Controls.Add(Me.BTN_RECHERCHE)
        Me.GroupBox1.Controls.Add(Me.BTN_AJOUT)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(75, 246)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(863, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'BTN_FERMER
        '
        Me.BTN_FERMER.BackgroundImage = CType(resources.GetObject("BTN_FERMER.BackgroundImage"), System.Drawing.Image)
        Me.BTN_FERMER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_FERMER.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_FERMER.FlatAppearance.BorderSize = 0
        Me.BTN_FERMER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_FERMER.Location = New System.Drawing.Point(735, 21)
        Me.BTN_FERMER.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_FERMER.Name = "BTN_FERMER"
        Me.BTN_FERMER.Size = New System.Drawing.Size(76, 66)
        Me.BTN_FERMER.TabIndex = 5
        Me.BTN_FERMER.UseVisualStyleBackColor = True
        '
        'BTN_RAZ
        '
        Me.BTN_RAZ.BackgroundImage = CType(resources.GetObject("BTN_RAZ.BackgroundImage"), System.Drawing.Image)
        Me.BTN_RAZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_RAZ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_RAZ.FlatAppearance.BorderSize = 0
        Me.BTN_RAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_RAZ.Location = New System.Drawing.Point(599, 6)
        Me.BTN_RAZ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_RAZ.Name = "BTN_RAZ"
        Me.BTN_RAZ.Size = New System.Drawing.Size(91, 91)
        Me.BTN_RAZ.TabIndex = 4
        Me.BTN_RAZ.UseVisualStyleBackColor = True
        '
        'BTN_SUPPRIMER
        '
        Me.BTN_SUPPRIMER.BackgroundImage = CType(resources.GetObject("BTN_SUPPRIMER.BackgroundImage"), System.Drawing.Image)
        Me.BTN_SUPPRIMER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SUPPRIMER.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_SUPPRIMER.FlatAppearance.BorderSize = 0
        Me.BTN_SUPPRIMER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SUPPRIMER.Location = New System.Drawing.Point(481, 22)
        Me.BTN_SUPPRIMER.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_SUPPRIMER.Name = "BTN_SUPPRIMER"
        Me.BTN_SUPPRIMER.Size = New System.Drawing.Size(76, 63)
        Me.BTN_SUPPRIMER.TabIndex = 3
        Me.BTN_SUPPRIMER.UseVisualStyleBackColor = True
        '
        'BTN_MODIFIER
        '
        Me.BTN_MODIFIER.BackgroundImage = CType(resources.GetObject("BTN_MODIFIER.BackgroundImage"), System.Drawing.Image)
        Me.BTN_MODIFIER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_MODIFIER.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_MODIFIER.FlatAppearance.BorderSize = 0
        Me.BTN_MODIFIER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MODIFIER.Location = New System.Drawing.Point(340, 21)
        Me.BTN_MODIFIER.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_MODIFIER.Name = "BTN_MODIFIER"
        Me.BTN_MODIFIER.Size = New System.Drawing.Size(79, 63)
        Me.BTN_MODIFIER.TabIndex = 2
        Me.BTN_MODIFIER.UseVisualStyleBackColor = True
        '
        'BTN_RECHERCHE
        '
        Me.BTN_RECHERCHE.BackgroundImage = CType(resources.GetObject("BTN_RECHERCHE.BackgroundImage"), System.Drawing.Image)
        Me.BTN_RECHERCHE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_RECHERCHE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_RECHERCHE.FlatAppearance.BorderSize = 0
        Me.BTN_RECHERCHE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_RECHERCHE.Location = New System.Drawing.Point(181, 17)
        Me.BTN_RECHERCHE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_RECHERCHE.Name = "BTN_RECHERCHE"
        Me.BTN_RECHERCHE.Size = New System.Drawing.Size(111, 73)
        Me.BTN_RECHERCHE.TabIndex = 1
        Me.BTN_RECHERCHE.UseVisualStyleBackColor = True
        '
        'BTN_AJOUT
        '
        Me.BTN_AJOUT.BackgroundImage = CType(resources.GetObject("BTN_AJOUT.BackgroundImage"), System.Drawing.Image)
        Me.BTN_AJOUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_AJOUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_AJOUT.FlatAppearance.BorderSize = 0
        Me.BTN_AJOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_AJOUT.Location = New System.Drawing.Point(55, 17)
        Me.BTN_AJOUT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_AJOUT.Name = "BTN_AJOUT"
        Me.BTN_AJOUT.Size = New System.Drawing.Size(85, 70)
        Me.BTN_AJOUT.TabIndex = 0
        Me.BTN_AJOUT.UseVisualStyleBackColor = True
        '
        'PEMP
        '
        Me.PEMP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PEMP.BackgroundImage = CType(resources.GetObject("PEMP.BackgroundImage"), System.Drawing.Image)
        Me.PEMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PEMP.Location = New System.Drawing.Point(689, 28)
        Me.PEMP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PEMP.Name = "PEMP"
        Me.PEMP.Size = New System.Drawing.Size(277, 210)
        Me.PEMP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PEMP.TabIndex = 4
        Me.PEMP.TabStop = False
        '
        'OFD_EMP
        '
        Me.OFD_EMP.FileName = "OpenFileDialog1"
        '
        'Fiche_Employe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(993, 484)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LCODE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TADRESSE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TTEL)
        Me.Controls.Add(Me.GEMP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TPRENOM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TNOM)
        Me.Controls.Add(Me.CID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PEMP)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Fiche_Employe"
        Me.Text = "Fiche Employe"
        CType(Me.GEMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PEMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PEMP As System.Windows.Forms.PictureBox
    Friend WithEvents GEMP As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CID As System.Windows.Forms.ComboBox
    Friend WithEvents TNOM As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TPRENOM As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TTEL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TADRESSE As System.Windows.Forms.TextBox
    Friend WithEvents LCODE As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_FERMER As System.Windows.Forms.Button
    Friend WithEvents BTN_RAZ As System.Windows.Forms.Button
    Friend WithEvents BTN_SUPPRIMER As System.Windows.Forms.Button
    Friend WithEvents BTN_MODIFIER As System.Windows.Forms.Button
    Friend WithEvents BTN_RECHERCHE As System.Windows.Forms.Button
    Friend WithEvents BTN_AJOUT As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OFD_EMP As System.Windows.Forms.OpenFileDialog
End Class
