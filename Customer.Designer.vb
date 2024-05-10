<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Panel1 = New Panel()
        CstSpntTb = New TextBox()
        CustomerDGV = New DataGridView()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        CstDOB = New DateTimePicker()
        Label8 = New Label()
        Label7 = New Label()
        CstPmtMetCb = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        CstCommCb = New ComboBox()
        Label4 = New Label()
        CstPhnTb = New TextBox()
        Label1 = New Label()
        CstEmailTb = New TextBox()
        Label3 = New Label()
        CstNameTb = New TextBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label9 = New Label()
        Panel1.SuspendLayout()
        CType(CustomerDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(CstSpntTb)
        Panel1.Controls.Add(CustomerDGV)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(CstDOB)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(CstPmtMetCb)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(CstCommCb)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(CstPhnTb)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(CstEmailTb)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(CstNameTb)
        Panel1.Location = New Point(4, 108)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1272, 593)
        Panel1.TabIndex = 1
        ' 
        ' CstSpntTb
        ' 
        CstSpntTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CstSpntTb.Location = New Point(769, 74)
        CstSpntTb.Name = "CstSpntTb"
        CstSpntTb.Size = New Size(215, 37)
        CstSpntTb.TabIndex = 27
        ' 
        ' CustomerDGV
        ' 
        CustomerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CustomerDGV.Location = New Point(25, 237)
        CustomerDGV.Name = "CustomerDGV"
        CustomerDGV.RowHeadersWidth = 62
        CustomerDGV.Size = New Size(1224, 301)
        CustomerDGV.TabIndex = 26
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Navy
        Button4.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(985, 136)
        Button4.Name = "Button4"
        Button4.Size = New Size(179, 52)
        Button4.TabIndex = 25
        Button4.Text = "HOME"
        Button4.UseVisualStyleBackColor = False
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
        ' CstDOB
        ' 
        CstDOB.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CstDOB.Location = New Point(354, 151)
        CstDOB.Name = "CstDOB"
        CstDOB.Size = New Size(245, 37)
        CstDOB.TabIndex = 21
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(415, 125)
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
        Label7.Location = New Point(79, 125)
        Label7.Name = "Label7"
        Label7.Size = New Size(270, 23)
        Label7.TabIndex = 19
        Label7.Text = "Preffered Payment Method"
        ' 
        ' CstPmtMetCb
        ' 
        CstPmtMetCb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CstPmtMetCb.FormattingEnabled = True
        CstPmtMetCb.Items.AddRange(New Object() {"Cash", "Credit Card", "Debit Card", "Net Banking", "UPI"})
        CstPmtMetCb.Location = New Point(101, 151)
        CstPmtMetCb.Name = "CstPmtMetCb"
        CstPmtMetCb.Size = New Size(215, 37)
        CstPmtMetCb.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(818, 48)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 23)
        Label6.TabIndex = 17
        Label6.Text = "Total Spent"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(504, 48)
        Label5.Name = "Label5"
        Label5.Size = New Size(261, 23)
        Label5.TabIndex = 15
        Label5.Text = "Preffered Communication"
        ' 
        ' CstCommCb
        ' 
        CstCommCb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CstCommCb.FormattingEnabled = True
        CstCommCb.Items.AddRange(New Object() {"Phone", "Email", "WhatsApp"})
        CstCommCb.Location = New Point(523, 74)
        CstCommCb.Name = "CstCommCb"
        CstCommCb.Size = New Size(220, 37)
        CstCommCb.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(1033, 48)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 23)
        Label4.TabIndex = 13
        Label4.Text = "Phone Number"
        ' 
        ' CstPhnTb
        ' 
        CstPhnTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CstPhnTb.Location = New Point(1005, 74)
        CstPhnTb.Name = "CstPhnTb"
        CstPhnTb.Size = New Size(220, 37)
        CstPhnTb.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(354, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 23)
        Label1.TabIndex = 11
        Label1.Text = "E-mail"
        ' 
        ' CstEmailTb
        ' 
        CstEmailTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CstEmailTb.Location = New Point(283, 74)
        CstEmailTb.Name = "CstEmailTb"
        CstEmailTb.Size = New Size(215, 37)
        CstEmailTb.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(67, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 23)
        Label3.TabIndex = 9
        Label3.Text = "Customer Name"
        ' 
        ' CstNameTb
        ' 
        CstNameTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CstNameTb.Location = New Point(43, 74)
        CstNameTb.Name = "CstNameTb"
        CstNameTb.Size = New Size(215, 37)
        CstNameTb.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(118, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(489, 38)
        Label2.TabIndex = 10
        Label2.Text = "Manage Customer Information"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(32, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(1235, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(34, 34)
        Label9.TabIndex = 12
        Label9.Text = "X"
        ' 
        ' Customer
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1281, 713)
        Controls.Add(Label9)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Customer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Customer"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(CustomerDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CstSpntTb As TextBox
    Friend WithEvents CustomerDGV As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CstDOB As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CstPmtMetCb As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CstCommCb As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CstPhnTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CstEmailTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CstNameTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
End Class
