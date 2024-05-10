<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Artist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Artist))
        Panel1 = New Panel()
        ArtistDGV = New DataGridView()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        AtDOB = New DateTimePicker()
        Label8 = New Label()
        Label7 = New Label()
        AtStylCb = New ComboBox()
        AtPhnTb = New TextBox()
        Label6 = New Label()
        Label4 = New Label()
        AtStatCb = New ComboBox()
        Label5 = New Label()
        AtGendCb = New ComboBox()
        AtEmailTb = New TextBox()
        Label3 = New Label()
        AtNameTb = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label9 = New Label()
        Panel1.SuspendLayout()
        CType(ArtistDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(ArtistDGV)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(AtDOB)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(AtStylCb)
        Panel1.Controls.Add(AtPhnTb)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(AtStatCb)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(AtGendCb)
        Panel1.Controls.Add(AtEmailTb)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(AtNameTb)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(4, 107)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1272, 594)
        Panel1.TabIndex = 0
        ' 
        ' ArtistDGV
        ' 
        ArtistDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ArtistDGV.Location = New Point(21, 252)
        ArtistDGV.Name = "ArtistDGV"
        ArtistDGV.RowHeadersWidth = 62
        ArtistDGV.Size = New Size(1231, 299)
        ArtistDGV.TabIndex = 30
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Tan
        Button4.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(1002, 135)
        Button4.Name = "Button4"
        Button4.Size = New Size(179, 52)
        Button4.TabIndex = 29
        Button4.Text = "HOME"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.RosyBrown
        Button3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(874, 141)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 46)
        Button3.TabIndex = 28
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.RosyBrown
        Button2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(756, 141)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 46)
        Button2.TabIndex = 27
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.RosyBrown
        Button1.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(638, 141)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 46)
        Button1.TabIndex = 26
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' AtDOB
        ' 
        AtDOB.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AtDOB.Location = New Point(357, 150)
        AtDOB.Name = "AtDOB"
        AtDOB.Size = New Size(245, 37)
        AtDOB.TabIndex = 25
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(406, 124)
        Label8.Name = "Label8"
        Label8.Size = New Size(128, 23)
        Label8.TabIndex = 24
        Label8.Text = "Date of Birth"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(169, 124)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 23)
        Label7.TabIndex = 23
        Label7.Text = "Art Style"
        ' 
        ' AtStylCb
        ' 
        AtStylCb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AtStylCb.FormattingEnabled = True
        AtStylCb.Items.AddRange(New Object() {"Ancient Art", "Medieval Art", "Renaissance", "Baroque", "Rococo", "Neoclassicism", "Romanticism", "Realism", "Impressionism", "Post-Impressionism"})
        AtStylCb.Location = New Point(105, 150)
        AtStylCb.Name = "AtStylCb"
        AtStylCb.Size = New Size(220, 37)
        AtStylCb.TabIndex = 22
        ' 
        ' AtPhnTb
        ' 
        AtPhnTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AtPhnTb.Location = New Point(1028, 68)
        AtPhnTb.Name = "AtPhnTb"
        AtPhnTb.Size = New Size(215, 37)
        AtPhnTb.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(1061, 42)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 23)
        Label6.TabIndex = 20
        Label6.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(821, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 23)
        Label4.TabIndex = 19
        Label4.Text = "Activity Status"
        ' 
        ' AtStatCb
        ' 
        AtStatCb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AtStatCb.FormattingEnabled = True
        AtStatCb.Items.AddRange(New Object() {"Active", "Inactive"})
        AtStatCb.Location = New Point(785, 68)
        AtStatCb.Name = "AtStatCb"
        AtStatCb.Size = New Size(220, 37)
        AtStatCb.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(594, 42)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 23)
        Label5.TabIndex = 17
        Label5.Text = "Gender"
        ' 
        ' AtGendCb
        ' 
        AtGendCb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AtGendCb.FormattingEnabled = True
        AtGendCb.Items.AddRange(New Object() {"Female", "Male"})
        AtGendCb.Location = New Point(530, 68)
        AtGendCb.Name = "AtGendCb"
        AtGendCb.Size = New Size(220, 37)
        AtGendCb.TabIndex = 16
        ' 
        ' AtEmailTb
        ' 
        AtEmailTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AtEmailTb.Location = New Point(282, 68)
        AtEmailTb.Name = "AtEmailTb"
        AtEmailTb.Size = New Size(215, 37)
        AtEmailTb.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(354, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 23)
        Label3.TabIndex = 14
        Label3.Text = "Email"
        ' 
        ' AtNameTb
        ' 
        AtNameTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AtNameTb.Location = New Point(38, 68)
        AtNameTb.Name = "AtNameTb"
        AtNameTb.Size = New Size(215, 37)
        AtNameTb.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(105, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 23)
        Label1.TabIndex = 12
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(121, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(247, 38)
        Label2.TabIndex = 8
        Label2.Text = "Manage Artists"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(38, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(77, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(1222, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(34, 34)
        Label9.TabIndex = 10
        Label9.Text = "X"
        ' 
        ' Artist
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        ClientSize = New Size(1281, 713)
        Controls.Add(Label9)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Artist"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Artist"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ArtistDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AtNameTb As TextBox
    Friend WithEvents AtEmailTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AtStatCb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AtGendCb As ComboBox
    Friend WithEvents AtPhnTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents AtStylCb As ComboBox
    Friend WithEvents AtDOB As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ArtistDGV As DataGridView
    Friend WithEvents Label9 As Label
End Class
