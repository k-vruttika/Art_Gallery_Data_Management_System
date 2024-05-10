<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArtistDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArtistDetails))
        Panel1 = New Panel()
        AtPhnLbl = New Label()
        AtStlLbl = New Label()
        AtDobLbl = New Label()
        AtStatLbl = New Label()
        AtGendLbl = New Label()
        AtEmailLbl = New Label()
        AtNameLbl = New Label()
        Button2 = New Button()
        AtIdTb = New TextBox()
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
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        PrintDocument2 = New Printing.PrintDocument()
        PrintPreviewDialog2 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(AtPhnLbl)
        Panel1.Controls.Add(AtStlLbl)
        Panel1.Controls.Add(AtDobLbl)
        Panel1.Controls.Add(AtStatLbl)
        Panel1.Controls.Add(AtGendLbl)
        Panel1.Controls.Add(AtEmailLbl)
        Panel1.Controls.Add(AtNameLbl)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(AtIdTb)
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
        Panel1.Location = New Point(0, 111)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1281, 562)
        Panel1.TabIndex = 2
        ' 
        ' AtPhnLbl
        ' 
        AtPhnLbl.AutoSize = True
        AtPhnLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AtPhnLbl.ForeColor = Color.IndianRed
        AtPhnLbl.Location = New Point(964, 134)
        AtPhnLbl.Name = "AtPhnLbl"
        AtPhnLbl.Size = New Size(208, 23)
        AtPhnLbl.TabIndex = 35
        AtPhnLbl.Text = "Artist Phone Number"
        AtPhnLbl.Visible = False
        ' 
        ' AtStlLbl
        ' 
        AtStlLbl.AutoSize = True
        AtStlLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AtStlLbl.ForeColor = Color.IndianRed
        AtStlLbl.Location = New Point(964, 216)
        AtStlLbl.Name = "AtStlLbl"
        AtStlLbl.Size = New Size(109, 23)
        AtStlLbl.TabIndex = 34
        AtStlLbl.Text = "Artist Style"
        AtStlLbl.Visible = False
        ' 
        ' AtDobLbl
        ' 
        AtDobLbl.AutoSize = True
        AtDobLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AtDobLbl.ForeColor = Color.IndianRed
        AtDobLbl.Location = New Point(964, 299)
        AtDobLbl.Name = "AtDobLbl"
        AtDobLbl.Size = New Size(128, 23)
        AtDobLbl.TabIndex = 33
        AtDobLbl.Text = "Date of Birth"
        AtDobLbl.Visible = False
        ' 
        ' AtStatLbl
        ' 
        AtStatLbl.AutoSize = True
        AtStatLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AtStatLbl.ForeColor = Color.IndianRed
        AtStatLbl.Location = New Point(361, 386)
        AtStatLbl.Name = "AtStatLbl"
        AtStatLbl.Size = New Size(198, 23)
        AtStatLbl.TabIndex = 32
        AtStatLbl.Text = "Artist Activity Status"
        AtStatLbl.Visible = False
        ' 
        ' AtGendLbl
        ' 
        AtGendLbl.AutoSize = True
        AtGendLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AtGendLbl.ForeColor = Color.IndianRed
        AtGendLbl.Location = New Point(361, 299)
        AtGendLbl.Name = "AtGendLbl"
        AtGendLbl.Size = New Size(137, 23)
        AtGendLbl.TabIndex = 31
        AtGendLbl.Text = "Artist Gender"
        AtGendLbl.Visible = False
        ' 
        ' AtEmailLbl
        ' 
        AtEmailLbl.AutoSize = True
        AtEmailLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AtEmailLbl.ForeColor = Color.IndianRed
        AtEmailLbl.Location = New Point(361, 216)
        AtEmailLbl.Name = "AtEmailLbl"
        AtEmailLbl.Size = New Size(115, 23)
        AtEmailLbl.TabIndex = 30
        AtEmailLbl.Text = "Artist Email"
        AtEmailLbl.Visible = False
        ' 
        ' AtNameLbl
        ' 
        AtNameLbl.AutoSize = True
        AtNameLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AtNameLbl.ForeColor = Color.IndianRed
        AtNameLbl.Location = New Point(361, 134)
        AtNameLbl.Name = "AtNameLbl"
        AtNameLbl.Size = New Size(123, 23)
        AtNameLbl.TabIndex = 29
        AtNameLbl.Text = "Artist Name"
        AtNameLbl.Visible = False
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
        ' AtIdTb
        ' 
        AtIdTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AtIdTb.Location = New Point(462, 18)
        AtIdTb.Name = "AtIdTb"
        AtIdTb.Size = New Size(252, 37)
        AtIdTb.TabIndex = 27
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(374, 25)
        Label9.Name = "Label9"
        Label9.Size = New Size(82, 23)
        Label9.TabIndex = 26
        Label9.Text = "Artist Id"
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
        Label8.Size = New Size(128, 23)
        Label8.TabIndex = 20
        Label8.Text = "Date of Birth"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(725, 216)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 23)
        Label7.TabIndex = 19
        Label7.Text = "Art Style"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(134, 386)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 23)
        Label6.TabIndex = 17
        Label6.Text = "Activity Status"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(134, 299)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 23)
        Label5.TabIndex = 15
        Label5.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(725, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 23)
        Label4.TabIndex = 13
        Label4.Text = "Phone Number"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(134, 216)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 23)
        Label1.TabIndex = 11
        Label1.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(134, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 23)
        Label3.TabIndex = 9
        Label3.Text = "Name"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(48, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(134, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(247, 38)
        Label2.TabIndex = 10
        Label2.Text = "Manage Artists"
        ' 
        ' PrintDocument2
        ' 
        ' 
        ' PrintPreviewDialog2
        ' 
        PrintPreviewDialog2.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog2.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog2.ClientSize = New Size(400, 300)
        PrintPreviewDialog2.Document = PrintDocument2
        PrintPreviewDialog2.Enabled = True
        PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), Icon)
        PrintPreviewDialog2.Name = "PrintPreviewDialog1"
        PrintPreviewDialog2.Visible = False
        ' 
        ' ArtistDetails
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleVioletRed
        ClientSize = New Size(1281, 713)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ArtistDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ArtistDetails"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents AtPhnLbl As Label
    Friend WithEvents AtStlLbl As Label
    Friend WithEvents AtDobLbl As Label
    Friend WithEvents AtStatLbl As Label
    Friend WithEvents AtGendLbl As Label
    Friend WithEvents AtEmailLbl As Label
    Friend WithEvents AtNameLbl As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents AtIdTb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
End Class
