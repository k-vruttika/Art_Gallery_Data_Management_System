Imports System.Data.SqlClient
Public Class Customer
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vruttika2004\OneDrive\Documents\ArtGallery.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Private Sub Populate()
        Con.Open()
        Dim sql = "select * from CustomerTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        CustomerDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Con.Open()
        Dim Query As String
        Query = "insert into CustomerTbl values('" + CstNameTb.Text + "','" + CstEmailTb.Text + "','" + CstSpntTb.Text + "','" + CstDOB.Value.ToString("yyyy-MM-dd") + "','" + CstPhnTb.Text + "','" + CstPmtMetCb.SelectedItem.ToString() + "','" + CstCommCb.SelectedItem.ToString() + "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Customer Information Added")
        Con.Close()
        Populate()
    End Sub
    Dim key = 0
    Private Sub Clear()
        CstNameTb.Clear()
        CstSpntTb.Text = ""
        CstCommCb.Text = ""
        CstEmailTb.Text = ""
        key = 0
        CstPmtMetCb.Text = ""
        CstPhnTb.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Select the Customer to Delete")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "Delete from CustomerTbl where CustId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Information Deleted Successfully!")
                Con.Close()
                Populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CustomerDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CustomerDGV.CellMouseClick
        Dim row As DataGridViewRow = CustomerDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        CstNameTb.Text = row.Cells(1).Value.ToString()
        CstEmailTb.Text = row.Cells(2).Value.ToString()
        CstSpntTb.Text = row.Cells(3).Value.ToString()
        CstDOB.Value = row.Cells(4).Value.ToString()
        CstPhnTb.Text = row.Cells(5).Value.ToString()
        CstPmtMetCb.Text = row.Cells(6).Value.ToString()
        CstCommCb.Text = row.Cells(7).Value.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CstNameTb.Text = "" Or CstPhnTb.Text = "" Or CstEmailTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim Query As String
            Query = "Update CustomerTbl set CustName='" & CstNameTb.Text & "', CustEmail='" & CstEmailTb.Text & "' , CustSpendings='" & CstSpntTb.Text & "', CustDob= '" & CstDOB.Value.ToString("yyyy-MM-dd") & "', CustPhone= '" & CstPhnTb.Text & "', CustPymtMethod= '" & CstPmtMetCb.SelectedItem.ToString() & "', CustComm= '" & CstCommCb.SelectedItem.ToString() & "' where CustId= " & key & ""
            Dim cmd As New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Customer Information Updated")
            Con.Close()
            Populate()
            Clear()
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub
End Class