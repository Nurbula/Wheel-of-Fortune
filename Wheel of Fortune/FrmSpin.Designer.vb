<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSpin
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblP1 = New System.Windows.Forms.Label()
        Me.lblP2 = New System.Windows.Forms.Label()
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.lstHide = New System.Windows.Forms.ListBox()
        Me.grpLetter = New System.Windows.Forms.GroupBox()
        Me.btnZ = New System.Windows.Forms.Button()
        Me.btnY = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnW = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnQ = New System.Windows.Forms.Button()
        Me.btnP = New System.Windows.Forms.Button()
        Me.btnO = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnL = New System.Windows.Forms.Button()
        Me.btnK = New System.Windows.Forms.Button()
        Me.btnJ = New System.Windows.Forms.Button()
        Me.btnI = New System.Windows.Forms.Button()
        Me.btnH = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLetter = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnReplay = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLetter.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSpin
        '
        Me.btnSpin.AutoEllipsis = True
        Me.btnSpin.Location = New System.Drawing.Point(598, 578)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(189, 53)
        Me.btnSpin.TabIndex = 1
        Me.btnSpin.Text = "Spin!"
        Me.btnSpin.UseVisualStyleBackColor = True
        Me.btnSpin.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1173, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1143, 356)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(162, 251)
        Me.btnExit.TabIndex = 32
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(1143, 82)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(162, 251)
        Me.btnStart.TabIndex = 33
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(615, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 54)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Phrase"
        Me.Label3.Visible = False
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(464, 80)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(490, 48)
        Me.lblResult.TabIndex = 34
        Me.lblResult.Text = "                              " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblResult.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.Wheel_of_Fortune.My.Resources.Resources.Picture1
        Me.PictureBox1.Location = New System.Drawing.Point(491, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(428, 288)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Player 1"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "PLayer 2"
        Me.Label5.Visible = False
        '
        'lblP1
        '
        Me.lblP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblP1.Location = New System.Drawing.Point(100, 56)
        Me.lblP1.Name = "lblP1"
        Me.lblP1.Size = New System.Drawing.Size(121, 32)
        Me.lblP1.TabIndex = 42
        Me.lblP1.Visible = False
        '
        'lblP2
        '
        Me.lblP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblP2.Location = New System.Drawing.Point(100, 136)
        Me.lblP2.Name = "lblP2"
        Me.lblP2.Size = New System.Drawing.Size(121, 32)
        Me.lblP2.TabIndex = 43
        Me.lblP2.Visible = False
        '
        'ofdFile
        '
        Me.ofdFile.FileName = "OpenFileDialog1"
        '
        'lstHide
        '
        Me.lstHide.FormattingEnabled = True
        Me.lstHide.ItemHeight = 16
        Me.lstHide.Location = New System.Drawing.Point(985, 225)
        Me.lstHide.Name = "lstHide"
        Me.lstHide.Size = New System.Drawing.Size(110, 196)
        Me.lstHide.TabIndex = 44
        Me.lstHide.Visible = False
        '
        'grpLetter
        '
        Me.grpLetter.Controls.Add(Me.btnZ)
        Me.grpLetter.Controls.Add(Me.btnY)
        Me.grpLetter.Controls.Add(Me.btnX)
        Me.grpLetter.Controls.Add(Me.btnW)
        Me.grpLetter.Controls.Add(Me.btnV)
        Me.grpLetter.Controls.Add(Me.btnU)
        Me.grpLetter.Controls.Add(Me.btnT)
        Me.grpLetter.Controls.Add(Me.btnS)
        Me.grpLetter.Controls.Add(Me.btnR)
        Me.grpLetter.Controls.Add(Me.btnQ)
        Me.grpLetter.Controls.Add(Me.btnP)
        Me.grpLetter.Controls.Add(Me.btnO)
        Me.grpLetter.Controls.Add(Me.btnN)
        Me.grpLetter.Controls.Add(Me.btnM)
        Me.grpLetter.Controls.Add(Me.btnL)
        Me.grpLetter.Controls.Add(Me.btnK)
        Me.grpLetter.Controls.Add(Me.btnJ)
        Me.grpLetter.Controls.Add(Me.btnI)
        Me.grpLetter.Controls.Add(Me.btnH)
        Me.grpLetter.Controls.Add(Me.btnG)
        Me.grpLetter.Controls.Add(Me.btnF)
        Me.grpLetter.Controls.Add(Me.btnE)
        Me.grpLetter.Controls.Add(Me.btnD)
        Me.grpLetter.Controls.Add(Me.btnC)
        Me.grpLetter.Controls.Add(Me.btnB)
        Me.grpLetter.Controls.Add(Me.btnA)
        Me.grpLetter.Controls.Add(Me.Label6)
        Me.grpLetter.Controls.Add(Me.txtLetter)
        Me.grpLetter.Location = New System.Drawing.Point(41, 276)
        Me.grpLetter.Name = "grpLetter"
        Me.grpLetter.Size = New System.Drawing.Size(414, 212)
        Me.grpLetter.TabIndex = 45
        Me.grpLetter.TabStop = False
        Me.grpLetter.Visible = False
        '
        'btnZ
        '
        Me.btnZ.AutoSize = True
        Me.btnZ.Location = New System.Drawing.Point(237, 174)
        Me.btnZ.Name = "btnZ"
        Me.btnZ.Size = New System.Drawing.Size(48, 26)
        Me.btnZ.TabIndex = 31
        Me.btnZ.Text = "Z"
        Me.btnZ.UseVisualStyleBackColor = True
        '
        'btnY
        '
        Me.btnY.AutoSize = True
        Me.btnY.Location = New System.Drawing.Point(184, 174)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(47, 26)
        Me.btnY.TabIndex = 30
        Me.btnY.Text = "Y"
        Me.btnY.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.AutoSize = True
        Me.btnX.Location = New System.Drawing.Point(129, 175)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(48, 26)
        Me.btnX.TabIndex = 29
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'btnW
        '
        Me.btnW.AutoSize = True
        Me.btnW.Location = New System.Drawing.Point(76, 174)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(47, 26)
        Me.btnW.TabIndex = 28
        Me.btnW.Text = "W"
        Me.btnW.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.AutoSize = True
        Me.btnV.Location = New System.Drawing.Point(21, 174)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(46, 26)
        Me.btnV.TabIndex = 27
        Me.btnV.Text = "V"
        Me.btnV.UseVisualStyleBackColor = True
        '
        'btnU
        '
        Me.btnU.AutoSize = True
        Me.btnU.Location = New System.Drawing.Point(345, 145)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(48, 26)
        Me.btnU.TabIndex = 26
        Me.btnU.Text = "U"
        Me.btnU.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.AutoSize = True
        Me.btnT.Location = New System.Drawing.Point(291, 145)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(48, 26)
        Me.btnT.TabIndex = 25
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.AutoSize = True
        Me.btnS.Location = New System.Drawing.Point(237, 146)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(48, 26)
        Me.btnS.TabIndex = 24
        Me.btnS.Text = "S"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnR
        '
        Me.btnR.AutoSize = True
        Me.btnR.Location = New System.Drawing.Point(184, 146)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(47, 26)
        Me.btnR.TabIndex = 23
        Me.btnR.Text = "R"
        Me.btnR.UseVisualStyleBackColor = True
        '
        'btnQ
        '
        Me.btnQ.AutoSize = True
        Me.btnQ.Location = New System.Drawing.Point(129, 146)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(48, 26)
        Me.btnQ.TabIndex = 22
        Me.btnQ.Text = "Q"
        Me.btnQ.UseVisualStyleBackColor = True
        '
        'btnP
        '
        Me.btnP.AutoSize = True
        Me.btnP.Location = New System.Drawing.Point(75, 146)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(48, 26)
        Me.btnP.TabIndex = 21
        Me.btnP.Text = "P"
        Me.btnP.UseVisualStyleBackColor = True
        '
        'btnO
        '
        Me.btnO.AutoSize = True
        Me.btnO.Location = New System.Drawing.Point(21, 146)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(48, 26)
        Me.btnO.TabIndex = 20
        Me.btnO.Text = "O"
        Me.btnO.UseVisualStyleBackColor = True
        '
        'btnN
        '
        Me.btnN.AutoSize = True
        Me.btnN.Location = New System.Drawing.Point(345, 116)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(48, 26)
        Me.btnN.TabIndex = 19
        Me.btnN.Text = "N"
        Me.btnN.UseVisualStyleBackColor = True
        '
        'btnM
        '
        Me.btnM.AutoSize = True
        Me.btnM.Location = New System.Drawing.Point(291, 116)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(48, 26)
        Me.btnM.TabIndex = 18
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = True
        '
        'btnL
        '
        Me.btnL.AutoSize = True
        Me.btnL.Location = New System.Drawing.Point(237, 116)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(48, 26)
        Me.btnL.TabIndex = 17
        Me.btnL.Text = "L"
        Me.btnL.UseVisualStyleBackColor = True
        '
        'btnK
        '
        Me.btnK.AutoSize = True
        Me.btnK.Location = New System.Drawing.Point(184, 116)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(47, 26)
        Me.btnK.TabIndex = 16
        Me.btnK.Text = "K"
        Me.btnK.UseVisualStyleBackColor = True
        '
        'btnJ
        '
        Me.btnJ.AutoSize = True
        Me.btnJ.Location = New System.Drawing.Point(129, 116)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(48, 26)
        Me.btnJ.TabIndex = 15
        Me.btnJ.Text = "J"
        Me.btnJ.UseVisualStyleBackColor = True
        '
        'btnI
        '
        Me.btnI.AutoSize = True
        Me.btnI.Location = New System.Drawing.Point(75, 117)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(48, 26)
        Me.btnI.TabIndex = 14
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = True
        '
        'btnH
        '
        Me.btnH.AutoSize = True
        Me.btnH.Location = New System.Drawing.Point(21, 116)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(48, 26)
        Me.btnH.TabIndex = 13
        Me.btnH.Text = "H"
        Me.btnH.UseVisualStyleBackColor = True
        '
        'btnG
        '
        Me.btnG.AutoSize = True
        Me.btnG.Location = New System.Drawing.Point(345, 87)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(48, 26)
        Me.btnG.TabIndex = 12
        Me.btnG.Text = "G"
        Me.btnG.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.AutoSize = True
        Me.btnF.Location = New System.Drawing.Point(291, 87)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(48, 26)
        Me.btnF.TabIndex = 11
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.AutoSize = True
        Me.btnE.Location = New System.Drawing.Point(237, 87)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(48, 26)
        Me.btnE.TabIndex = 10
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.AutoSize = True
        Me.btnD.Location = New System.Drawing.Point(183, 87)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(48, 26)
        Me.btnD.TabIndex = 9
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.AutoSize = True
        Me.btnC.Location = New System.Drawing.Point(129, 87)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(48, 26)
        Me.btnC.TabIndex = 8
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.AutoSize = True
        Me.btnB.Location = New System.Drawing.Point(75, 87)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(48, 26)
        Me.btnB.TabIndex = 7
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.AutoSize = True
        Me.btnA.Location = New System.Drawing.Point(21, 87)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(48, 26)
        Me.btnA.TabIndex = 6
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Letter:"
        '
        'txtLetter
        '
        Me.txtLetter.Location = New System.Drawing.Point(21, 59)
        Me.txtLetter.Name = "txtLetter"
        Me.txtLetter.Size = New System.Drawing.Size(46, 22)
        Me.txtLetter.TabIndex = 1
        Me.txtLetter.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(397, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 94)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Spin"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(784, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(223, 94)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Solve"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'btnReplay
        '
        Me.btnReplay.Location = New System.Drawing.Point(1143, 82)
        Me.btnReplay.Name = "btnReplay"
        Me.btnReplay.Size = New System.Drawing.Size(162, 251)
        Me.btnReplay.TabIndex = 48
        Me.btnReplay.Text = "New Game"
        Me.btnReplay.UseVisualStyleBackColor = True
        Me.btnReplay.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Wheel_of_Fortune.My.Resources.Resources.Cow
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1108, 595)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(100, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 32)
        Me.Label2.TabIndex = 52
        Me.Label2.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(76, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Playing for"
        Me.Label7.Visible = False
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Location = New System.Drawing.Point(1224, 32)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(0, 16)
        Me.lblPlayer1.TabIndex = 53
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Location = New System.Drawing.Point(1280, 31)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(0, 16)
        Me.lblPlayer2.TabIndex = 54
        Me.lblPlayer2.Visible = False
        '
        'FrmSpin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 742)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnReplay)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grpLetter)
        Me.Controls.Add(Me.lstHide)
        Me.Controls.Add(Me.lblP2)
        Me.Controls.Add(Me.lblP1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSpin)
        Me.Name = "FrmSpin"
        Me.Text = "Wheel of Fortune"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLetter.ResumeLayout(False)
        Me.grpLetter.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSpin As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblP1 As Label
    Friend WithEvents lblP2 As Label
    Friend WithEvents ofdFile As OpenFileDialog
    Friend WithEvents lstHide As ListBox
    Friend WithEvents grpLetter As GroupBox
    Friend WithEvents btnZ As Button
    Friend WithEvents btnY As Button
    Friend WithEvents btnX As Button
    Friend WithEvents btnW As Button
    Friend WithEvents btnV As Button
    Friend WithEvents btnU As Button
    Friend WithEvents btnT As Button
    Friend WithEvents btnS As Button
    Friend WithEvents btnR As Button
    Friend WithEvents btnQ As Button
    Friend WithEvents btnP As Button
    Friend WithEvents btnO As Button
    Friend WithEvents btnN As Button
    Friend WithEvents btnM As Button
    Friend WithEvents btnL As Button
    Friend WithEvents btnK As Button
    Friend WithEvents btnJ As Button
    Friend WithEvents btnI As Button
    Friend WithEvents btnH As Button
    Friend WithEvents btnG As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnA As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLetter As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnReplay As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPlayer1 As Label
    Friend WithEvents lblPlayer2 As Label
End Class
