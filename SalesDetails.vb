Imports System.Data.SqlClient
Public Class SalesDetails
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vruttika2004\OneDrive\Documents\ArtGallery.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FetchSalesData()
        If SaleIdTb.Text = "" Then
            MsgBox("Enter the Sale Id")
        Else
            Con.Open()
            Dim Query = "select * from SalesTbl where SaleId=" & SaleIdTb.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                SlSldLbl.Text = dr(1).ToString()
                SlCustNmLbl.Text = dr(2).ToString()
                SlAmtPdLbl.Text = dr(3).ToString()
                SlDOSLbl.Text = dr(4).ToString()
                SlTransIdLbl.Text = dr(5).ToString()
                SlDelStatLbl.Text = dr(6).ToString()
                SlPmtMetLbl.Text = dr(7).ToString()
                SlSldLbl.Visible = True
                SlCustNmLbl.Visible = True
                SlAmtPdLbl.Visible = True
                SlDOSLbl.Visible = True
                SlTransIdLbl.Visible = True
                SlDelStatLbl.Visible = True
                SlPmtMetLbl.Visible = True
            Next
            Con.Close()
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FetchSalesData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub

    Private Sub PrintDocument5_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument5.PrintPage
        e.Graphics.DrawString("ArtWork Gallery Management System", New Font("Century Gothic", 25), Brushes.MediumVioletRed, 100, 40)
        e.Graphics.DrawString("***SALESSUMMARY***", New Font("Arial ", 20), Brushes.PaleVioletRed, 250, 100)
        e.Graphics.DrawString("Artwork Sold:      " + SlSldLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 205)
        e.Graphics.DrawString("Customer Name:     " + SlCustNmLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 264)
        e.Graphics.DrawString("Amount Paid:      " + SlAmtPdLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 325)
        e.Graphics.DrawString("Delivery Status:     " + SlDelStatLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 385)
        e.Graphics.DrawString("Transaction ID:      " + SlTransIdLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 445)
        e.Graphics.DrawString("Payment Method:     " + SlPmtMetLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 505)
        e.Graphics.DrawString("Date of Sale:      " + SlDOSLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 600)

        e.Graphics.DrawString("===============Thank You For Your Services===============", New Font("Cetury Gothic", 15), Brushes.MediumVioletRed, 120, 800)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog5.Show()
    End Sub
End Class