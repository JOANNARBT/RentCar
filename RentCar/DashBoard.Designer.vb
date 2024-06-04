<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashBoard))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BtnSettings = New FontAwesome.Sharp.IconButton()
        Me.BtnVoitures = New FontAwesome.Sharp.IconButton()
        Me.BtnClients = New FontAwesome.Sharp.IconButton()
        Me.BtnEmploye = New FontAwesome.Sharp.IconButton()
        Me.BtnDashBoard = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImgHome = New System.Windows.Forms.PictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.PicProfile = New System.Windows.Forms.PictureBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnMaxi = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnMini = New System.Windows.Forms.Button()
        Me.LblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Piccenter = New System.Windows.Forms.PictureBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.PicProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.Piccenter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BtnSettings)
        Me.PanelMenu.Controls.Add(Me.BtnVoitures)
        Me.PanelMenu.Controls.Add(Me.BtnClients)
        Me.PanelMenu.Controls.Add(Me.BtnEmploye)
        Me.PanelMenu.Controls.Add(Me.BtnDashBoard)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(175, 621)
        Me.PanelMenu.TabIndex = 0
        '
        'BtnSettings
        '
        Me.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSettings.FlatAppearance.BorderSize = 0
        Me.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnSettings.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnSettings.IconChar = FontAwesome.Sharp.IconChar.Wrench
        Me.BtnSettings.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnSettings.IconSize = 32
        Me.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSettings.Location = New System.Drawing.Point(0, 443)
        Me.BtnSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Padding = New System.Windows.Forms.Padding(13, 0, 20, 0)
        Me.BtnSettings.Rotation = 0.0R
        Me.BtnSettings.Size = New System.Drawing.Size(175, 78)
        Me.BtnSettings.TabIndex = 5
        Me.BtnSettings.Text = "Settings"
        Me.BtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSettings.UseVisualStyleBackColor = True
        '
        'BtnVoitures
        '
        Me.BtnVoitures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnVoitures.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVoitures.FlatAppearance.BorderSize = 0
        Me.BtnVoitures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVoitures.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnVoitures.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnVoitures.IconChar = FontAwesome.Sharp.IconChar.Car
        Me.BtnVoitures.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnVoitures.IconSize = 32
        Me.BtnVoitures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVoitures.Location = New System.Drawing.Point(0, 365)
        Me.BtnVoitures.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVoitures.Name = "BtnVoitures"
        Me.BtnVoitures.Padding = New System.Windows.Forms.Padding(13, 0, 20, 0)
        Me.BtnVoitures.Rotation = 0.0R
        Me.BtnVoitures.Size = New System.Drawing.Size(175, 78)
        Me.BtnVoitures.TabIndex = 4
        Me.BtnVoitures.Text = "Cars"
        Me.BtnVoitures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVoitures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVoitures.UseVisualStyleBackColor = True
        '
        'BtnClients
        '
        Me.BtnClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnClients.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnClients.FlatAppearance.BorderSize = 0
        Me.BtnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClients.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnClients.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnClients.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.BtnClients.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnClients.IconSize = 32
        Me.BtnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClients.Location = New System.Drawing.Point(0, 287)
        Me.BtnClients.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClients.Name = "BtnClients"
        Me.BtnClients.Padding = New System.Windows.Forms.Padding(13, 0, 20, 0)
        Me.BtnClients.Rotation = 0.0R
        Me.BtnClients.Size = New System.Drawing.Size(175, 78)
        Me.BtnClients.TabIndex = 3
        Me.BtnClients.Text = "Customers"
        Me.BtnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClients.UseVisualStyleBackColor = True
        '
        'BtnEmploye
        '
        Me.BtnEmploye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnEmploye.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEmploye.FlatAppearance.BorderSize = 0
        Me.BtnEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmploye.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnEmploye.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnEmploye.IconChar = FontAwesome.Sharp.IconChar.UserTie
        Me.BtnEmploye.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnEmploye.IconSize = 32
        Me.BtnEmploye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmploye.Location = New System.Drawing.Point(0, 209)
        Me.BtnEmploye.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEmploye.Name = "BtnEmploye"
        Me.BtnEmploye.Padding = New System.Windows.Forms.Padding(13, 0, 20, 0)
        Me.BtnEmploye.Rotation = 0.0R
        Me.BtnEmploye.Size = New System.Drawing.Size(175, 78)
        Me.BtnEmploye.TabIndex = 2
        Me.BtnEmploye.Text = "Employe"
        Me.BtnEmploye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmploye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEmploye.UseVisualStyleBackColor = True
        '
        'BtnDashBoard
        '
        Me.BtnDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDashBoard.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDashBoard.FlatAppearance.BorderSize = 0
        Me.BtnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashBoard.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnDashBoard.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnDashBoard.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.BtnDashBoard.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnDashBoard.IconSize = 32
        Me.BtnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashBoard.Location = New System.Drawing.Point(0, 131)
        Me.BtnDashBoard.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDashBoard.Name = "BtnDashBoard"
        Me.BtnDashBoard.Padding = New System.Windows.Forms.Padding(13, 0, 20, 0)
        Me.BtnDashBoard.Rotation = 0.0R
        Me.BtnDashBoard.Size = New System.Drawing.Size(175, 78)
        Me.BtnDashBoard.TabIndex = 1
        Me.BtnDashBoard.Text = "DashBoard"
        Me.BtnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDashBoard.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.Label1)
        Me.PanelLogo.Controls.Add(Me.ImgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(175, 131)
        Me.PanelLogo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Magneto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(56, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RentCar"
        '
        'ImgHome
        '
        Me.ImgHome.Image = CType(resources.GetObject("ImgHome.Image"), System.Drawing.Image)
        Me.ImgHome.Location = New System.Drawing.Point(4, 4)
        Me.ImgHome.Margin = New System.Windows.Forms.Padding(4)
        Me.ImgHome.Name = "ImgHome"
        Me.ImgHome.Size = New System.Drawing.Size(171, 123)
        Me.ImgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgHome.TabIndex = 0
        Me.ImgHome.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.PicProfile)
        Me.PanelTitleBar.Controls.Add(Me.BtnLogin)
        Me.PanelTitleBar.Controls.Add(Me.BtnMaxi)
        Me.PanelTitleBar.Controls.Add(Me.BtnExit)
        Me.PanelTitleBar.Controls.Add(Me.BtnMini)
        Me.PanelTitleBar.Controls.Add(Me.LblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Controls.Add(Me.BtnLogout)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(175, 0)
        Me.PanelTitleBar.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1009, 98)
        Me.PanelTitleBar.TabIndex = 1
        '
        'PicProfile
        '
        Me.PicProfile.BackgroundImage = CType(resources.GetObject("PicProfile.BackgroundImage"), System.Drawing.Image)
        Me.PicProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicProfile.Location = New System.Drawing.Point(967, 58)
        Me.PicProfile.Name = "PicProfile"
        Me.PicProfile.Size = New System.Drawing.Size(36, 37)
        Me.PicProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicProfile.TabIndex = 6
        Me.PicProfile.TabStop = False
        '
        'BtnLogin
        '
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.Black
        Me.BtnLogin.Location = New System.Drawing.Point(892, 60)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(71, 31)
        Me.BtnLogin.TabIndex = 5
        Me.BtnLogin.Text = "Sign in"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnMaxi
        '
        Me.BtnMaxi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaxi.BackgroundImage = CType(resources.GetObject("BtnMaxi.BackgroundImage"), System.Drawing.Image)
        Me.BtnMaxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMaxi.FlatAppearance.BorderSize = 0
        Me.BtnMaxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaxi.Location = New System.Drawing.Point(943, 13)
        Me.BtnMaxi.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMaxi.Name = "BtnMaxi"
        Me.BtnMaxi.Size = New System.Drawing.Size(26, 27)
        Me.BtnMaxi.TabIndex = 4
        Me.BtnMaxi.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.BackgroundImage = CType(resources.GetObject("BtnExit.BackgroundImage"), System.Drawing.Image)
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Location = New System.Drawing.Point(977, 13)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(26, 27)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnMini
        '
        Me.BtnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMini.BackgroundImage = CType(resources.GetObject("BtnMini.BackgroundImage"), System.Drawing.Image)
        Me.BtnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMini.FlatAppearance.BorderSize = 0
        Me.BtnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMini.Location = New System.Drawing.Point(909, 13)
        Me.BtnMini.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMini.Name = "BtnMini"
        Me.BtnMini.Size = New System.Drawing.Size(26, 27)
        Me.BtnMini.TabIndex = 2
        Me.BtnMini.UseVisualStyleBackColor = True
        '
        'LblFormTitle
        '
        Me.LblFormTitle.AutoSize = True
        Me.LblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblFormTitle.Location = New System.Drawing.Point(55, 41)
        Me.LblFormTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFormTitle.Name = "LblFormTitle"
        Me.LblFormTitle.Size = New System.Drawing.Size(45, 17)
        Me.LblFormTitle.TabIndex = 1
        Me.LblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.Salmon
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.Salmon
        Me.IconCurrentForm.IconSize = 42
        Me.IconCurrentForm.Location = New System.Drawing.Point(8, 29)
        Me.IconCurrentForm.Margin = New System.Windows.Forms.Padding(4)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(43, 42)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'BtnLogout
        '
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.Black
        Me.BtnLogout.Location = New System.Drawing.Point(882, 60)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(87, 31)
        Me.BtnLogout.TabIndex = 7
        Me.BtnLogout.Text = "Log out"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.LblDate)
        Me.PanelDesktop.Controls.Add(Me.LblTime)
        Me.PanelDesktop.Controls.Add(Me.Label3)
        Me.PanelDesktop.Controls.Add(Me.Piccenter)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(175, 98)
        Me.PanelDesktop.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1009, 523)
        Me.PanelDesktop.TabIndex = 0
        '
        'LblDate
        '
        Me.LblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.Location = New System.Drawing.Point(864, 491)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(142, 27)
        Me.LblDate.TabIndex = 5
        Me.LblDate.Text = "Mar, 31 March 2024"
        '
        'LblTime
        '
        Me.LblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTime.AutoSize = True
        Me.LblTime.Font = New System.Drawing.Font("Microsoft Uighur", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.Location = New System.Drawing.Point(911, 462)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(58, 31)
        Me.LblTime.TabIndex = 4
        Me.LblTime.Text = "00:00 "
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Magneto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(426, 279)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 41)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "RentCar"
        '
        'Piccenter
        '
        Me.Piccenter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Piccenter.BackColor = System.Drawing.Color.Transparent
        Me.Piccenter.Image = CType(resources.GetObject("Piccenter.Image"), System.Drawing.Image)
        Me.Piccenter.Location = New System.Drawing.Point(289, 87)
        Me.Piccenter.Margin = New System.Windows.Forms.Padding(4)
        Me.Piccenter.Name = "Piccenter"
        Me.Piccenter.Size = New System.Drawing.Size(441, 289)
        Me.Piccenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Piccenter.TabIndex = 2
        Me.Piccenter.TabStop = False
        '
        'Timer
        '
        '
        'DashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 621)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1100, 600)
        Me.Name = "DashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashBoard"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.PicProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        CType(Me.Piccenter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents PanelLogo As System.Windows.Forms.Panel
    Friend WithEvents PanelTitleBar As System.Windows.Forms.Panel
    Friend WithEvents BtnDashBoard As FontAwesome.Sharp.IconButton
    Friend WithEvents ImgHome As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSettings As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnVoitures As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnClients As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnEmploye As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As System.Windows.Forms.Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LblFormTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Piccenter As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnMini As System.Windows.Forms.Button
    Friend WithEvents BtnMaxi As System.Windows.Forms.Button
    Friend WithEvents LblTime As System.Windows.Forms.Label
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents PicProfile As System.Windows.Forms.PictureBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
End Class
