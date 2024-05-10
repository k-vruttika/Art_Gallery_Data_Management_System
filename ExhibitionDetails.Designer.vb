<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExhibitionDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExhibitionDetails))
        Panel1 = New Panel()
        ExbVstrLbl = New Label()
        ExbStrtDtLbl = New Label()
        ExbEndDtLbl = New Label()
        ExbTypLbl = New Label()
        ExbStatLbl = New Label()
        ExbTktLbl = New Label()
        ExbNameLbl = New Label()
        Button2 = New Button()
        ExbIdTb = New TextBox()
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
        PrintDocument3 = New Printing.PrintDocument()
        PrintPreviewDialog3 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(ExbVstrLbl)
        Panel1.Controls.Add(ExbStrtDtLbl)
        Panel1.Controls.Add(ExbEndDtLbl)
        Panel1.Controls.Add(ExbTypLbl)
        Panel1.Controls.Add(ExbStatLbl)
        Panel1.Controls.Add(ExbTktLbl)
        Panel1.Controls.Add(ExbNameLbl)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(ExbIdTb)
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
        Panel1.Location = New Point(0, 104)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1281, 568)
        Panel1.TabIndex = 2
        ' 
        ' ExbVstrLbl
        ' 
        ExbVstrLbl.AutoSize = True
        ExbVstrLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExbVstrLbl.ForeColor = Color.IndianRed
        ExbVstrLbl.Location = New Point(964, 134)
        ExbVstrLbl.Name = "ExbVstrLbl"
        ExbVstrLbl.Size = New Size(133, 23)
        ExbVstrLbl.TabIndex = 35
        ExbVstrLbl.Text = "Visitor Count"
        ExbVstrLbl.Visible = False
        ' 
        ' ExbStrtDtLbl
        ' 
        ExbStrtDtLbl.AutoSize = True
        ExbStrtDtLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExbStrtDtLbl.ForeColor = Color.IndianRed
        ExbStrtDtLbl.Location = New Point(964, 216)
        ExbStrtDtLbl.Name = "ExbStrtDtLbl"
        ExbStrtDtLbl.Size = New Size(103, 23)
        ExbStrtDtLbl.TabIndex = 34
        ExbStrtDtLbl.Text = "Start Date"
        ExbStrtDtLbl.Visible = False
        ' 
        ' ExbEndDtLbl
        ' 
        ExbEndDtLbl.AutoSize = True
        ExbEndDtLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExbEndDtLbl.ForeColor = Color.IndianRed
        ExbEndDtLbl.Location = New Point(964, 299)
        ExbEndDtLbl.Name = "ExbEndDtLbl"
        ExbEndDtLbl.Size = New Size(97, 23)
        ExbEndDtLbl.TabIndex = 33
        ExbEndDtLbl.Text = "End Date"
        ExbEndDtLbl.Visible = False
        ' 
        ' ExbTypLbl
        ' 
        ExbTypLbl.AutoSize = True
        ExbTypLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExbTypLbl.ForeColor = Color.IndianRed
        ExbTypLbl.Location = New Point(361, 386)
        ExbTypLbl.Name = "ExbTypLbl"
        ExbTypLbl.Size = New Size(154, 23)
        ExbTypLbl.TabIndex = 32
        ExbTypLbl.Text = "Exhibition Type"
        ExbTypLbl.Visible = False
        ' 
        ' ExbStatLbl
        ' 
        ExbStatLbl.AutoSize = True
        ExbStatLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExbStatLbl.ForeColor = Color.IndianRed
        ExbStatLbl.Location = New Point(361, 299)
        ExbStatLbl.Name = "ExbStatLbl"
        ExbStatLbl.Size = New Size(164, 23)
        ExbStatLbl.TabIndex = 31
        ExbStatLbl.Text = "Exhibition Status"
        ExbStatLbl.Visible = False
        ' 
        ' ExbTktLbl
        ' 
        ExbTktLbl.AutoSize = True
        ExbTktLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExbTktLbl.ForeColor = Color.IndianRed
        ExbTktLbl.Location = New Point(361, 216)
        ExbTktLbl.Name = "ExbTktLbl"
        ExbTktLbl.Size = New Size(121, 23)
        ExbTktLbl.TabIndex = 30
        ExbTktLbl.Text = "Ticket Price"
        ExbTktLbl.Visible = False
        ' 
        ' ExbNameLbl
        ' 
        ExbNameLbl.AutoSize = True
        ExbNameLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExbNameLbl.ForeColor = Color.IndianRed
        ExbNameLbl.Location = New Point(361, 134)
        ExbNameLbl.Name = "ExbNameLbl"
        ExbNameLbl.Size = New Size(168, 23)
        ExbNameLbl.TabIndex = 29
        ExbNameLbl.Text = "Exhibition Name"
        ExbNameLbl.Visible = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.PaleVioletRed
        Button2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(761, 28)
        Button2.Name = "Button2"
        Button2.Size = New Size(139, 46)
        Button2.TabIndex = 28
        Button2.Text = "Fetch Data"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ExbIdTb
        ' 
        ExbIdTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ExbIdTb.Location = New Point(503, 32)
        ExbIdTb.Name = "ExbIdTb"
        ExbIdTb.Size = New Size(252, 37)
        ExbIdTb.TabIndex = 27
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(370, 46)
        Label9.Name = "Label9"
        Label9.Size = New Size(127, 23)
        Label9.TabIndex = 26
        Label9.Text = "Exhibition Id"
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
        Label8.Size = New Size(97, 23)
        Label8.TabIndex = 20
        Label8.Text = "End Date"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(725, 216)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 23)
        Label7.TabIndex = 19
        Label7.Text = "Start Date"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(134, 386)
        Label6.Name = "Label6"
        Label6.Size = New Size(154, 23)
        Label6.TabIndex = 17
        Label6.Text = "Exhibition Type"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(134, 299)
        Label5.Name = "Label5"
        Label5.Size = New Size(164, 23)
        Label5.TabIndex = 15
        Label5.Text = "Exhibition Status"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(725, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 23)
        Label4.TabIndex = 13
        Label4.Text = "Visitor Count"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(134, 216)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 23)
        Label1.TabIndex = 11
        Label1.Text = "Ticket Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(134, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 23)
        Label3.TabIndex = 9
        Label3.Text = "Exhibition Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(111, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(264, 38)
        Label2.TabIndex = 10
        Label2.Text = "View Exhibitions"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(25, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' PrintDocument3
        ' 
        ' 
        ' PrintPreviewDialog3
        ' 
        PrintPreviewDialog3.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog3.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog3.ClientSize = New Size(400, 300)
        PrintPreviewDialog3.Document = PrintDocument3
        PrintPreviewDialog3.Enabled = True
        PrintPreviewDialog3.Icon = CType(resources.GetObject("PrintPreviewDialog3.Icon"), Icon)
        PrintPreviewDialog3.Name = "PrintPreviewDialog3"
        PrintPreviewDialog3.Visible = False
        ' 
        ' ExhibitionDetails
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleVioletRed
        ClientSize = New Size(1281, 713)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ExhibitionDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ExhibitionDetails"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExbVstrLbl As Label
    Friend WithEvents ExbStrtDtLbl As Label
    Friend WithEvents ExbEndDtLbl As Label
    Friend WithEvents ExbTypLbl As Label
    Friend WithEvents ExbStatLbl As Label
    Friend WithEvents ExbTktLbl As Label
    Friend WithEvents ExbNameLbl As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ExbIdTb As TextBox
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
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintDocument3 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog3 As PrintPreviewDialog
End Class
