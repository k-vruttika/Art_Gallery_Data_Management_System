<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Artwork
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Artwork))
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label9 = New Label()
        AwkNameTb = New TextBox()
        Label3 = New Label()
        AwkAtst = New TextBox()
        Label1 = New Label()
        AwkCodeTb = New TextBox()
        Label4 = New Label()
        AwkAvail = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        AwkEraCb = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        AwkDOA = New DateTimePicker()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        ArtworkDGV = New DataGridView()
        AmtTb = New TextBox()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ArtworkDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(40, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(123, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(290, 38)
        Label2.TabIndex = 7
        Label2.Text = "Manage Artworks"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(1212, 12)
        Label9.Name = "Label9"
        Label9.Size = New Size(34, 34)
        Label9.TabIndex = 8
        Label9.Text = "X"
        ' 
        ' AwkNameTb
        ' 
        AwkNameTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AwkNameTb.Location = New Point(43, 74)
        AwkNameTb.Name = "AwkNameTb"
        AwkNameTb.Size = New Size(215, 37)
        AwkNameTb.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(77, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 23)
        Label3.TabIndex = 9
        Label3.Text = "Artwork Name"
        ' 
        ' AwkAtst
        ' 
        AwkAtst.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AwkAtst.Location = New Point(283, 74)
        AwkAtst.Name = "AwkAtst"
        AwkAtst.Size = New Size(215, 37)
        AwkAtst.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(328, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 23)
        Label1.TabIndex = 11
        Label1.Text = "Artist Name"
        ' 
        ' AwkCodeTb
        ' 
        AwkCodeTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AwkCodeTb.Location = New Point(1005, 74)
        AwkCodeTb.Name = "AwkCodeTb"
        AwkCodeTb.Size = New Size(220, 37)
        AwkCodeTb.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(1044, 48)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 23)
        Label4.TabIndex = 13
        Label4.Text = "Artwork Code"
        ' 
        ' AwkAvail
        ' 
        AwkAvail.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AwkAvail.FormattingEnabled = True
        AwkAvail.Items.AddRange(New Object() {"Available", "Sold Out", "In Transit"})
        AwkAvail.Location = New Point(523, 74)
        AwkAvail.Name = "AwkAvail"
        AwkAvail.Size = New Size(220, 37)
        AwkAvail.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.WhiteSmoke
        Label5.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(528, 48)
        Label5.Name = "Label5"
        Label5.Size = New Size(198, 23)
        Label5.TabIndex = 15
        Label5.Text = "Artwork Availability"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.WhiteSmoke
        Label6.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(814, 48)
        Label6.Name = "Label6"
        Label6.Size = New Size(138, 23)
        Label6.TabIndex = 17
        Label6.Text = "Artwork Price"
        ' 
        ' AwkEraCb
        ' 
        AwkEraCb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AwkEraCb.FormattingEnabled = True
        AwkEraCb.Items.AddRange(New Object() {"Ancient Art", "Medieval Art", "Renaissance", "Baroque", "Rococo", "Neoclassicism", "Romanticism", "Realism", "Impressionism", "Post-Impressionism"})
        AwkEraCb.Location = New Point(112, 151)
        AwkEraCb.Name = "AwkEraCb"
        AwkEraCb.Size = New Size(215, 37)
        AwkEraCb.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.WhiteSmoke
        Label7.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(161, 125)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 23)
        Label7.TabIndex = 19
        Label7.Text = "Artwork Era"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.WhiteSmoke
        Label8.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(376, 125)
        Label8.Name = "Label8"
        Label8.Size = New Size(195, 23)
        Label8.TabIndex = 20
        Label8.Text = "Date of Acquisition"
        ' 
        ' AwkDOA
        ' 
        AwkDOA.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AwkDOA.Location = New Point(354, 151)
        AwkDOA.Name = "AwkDOA"
        AwkDOA.Size = New Size(245, 37)
        AwkDOA.TabIndex = 21
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.RosyBrown
        Button1.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(631, 142)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 46)
        Button1.TabIndex = 22
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.RosyBrown
        Button2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(749, 142)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 46)
        Button2.TabIndex = 23
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.RosyBrown
        Button3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(867, 142)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 46)
        Button3.TabIndex = 24
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.IndianRed
        Button4.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(985, 136)
        Button4.Name = "Button4"
        Button4.Size = New Size(179, 52)
        Button4.TabIndex = 25
        Button4.Text = "HOME"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' ArtworkDGV
        ' 
        ArtworkDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ArtworkDGV.Location = New Point(30, 232)
        ArtworkDGV.Name = "ArtworkDGV"
        ArtworkDGV.RowHeadersWidth = 62
        ArtworkDGV.Size = New Size(1224, 301)
        ArtworkDGV.TabIndex = 26
        ' 
        ' AmtTb
        ' 
        AmtTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AmtTb.Location = New Point(769, 74)
        AmtTb.Name = "AmtTb"
        AmtTb.Size = New Size(215, 37)
        AmtTb.TabIndex = 27
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(AmtTb)
        Panel1.Controls.Add(ArtworkDGV)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(AwkDOA)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(AwkEraCb)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(AwkAvail)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(AwkCodeTb)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(AwkAtst)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(AwkNameTb)
        Panel1.Location = New Point(1, 109)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1278, 592)
        Panel1.TabIndex = 0
        ' 
        ' Artwork
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        ClientSize = New Size(1281, 713)
        Controls.Add(Label9)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Artwork"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Artwork"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ArtworkDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents AwkNameTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AwkAtst As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AwkCodeTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AwkAvail As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents AwkEraCb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents AwkDOA As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ArtworkDGV As DataGridView
    Friend WithEvents AmtTb As TextBox
    Friend WithEvents Panel1 As Panel
End Class
