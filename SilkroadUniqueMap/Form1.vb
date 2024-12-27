Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        ' Blende alle PictureBox-Steuerelemente aus
        pb_TigerGirl.Visible = False
        pb_Cerberus.Visible = False
        pb_CaptainIvy.Visible = False
        pb_Uruchi.Visible = False
        pb_Isyutaru.Visible = False
        pb_LordYarkan.Visible = False
        pb_DemonShaitan.Visible = False

        ' Überprüfe die Auswahl und zeige die entsprechende PictureBox
        Select Case ComboBox1.SelectedItem.ToString()
            Case "Tiger Girl"
                pb_TigerGirl.Visible = True
            Case "Cerberus"
                pb_Cerberus.Visible = True
            Case "Captain Ivy"
                pb_CaptainIvy.Visible = True
            Case "Uruchi"
                pb_Uruchi.Visible = True
            Case "Isyutaru"
                pb_Isyutaru.Visible = True
            Case "Lord Yarkan"
                pb_LordYarkan.Visible = True
            Case "Demon Shaitan"
                pb_DemonShaitan.Visible = True
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.AddRange(New String() {
            "Tiger Girl",
            "Cerberus",
            "Captain Ivy",
            "Uruchi",
            "Isyutaru",
            "Lord Yarkan",
            "Demon Shaitan"
        })



        ' Wähle das erste Element standardmäßig aus
        ComboBox1.SelectedIndex = 0

    End Sub

    Private Sub PicturesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bt_about_Click(sender As Object, e As EventArgs) Handles bt_about.Click
        MessageBox.Show("Pictures taken from https://immortalitysro.weebly.com")
    End Sub
End Class
