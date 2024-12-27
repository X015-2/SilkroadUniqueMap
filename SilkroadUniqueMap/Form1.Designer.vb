<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ComboBox1 = New ComboBox()
        pb_TigerGirl = New PictureBox()
        pb_Cerberus = New PictureBox()
        pb_CaptainIvy = New PictureBox()
        pb_Uruchi = New PictureBox()
        pb_Isyutaru = New PictureBox()
        pb_LordYarkan = New PictureBox()
        pb_DemonShaitan = New PictureBox()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        bt_about = New Button()
        CType(pb_TigerGirl, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb_Cerberus, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb_CaptainIvy, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb_Uruchi, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb_Isyutaru, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb_LordYarkan, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb_DemonShaitan, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 12)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' pb_TigerGirl
        ' 
        pb_TigerGirl.Image = CType(resources.GetObject("pb_TigerGirl.Image"), Image)
        pb_TigerGirl.Location = New Point(149, 12)
        pb_TigerGirl.Name = "pb_TigerGirl"
        pb_TigerGirl.Size = New Size(652, 424)
        pb_TigerGirl.TabIndex = 1
        pb_TigerGirl.TabStop = False
        ' 
        ' pb_Cerberus
        ' 
        pb_Cerberus.Image = CType(resources.GetObject("pb_Cerberus.Image"), Image)
        pb_Cerberus.Location = New Point(149, 12)
        pb_Cerberus.Name = "pb_Cerberus"
        pb_Cerberus.Size = New Size(652, 424)
        pb_Cerberus.TabIndex = 2
        pb_Cerberus.TabStop = False
        ' 
        ' pb_CaptainIvy
        ' 
        pb_CaptainIvy.Image = CType(resources.GetObject("pb_CaptainIvy.Image"), Image)
        pb_CaptainIvy.Location = New Point(149, 12)
        pb_CaptainIvy.Name = "pb_CaptainIvy"
        pb_CaptainIvy.Size = New Size(653, 430)
        pb_CaptainIvy.TabIndex = 3
        pb_CaptainIvy.TabStop = False
        ' 
        ' pb_Uruchi
        ' 
        pb_Uruchi.Image = CType(resources.GetObject("pb_Uruchi.Image"), Image)
        pb_Uruchi.Location = New Point(149, 12)
        pb_Uruchi.Name = "pb_Uruchi"
        pb_Uruchi.Size = New Size(653, 431)
        pb_Uruchi.TabIndex = 4
        pb_Uruchi.TabStop = False
        ' 
        ' pb_Isyutaru
        ' 
        pb_Isyutaru.Image = CType(resources.GetObject("pb_Isyutaru.Image"), Image)
        pb_Isyutaru.Location = New Point(149, 12)
        pb_Isyutaru.Name = "pb_Isyutaru"
        pb_Isyutaru.Size = New Size(652, 424)
        pb_Isyutaru.TabIndex = 5
        pb_Isyutaru.TabStop = False
        ' 
        ' pb_LordYarkan
        ' 
        pb_LordYarkan.Image = CType(resources.GetObject("pb_LordYarkan.Image"), Image)
        pb_LordYarkan.Location = New Point(149, 12)
        pb_LordYarkan.Name = "pb_LordYarkan"
        pb_LordYarkan.Size = New Size(652, 424)
        pb_LordYarkan.TabIndex = 6
        pb_LordYarkan.TabStop = False
        ' 
        ' pb_DemonShaitan
        ' 
        pb_DemonShaitan.Image = CType(resources.GetObject("pb_DemonShaitan.Image"), Image)
        pb_DemonShaitan.Location = New Point(149, 12)
        pb_DemonShaitan.Name = "pb_DemonShaitan"
        pb_DemonShaitan.Size = New Size(652, 424)
        pb_DemonShaitan.TabIndex = 7
        pb_DemonShaitan.TabStop = False
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 454)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(809, 22)
        StatusStrip1.TabIndex = 8
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(186, 17)
        ToolStripStatusLabel1.Text = "(c) 2024 by Dragan 'X015' Pavlovic"
        ' 
        ' bt_about
        ' 
        bt_about.Location = New Point(12, 413)
        bt_about.Name = "bt_about"
        bt_about.Size = New Size(75, 23)
        bt_about.TabIndex = 9
        bt_about.Text = "About"
        bt_about.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(809, 476)
        Controls.Add(bt_about)
        Controls.Add(StatusStrip1)
        Controls.Add(pb_DemonShaitan)
        Controls.Add(pb_LordYarkan)
        Controls.Add(pb_Isyutaru)
        Controls.Add(pb_Uruchi)
        Controls.Add(pb_CaptainIvy)
        Controls.Add(pb_Cerberus)
        Controls.Add(pb_TigerGirl)
        Controls.Add(ComboBox1)
        MaximizeBox = False
        MaximumSize = New Size(825, 515)
        MinimumSize = New Size(825, 515)
        Name = "Form1"
        Text = "Form1"
        CType(pb_TigerGirl, ComponentModel.ISupportInitialize).EndInit()
        CType(pb_Cerberus, ComponentModel.ISupportInitialize).EndInit()
        CType(pb_CaptainIvy, ComponentModel.ISupportInitialize).EndInit()
        CType(pb_Uruchi, ComponentModel.ISupportInitialize).EndInit()
        CType(pb_Isyutaru, ComponentModel.ISupportInitialize).EndInit()
        CType(pb_LordYarkan, ComponentModel.ISupportInitialize).EndInit()
        CType(pb_DemonShaitan, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents pb_TigerGirl As PictureBox
    Friend WithEvents pb_Cerberus As PictureBox
    Friend WithEvents pb_CaptainIvy As PictureBox
    Friend WithEvents pb_Uruchi As PictureBox
    Friend WithEvents pb_Isyutaru As PictureBox
    Friend WithEvents pb_LordYarkan As PictureBox
    Friend WithEvents pb_DemonShaitan As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents bt_about As Button

End Class
