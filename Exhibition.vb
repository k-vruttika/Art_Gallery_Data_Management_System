Imports System.Data.SqlClient
Public Class Exhibition
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vruttika2004\OneDrive\Documents\ArtGallery.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Exhibition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    Private Sub Populate()
        Con.Open()
        Dim sql = "select * from ExhibitionTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ExbDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Con.Open()
        Dim Query As String
        Query = "insert into ExhibitionTbl values('" + ExbNameTb.Text + "','" + ExbTktPrcTb.Text + "','" + ExbStatCb.SelectedItem.ToString() + "','" + ExbEndDate.Value.ToString("yyyy-MM-dd") + "','" + ExbVstrTb.Text + "','" + ExbStrtDate.Value.ToString("yyyy-MM-dd") + "','" + ExbStatCb.SelectedItem.ToString() + "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Exhibition Added")
        Con.Close()
        Populate()
    End Sub
    Dim key = 0

    Private Sub Clear()
        ExbNameTb.Clear()
        ExbTypCb.Text = ""
        ExbStatCb.Text = ""
        ExbTktPrcTb.Text = ""
        key = 0
        ExbStrtDate.Text = ""
        ExbVstrTb.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Select the Exhibition to Delete")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "Delete from ExhibitionTbl where ExbId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Exhibition Deleted Successfully")
                Con.Close()
                Populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ExbDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ExbDGV.CellMouseClick
        Dim row As DataGridViewRow = ExbDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        ExbNameTb.Text = row.Cells(1).Value.ToString()
        ExbTktPrcTb.Text = row.Cells(2).Value.ToString()
        ExbTypCb.Text = row.Cells(3).Value.ToString()
        ExbEndDate.Value = row.Cells(4).Value.ToString()
        ExbVstrTb.Text = row.Cells(5).Value.ToString()
        ExbStrtDate.Text = row.Cells(6).Value.ToString()
        ExbStatCb.Text = row.Cells(7).Value.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ExbNameTb.Text = "" Or ExbVstrTb.Text = "" Or ExbTktPrcTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim Query As String
            Query = "Update ExhibitionTbl set ExbName='" & ExbNameTb.Text & "', ExbTktPrice='" & ExbTktPrcTb.Text & "' , ExbType='" & ExbTypCb.SelectedItem.ToString() & "', ExbEndDate= '" & ExbEndDate.Value.ToString("yyyy-MM-dd") & "', ExbVstrCount= '" & ExbVstrTb.Text & "', ExbSrtDate= '" & ExbStrtDate.Value.ToString("yyyy-MM-dd") & "', ExbStat= '" & ExbStatCb.SelectedItem.ToString() & "' where ExbId= " & key & ""
            Dim cmd As New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Exhibition Updated")
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