<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class student_dashboard
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
        Label5 = New Label()
        Panel3 = New Panel()
        assign_container = New Label()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        Panel4 = New Panel()
        not_attempted_container = New Label()
        Label8 = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel6 = New Panel()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        name = New Label()
        Panel_Purchases = New Panel()
        attempted_container = New Label()
        tot_at = New Label()
        Panel_Revenue = New Panel()
        Completed_container = New Label()
        assign_na = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel_Purchases.SuspendLayout()
        Panel_Revenue.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(name)
        Panel1.Controls.Add(Panel_Purchases)
        Panel1.Controls.Add(Panel_Revenue)
        Panel1.Dock = DockStyle.Fill
        Panel1.ForeColor = SystemColors.ControlDark
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(999, 526)
        Panel1.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(1004, 336)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(173, 20)
        Label5.TabIndex = 61
        Label5.Text = "Last Five Assessments"' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(119), CByte(85), CByte(218))
        Panel3.Controls.Add(assign_container)
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(37, 116)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(278, 160)
        Panel3.TabIndex = 34
        ' 
        ' assign_container
        ' 
        assign_container.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point)
        assign_container.ForeColor = Color.White
        assign_container.Location = New Point(-3, 73)
        assign_container.Name = "assign_container"
        assign_container.Size = New Size(278, 36)
        assign_container.TabIndex = 6
        assign_container.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.FromArgb(CByte(100), CByte(75), CByte(200))
        Label6.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(0, 0)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(12, 0, 0, 0)
        Label6.Size = New Size(320, 45)
        Label6.TabIndex = 5
        Label6.Text = "Total Assessments"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(740, 385)
        DataGridView1.Margin = New Padding(2, 2, 2, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 28
        DataGridView1.Size = New Size(715, 234)
        DataGridView1.TabIndex = 60
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(119), CByte(85), CByte(218))
        Panel4.Controls.Add(not_attempted_container)
        Panel4.Controls.Add(Label8)
        Panel4.Location = New Point(377, 373)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(278, 160)
        Panel4.TabIndex = 33
        ' 
        ' not_attempted_container
        ' 
        not_attempted_container.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point)
        not_attempted_container.ForeColor = Color.White
        not_attempted_container.Location = New Point(-3, 73)
        not_attempted_container.Name = "not_attempted_container"
        not_attempted_container.Size = New Size(278, 36)
        not_attempted_container.TabIndex = 6
        not_attempted_container.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.FromArgb(CByte(100), CByte(75), CByte(200))
        Label8.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(0, 0)
        Label8.Name = "Label8"
        Label8.Padding = New Padding(12, 0, 0, 0)
        Label8.Size = New Size(320, 45)
        Label8.TabIndex = 5
        Label8.Text = "Not Attempted"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(725, 319)
        Panel2.Margin = New Padding(2, 2, 2, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(774, 8)
        Panel2.TabIndex = 59
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(100), CByte(75), CByte(200))
        Label3.Cursor = Cursors.Hand
        Label3.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(1052, 182)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(12, 0, 0, 0)
        Label3.Size = New Size(198, 105)
        Label3.TabIndex = 55
        Label3.Text = "Logout"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Location = New Point(940, 182)
        PictureBox3.Margin = New Padding(2, 2, 2, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(114, 105)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 56
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(100), CByte(75), CByte(200))
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(866, 28)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(12, 0, 0, 0)
        Label1.Size = New Size(202, 105)
        Label1.TabIndex = 53
        Label1.Text = "List Assessments"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Location = New Point(754, 28)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(114, 105)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 54
        PictureBox1.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Location = New Point(718, 2)
        Panel6.Margin = New Padding(2, 2, 2, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(8, 766)
        Panel6.TabIndex = 51
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(100), CByte(75), CByte(200))
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(1248, 28)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(12, 0, 0, 0)
        Label2.Size = New Size(198, 105)
        Label2.TabIndex = 44
        Label2.Text = "Reassign Assessments"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Location = New Point(1136, 28)
        PictureBox2.Margin = New Padding(2, 2, 2, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(114, 105)
        PictureBox2.TabIndex = 45
        PictureBox2.TabStop = False
        ' 
        ' name
        ' 
        name.AutoSize = True
        name.Font = New Font("Constantia", 16F, FontStyle.Bold, GraphicsUnit.Point)
        name.ForeColor = Color.White
        name.Location = New Point(26, 17)
        name.Margin = New Padding(2, 0, 2, 0)
        name.Name = "name"
        name.Size = New Size(201, 27)
        name.TabIndex = 43
        name.Text = "Hi, VASUDEVAN.N"' 
        ' Panel_Purchases
        ' 
        Panel_Purchases.BackColor = Color.FromArgb(CByte(50), CByte(100), CByte(240))
        Panel_Purchases.Controls.Add(attempted_container)
        Panel_Purchases.Controls.Add(tot_at)
        Panel_Purchases.Location = New Point(32, 373)
        Panel_Purchases.Margin = New Padding(3, 4, 3, 4)
        Panel_Purchases.Name = "Panel_Purchases"
        Panel_Purchases.Size = New Size(278, 160)
        Panel_Purchases.TabIndex = 32
        ' 
        ' attempted_container
        ' 
        attempted_container.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point)
        attempted_container.ForeColor = Color.White
        attempted_container.Location = New Point(-3, 73)
        attempted_container.Name = "attempted_container"
        attempted_container.Size = New Size(278, 36)
        attempted_container.TabIndex = 6
        attempted_container.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tot_at
        ' 
        tot_at.BackColor = Color.FromArgb(CByte(40), CByte(90), CByte(230))
        tot_at.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        tot_at.ForeColor = Color.White
        tot_at.Location = New Point(0, 0)
        tot_at.Name = "tot_at"
        tot_at.Padding = New Padding(12, 0, 0, 0)
        tot_at.Size = New Size(320, 45)
        tot_at.TabIndex = 5
        tot_at.Text = "Attempted"
        tot_at.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel_Revenue
        ' 
        Panel_Revenue.BackColor = Color.FromArgb(CByte(50), CByte(100), CByte(240))
        Panel_Revenue.Controls.Add(Completed_container)
        Panel_Revenue.Controls.Add(assign_na)
        Panel_Revenue.Location = New Point(377, 116)
        Panel_Revenue.Margin = New Padding(3, 4, 3, 4)
        Panel_Revenue.Name = "Panel_Revenue"
        Panel_Revenue.Size = New Size(278, 160)
        Panel_Revenue.TabIndex = 33
        ' 
        ' Completed_container
        ' 
        Completed_container.AccessibleName = ""
        Completed_container.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Completed_container.ForeColor = Color.White
        Completed_container.Location = New Point(0, 73)
        Completed_container.Name = "Completed_container"
        Completed_container.Size = New Size(278, 36)
        Completed_container.TabIndex = 6
        Completed_container.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' assign_na
        ' 
        assign_na.BackColor = Color.FromArgb(CByte(40), CByte(90), CByte(230))
        assign_na.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        assign_na.ForeColor = Color.White
        assign_na.Location = New Point(0, 0)
        assign_na.Name = "assign_na"
        assign_na.Padding = New Padding(12, 0, 0, 0)
        assign_na.Size = New Size(320, 45)
        assign_na.TabIndex = 5
        assign_na.Text = "Completed"
        assign_na.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' student_dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(999, 526)
        Controls.Add(Panel1)
        Margin = New Padding(2, 2, 2, 2)
        MaximizeBox = False
        MaximumSize = New Size(1486, 680)
        MinimizeBox = False
        MinimumSize = New Size(998, 518)

        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel_Purchases.ResumeLayout(False)
        Panel_Revenue.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents name As Label
    Friend WithEvents Panel_Purchases As Panel
    Friend WithEvents attempted_container As Label
    Friend WithEvents tot_at As Label
    Friend WithEvents Panel_Revenue As Panel
    Friend WithEvents Completed_container As Label
    Friend WithEvents assign_na As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents not_attempted_container As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents assign_container As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
