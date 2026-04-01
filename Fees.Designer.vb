<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fees))
        Panel1 = New Panel()
        Button4 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Label6 = New Label()
        PictureBox7 = New PictureBox()
        Label7 = New Label()
        btnPay = New Button()
        StAmountTb = New TextBox()
        StNameTb = New TextBox()
        StIdCb = New ComboBox()
        Period = New DateTimePicker()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        DGVFeesDeposit = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVFeesDeposit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(256, 800)
        Panel1.TabIndex = 3
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Crimson
        Button4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(129, 231)
        Button4.Name = "Button4"
        Button4.Size = New Size(107, 29)
        Button4.TabIndex = 24
        Button4.Text = "Dashboard"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Crimson
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(129, 699)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 29)
        Button1.TabIndex = 21
        Button1.Text = "LogOUt"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Crimson
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(129, 390)
        Button3.Name = "Button3"
        Button3.Size = New Size(107, 29)
        Button3.TabIndex = 23
        Button3.Text = "Students"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Crimson
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(129, 532)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 29)
        Button2.TabIndex = 22
        Button2.Text = "FeesDeposit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(23, 461)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(100, 100)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(23, 319)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 100)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(23, 628)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(100, 100)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 8
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(23, 160)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(100, 100)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 6
        PictureBox4.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Crimson
        Label1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(129, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 25)
        Label1.TabIndex = 1
        Label1.Text = "CMS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(23, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Crimson
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(PictureBox7)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(256, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(944, 191)
        Panel3.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(273, 76)
        Label6.Name = "Label6"
        Label6.Size = New Size(399, 38)
        Label6.TabIndex = 14
        Label6.Text = "Collage Management System"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(54, 43)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(100, 100)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 13
        PictureBox7.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.Control
        Label7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(308, 226)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 23)
        Label7.TabIndex = 5
        Label7.Text = "Student's ID"
        ' 
        ' btnPay
        ' 
        btnPay.BackColor = Color.Crimson
        btnPay.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPay.ForeColor = Color.White
        btnPay.Location = New Point(642, 309)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(121, 47)
        btnPay.TabIndex = 6
        btnPay.Text = "Pay"
        btnPay.UseVisualStyleBackColor = False
        ' 
        ' StAmountTb
        ' 
        StAmountTb.Location = New Point(971, 267)
        StAmountTb.Name = "StAmountTb"
        StAmountTb.Size = New Size(125, 27)
        StAmountTb.TabIndex = 7
        ' 
        ' StNameTb
        ' 
        StNameTb.Location = New Point(465, 265)
        StNameTb.Name = "StNameTb"
        StNameTb.Size = New Size(170, 27)
        StNameTb.TabIndex = 8
        ' 
        ' StIdCb
        ' 
        StIdCb.FormattingEnabled = True
        StIdCb.Location = New Point(308, 261)
        StIdCb.Name = "StIdCb"
        StIdCb.Size = New Size(120, 28)
        StIdCb.TabIndex = 9
        ' 
        ' Period
        ' 
        Period.Location = New Point(677, 265)
        Period.Name = "Period"
        Period.Size = New Size(269, 27)
        Period.TabIndex = 10
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.Control
        Label8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(465, 226)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 23)
        Label8.TabIndex = 11
        Label8.Text = "Student's Name"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.Control
        Label9.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(677, 226)
        Label9.Name = "Label9"
        Label9.Size = New Size(46, 23)
        Label9.TabIndex = 12
        Label9.Text = "Date"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.Control
        Label10.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(971, 226)
        Label10.Name = "Label10"
        Label10.Size = New Size(72, 23)
        Label10.TabIndex = 14
        Label10.Text = "Amount"
        ' 
        ' DGVFeesDeposit
        ' 
        DGVFeesDeposit.AllowUserToAddRows = False
        DGVFeesDeposit.AllowUserToDeleteRows = False
        DGVFeesDeposit.BackgroundColor = Color.White
        DGVFeesDeposit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVFeesDeposit.Location = New Point(310, 395)
        DGVFeesDeposit.Name = "DGVFeesDeposit"
        DGVFeesDeposit.ReadOnly = True
        DGVFeesDeposit.RowHeadersWidth = 51
        DGVFeesDeposit.Size = New Size(836, 378)
        DGVFeesDeposit.TabIndex = 15
        ' 
        ' Fees
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 800)
        Controls.Add(DGVFeesDeposit)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Period)
        Controls.Add(StIdCb)
        Controls.Add(StNameTb)
        Controls.Add(StAmountTb)
        Controls.Add(btnPay)
        Controls.Add(Label7)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Fees"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Fees"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(DGVFeesDeposit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents StAmountTb As TextBox
    Friend WithEvents StNameTb As TextBox
    Friend WithEvents StIdCb As ComboBox
    Friend WithEvents Period As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DGVFeesDeposit As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
End Class
