<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Panel1 = New Panel()
        versionLabel = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        RichTextBox1 = New RichTextBox()
        btnSingle = New Button()
        Panel3 = New Panel()
        RichTextBox2 = New RichTextBox()
        btnMultiple = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(63), CByte(135), CByte(63))
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(versionLabel)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(386, 91)
        Panel1.TabIndex = 0
        ' 
        ' versionLabel
        ' 
        versionLabel.AutoSize = True
        versionLabel.ForeColor = Color.DarkGreen
        versionLabel.Location = New Point(246, 52)
        versionLabel.Name = "versionLabel"
        versionLabel.Size = New Size(58, 15)
        versionLabel.TabIndex = 2
        versionLabel.Text = "9.9999.9.9"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(99, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 21)
        Label1.TabIndex = 1
        Label1.Text = "SMOKE MGMT CALCULATOR"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ADOA_64x64
        PictureBox1.Location = New Point(10, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 63)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(RichTextBox1)
        Panel2.Controls.Add(btnSingle)
        Panel2.Location = New Point(12, 97)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(362, 100)
        Panel2.TabIndex = 1
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = SystemColors.Control
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Location = New Point(3, 32)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(352, 61)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = "The single fuels calculator will assist in calculating burns that are conducted in mainly a single fuel type."
        ' 
        ' btnSingle
        ' 
        btnSingle.Location = New Point(3, 3)
        btnSingle.Name = "btnSingle"
        btnSingle.Size = New Size(129, 23)
        btnSingle.TabIndex = 0
        btnSingle.Text = "Single Fuels"
        btnSingle.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(RichTextBox2)
        Panel3.Controls.Add(btnMultiple)
        Panel3.Location = New Point(12, 216)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(362, 100)
        Panel3.TabIndex = 2
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = SystemColors.Control
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.Location = New Point(3, 32)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(352, 61)
        RichTextBox2.TabIndex = 1
        RichTextBox2.Text = "The multiple fuels calculator will assist with burns that will be conducted in blocks that contain more than one fuel type." & vbLf
        ' 
        ' btnMultiple
        ' 
        btnMultiple.Location = New Point(3, 3)
        btnMultiple.Name = "btnMultiple"
        btnMultiple.Size = New Size(129, 23)
        btnMultiple.TabIndex = 0
        btnMultiple.Text = "Multiple Fuels"
        btnMultiple.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(386, 330)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "x"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents versionLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnSingle As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents btnMultiple As Button

End Class
