Imports System.Data.SqlClient
Imports System.Drawing.Image
Imports System.IO
Public Class Fiche_Employe
    Dim x As DialogResult
    Dim con As New SqlConnection("Data Source=DESKTOP-387BGJ7\SQLEXPRESS;Initial Catalog=Location;Integrated Security=True")
    Private Sub Fiche_Employe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Code pour l'image
        PEMP.Image = PEMP.BackgroundImage
        PEMP.BackgroundImageLayout = ImageLayout.Stretch
        con.Open()
        'Forecolor and backcolor for header of the DataGrid
        GEMP.EnableHeadersVisualStyles = False
        GEMP.ColumnHeadersDefaultCellStyle.BackColor = Color.MistyRose
        GEMP.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        GEMP.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        'Alimentation de Grid
        Dim sql As String = "SELECT * FROM TEmploye"
        Dim command As New SqlCommand(sql, con)
        Dim reader As SqlDataReader = command.ExecuteReader()
        GEMP.Rows.Clear()
        While reader.Read()
            GEMP.Rows.Add(reader("ID"), reader("Nom"), reader("Prenom"), reader("Telephone"), reader("Adresse"))
            CID.Items.Add(reader("ID"))
        End While
        con.Close()
    End Sub
    Public Function ConvertToData(ByVal myImage As Image) As Byte()
        Dim ms As New MemoryStream()
        myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim myBytes(ms.Length - 1) As Byte
        ms.Position = 0
        ms.Read(myBytes, 0, ms.Length)
        Return myBytes
    End Function
    'Code pour ajouter des Employés
    Private Sub BTN_AJOUT_Click(sender As Object, e As EventArgs) Handles BTN_AJOUT.Click
        If CID.Text = Nothing And TNOM.Text = Nothing And TPRENOM.Text = Nothing And TTEL.Text = Nothing And TADRESSE.Text = Nothing Then
            MessageBox.Show("Toutes les zones de textes sont vides", "Aucune Entrée", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
            Dim sql As String = "INSERT INTO TEmploye (ID, Nom, Prenom, Telephone, Adresse, Code_Emp, Photo_Emp) VALUES (@ID,@Nom,@Prenom,@Telephone,@Adresse,@Code_Emp,@Photo_Emp)"
            Dim command As New SqlCommand(sql, con)
            'Code pour Code_Accés
            Dim RND As Random
            Dim Number As Integer
            RND = New Random
            Number = RND.Next(999, 10000)
            'code pour affecter le numéro RND à un Champ de la Table
            LCODE.Text = Number.ToString
            command.Parameters.AddWithValue("@ID", CID.Text)
            command.Parameters.AddWithValue("@Nom", TNOM.Text)
            command.Parameters.AddWithValue("@Prenom", TPRENOM.Text)
            command.Parameters.AddWithValue("@Telephone", TTEL.Text)
            command.Parameters.AddWithValue("@Adresse", TADRESSE.Text)
            command.Parameters.AddWithValue("@Code_Emp", LCODE.Text)
            command.Parameters.AddWithValue("@Photo_Emp", ConvertToData(Me.PEMP.Image))
            Dim rowsaffected As Integer = command.ExecuteNonQuery()
            If rowsaffected > 0 Then
                x = MessageBox.Show("Voulez vous ajouter cet Employé ?", "Ajout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If x = MsgBoxResult.Yes Then
                    Beep()
                    GEMP.Rows.Add(CID.Text, TNOM.Text, TPRENOM.Text, TTEL.Text, TADRESSE.Text)
                    MessageBox.Show("Donnée ajoutée avec succés")
                End If
            End If
            con.Close()
        End If
    End Sub
    'Code pour rechercher sur Employé
    Private Sub BTN_RECHERCHE_Click(sender As Object, e As EventArgs) Handles BTN_RECHERCHE.Click
        con.Open()
        Dim sql As String = "SELECT * FROM TEmploye WHERE ID LIKE @ID"
        Dim command As New SqlCommand(sql, con)
        command.Parameters.AddWithValue("@ID", CID.Text)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                TNOM.Text = reader("Nom")
                TPRENOM.Text = reader("Prenom")
                TTEL.Text = reader("Telephone")
                TADRESSE.Text = reader("Adresse")
                PEMP.Image = convertToImage(reader("Photo_Emp"))
            End While
        Else
            MessageBox.Show("aucun Employé trouvé avec cet ID")
        End If
        con.Close()
    End Sub
    Public Function ConvertToImage(ByVal data() As Byte) As Image
        Dim stream As New MemoryStream(data)
        Return Image.FromStream(stream)
    End Function
    'Code pour modifier les données des Employés
    Private Sub BTN_MODIFIER_Click(sender As Object, e As EventArgs) Handles BTN_MODIFIER.Click
        If CID.Text = Nothing And TNOM.Text = Nothing And TPRENOM.Text = Nothing And TTEL.Text = Nothing And TADRESSE.Text = Nothing Then
            MessageBox.Show("Toutes les zones de textes sont vides", "Aucune Entrée", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            x = MessageBox.Show("Voulez vous Modifier cette Données?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = MsgBoxResult.Yes Then
                con.Open()
                Dim sql As String = "UPDATE TEmploye SET  Nom=@NouveauNom, Prenom=@NouveauPrenom, Telephone=@NouveauTel, Adresse=@NouveauAdresse, Photo_Emp=@NouveauPhoto_Emp where ID=@ID"
                Dim command As New SqlCommand(sql, con)

                command.Parameters.AddWithValue("@NouveauNom", TNOM.Text)
                command.Parameters.AddWithValue("@NouveauPrenom", TPRENOM.Text)
                command.Parameters.AddWithValue("@NouveauTel", TTEL.Text)
                command.Parameters.AddWithValue("@NouveauAdresse", TADRESSE.Text)
                command.Parameters.AddWithValue("@NouveauPhoto_Emp", ConvertToData(Me.PEMP.Image))
                command.Parameters.AddWithValue("@ID", CID.Text)

                Dim rowsaffected As Integer = command.ExecuteNonQuery()
                If rowsaffected > 0 Then
                    Beep()
                    MessageBox.Show("Employé mise à jour avec succés")
                    GEMP.Rows.Clear()
                    Dim sql1 As String = "SELECT * FROM TEmploye"
                    Dim command1 As New SqlCommand(sql1, con)

                    Dim reader As SqlDataReader = command1.ExecuteReader()
                    While reader.Read()
                        GEMP.Rows.Add(reader("ID"), reader("Nom"), reader("Prenom"), reader("Telephone"), reader("Adresse"))
                    End While
                Else
                    MessageBox.Show("aucun Employé trouvé avec cet ID")
                End If
                con.Close()
            End If
        End If
    End Sub
    'Code pour supprimer des Emoployés
    Private Sub BTN_SUPPRIMER_Click(sender As Object, e As EventArgs) Handles BTN_SUPPRIMER.Click
        x = MessageBox.Show("Voulez vous supprimer cet Employé ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = MsgBoxResult.Yes Then
            con.Open()
            Dim sql As String = "DELETE FROM TEmploye where ID=@ID"
            Dim command As New SqlCommand(sql, con)
            command.Parameters.AddWithValue("@ID", CID.Text)
            Dim rowsaffected As Integer = command.ExecuteNonQuery()
            If rowsaffected > 0 Then
                Beep()
                MessageBox.Show("Employé Supprimé avec succés")
                CID.Text = ""
                TNOM.Text = Nothing
                TPRENOM.Text = Nothing
                TTEL.Text = Nothing
                TADRESSE.Text = Nothing
                PEMP.Image = PEMP.BackgroundImage
                PEMP.BackgroundImageLayout = ImageLayout.Stretch
                GEMP.Rows.Clear()
                Dim sql1 As String = "SELECT * FROM TEmploye"
                Dim command1 As New SqlCommand(sql1, con)
                Dim reader As SqlDataReader = command1.ExecuteReader()
                While reader.Read()
                    GEMP.Rows.Add(reader("ID"), reader("Nom"), reader("Prenom"), reader("Telephone"), reader("Adresse"))
                End While
            Else
                MessageBox.Show("aucun Employé trouvé avec cet ID")
            End If
            con.Close()
        End If
    End Sub
    'Code pour Effacer les données qui sont écrits
    Private Sub BTN_RAZ_Click(sender As Object, e As EventArgs) Handles BTN_RAZ.Click
        If CID.Text = Nothing And TNOM.Text = Nothing And TPRENOM.Text = Nothing And TTEL.Text = Nothing And TADRESSE.Text = Nothing Then
            MessageBox.Show("Toutes les zones de textes sont vides", "Aucune Entrée", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            x = MessageBox.Show("Voulez Vous Vider Toutes les Zones de Textes ?", "Effaçage", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = MsgBoxResult.Yes Then
                Beep()
                CID.Text = Nothing
                TNOM.Text = Nothing
                TPRENOM.Text = Nothing
                TTEL.Text = Nothing
                TADRESSE.Text = Nothing
                PEMP.Image = PEMP.BackgroundImage
                PEMP.BackgroundImageLayout = ImageLayout.Stretch
            End If
        End If
    End Sub


    Private Sub PEMP_Click(sender As Object, e As EventArgs) Handles PEMP.Click
        Me.OFD_EMP.FileName = Nothing
        Me.OFD_EMP.ShowDialog()
        If Not Me.OFD_EMP.FileName = Nothing Then
            Me.PEMP.ImageLocation = Me.OFD_EMP.FileName
        End If
    End Sub
    'Code pour fermer l'application
    Private Sub BTN_FERMER_Click(sender As Object, e As EventArgs) Handles BTN_FERMER.Click
        x = MessageBox.Show("Voulez vous fermer ?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = MsgBoxResult.Yes Then
            Beep()
            Me.Close()
        End If
    End Sub
    Private Sub CID_SelectedIndexChange(sender As Object, e As EventArgs) Handles CID.SelectedIndexChanged
        con.Open()
        Dim sql As String = "SELECT * FROM TEmploye WHERE ID LIKE @ID"
        Dim command As New SqlCommand(sql, con)
        command.Parameters.AddWithValue("@ID", CID.Text)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                TNOM.Text = reader("Nom")
                TPRENOM.Text = reader("Prenom")
                TTEL.Text = reader("Telephone")
                TADRESSE.Text = reader("Adresse")
                PEMP.Image = ConvertToImage(reader("Photo_Emp"))
            End While
        End If
        con.Close()
    End Sub

    Private Sub TTEL_TextChanged(sender As Object, e As EventArgs) Handles TTEL.TextChanged
        If Not IsNumeric(TTEL.Text) Then
            TTEL.Text = Nothing
        End If
    End Sub

    Private Sub TADRESSE_Click(sender As Object, e As EventArgs) Handles TADRESSE.Click
        If Len(TTEL.Text) <> 10 Then
            MessageBox.Show("Numéro de Téléphone invalide")
            TTEL.Text = Nothing
        End If
    End Sub

    Private Sub TNOM_TextChanged(sender As Object, e As EventArgs) Handles TNOM.TextChanged
        TNOM.CharacterCasing = CharacterCasing.Upper
        If IsNumeric(TTEL.Text) Then
            TNOM.Text = Nothing
        End If
    End Sub
End Class