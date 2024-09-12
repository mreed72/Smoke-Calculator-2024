<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSingle
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
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txBurnSize = New TextBox()
        txCatDay = New NumericUpDown()
        txDistance = New TextBox()
        txFtype = New ComboBox()
        txFload = New ComboBox()
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        txResults = New RichTextBox()
        txTotalTons = New Label()
        Label13 = New Label()
        txAllowed = New Label()
        Label11 = New Label()
        txAvFuels = New Label()
        Label8 = New Label()
        btnCalc = New Button()
        btnClear = New Button()
        btnExit = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(txCatDay, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(63), CByte(135), CByte(63))
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 91)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ADOA_64x64
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 63)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(50, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 21)
        Label1.TabIndex = 1
        Label1.Text = "Burn Size:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 21)
        Label2.TabIndex = 2
        Label2.Text = "Category Day:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(10, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 21)
        Label3.TabIndex = 3
        Label3.Text = "Target Distance:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(50, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 21)
        Label4.TabIndex = 4
        Label4.Text = "Fuel Type:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(48, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 21)
        Label5.TabIndex = 5
        Label5.Text = "Fuel Load:"
        ' 
        ' txBurnSize
        ' 
        txBurnSize.Location = New Point(134, 30)
        txBurnSize.Name = "txBurnSize"
        txBurnSize.Size = New Size(56, 23)
        txBurnSize.TabIndex = 6
        ' 
        ' txCatDay
        ' 
        txCatDay.BorderStyle = BorderStyle.None
        txCatDay.Location = New Point(134, 62)
        txCatDay.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        txCatDay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        txCatDay.Name = "txCatDay"
        txCatDay.Size = New Size(43, 19)
        txCatDay.TabIndex = 7
        txCatDay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' txDistance
        ' 
        txDistance.Location = New Point(134, 94)
        txDistance.Name = "txDistance"
        txDistance.Size = New Size(56, 23)
        txDistance.TabIndex = 8
        ' 
        ' txFtype
        ' 
        txFtype.FormattingEnabled = True
        txFtype.Items.AddRange(New Object() {"1-Shortleaf Pine with Oak", "2-Shortleaf Pine Regeneration", "3-Loblolly Pine with Oak", "4-Loblolly Pine Regeneration", "5-Hardwood Leaf Litter", "6-Grass or Brush", "7-Dispersed Slash", "8-Piled Debris", "9-Shortleaf Loblolly with Grass", "10-Corn", "11-Cotton", "12-Rice", "13-Soybean", "14-Wheat"})
        txFtype.Location = New Point(134, 126)
        txFtype.Name = "txFtype"
        txFtype.Size = New Size(195, 23)
        txFtype.TabIndex = 9
        ' 
        ' txFload
        ' 
        txFload.FormattingEnabled = True
        txFload.Items.AddRange(New Object() {"Low", "Moderate", "Heavy"})
        txFload.Location = New Point(134, 158)
        txFload.Name = "txFload"
        txFload.Size = New Size(121, 23)
        txFload.TabIndex = 10
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txFload)
        GroupBox1.Controls.Add(txBurnSize)
        GroupBox1.Controls.Add(txFtype)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txDistance)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txCatDay)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(12, 109)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(354, 202)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "USER inputs"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.AppWorkspace
        Label7.Location = New Point(196, 97)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 15)
        Label7.TabIndex = 13
        Label7.Text = "( miles )"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.AppWorkspace
        Label6.Location = New Point(196, 33)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 15)
        Label6.TabIndex = 12
        Label6.Text = "( acres )"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(txTotalTons)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(txAllowed)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(txAvFuels)
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(372, 109)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(249, 202)
        Panel2.TabIndex = 12
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txResults)
        Panel3.Location = New Point(12, 117)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(222, 69)
        Panel3.TabIndex = 6
        ' 
        ' txResults
        ' 
        txResults.BackColor = Color.White
        txResults.BorderStyle = BorderStyle.None
        txResults.Dock = DockStyle.Fill
        txResults.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txResults.ForeColor = Color.White
        txResults.Location = New Point(0, 0)
        txResults.Name = "txResults"
        txResults.Size = New Size(220, 67)
        txResults.TabIndex = 0
        txResults.Text = "TESST"
        ' 
        ' txTotalTons
        ' 
        txTotalTons.AutoSize = True
        txTotalTons.Location = New Point(128, 78)
        txTotalTons.Name = "txTotalTons"
        txTotalTons.Size = New Size(13, 15)
        txTotalTons.TabIndex = 5
        txTotalTons.Text = "0"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(39, 78)
        Label13.Name = "Label13"
        Label13.Size = New Size(74, 15)
        Label13.TabIndex = 4
        Label13.Text = "TOTAL TONS:"
        ' 
        ' txAllowed
        ' 
        txAllowed.AutoSize = True
        txAllowed.Location = New Point(128, 48)
        txAllowed.Name = "txAllowed"
        txAllowed.Size = New Size(13, 15)
        txAllowed.TabIndex = 3
        txAllowed.Text = "0"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(12, 48)
        Label11.Name = "Label11"
        Label11.Size = New Size(101, 15)
        Label11.TabIndex = 2
        Label11.Text = "Allowed Tonnage:"
        ' 
        ' txAvFuels
        ' 
        txAvFuels.AutoSize = True
        txAvFuels.Location = New Point(128, 17)
        txAvFuels.Name = "txAvFuels"
        txAvFuels.Size = New Size(22, 15)
        txAvFuels.TabIndex = 1
        txAvFuels.Text = "0.0"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(25, 17)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 15)
        Label8.TabIndex = 0
        Label8.Text = "Available Fuels:"
        ' 
        ' btnCalc
        ' 
        btnCalc.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnCalc.FlatStyle = FlatStyle.Popup
        btnCalc.Location = New Point(627, 109)
        btnCalc.Name = "btnCalc"
        btnCalc.Size = New Size(161, 48)
        btnCalc.TabIndex = 13
        btnCalc.Text = "CALCULATE"
        btnCalc.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Location = New Point(627, 164)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(161, 48)
        btnClear.TabIndex = 14
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnExit.FlatStyle = FlatStyle.Popup
        btnExit.Location = New Point(733, 271)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(55, 40)
        btnExit.TabIndex = 15
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frmSingle
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 326)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalc)
        Controls.Add(Panel2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmSingle"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Single Fuels"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(txCatDay, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txBurnSize As TextBox
    Friend WithEvents txCatDay As NumericUpDown
    Friend WithEvents txDistance As TextBox
    Friend WithEvents txFtype As ComboBox
    Friend WithEvents txFload As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txResults As RichTextBox
    Friend WithEvents txTotalTons As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txAllowed As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txAvFuels As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
