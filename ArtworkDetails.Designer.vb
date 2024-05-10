<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArtworkDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArtworkDetails))
        Panel1 = New Panel()
        AwkCdLbl = New Label()
        AwkEraLbl = New Label()
        AwkDOALbl = New Label()
        AwkAmtLbl = New Label()
        AwkAvailLbl = New Label()
        AwkAtstLbl = New Label()
        AwkNameLbl = New Label()
        Button2 = New Button()
        AwkIdTb = New TextBox()
        Label9 = New Label()
        Button4 = New Button()
        Button1 = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(AwkCdLbl)
        Panel1.Controls.Add(AwkEraLbl)
        Panel1.Controls.Add(AwkDOALbl)
        Panel1.Controls.Add(AwkAmtLbl)
        Panel1.Controls.Add(AwkAvailLbl)
        Panel1.Controls.Add(AwkAtstLbl)
        Panel1.Controls.Add(AwkNameLbl)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(AwkIdTb)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(0, 105)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1281, 565)
        Panel1.TabIndex = 1
        ' 
        ' AwkCdLbl
        ' 
        AwkCdLbl.AutoSize = True
        AwkCdLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AwkCdLbl.ForeColor = Color.IndianRed
        AwkCdLbl.Location = New Point(964, 134)
        AwkCdLbl.Name = "AwkCdLbl"
        AwkCdLbl.Size = New Size(145, 23)
        AwkCdLbl.TabIndex = 35
        AwkCdLbl.Text = "Artwork Code"
        AwkCdLbl.Visible = False
        ' 
        ' AwkEraLbl
        ' 
        AwkEraLbl.AutoSize = True
        AwkEraLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AwkEraLbl.ForeColor = Color.IndianRed
        AwkEraLbl.Location = New Point(964, 216)
        AwkEraLbl.Name = "AwkEraLbl"
        AwkEraLbl.Size = New Size(119, 23)
        AwkEraLbl.TabIndex = 34
        AwkEraLbl.Text = "Artwork Era"
        AwkEraLbl.Visible = False
        ' 
        ' AwkDOALbl
        ' 
        AwkDOALbl.AutoSize = True
        AwkDOALbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AwkDOALbl.ForeColor = Color.IndianRed
        AwkDOALbl.Location = New Point(964, 299)
        AwkDOALbl.Name = "AwkDOALbl"
        AwkDOALbl.Size = New Size(195, 23)
        AwkDOALbl.TabIndex = 33
        AwkDOALbl.Text = "Date of Acquisition"
        AwkDOALbl.Visible = False
        ' 
        ' AwkAmtLbl
        ' 
        AwkAmtLbl.AutoSize = True
        AwkAmtLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AwkAmtLbl.ForeColor = Color.IndianRed
        AwkAmtLbl.Location = New Point(361, 386)
        AwkAmtLbl.Name = "AwkAmtLbl"
        AwkAmtLbl.Size = New Size(138, 23)
        AwkAmtLbl.TabIndex = 32
        AwkAmtLbl.Text = "Artwork Price"
        AwkAmtLbl.Visible = False
        ' 
        ' AwkAvailLbl
        ' 
        AwkAvailLbl.AutoSize = True
        AwkAvailLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AwkAvailLbl.ForeColor = Color.IndianRed
        AwkAvailLbl.Location = New Point(361, 299)
        AwkAvailLbl.Name = "AwkAvailLbl"
        AwkAvailLbl.Size = New Size(198, 23)
        AwkAvailLbl.TabIndex = 31
        AwkAvailLbl.Text = "Artwork Availability"
        AwkAvailLbl.Visible = False
        ' 
        ' AwkAtstLbl
        ' 
        AwkAtstLbl.AutoSize = True
        AwkAtstLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AwkAtstLbl.ForeColor = Color.IndianRed
        AwkAtstLbl.Location = New Point(361, 216)
        AwkAtstLbl.Name = "AwkAtstLbl"
        AwkAtstLbl.Size = New Size(123, 23)
        AwkAtstLbl.TabIndex = 30
        AwkAtstLbl.Text = "Artist Name"
        AwkAtstLbl.Visible = False
        ' 
        ' AwkNameLbl
        ' 
        AwkNameLbl.AutoSize = True
        AwkNameLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AwkNameLbl.ForeColor = Color.IndianRed
        AwkNameLbl.Location = New Point(361, 134)
        AwkNameLbl.Name = "AwkNameLbl"
        AwkNameLbl.Size = New Size(150, 23)
        AwkNameLbl.TabIndex = 29
        AwkNameLbl.Text = "Artwork Name"
        AwkNameLbl.Visible = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.PaleVioletRed
        Button2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(734, 14)
        Button2.Name = "Button2"
        Button2.Size = New Size(139, 46)
        Button2.TabIndex = 28
        Button2.Text = "Fetch Data"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' AwkIdTb
        ' 
        AwkIdTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AwkIdTb.Location = New Point(476, 18)
        AwkIdTb.Name = "AwkIdTb"
        AwkIdTb.Size = New Size(252, 37)
        AwkIdTb.TabIndex = 27
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(361, 32)
        Label9.Name = "Label9"
        Label9.Size = New Size(109, 23)
        Label9.TabIndex = 26
        Label9.Text = "Artwork Id"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.PaleVioletRed
        Button4.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(688, 472)
        Button4.Name = "Button4"
        Button4.Size = New Size(179, 52)
        Button4.TabIndex = 25
        Button4.Text = "HOME"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.PaleVioletRed
        Button1.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(405, 472)
        Button1.Name = "Button1"
        Button1.Size = New Size(179, 52)
        Button1.TabIndex = 22
        Button1.Text = "PRINT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(725, 299)
        Label8.Name = "Label8"
        Label8.Size = New Size(195, 23)
        Label8.TabIndex = 20
        Label8.Text = "Date of Acquisition"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(725, 216)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 23)
        Label7.TabIndex = 19
        Label7.Text = "Artwork Era"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(134, 386)
        Label6.Name = "Label6"
        Label6.Size = New Size(138, 23)
        Label6.TabIndex = 17
        Label6.Text = "Artwork Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(134, 299)
        Label5.Name = "Label5"
        Label5.Size = New Size(198, 23)
        Label5.TabIndex = 15
        Label5.Text = "Artwork Availability"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(725, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 23)
        Label4.TabIndex = 13
        Label4.Text = "Artwork Code"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(134, 216)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 23)
        Label1.TabIndex = 11
        Label1.Text = "Artist Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(134, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 23)
        Label3.TabIndex = 9
        Label3.Text = "Artwork Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(134, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(235, 38)
        Label2.TabIndex = 9
        Label2.Text = "View Artworks"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(48, 19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' ArtworkDetails
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleVioletRed
        ClientSize = New Size(1281, 713)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        ForeColor = SystemColors.ControlDark
        FormBorderStyle = FormBorderStyle.None
        Name = "ArtworkDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ArtworkDetails"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents AwkIdTb As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents AwkAtstLbl As Label
    Friend WithEvents AwkNameLbl As Label
    Friend WithEvents AwkCdLbl As Label
    Friend WithEvents AwkEraLbl As Label
    Friend WithEvents AwkDOALbl As Label
    Friend WithEvents AwkAmtLbl As Label
    Friend WithEvents AwkAvailLbl As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
