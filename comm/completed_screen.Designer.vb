<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Completed_screen
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Completed_screen))
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        play_btn = New Button()
        Label1 = New Label()
        st = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Panel1 = New Panel()
        Nutural = New PictureBox()
        playaudio = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(Nutural, ComponentModel.ISupportInitialize).BeginInit()
        CType(playaudio, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(415, 14)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 2
        Label2.Text = "Assign Date:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(529, 17)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 17)
        Label3.TabIndex = 3
        Label3.Text = "13/09/2003"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(963, 21)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 17)
        Label4.TabIndex = 5
        Label4.Text = "13/09/2003"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(814, 19)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 20)
        Label5.TabIndex = 4
        Label5.Text = "Submitted Date:"' 
        ' play_btn
        ' 
        play_btn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        play_btn.Location = New Point(646, 320)
        play_btn.Margin = New Padding(2, 3, 2, 3)
        play_btn.Name = "play_btn"
        play_btn.Size = New Size(135, 45)
        play_btn.TabIndex = 10
        play_btn.Text = "play"
        play_btn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(417, 413)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 17)
        Label1.TabIndex = 12
        Label1.Text = "Approved Status    :"' 
        ' st
        ' 
        st.AutoSize = True
        st.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        st.Location = New Point(598, 413)
        st.Margin = New Padding(2, 0, 2, 0)
        st.Name = "st"
        st.Size = New Size(60, 17)
        st.TabIndex = 13
        st.Text = "Pending"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(803, 413)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 17)
        Label7.TabIndex = 14
        Label7.Text = "Approved by       :"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(420, 460)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 17)
        Label8.TabIndex = 15
        Label8.Text = "Approved Date      :"' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.Maroon
        Label9.Location = New Point(963, 413)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(18, 17)
        Label9.TabIndex = 16
        Label9.Text = "--"' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.Navy
        Label10.Location = New Point(598, 460)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(46, 17)
        Label10.TabIndex = 17
        Label10.Text = "--/--/--"' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(803, 460)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(121, 17)
        Label11.TabIndex = 18
        Label11.Text = "Percentage         :"' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label12.Location = New Point(963, 462)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(18, 17)
        Label12.TabIndex = 19
        Label12.Text = "--"' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Location = New Point(390, -1)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(8, 518)
        Panel1.TabIndex = 20
        ' 
        ' Nutural
        ' 
        Nutural.Location = New Point(607, 99)
        Nutural.Margin = New Padding(2, 2, 2, 2)
        Nutural.Name = "Nutural"
        Nutural.Size = New Size(202, 176)
        Nutural.SizeMode = PictureBoxSizeMode.StretchImage
        Nutural.TabIndex = 21
        Nutural.TabStop = False
        ' 
        ' playaudio
        ' 
        playaudio.Location = New Point(502, 89)
        playaudio.Margin = New Padding(2, 3, 2, 3)
        playaudio.Name = "playaudio"
        playaudio.Size = New Size(429, 198)
        playaudio.SizeMode = PictureBoxSizeMode.StretchImage
        playaudio.TabIndex = 9
        playaudio.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(-2, -12)
        PictureBox1.Margin = New Padding(2, 3, 2, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(399, 524)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Completed_screen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.White
        ClientSize = New Size(999, 509)
        Controls.Add(Nutural)
        Controls.Add(Panel1)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(st)
        Controls.Add(Label1)
        Controls.Add(play_btn)
        Controls.Add(playaudio)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2, 3, 2, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Completed_screen"
        StartPosition = FormStartPosition.CenterScreen
        CType(Nutural, ComponentModel.ISupportInitialize).EndInit()
        CType(playaudio, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents playaudio As PictureBox
    Friend WithEvents play_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents st As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Nutural As PictureBox
End Class
