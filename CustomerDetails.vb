Imports System.Data.SqlClient
Public Class CustomerDetails
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vruttika2004\OneDrive\Documents\ArtGallery.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FetchCustomerData()
        If CustIdTb.Text = "" Then
            MsgBox("Enter the Customer Id")
        Else
            Con.Open()
            Dim Query = "select * from CustomerTbl where CustId=" & CustIdTb.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                CustNameLbl.Text = dr(1).ToString()
                CustEmlLbl.Text = dr(2).ToString()
                CustSpndsLbl.Text = dr(3).ToString()
                CustDOBLbl.Text = dr(4).ToString()
                CustPhnLbl.Text = dr(5).ToString()
                CustPmtMetLbl.Text = dr(6).ToString()
                CustCommLbl.Text = dr(7).ToString()
                CustNameLbl.Visible = True
                CustEmlLbl.Visible = True
                CustSpndsLbl.Visible = True
                CustDOBLbl.Visible = True
                CustPhnLbl.Visible = True
                CustPmtMetLbl.Visible = True
                CustCommLbl.Visible = True
            Next
            Con.Close()
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FetchCustomerData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub

    Private Sub PrintDocument4_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument4.PrintPage
        e.Graphics.DrawString("ArtWork Gallery Management System", New Font("Century Gothic", 25), Brushes.MediumVioletRed, 100, 40)
        e.Graphics.DrawString("***CUSTOMERINFOSUMMARY***", New Font("Arial ", 20), Brushes.PaleVioletRed, 250, 100)
        e.Graphics.DrawString("Name:      " + CustNameLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 205)
        e.Graphics.DrawString("Email:     " + CustEmlLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 264)
        e.Graphics.DrawString("Spendings:      " + CustSpndsLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 325)
        e.Graphics.DrawString("Preferred Payment Method:     " + CustPmtMetLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 385)
        e.Graphics.DrawString("Phone Number:      " + CustPhnLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 445)
        e.Graphics.DrawString("Preferred Communication:     " + CustCommLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 505)
        e.Graphics.DrawString("DOB:      " + CustDOBLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 120, 600)

        e.Graphics.DrawString("===============Thank You For Your Services===============", New Font("Cetury Gothic", 15), Brushes.MediumVioletRed, 120, 800)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog4.Show()
    End Sub
End Class