Imports System.Data.SqlClient
Public Class ArtworkDetails
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vruttika2004\OneDrive\Documents\ArtGallery.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FetchArtworkData()
        If AwkIdTb.Text = "" Then
            MsgBox("Enter the Artwork Id")
        Else
            Con.Open()
            Dim Query = "select * from ArtworkTbl where AwkId=" & AwkIdTb.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                AwkNameLbl.Text = dr(1).ToString()
                AwkAtstLbl.Text = dr(2).ToString()
                AwkAmtLbl.Text = dr(3).ToString()
                AwkDOALbl.Text = dr(4).ToString()
                AwkCdLbl.Text = dr(5).ToString()
                AwkEraLbl.Text = dr(6).ToString()
                AwkAvailLbl.Text = dr(7).ToString()
                AwkNameLbl.Visible = True
                AwkAtstLbl.Visible = True
                AwkAmtLbl.Visible = True
                AwkDOALbl.Visible = True
                AwkCdLbl.Visible = True
                AwkEraLbl.Visible = True
                AwkAvailLbl.Visible = True
            Next
            Con.Close()
        End If

    End Sub
    Private Sub ArtworkDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FetchArtworkData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("ArtWork Gallery Management System", New Font("Century Gothic", 25), Brushes.MediumVioletRed, 100, 40)
        e.Graphics.DrawString("***ARTWORKSUMMARY***", New Font("Arial ", 20), Brushes.PaleVioletRed, 250, 100)
        e.Graphics.DrawString("Name:      " + AwkNameLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 205)
        e.Graphics.DrawString("Artist:     " + AwkAtstLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 264)
        e.Graphics.DrawString("Amount:      " + AwkAmtLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 325)
        e.Graphics.DrawString("Era:     " + AwkEraLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 385)
        e.Graphics.DrawString("Code:      " + AwkCdLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 445)
        e.Graphics.DrawString("Availability:     " + AwkAvailLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 505)
        e.Graphics.DrawString("DOA:      " + AwkDOALbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 600)

        e.Graphics.DrawString("===============Thank You For Your Services===============", New Font("Cetury Gothic", 15), Brushes.MediumVioletRed, 120, 800)
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Show()
    End Sub
End Class