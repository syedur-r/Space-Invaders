<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGameState
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGameState))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Movecomp = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.alienshot4 = New System.Windows.Forms.Label()
        Me.alienshot12 = New System.Windows.Forms.Label()
        Me.alienshot11 = New System.Windows.Forms.Label()
        Me.alienshot10 = New System.Windows.Forms.Label()
        Me.alienshot9 = New System.Windows.Forms.Label()
        Me.alienshot8 = New System.Windows.Forms.Label()
        Me.alienshot6 = New System.Windows.Forms.Label()
        Me.alienshot5 = New System.Windows.Forms.Label()
        Me.alienshot7 = New System.Windows.Forms.Label()
        Me.alienshot3 = New System.Windows.Forms.Label()
        Me.alienshot2 = New System.Windows.Forms.Label()
        Me.alienshot1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblDead = New System.Windows.Forms.Label()
        Me.shot5 = New System.Windows.Forms.Label()
        Me.shot4 = New System.Windows.Forms.Label()
        Me.shot3 = New System.Windows.Forms.Label()
        Me.shot2 = New System.Windows.Forms.Label()
        Me.shot1 = New System.Windows.Forms.Label()
        Me.RestartShot = New System.Windows.Forms.Label()
        Me.alien2 = New System.Windows.Forms.PictureBox()
        Me.alien3 = New System.Windows.Forms.PictureBox()
        Me.alien5 = New System.Windows.Forms.PictureBox()
        Me.alien6 = New System.Windows.Forms.PictureBox()
        Me.alien4 = New System.Windows.Forms.PictureBox()
        Me.alien10 = New System.Windows.Forms.PictureBox()
        Me.alien8 = New System.Windows.Forms.PictureBox()
        Me.alien11 = New System.Windows.Forms.PictureBox()
        Me.alien12 = New System.Windows.Forms.PictureBox()
        Me.alien9 = New System.Windows.Forms.PictureBox()
        Me.alien7 = New System.Windows.Forms.PictureBox()
        Me.alien1 = New System.Windows.Forms.PictureBox()
        Me.picSpaceship = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.alien2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpaceship, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Black
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnStart, "btnStart")
        Me.btnStart.ForeColor = System.Drawing.Color.Lime
        Me.btnStart.Name = "btnStart"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Black
        Me.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnQuit, "btnQuit")
        Me.btnQuit.ForeColor = System.Drawing.Color.Lime
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'Movecomp
        '
        Me.Movecomp.Interval = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.alienshot4)
        Me.Panel1.Controls.Add(Me.alienshot12)
        Me.Panel1.Controls.Add(Me.alienshot11)
        Me.Panel1.Controls.Add(Me.alienshot10)
        Me.Panel1.Controls.Add(Me.alienshot9)
        Me.Panel1.Controls.Add(Me.alienshot8)
        Me.Panel1.Controls.Add(Me.alienshot6)
        Me.Panel1.Controls.Add(Me.alienshot5)
        Me.Panel1.Controls.Add(Me.alienshot7)
        Me.Panel1.Controls.Add(Me.alienshot3)
        Me.Panel1.Controls.Add(Me.alienshot2)
        Me.Panel1.Controls.Add(Me.alienshot1)
        Me.Panel1.Controls.Add(Me.lblScore)
        Me.Panel1.Controls.Add(Me.lblLevel)
        Me.Panel1.Controls.Add(Me.lblDead)
        Me.Panel1.Controls.Add(Me.shot5)
        Me.Panel1.Controls.Add(Me.shot4)
        Me.Panel1.Controls.Add(Me.shot3)
        Me.Panel1.Controls.Add(Me.shot2)
        Me.Panel1.Controls.Add(Me.shot1)
        Me.Panel1.Controls.Add(Me.RestartShot)
        Me.Panel1.Controls.Add(Me.alien2)
        Me.Panel1.Controls.Add(Me.alien3)
        Me.Panel1.Controls.Add(Me.alien5)
        Me.Panel1.Controls.Add(Me.alien6)
        Me.Panel1.Controls.Add(Me.alien4)
        Me.Panel1.Controls.Add(Me.alien10)
        Me.Panel1.Controls.Add(Me.alien8)
        Me.Panel1.Controls.Add(Me.alien11)
        Me.Panel1.Controls.Add(Me.alien12)
        Me.Panel1.Controls.Add(Me.alien9)
        Me.Panel1.Controls.Add(Me.alien7)
        Me.Panel1.Controls.Add(Me.alien1)
        Me.Panel1.Controls.Add(Me.picSpaceship)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblEnter)
        Me.Panel2.Controls.Add(Me.btnMainMenu)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblName)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'lblEnter
        '
        resources.ApplyResources(Me.lblEnter, "lblEnter")
        Me.lblEnter.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblEnter.Name = "lblEnter"
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Black
        Me.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnMainMenu, "btnMainMenu")
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label9.Name = "Label9"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label2.Name = "Label2"
        '
        'lblName
        '
        resources.ApplyResources(Me.lblName, "lblName")
        Me.lblName.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblName.Name = "lblName"
        '
        'alienshot4
        '
        Me.alienshot4.BackColor = System.Drawing.Color.Red
        Me.alienshot4.ForeColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.alienshot4, "alienshot4")
        Me.alienshot4.Name = "alienshot4"
        '
        'alienshot12
        '
        Me.alienshot12.BackColor = System.Drawing.Color.Red
        Me.alienshot12.ForeColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.alienshot12, "alienshot12")
        Me.alienshot12.Name = "alienshot12"
        '
        'alienshot11
        '
        Me.alienshot11.BackColor = System.Drawing.Color.Red
        Me.alienshot11.ForeColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.alienshot11, "alienshot11")
        Me.alienshot11.Name = "alienshot11"
        '
        'alienshot10
        '
        Me.alienshot10.BackColor = System.Drawing.Color.Red
        Me.alienshot10.ForeColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.alienshot10, "alienshot10")
        Me.alienshot10.Name = "alienshot10"
        '
        'alienshot9
        '
        Me.alienshot9.BackColor = System.Drawing.Color.Red
        Me.alienshot9.ForeColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.alienshot9, "alienshot9")
        Me.alienshot9.Name = "alienshot9"
        '
        'alienshot8
        '
        Me.alienshot8.BackColor = System.Drawing.Color.Red
        Me.alienshot8.ForeColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.alienshot8, "alienshot8")
        Me.alienshot8.Name = "alienshot8"
        '
        'alienshot6
        '
        Me.alienshot6.BackColor = System.Drawing.Color.Red
        Me.alienshot6.ForeColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.alienshot6, "alienshot6")
        Me.alienshot6.Name = "alienshot6"
        '
        'alienshot5
        '
        Me.alienshot5.BackColor = System.Drawing.Color.Red
        Me.alienshot5.ForeColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.alienshot5, "alienshot5")
        Me.alienshot5.Name = "alienshot5"
        '
        'alienshot7
        '
        Me.alienshot7.BackColor = System.Drawing.Color.Red
        Me.alienshot7.ForeColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.alienshot7, "alienshot7")
        Me.alienshot7.Name = "alienshot7"
        '
        'alienshot3
        '
        Me.alienshot3.BackColor = System.Drawing.Color.Red
        Me.alienshot3.ForeColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.alienshot3, "alienshot3")
        Me.alienshot3.Name = "alienshot3"
        '
        'alienshot2
        '
        Me.alienshot2.BackColor = System.Drawing.Color.Red
        Me.alienshot2.ForeColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.alienshot2, "alienshot2")
        Me.alienshot2.Name = "alienshot2"
        '
        'alienshot1
        '
        Me.alienshot1.BackColor = System.Drawing.Color.Red
        Me.alienshot1.ForeColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.alienshot1, "alienshot1")
        Me.alienshot1.Name = "alienshot1"
        '
        'lblScore
        '
        resources.ApplyResources(Me.lblScore, "lblScore")
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.ForeColor = System.Drawing.Color.Lime
        Me.lblScore.Name = "lblScore"
        '
        'lblLevel
        '
        resources.ApplyResources(Me.lblLevel, "lblLevel")
        Me.lblLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblLevel.ForeColor = System.Drawing.Color.Lime
        Me.lblLevel.Name = "lblLevel"
        '
        'lblDead
        '
        resources.ApplyResources(Me.lblDead, "lblDead")
        Me.lblDead.BackColor = System.Drawing.Color.Transparent
        Me.lblDead.ForeColor = System.Drawing.Color.Orange
        Me.lblDead.Name = "lblDead"
        '
        'shot5
        '
        Me.shot5.BackColor = System.Drawing.Color.OrangeRed
        resources.ApplyResources(Me.shot5, "shot5")
        Me.shot5.Name = "shot5"
        '
        'shot4
        '
        Me.shot4.BackColor = System.Drawing.Color.OrangeRed
        resources.ApplyResources(Me.shot4, "shot4")
        Me.shot4.Name = "shot4"
        '
        'shot3
        '
        Me.shot3.BackColor = System.Drawing.Color.OrangeRed
        resources.ApplyResources(Me.shot3, "shot3")
        Me.shot3.Name = "shot3"
        '
        'shot2
        '
        Me.shot2.BackColor = System.Drawing.Color.OrangeRed
        resources.ApplyResources(Me.shot2, "shot2")
        Me.shot2.Name = "shot2"
        '
        'shot1
        '
        Me.shot1.BackColor = System.Drawing.Color.OrangeRed
        resources.ApplyResources(Me.shot1, "shot1")
        Me.shot1.Name = "shot1"
        '
        'RestartShot
        '
        Me.RestartShot.BackColor = System.Drawing.Color.OrangeRed
        resources.ApplyResources(Me.RestartShot, "RestartShot")
        Me.RestartShot.Name = "RestartShot"
        '
        'alien2
        '
        Me.alien2.Image = Global.Space_Invaders.My.Resources.Resources.invader
        resources.ApplyResources(Me.alien2, "alien2")
        Me.alien2.Name = "alien2"
        Me.alien2.TabStop = False
        '
        'alien3
        '
        Me.alien3.Image = Global.Space_Invaders.My.Resources.Resources.invader
        resources.ApplyResources(Me.alien3, "alien3")
        Me.alien3.Name = "alien3"
        Me.alien3.TabStop = False
        '
        'alien5
        '
        Me.alien5.Image = Global.Space_Invaders.My.Resources.Resources.invader
        resources.ApplyResources(Me.alien5, "alien5")
        Me.alien5.Name = "alien5"
        Me.alien5.TabStop = False
        '
        'alien6
        '
        Me.alien6.Image = Global.Space_Invaders.My.Resources.Resources.invader
        resources.ApplyResources(Me.alien6, "alien6")
        Me.alien6.Name = "alien6"
        Me.alien6.TabStop = False
        '
        'alien4
        '
        Me.alien4.Image = Global.Space_Invaders.My.Resources.Resources.invader
        resources.ApplyResources(Me.alien4, "alien4")
        Me.alien4.Name = "alien4"
        Me.alien4.TabStop = False
        '
        'alien10
        '
        Me.alien10.Image = Global.Space_Invaders.My.Resources.Resources.invader
        resources.ApplyResources(Me.alien10, "alien10")
        Me.alien10.Name = "alien10"
        Me.alien10.TabStop = False
        '
        'alien8
        '
        Me.alien8.Image = Global.Space_Invaders.My.Resources.Resources.invader
        resources.ApplyResources(Me.alien8, "alien8")
        Me.alien8.Name = "alien8"
        Me.alien8.TabStop = False
        '
        'alien11
        '
        Me.alien11.Image = Global.Space_Invaders.My.Resources.Resources.invader
        resources.ApplyResources(Me.alien11, "alien11")
        Me.alien11.Name = "alien11"
        Me.alien11.TabStop = False
        '
        'alien12
        '
        Me.alien12.Image = Global.Space_Invaders.My.Resources.Resources.invader
        resources.ApplyResources(Me.alien12, "alien12")
        Me.alien12.Name = "alien12"
        Me.alien12.TabStop = False
        '
        'alien9
        '
        Me.alien9.Image = Global.Space_Invaders.My.Resources.Resources.invader
        resources.ApplyResources(Me.alien9, "alien9")
        Me.alien9.Name = "alien9"
        Me.alien9.TabStop = False
        '
        'alien7
        '
        Me.alien7.Image = Global.Space_Invaders.My.Resources.Resources.invader
        resources.ApplyResources(Me.alien7, "alien7")
        Me.alien7.Name = "alien7"
        Me.alien7.TabStop = False
        '
        'alien1
        '
        Me.alien1.Image = Global.Space_Invaders.My.Resources.Resources.invader
        resources.ApplyResources(Me.alien1, "alien1")
        Me.alien1.Name = "alien1"
        Me.alien1.TabStop = False
        '
        'picSpaceship
        '
        Me.picSpaceship.Image = Global.Space_Invaders.My.Resources.Resources.piq_128794_400x400
        resources.ApplyResources(Me.picSpaceship, "picSpaceship")
        Me.picSpaceship.Name = "picSpaceship"
        Me.picSpaceship.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2500
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Black
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnHelp, "btnHelp")
        Me.btnHelp.ForeColor = System.Drawing.Color.LimeGreen
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox6)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.btnBack)
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label15)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Space_Invaders.My.Resources.Resources.left_right
        resources.ApplyResources(Me.PictureBox6, "PictureBox6")
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.TabStop = False
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.ForeColor = System.Drawing.Color.Lime
        Me.Label13.Name = "Label13"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnBack, "btnBack")
        Me.btnBack.ForeColor = System.Drawing.Color.Lime
        Me.btnBack.Name = "btnBack"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Space_Invaders.My.Resources.Resources.shoot
        resources.ApplyResources(Me.PictureBox5, "PictureBox5")
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.TabStop = False
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.ForeColor = System.Drawing.Color.Lime
        Me.Label14.Name = "Label14"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.ForeColor = System.Drawing.Color.Lime
        Me.Label15.Name = "Label15"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Space_Invaders.My.Resources.Resources.invader
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Space_Invaders.My.Resources.Resources.piq_128794_400x400
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Title
        '
        Me.Title.Image = Global.Space_Invaders.My.Resources.Resources.Space_Invaders_Title
        resources.ApplyResources(Me.Title, "Title")
        Me.Title.Name = "Title"
        Me.Title.TabStop = False
        '
        'FrmGameState
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnHelp)
        Me.ForeColor = System.Drawing.Color.LimeGreen
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGameState"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.alien2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpaceship, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Movecomp As Timer
    Friend WithEvents picSpaceship As PictureBox
    Friend WithEvents alien1 As PictureBox
    Friend WithEvents alien4 As PictureBox
    Friend WithEvents alien6 As PictureBox
    Friend WithEvents alien5 As PictureBox
    Friend WithEvents alien3 As PictureBox
    Friend WithEvents alien2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents alien10 As PictureBox
    Friend WithEvents alien8 As PictureBox
    Friend WithEvents alien11 As PictureBox
    Friend WithEvents alien12 As PictureBox
    Friend WithEvents alien9 As PictureBox
    Friend WithEvents alien7 As PictureBox
    Friend WithEvents shot5 As Label
    Friend WithEvents shot4 As Label
    Friend WithEvents shot3 As Label
    Friend WithEvents shot2 As Label
    Friend WithEvents shot1 As Label
    Friend WithEvents RestartShot As Label
    Friend WithEvents lblDead As Label
    Friend WithEvents lblLevel As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents alienshot3 As Label
    Friend WithEvents alienshot2 As Label
    Friend WithEvents alienshot1 As Label
    Friend WithEvents alienshot4 As Label
    Friend WithEvents alienshot12 As Label
    Friend WithEvents alienshot11 As Label
    Friend WithEvents alienshot10 As Label
    Friend WithEvents alienshot9 As Label
    Friend WithEvents alienshot8 As Label
    Friend WithEvents alienshot6 As Label
    Friend WithEvents alienshot5 As Label
    Friend WithEvents alienshot7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents lblEnter As Label
    Friend WithEvents btnHelp As Button
    Friend WithEvents Title As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
