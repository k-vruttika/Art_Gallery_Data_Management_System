Imports System.Data.SqlClient
Public Class Artwork
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vruttika2004\OneDrive\Documents\ArtGallery.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Artwork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    Private Sub Populate()
        Con.Open()
        Dim sql = "select * from ArtworkTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ArtworkDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Con.Open()
        Dim Query As String
        Query = "insert into ArtworkTbl values('" + AwkNameTb.Text + "','" + AwkAtst.Text + "','" + AmtTb.Text + "','" + AwkDOA.Value.ToString("yyyy-MM-dd") + "','" + AwkCodeTb.Text + "','" + AwkEraCb.SelectedItem.ToString() + "','" + AwkAvail.SelectedItem.ToString() + "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Artwork Added")
        Con.Close()
        Populate()
    End Sub
    Dim key = 0
    Private Sub Clear()
        AwkNameTb.Clear()
        AmtTb.Text = ""
        AwkAvail.Text = ""
        AwkAtst.Text = ""
        key = 0
        AwkEraCb.Text = ""
        AwkCodeTb.Text = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Select the Artwork to Delete")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "Delete from ArtworkTbl where AwkId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Artwork Deleted Successfully")
                Con.Close()
                Populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ArtworkDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ArtworkDGV.CellMouseClick
        Dim row As DataGridViewRow = ArtworkDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        AwkNameTb.Text = row.Cells(1).Value.ToString()
        AwkAtst.Text = row.Cells(2).Value.ToString()
        AmtTb.Text = row.Cells(3).Value.ToString()
        AwkDOA.Value = row.Cells(4).Value.ToString()
        AwkCodeTb.Text = row.Cells(5).Value.ToString()
        AwkEraCb.Text = row.Cells(6).Value.ToString()
        AwkAvail.Text = row.Cells(7).Value.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If AwkNameTb.Text = "" Or AwkCodeTb.Text = "" Or AwkAtst.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim Query As String
            Query = "Update ArtworkTbl set AwkName='" & AwkNameTb.Text & "', AwkAtst='" & AwkAtst.Text & "' , AwkAmt='" & AmtTb.Text & "', AwkDoa= '" & AwkDOA.Value.ToString("yyyy-MM-dd") & "', AwkCode= '" & AwkCodeTb.Text & "', AwkEra= '" & AwkEraCb.SelectedItem.ToString() & "', AwkAvail= '" & AwkAvail.SelectedItem.ToString() & "' where AwkId= " & key & ""
            Dim cmd As New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Artwork Updated")
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