Imports System.Data.SqlClient
Public Class ExhibitionDetails
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vruttika2004\OneDrive\Documents\ArtGallery.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FetchExhibitionData()
        If ExbIdTb.Text = "" Then
            MsgBox("Enter the Exhibition Id")
        Else
            Con.Open()
            Dim Query = "select * from ExhibitionTbl where ExbId=" & ExbIdTb.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                ExbNameLbl.Text = dr(1).ToString()
                ExbTktLbl.Text = dr(2).ToString()
                ExbTypLbl.Text = dr(3).ToString()
                ExbEndDtLbl.Text = dr(4).ToString()
                ExbVstrLbl.Text = dr(5).ToString()
                ExbStrtDtLbl.Text = dr(6).ToString()
                ExbStatLbl.Text = dr(7).ToString()
                ExbNameLbl.Visible = True
                ExbTktLbl.Visible = True
                ExbTypLbl.Visible = True
                ExbEndDtLbl.Visible = True
                ExbVstrLbl.Visible = True
                ExbStrtDtLbl.Visible = True
                ExbStatLbl.Visible = True
            Next
            Con.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FetchExhibitionData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub

    Private Sub PrintDocument3_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage
        e.Graphics.DrawString("ArtWork Gallery Management System", New Font("Century Gothic", 25), Brushes.MediumVioletRed, 100, 40)
        e.Graphics.DrawString("***EXHIBITIONSUMMARY***", New Font("Arial ", 20), Brushes.PaleVioletRed, 250, 100)
        e.Graphics.DrawString("Exhibition Name:      " + ExbNameLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 205)
        e.Graphics.DrawString("Ticket Price:     " + ExbTktLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 264)
        e.Graphics.DrawString("Exhibition Type:      " + ExbTypLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 325)
        e.Graphics.DrawString("End Date:     " + ExbEndDtLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 385)
        e.Graphics.DrawString("Visitor Count:      " + ExbVstrLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 445)
        e.Graphics.DrawString("Start Date:     " + ExbStrtDtLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 505)
        e.Graphics.DrawString("Exhibitin Status:      " + ExbStatLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 600)

        e.Graphics.DrawString("===============Thank You For Your Services===============", New Font("Cetury Gothic", 15), Brushes.MediumVioletRed, 120, 800)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog3.Show()
    End Sub
End Class