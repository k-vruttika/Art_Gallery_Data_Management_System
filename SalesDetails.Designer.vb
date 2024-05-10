<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesDetails))
        Panel1 = New Panel()
        SlTransIdLbl = New Label()
        SlDelStatLbl = New Label()
        SlDOSLbl = New Label()
        SlAmtPdLbl = New Label()
        SlPmtMetLbl = New Label()
        SlCustNmLbl = New Label()
        SlSldLbl = New Label()
        Button2 = New Button()
        SaleIdTb = New TextBox()
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
        PrintDocument5 = New Printing.PrintDocument()
        PrintPreviewDialog5 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(SlTransIdLbl)
        Panel1.Controls.Add(SlDelStatLbl)
        Panel1.Controls.Add(SlDOSLbl)
        Panel1.Controls.Add(SlAmtPdLbl)
        Panel1.Controls.Add(SlPmtMetLbl)
        Panel1.Controls.Add(SlCustNmLbl)
        Panel1.Controls.Add(SlSldLbl)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(SaleIdTb)
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
        Panel1.Location = New Point(0, 110)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1281, 559)
        Panel1.TabIndex = 2
        ' 
        ' SlTransIdLbl
        ' 
        SlTransIdLbl.AutoSize = True
        SlTransIdLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SlTransIdLbl.ForeColor = Color.IndianRed
        SlTransIdLbl.Location = New Point(964, 134)
        SlTransIdLbl.Name = "SlTransIdLbl"
        SlTransIdLbl.Size = New Size(146, 23)
        SlTransIdLbl.TabIndex = 35
        SlTransIdLbl.Text = "Transaction ID"
        SlTransIdLbl.Visible = False
        ' 
        ' SlDelStatLbl
        ' 
        SlDelStatLbl.AutoSize = True
        SlDelStatLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SlDelStatLbl.ForeColor = Color.IndianRed
        SlDelStatLbl.Location = New Point(964, 216)
        SlDelStatLbl.Name = "SlDelStatLbl"
        SlDelStatLbl.Size = New Size(151, 23)
        SlDelStatLbl.TabIndex = 34
        SlDelStatLbl.Text = "Delivery Status"
        SlDelStatLbl.Visible = False
        ' 
        ' SlDOSLbl
        ' 
        SlDOSLbl.AutoSize = True
        SlDOSLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SlDOSLbl.ForeColor = Color.IndianRed
        SlDOSLbl.Location = New Point(964, 299)
        SlDOSLbl.Name = "SlDOSLbl"
        SlDOSLbl.Size = New Size(128, 23)
        SlDOSLbl.TabIndex = 33
        SlDOSLbl.Text = "Date of Sale"
        SlDOSLbl.Visible = False
        ' 
        ' SlAmtPdLbl
        ' 
        SlAmtPdLbl.AutoSize = True
        SlAmtPdLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SlAmtPdLbl.ForeColor = Color.IndianRed
        SlAmtPdLbl.Location = New Point(361, 386)
        SlAmtPdLbl.Name = "SlAmtPdLbl"
        SlAmtPdLbl.Size = New Size(135, 23)
        SlAmtPdLbl.TabIndex = 32
        SlAmtPdLbl.Text = "Amount Paid"
        SlAmtPdLbl.Visible = False
        ' 
        ' SlPmtMetLbl
        ' 
        SlPmtMetLbl.AutoSize = True
        SlPmtMetLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SlPmtMetLbl.ForeColor = Color.IndianRed
        SlPmtMetLbl.Location = New Point(361, 299)
        SlPmtMetLbl.Name = "SlPmtMetLbl"
        SlPmtMetLbl.Size = New Size(177, 23)
        SlPmtMetLbl.TabIndex = 31
        SlPmtMetLbl.Text = "Payment Method"
        SlPmtMetLbl.Visible = False
        ' 
        ' SlCustNmLbl
        ' 
        SlCustNmLbl.AutoSize = True
        SlCustNmLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SlCustNmLbl.ForeColor = Color.IndianRed
        SlCustNmLbl.Location = New Point(361, 216)
        SlCustNmLbl.Name = "SlCustNmLbl"
        SlCustNmLbl.Size = New Size(170, 23)
        SlCustNmLbl.TabIndex = 30
        SlCustNmLbl.Text = "Customer Name"
        SlCustNmLbl.Visible = False
        ' 
        ' SlSldLbl
        ' 
        SlSldLbl.AutoSize = True
        SlSldLbl.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SlSldLbl.ForeColor = Color.IndianRed
        SlSldLbl.Location = New Point(361, 134)
        SlSldLbl.Name = "SlSldLbl"
        SlSldLbl.Size = New Size(131, 23)
        SlSldLbl.TabIndex = 29
        SlSldLbl.Text = "Artwork Sold"
        SlSldLbl.Visible = False
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
        ' SaleIdTb
        ' 
        SaleIdTb.Font = New Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SaleIdTb.Location = New Point(476, 18)
        SaleIdTb.Name = "SaleIdTb"
        SaleIdTb.Size = New Size(252, 37)
        SaleIdTb.TabIndex = 27
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(361, 32)
        Label9.Name = "Label9"
        Label9.Size = New Size(70, 23)
        Label9.TabIndex = 26
        Label9.Text = "SaleId"
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
        Label8.Text = "Date of Sale"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(725, 216)
        Label7.Name = "Label7"
        Label7.Size = New Size(151, 23)
        Label7.TabIndex = 19
        Label7.Text = "Delivery Status"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(134, 386)
        Label6.Name = "Label6"
        Label6.Size = New Size(135, 23)
        Label6.TabIndex = 17
        Label6.Text = "Amount Paid"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(134, 299)
        Label5.Name = "Label5"
        Label5.Size = New Size(177, 23)
        Label5.TabIndex = 15
        Label5.Text = "Payment Method"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(725, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(146, 23)
        Label4.TabIndex = 13
        Label4.Text = "Transaction ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(134, 216)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 23)
        Label1.TabIndex = 11
        Label1.Text = "Customer Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(134, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 23)
        Label3.TabIndex = 9
        Label3.Text = "Artwork Sold"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(41, 24)
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
        Label2.Location = New Point(124, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(237, 38)
        Label2.TabIndex = 10
        Label2.Text = "Manage Sales"
        ' 
        ' PrintDocument5
        ' 
        ' 
        ' PrintPreviewDialog5
        ' 
        PrintPreviewDialog5.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog5.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog5.ClientSize = New Size(400, 300)
        PrintPreviewDialog5.Document = PrintDocument5
        PrintPreviewDialog5.Enabled = True
        PrintPreviewDialog5.Icon = CType(resources.GetObject("PrintPreviewDialog5.Icon"), Icon)
        PrintPreviewDialog5.Name = "PrintPreviewDialog5"
        PrintPreviewDialog5.Visible = False
        ' 
        ' SalesDetails
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleVioletRed
        ClientSize = New Size(1281, 713)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SalesDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SalesDetails"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SlTransIdLbl As Label
    Friend WithEvents SlDelStatLbl As Label
    Friend WithEvents SlDOSLbl As Label
    Friend WithEvents SlAmtPdLbl As Label
    Friend WithEvents SlPmtMetLbl As Label
    Friend WithEvents SlCustNmLbl As Label
    Friend WithEvents SlSldLbl As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents SaleIdTb As TextBox
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
    Friend WithEvents PrintDocument5 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog5 As PrintPreviewDialog
End Class
