Imports System.Data.SqlClient
Imports System.Drawing.Image
Imports System.IO
Public Class Authentification
    'Dim x As DialogResult
    Dim con As New SqlConnection("Data Source=DESKTOP-387BGJ7\SQLEXPRESS;Initial Catalog=Location;Integrated Security=True")
    Private Sub Authentification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        PanelProgress.Visible = False
        Dim sql As String = "SELECT * FROM TEmploye"
        Dim command As New SqlCommand(sql, con)
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read()
            CLogin.Items.Add(reader("ID"))
        End While
        con.Close()
    End Sub
    Public Function ConvertToImage(ByVal data() As Byte) As Image
        Dim stream As New MemoryStream(data)
        Return Image.FromStream(stream)
    End Function
    Private Sub TPass_TextChanged(sender As Object, e As EventArgs) Handles TPass.TextChanged
        If Len(TPass.Text) = 4 Then

            con.Open()
            Dim sql As String = "SELECT * FROM TEmploye WHERE ID LIKE @CLogin"
            Dim command As New SqlCommand(sql, con)
            command.Parameters.AddWithValue("@CLogin", CLogin.Text)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    If TPass.Text = reader("Code_Emp") Then
                        P1.Value = 0
                        PanelProgress.Visible = True
                        TimerAuth.Enabled = True
                        DashBoard.PicProfile.Image = ConvertToImage(reader("Photo_Emp"))
                    Else
                        MessageBox.Show("Mot de Passe Incorrecte")
                        TPass.Text = Nothing
                    End If
                End While
            Else
                MessageBox.Show("Login Introuvable")
            End If
            con.Close()
        End If
    End Sub

    Private Sub TimerAuth_Tick(sender As Object, e As EventArgs) Handles TimerAuth.Tick
        P1.Value = P1.Value + 10
        If P1.Value >= 99 Then
            TimerAuth.Enabled = False
            DashBoard.BtnDashBoard.Enabled = True
            DashBoard.BtnEmploye.Enabled = True
            DashBoard.BtnClients.Enabled = True
            DashBoard.BtnVoitures.Enabled = True
            DashBoard.BtnSettings.Enabled = True
            DashBoard.BtnLogout.Visible = True
            DashBoard.BtnLogin.Visible = False
            CLogin.Text = Nothing
            TPass.Text = Nothing
            P1.Value = 0
            Me.Hide()
        End If
    End Sub

   
End Class