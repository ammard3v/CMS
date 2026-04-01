<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student))
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Button4 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Panel2 = New Panel()
        btnShow = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        StudentsDGV = New DataGridView()
        Label12 = New Label()
        txtSfees = New TextBox()
        Label11 = New Label()
        txtSdept = New ComboBox()
        Label10 = New Label()
        txtSPno = New TextBox()
        Label9 = New Label()
        txtSDOB = New DateTimePicker()
        Label8 = New Label()
        Label7 = New Label()
        txtSgender = New ComboBox()
        txtSname = New TextBox()
        Panel3 = New Panel()
        Label6 = New Label()
        PictureBox6 = New PictureBox()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(StudentsDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Panel1.TabIndex = 2
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Crimson
        Button4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(129, 231)
        Button4.Name = "Button4"
        Button4.Size = New Size(111, 29)
        Button4.TabIndex = 28
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
        Button1.Size = New Size(111, 29)
        Button1.TabIndex = 25
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
        Button3.Size = New Size(111, 29)
        Button3.TabIndex = 27
        Button3.Text = "Students"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Crimson
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(124, 532)
        Button2.Name = "Button2"
        Button2.Size = New Size(121, 29)
        Button2.TabIndex = 26
        Button2.Text = "FeesDeposit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnShow)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnUpdate)
        Panel2.Controls.Add(btnSave)
        Panel2.Controls.Add(StudentsDGV)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(txtSfees)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(txtSdept)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(txtSPno)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(txtSDOB)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(txtSgender)
        Panel2.Controls.Add(txtSname)
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(256, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(944, 800)
        Panel2.TabIndex = 5
        ' 
        ' btnShow
        ' 
        btnShow.BackColor = Color.Crimson
        btnShow.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnShow.ForeColor = SystemColors.Control
        btnShow.Location = New Point(185, 390)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(94, 41)
        btnShow.TabIndex = 19
        btnShow.Text = "Show"
        btnShow.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Crimson
        btnDelete.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnDelete.ForeColor = SystemColors.Control
        btnDelete.Location = New Point(531, 390)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 41)
        btnDelete.TabIndex = 18
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Crimson
        btnClear.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnClear.ForeColor = SystemColors.Control
        btnClear.Location = New Point(655, 390)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 41)
        btnClear.TabIndex = 17
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Crimson
        btnUpdate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnUpdate.ForeColor = SystemColors.Control
        btnUpdate.Location = New Point(412, 390)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 41)
        btnUpdate.TabIndex = 16
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Crimson
        btnSave.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnSave.ForeColor = SystemColors.Control
        btnSave.Location = New Point(302, 390)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 41)
        btnSave.TabIndex = 15
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' StudentsDGV
        ' 
        StudentsDGV.AllowUserToAddRows = False
        StudentsDGV.AllowUserToDeleteRows = False
        StudentsDGV.BackgroundColor = Color.White
        StudentsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StudentsDGV.GridColor = SystemColors.Window
        StudentsDGV.Location = New Point(51, 461)
        StudentsDGV.Name = "StudentsDGV"
        StudentsDGV.ReadOnly = True
        StudentsDGV.RowHeadersWidth = 51
        StudentsDGV.Size = New Size(853, 309)
        StudentsDGV.TabIndex = 14
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.2F)
        Label12.Location = New Point(391, 292)
        Label12.Name = "Label12"
        Label12.Size = New Size(43, 23)
        Label12.TabIndex = 13
        Label12.Text = "Fees"
        ' 
        ' txtSfees
        ' 
        txtSfees.Location = New Point(391, 317)
        txtSfees.Name = "txtSfees"
        txtSfees.Size = New Size(125, 27)
        txtSfees.TabIndex = 12
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10.2F)
        Label11.Location = New Point(748, 210)
        Label11.Name = "Label11"
        Label11.Size = New Size(109, 23)
        Label11.TabIndex = 11
        Label11.Text = "Departments"
        ' 
        ' txtSdept
        ' 
        txtSdept.FormattingEnabled = True
        txtSdept.Items.AddRange(New Object() {"BBA", "BCA", "BCIS", "BIT"})
        txtSdept.Location = New Point(748, 245)
        txtSdept.Name = "txtSdept"
        txtSdept.Size = New Size(109, 28)
        txtSdept.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.2F)
        Label10.Location = New Point(221, 292)
        Label10.Name = "Label10"
        Label10.Size = New Size(94, 23)
        Label10.TabIndex = 9
        Label10.Text = "Mobile No."
        ' 
        ' txtSPno
        ' 
        txtSPno.Location = New Point(221, 317)
        txtSPno.Name = "txtSPno"
        txtSPno.Size = New Size(125, 27)
        txtSPno.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.2F)
        Label9.Location = New Point(409, 210)
        Label9.Name = "Label9"
        Label9.Size = New Size(107, 23)
        Label9.TabIndex = 7
        Label9.Text = "Date of Birth"
        ' 
        ' txtSDOB
        ' 
        txtSDOB.Location = New Point(409, 243)
        txtSDOB.Name = "txtSDOB"
        txtSDOB.Size = New Size(260, 27)
        txtSDOB.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F)
        Label8.Location = New Point(249, 210)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 23)
        Label8.TabIndex = 5
        Label8.Text = "Gender"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F)
        Label7.Location = New Point(51, 210)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 23)
        Label7.TabIndex = 4
        Label7.Text = "Students Name"
        ' 
        ' txtSgender
        ' 
        txtSgender.FormattingEnabled = True
        txtSgender.Items.AddRange(New Object() {"Male", "Female"})
        txtSgender.Location = New Point(250, 246)
        txtSgender.Name = "txtSgender"
        txtSgender.Size = New Size(115, 28)
        txtSgender.TabIndex = 3
        ' 
        ' txtSname
        ' 
        txtSname.Location = New Point(51, 246)
        txtSname.Name = "txtSname"
        txtSname.Size = New Size(164, 27)
        txtSname.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Crimson
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(PictureBox6)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(944, 191)
        Panel3.TabIndex = 0
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
        Label6.TabIndex = 15
        Label6.Text = "Collage Management System"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(38, 57)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(100, 100)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 14
        PictureBox6.TabStop = False
        ' 
        ' Student
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 800)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Student"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(StudentsDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnShow As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents StudentsDGV As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSfees As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSdept As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSPno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSDOB As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSgender As ComboBox
    Friend WithEvents txtSname As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
End Class
