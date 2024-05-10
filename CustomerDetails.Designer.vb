<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerDetails))
        Panel1 = New Panel()
        CustPhnLbl = New Label()
        CustPmtMetLbl = New Label()
        CustDOBLbl = New Label()
        CustSpndsLbl = New Label()
        CustCommLbl = New Label()
        CustEmlLbl = New Label()
        CustNameLbl = New Label()
        Button2 = New Button()
        CustIdTb = New TextBox()
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
        PrintDocument4 = New Printing.PrintDocument()
        PrintPreviewDialog4 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(CustPhnLbl)
        Panel1.Controls.Add(CustPmtMetLbl)
        Panel1.Controls.Add(CustDOBLbl)
        Panel1.Controls.Add(CustSpndsLbl)
        Panel1.Controls.Add(CustCommLbl)
        Panel1.Controls.Add(CustEmlLbl)
        Panel1.Controls.Add(CustNameLbl)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(CustIdTb)
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
        Panel1.Location = New Point(0, 109)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1281, 553)
        Panel1.TabIndex = 2
        ' 
        ' CustPhnLbl
        ' 
        CustPhnLbl.AutoSize = True
        CustPhnLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CustPhnLbl.ForeColor = Color.IndianRed
        CustPhnLbl.Location = New Point(987, 134)
        CustPhnLbl.Name = "CustPhnLbl"
        CustPhnLbl.Size = New Size(155, 23)
        CustPhnLbl.TabIndex = 35
        CustPhnLbl.Text = "Phone Number"
        CustPhnLbl.Visible = False
        ' 
        ' CustPmtMetLbl
        ' 
        CustPmtMetLbl.AutoSize = True
        CustPmtMetLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CustPmtMetLbl.ForeColor = Color.IndianRed
        CustPmtMetLbl.Location = New Point(987, 216)
        CustPmtMetLbl.Name = "CustPmtMetLbl"
        CustPmtMetLbl.Size = New Size(177, 23)
        CustPmtMetLbl.TabIndex = 34
        CustPmtMetLbl.Text = "Payment Method"
        CustPmtMetLbl.Visible = False
        ' 
        ' CustDOBLbl
        ' 
        CustDOBLbl.AutoSize = True
        CustDOBLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CustDOBLbl.ForeColor = Color.IndianRed
        CustDOBLbl.Location = New Point(987, 299)
        CustDOBLbl.Name = "CustDOBLbl"
        CustDOBLbl.Size = New Size(128, 23)
        CustDOBLbl.TabIndex = 33
        CustDOBLbl.Text = "Date of Birth"
        CustDOBLbl.Visible = False
        ' 
        ' CustSpndsLbl
        ' 
        CustSpndsLbl.AutoSize = True
        CustSpndsLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CustSpndsLbl.ForeColor = Color.IndianRed
        CustSpndsLbl.Location = New Point(375, 386)
        CustSpndsLbl.Name = "CustSpndsLbl"
        CustSpndsLbl.Size = New Size(110, 23)
        CustSpndsLbl.TabIndex = 32
        CustSpndsLbl.Text = "Spendings"
        CustSpndsLbl.Visible = False
        ' 
        ' CustCommLbl
        ' 
        CustCommLbl.AutoSize = True
        CustCommLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CustCommLbl.ForeColor = Color.IndianRed
        CustCommLbl.Location = New Point(375, 299)
        CustCommLbl.Name = "CustCommLbl"
        CustCommLbl.Size = New Size(168, 23)
        CustCommLbl.TabIndex = 31
        CustCommLbl.Text = "Communication"
        CustCommLbl.Visible = False
        ' 
        ' CustEmlLbl
        ' 
        CustEmlLbl.AutoSize = True
        CustEmlLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CustEmlLbl.ForeColor = Color.IndianRed
        CustEmlLbl.Location = New Point(375, 216)
        CustEmlLbl.Name = "CustEmlLbl"
        CustEmlLbl.Size = New Size(162, 23)
        CustEmlLbl.TabIndex = 30
        CustEmlLbl.Text = "Customer Email"
        CustEmlLbl.Visible = False
        ' 
        ' CustNameLbl
        ' 
        CustNameLbl.AutoSize = True
        CustNameLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CustNameLbl.ForeColor = Color.IndianRed
        CustNameLbl.Location = New Point(375, 134)
        CustNameLbl.Name = "CustNameLbl"
        CustNameLbl.Size = New Size(170, 23)
        CustNameLbl.TabIndex = 29
        CustNameLbl.Text = "Customer Name"
        CustNameLbl.Visible = False
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
        ' CustIdTb
        ' 
        CustIdTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CustIdTb.Location = New Point(476, 18)
        CustIdTb.Name = "CustIdTb"
        CustIdTb.Size = New Size(252, 37)
        CustIdTb.TabIndex = 27
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(341, 25)
        Label9.Name = "Label9"
        Label9.Size = New Size(129, 23)
        Label9.TabIndex = 26
        Label9.Text = "Customer Id"
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
        Label8.Location = New Point(702, 299)
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
        Label7.Location = New Point(702, 216)
        Label7.Name = "Label7"
        Label7.Size = New Size(270, 23)
        Label7.TabIndex = 19
        Label7.Text = "Preferred Payment Method"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(97, 386)
        Label6.Name = "Label6"
        Label6.Size = New Size(161, 23)
        Label6.TabIndex = 17
        Label6.Text = "Total Spendings"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(97, 299)
        Label5.Name = "Label5"
        Label5.Size = New Size(261, 23)
        Label5.TabIndex = 15
        Label5.Text = "Preferred Communication"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(702, 134)
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
        Label1.Location = New Point(97, 216)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 23)
        Label1.TabIndex = 11
        Label1.Text = "Customer Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(97, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 23)
        Label3.TabIndex = 9
        Label3.Text = "Customer Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(120, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(434, 38)
        Label2.TabIndex = 10
        Label2.Text = "View Customer Information"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(34, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' PrintDocument4
        ' 
        ' 
        ' PrintPreviewDialog4
        ' 
        PrintPreviewDialog4.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog4.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog4.ClientSize = New Size(400, 300)
        PrintPreviewDialog4.Document = PrintDocument4
        PrintPreviewDialog4.Enabled = True
        PrintPreviewDialog4.Icon = CType(resources.GetObject("PrintPreviewDialog4.Icon"), Icon)
        PrintPreviewDialog4.Name = "PrintPreviewDialog4"
        PrintPreviewDialog4.Visible = False
        ' 
        ' CustomerDetails
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleVioletRed
        ClientSize = New Size(1281, 713)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "CustomerDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CustomerDetails"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CustPhnLbl As Label
    Friend WithEvents CustPmtMetLbl As Label
    Friend WithEvents CustDOBLbl As Label
    Friend WithEvents CustSpndsLbl As Label
    Friend WithEvents CustCommLbl As Label
    Friend WithEvents CustEmlLbl As Label
    Friend WithEvents CustNameLbl As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents CustIdTb As TextBox
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
    Friend WithEvents PrintDocument4 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog4 As PrintPreviewDialog
End Class
