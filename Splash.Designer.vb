<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Label1 = New Label()
        Label2 = New Label()
        ProgressBar1 = New ProgressBar()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Monotype Corsiva", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MediumVioletRed
        Label1.Location = New Point(138, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(517, 49)
        Label1.TabIndex = 0
        Label1.Text = "Art Gallery Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.PaleVioletRed
        Label2.Location = New Point(277, 317)
        Label2.Name = "Label2"
        Label2.Size = New Size(246, 32)
        Label2.TabIndex = 1
        Label2.Text = "Loading Application..."
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = Color.LightGray
        ProgressBar1.ForeColor = Color.LimeGreen
        ProgressBar1.Location = New Point(120, 280)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(566, 34)
        ProgressBar1.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(213, 88)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(370, 186)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Splash
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(818, 402)
        Controls.Add(PictureBox1)
        Controls.Add(ProgressBar1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.LightCoral
        FormBorderStyle = FormBorderStyle.None
        Name = "Splash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer

End Class
