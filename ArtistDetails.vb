Imports System.Data.SqlClient
Public Class ArtistDetails
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vruttika2004\OneDrive\Documents\ArtGallery.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FetchArtistData()
        If AtIdTb.Text = "" Then
            MsgBox("Enter the Artist Id")
        Else
            Con.Open()
            Dim Query = "select * from ArtistTbl where AtId=" & AtIdTb.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                AtNameLbl.Text = dr(1).ToString()
                AtEmailLbl.Text = dr(2).ToString()
                AtStatLbl.Text = dr(3).ToString()
                AtDobLbl.Text = dr(4).ToString()
                AtPhnLbl.Text = dr(5).ToString()
                AtStlLbl.Text = dr(6).ToString()
                AtGendLbl.Text = dr(7).ToString()
                AtNameLbl.Visible = True
                AtEmailLbl.Visible = True
                AtStatLbl.Visible = True
                AtDobLbl.Visible = True
                AtPhnLbl.Visible = True
                AtStlLbl.Visible = True
                AtGendLbl.Visible = True
            Next
            Con.Close()
        End If

    End Sub
    Private Sub ArtistDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FetchArtistData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        e.Graphics.DrawString("ArtWork Gallery Management System", New Font("Century Gothic", 25), Brushes.MediumVioletRed, 100, 40)
        e.Graphics.DrawString("***ARTISTSUMMARY***", New Font("Arial ", 20), Brushes.PaleVioletRed, 250, 100)
        e.Graphics.DrawString("Name:      " + AtNameLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 205)
        e.Graphics.DrawString("Email:     " + AtEmailLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 264)
        e.Graphics.DrawString("Gender:      " + AtGendLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 325)
        e.Graphics.DrawString("Activity Status:     " + AtStatLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 385)
        e.Graphics.DrawString("Phone Number:      " + AtPhnLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 445)
        e.Graphics.DrawString("Art Style:     " + AtStlLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 505)
        e.Graphics.DrawString("DOB:      " + AtDobLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 600)

        e.Graphics.DrawString("===============Thank You For Your Services===============", New Font("Cetury Gothic", 15), Brushes.MediumVioletRed, 120, 800)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog2.Show()
    End Sub
End Class
