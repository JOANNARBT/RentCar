Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp


Public Class DashBoard
    'champs
    Private currentBtn As IconButton
    Private LeftBorderBtn As Panel
    Private currentChildForm As Form

    'constructeur
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        LeftBorderBtn = New Panel()
        LeftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(LeftBorderBtn)
        'Form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    'methods
    Private Sub ActivateButton(senderBtn As Object, customcolor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customcolor
            currentBtn.IconColor = customcolor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'leftBorder
            LeftBorderBtn.BackColor = customcolor
            LeftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            LeftBorderBtn.Visible = True
            LeftBorderBtn.BringToFront()
            'current form icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customcolor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(29, 30, 39)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(ChildForm As Form)
        'open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = ChildForm
        'end
        ChildForm.TopLevel = False
        ChildForm.FormBorderStyle = FormBorderStyle.None
        ChildForm.Dock = DockStyle.Fill
        ChildForm.BackColor = Color.FromArgb(186, 2, 3)
        PanelDesktop.Controls.Add(ChildForm)
        PanelDesktop.Tag = ChildForm
        ChildForm.BringToFront()
        ChildForm.Show()
        LblFormTitle.Text = ChildForm.Text
    End Sub
    'Events
    Private Sub BtnDashBoard_Click(sender As Object, e As EventArgs) Handles BtnDashBoard.Click
        ActivateButton(sender, RGBColors.Color1)
        OpenChildForm(New FormDashBoard)
    End Sub

    Private Sub BtnEmploye_Click(sender As Object, e As EventArgs) Handles BtnEmploye.Click
        ActivateButton(sender, RGBColors.Color2)
        OpenChildForm(New FormEmploye)
    End Sub

    Private Sub BtnClients_Click(sender As Object, e As EventArgs) Handles BtnClients.Click
        ActivateButton(sender, RGBColors.Color3)
        OpenChildForm(New FormCustomers)
    End Sub

    Private Sub BtnVoitures_Click(sender As Object, e As EventArgs) Handles BtnVoitures.Click
        ActivateButton(sender, RGBColors.Color4)
        OpenChildForm(New FormCars)
    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        ActivateButton(sender, RGBColors.Color5)
        OpenChildForm(New FormSettings)
    End Sub


    Private Sub ImgHome_Click(sender As Object, e As EventArgs) Handles ImgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub
    Private Sub Reset()
        DisableButton()
        LeftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.Salmon
        LblFormTitle.Text = "Home"
    End Sub

    'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hwmd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal Param As Integer)
    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H122&, &HF012&, 0)
    End Sub

    Private Sub DashBoard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Else
            FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Private Sub BtnMini_Click(sender As Object, e As EventArgs) Handles BtnMini.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnMaxi_Click(sender As Object, e As EventArgs) Handles BtnMaxi.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        LblTime.Text = Now.ToShortTimeString
        LblDate.Text = Now.ToLongDateString
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Authentification.Show()
    End Sub

    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Enabled = True
        BtnDashBoard.Enabled = False
        BtnEmploye.Enabled = False
        BtnClients.Enabled = False
        BtnVoitures.Enabled = False
        BtnSettings.Enabled = False
        BtnLogout.Visible = False
    End Sub


    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        PicProfile.Image = PicProfile.BackgroundImage
        PicProfile.BackgroundImageLayout = ImageLayout.Stretch
        BtnDashBoard.Enabled = False
        BtnEmploye.Enabled = False
        BtnClients.Enabled = False
        BtnVoitures.Enabled = False
        BtnSettings.Enabled = False
        BtnLogout.Visible = False
        BtnLogout.Visible = False
        BtnLogin.Visible = True
    End Sub
End Class