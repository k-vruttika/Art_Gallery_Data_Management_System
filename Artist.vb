Imports System.Data.SqlClient
Public Class Artist
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vruttika2004\OneDrive\Documents\ArtGallery.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Artist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    Private Sub Populate()
        Con.Open()
        Dim sql = "select * from ArtistTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ArtistDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Con.Open()
        Dim Query As String
        Query = "insert into ArtistTbl values('" + AtNameTb.Text + "','" + AtEmailTb.Text + "','" + AtStatCb.Text + "','" + AtDOB.Value.ToString("yyyy-MM-dd") + "','" + AtPhnTb.Text + "','" + AtStylCb.SelectedItem.ToString() + "','" + AtGendCb.SelectedItem.ToString() + "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Artist Added")
        Con.Close()
        Populate()
    End Sub
    Dim key = 0
    Private Sub Clear()
        AtNameTb.Clear()
        AtStatCb.Text = ""
        AtGendCb.Text = ""
        AtEmailTb.Text = ""
        key = 0
        AtStylCb.Text = ""
        AtPhnTb.Text = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Select the Artist to Delete")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "Delete from ArtistTbl where AtId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Artist Deleted Successfully")
                Con.Close()
                Populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub ArtistDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ArtistDGV.CellMouseClick
        Dim row As DataGridViewRow = ArtistDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        AtNameTb.Text = row.Cells(1).Value.ToString()
        AtEmailTb.Text = row.Cells(2).Value.ToString()
        AtStatCb.Text = row.Cells(3).Value.ToString()
        AtDOB.Value = row.Cells(4).Value.ToString()
        AtPhnTb.Text = row.Cells(5).Value.ToString()
        AtStylCb.Text = row.Cells(6).Value.ToString()
        AtGendCb.Text = row.Cells(7).Value.ToString()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If AtNameTb.Text = "" Or AtPhnTb.Text = "" Or AtEmailTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim Query As String
            Query = "Update ArtistTbl set AtName='" & AtNameTb.Text & "', AtEmail='" & AtEmailTb.Text & "' , AtStatus='" & AtStatCb.SelectedItem.ToString() & "', AtDob= '" & AtDOB.Value.ToString("yyyy-MM-dd") & "', AtPhone= '" & AtPhnTb.Text & "', AtStyle= '" & AtStylCb.SelectedItem.ToString() & "', AtGend= '" & AtGendCb.SelectedItem.ToString() & "' where AtId= " & key & ""
            Dim cmd As New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Artist Updated")
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