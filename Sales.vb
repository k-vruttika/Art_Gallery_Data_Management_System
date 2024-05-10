Imports System.Data.SqlClient
Public Class Sales
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vruttika2004\OneDrive\Documents\ArtGallery.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    Private Sub Populate()
        Con.Open()
        Dim sql = "select * from SalesTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        SalesDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Con.Open()
        Dim Query As String
        Query = "insert into SalesTbl values('" + SlSoldTb.Text + "','" + SlCustNmTb.Text + "','" + SlAmtTb.Text + "','" + SlDOB.Value.ToString("yyyy-MM-dd") + "','" + SlTransIdTb.Text + "','" + SlDelStatCb.SelectedItem.ToString() + "','" + SlPymtMthdCb.SelectedItem.ToString() + "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Transaction Added")
        Con.Close()
        Populate()
    End Sub
    Dim key = 0
    Private Sub Clear()
        SlSoldTb.Clear()
        SlAmtTb.Text = ""
        SlPymtMthdCb.Text = ""
        SlCustNmTb.Text = ""
        key = 0
        SlDelStatCb.Text = ""
        SlTransIdTb.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Select the Transaction to Delete")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "Delete from SalesTbl where SaleId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Transaction Deleted Successfully")
                Con.Close()
                Populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SalesDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SalesDGV.CellMouseClick
        Dim row As DataGridViewRow = SalesDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        SlSoldTb.Text = row.Cells(1).Value.ToString()
        SlCustNmTb.Text = row.Cells(2).Value.ToString()
        SlAmtTb.Text = row.Cells(3).Value.ToString()
        SlDOB.Value = row.Cells(4).Value.ToString()
        SlTransIdTb.Text = row.Cells(5).Value.ToString()
        SlDelStatCb.Text = row.Cells(6).Value.ToString()
        SlPymtMthdCb.Text = row.Cells(7).Value.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If SlSoldTb.Text = "" Or SlTransIdTb.Text = "" Or SlCustNmTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim Query As String
            Query = "Update SalesTbl set SlSold='" & SlSoldTb.Text & "', SlCustName='" & SlCustNmTb.Text & "' , SlAmt='" & SlAmtTb.Text & "', SlCustDob= '" & SlDOB.Value.ToString("yyyy-MM-dd") & "', SlTransId= '" & SlTransIdTb.Text & "', SlDelivStat= '" & SlDelStatCb.SelectedItem.ToString() & "', SlPymtMethod= '" & SlPymtMthdCb.SelectedItem.ToString() & "' where SaleId= " & key & ""
            Dim cmd As New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Transaction Updated")
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