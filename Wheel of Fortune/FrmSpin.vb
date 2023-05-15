Imports System.IO
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmSpin
    Dim num1 As String = "Lose a Turn"
    Dim num2 As String = "2,000"
    Dim num3 As String = "1,000"
    Dim num4 As String = "2,000"
    Dim num5 As String = "1,000"
    Dim num6 As String = "Bankrupt"
    Dim num7 As String = "1,000"
    Dim num8 As String = "5,000"
    Dim num9 As String = "2,000"
    Dim num10 As String = "1,000"
    Dim num11 As String = "Lose a Turn"
    Dim num12 As String = "1,000"
    Dim num13 As String = "5,000"
    Dim num14 As String = "2,000"
    Dim num15 As String = "1,000"
    Dim num16 As String = "Bankrupt"
    Dim num17 As String = "1,000"
    Dim num18 As String = "10,000"
    Dim num19 As String = "2,000"
    Dim num20 As String = "1,000"
    Dim num21 As String = "Lose a Turn"
    Dim num22 As String = "1,000"
    Dim num23 As String = "2,000"
    Dim num24 As String = "5,000"
    Dim num25 As String = "1,000"
    Dim Start As Integer = 1
    Dim strWord As String
    Private people As String()
    Dim strLetter As String
    Dim player As Integer = 1



    Private Async Sub BtnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        Dim randGen As New Random
        Dim intRand As Integer
        Dim Mynumber As Integer
        Dim isEven As Boolean
        btnSpin.Enabled = False
        grpLetter.Enabled = False
        If Start = 1 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 2 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 3 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand


                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer

        ElseIf Start = 4 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand


                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer

        ElseIf Start = 5 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand


                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer

        ElseIf Start = 6 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand


                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 7 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 8 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 9 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 10 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 11 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 12 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 13 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 14 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 15 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 16 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 17 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 18 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 19 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 20 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 21 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 22 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 23 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 24 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        ElseIf Start = 25 Then

            For IntTimer As Integer = 1 To 1
                intRand = randGen.Next(1, 26)
                'intRand = TextBox1.Text
                Label1.Text = intRand

                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(25)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(25)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(25)

            Next IntTimer
        End If

        Select Case True
            Case intRand = 1
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(300)

                PictureBox1.Image = My.Resources.Picture28
                Await Task.Delay(400)

                Label2.Text = ""
                Label2.Text = num1
                player += 1
                Start = 1
            Case intRand = 2

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(250)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture29
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num2
                Start = 2

            Case intRand = 3

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(200)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture30
                Await Task.Delay(400)

                Label2.Text = ""
                Label2.Text = num3
                Start = 3

            Case intRand = 4

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(175)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture31
                Await Task.Delay(400)

                Label2.Text = ""
                Label2.Text = num4
                Start = 4

            Case intRand = 5

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(150)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture32
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num5
                Start = 5

            Case intRand = 6

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(125)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture33
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = "Playing for nothing"


                Mynumber = Val(player)
                If Mynumber Mod 2 = 0 Then
                    isEven = True
                    lblP2.Text = ""
                Else
                    lblP1.Text = ""
                End If

                Start = 6

            Case intRand = 7

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(100)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture34
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num7
                Start = 7
            Case intRand = 8

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(75)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture35
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num8
                Start = 8
            Case intRand = 9

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture36
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num9
                Start = 9

            Case intRand = 10
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture37
                Await Task.Delay(400)

                Label2.Text = ""
                Label2.Text = num10
                Start = 10

            Case intRand = 11

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture38
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num11
                Start = 11
                player += 1

            Case intRand = 12

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture39
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num12
                Start = 12
            Case intRand = 13

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture40
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num13
                Start = 13
            Case intRand = 14

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture41
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num14
                Start = 14

            Case intRand = 15

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture42
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num15
                Start = 15

            Case intRand = 16

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture43
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = "Playing for nothing"

                Mynumber = Val(player)
                If Mynumber Mod 2 = 0 Then
                    isEven = True
                    lblP2.Text = ""
                Else
                    lblP1.Text = ""
                End If

                Start = 16

            Case intRand = 17

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture44
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num17
                Start = 17
            Case intRand = 18

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture45
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num18
                Start = 18
            Case intRand = 19

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture46
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num19
                Start = 19
            Case intRand = 20

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture47
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num20
                Start = 20

            Case intRand = 21

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture49
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num21
                Start = 21


            Case intRand = 22

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture50
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num2
                Start = 22
            Case intRand = 23

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture51
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num23
                Start = 23
            Case intRand = 24

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture52
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num24
                Start = 24
            Case intRand = 25

                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture15
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture25
                Await Task.Delay(50)

                PictureBox1.Image = My.Resources.Picture1
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture2
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture3
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture4
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture5
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture6
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture7
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture8
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture9
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture10
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture11
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture12
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture13
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture14
                Await Task.Delay(50)
                PictureBox1.Image = My.Resources.Picture16
                Await Task.Delay(75)
                PictureBox1.Image = My.Resources.Picture17
                Await Task.Delay(100)
                PictureBox1.Image = My.Resources.Picture18
                Await Task.Delay(125)
                PictureBox1.Image = My.Resources.Picture19
                Await Task.Delay(150)
                PictureBox1.Image = My.Resources.Picture20
                Await Task.Delay(175)
                PictureBox1.Image = My.Resources.Picture21
                Await Task.Delay(200)
                PictureBox1.Image = My.Resources.Picture22
                Await Task.Delay(250)
                PictureBox1.Image = My.Resources.Picture23
                Await Task.Delay(300)
                PictureBox1.Image = My.Resources.Picture24
                Await Task.Delay(400)
                PictureBox1.Image = My.Resources.Picture27
                Await Task.Delay(400)
                Label2.Text = ""
                Label2.Text = num25
                Start = 25
        End Select
        btnSpin.Enabled = True
        grpLetter.Enabled = True
        If lblPlayer1.Visible = True Then
            lblP1.Text = Label2.Text
        ElseIf lblPlayer2 Then

        End If

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click, btnReplay.Click


        btnSpin.Visible = True
        PictureBox1.Visible = True
        btnStart.Visible = False
        btnExit.Visible = False
        lblP1.Visible = True
        lblP2.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        lblResult.Visible = True
        Label3.Visible = True
        grpLetter.Visible = True
        PictureBox2.Visible = False
        grpLetter.Enabled = False
        Label7.Visible = True
        Label2.Visible = True

        ofdFile.Title = "Please select a DB file"
        ofdFile.InitialDirectory = "C:\Users\griff\OneDrive\Documents\Visual Studio 2022\Wheel of Fortune\"
        ofdFile.Filter = "DB Files|*.txt"
        If ofdFile.ShowDialog() = DialogResult.OK Then
            Dim lines() As String = File.ReadAllLines(ofdFile.FileName)
            lstHide.Items.Clear()
            lstHide.Items.AddRange(lines)
        End If
        Dim randGen As New Random
        Dim intRand As Integer
        people = File.ReadAllLines(ofdFile.FileName)
        intRand = randGen.Next(people.Length)
        lstHide.SelectedIndex = intRand
        strWord = lstHide.SelectedItem.ToString.ToUpper

        Dim mytext As String = strWord
        Dim RemoveChars As String = " " 'These are the chars that you want to remove from your mytext string
        Dim FinalResult As String
        Dim myChars() As Char = mytext.ToCharArray()
        For Each ch As Char In myChars
            If Not RemoveChars.Contains(ch) Then
                FinalResult &= ch
            End If
        Next
        strWord = ""
        strWord = FinalResult
        'MsgBox(strWord)

        lblResult.Text = ""

        For i As Integer = 1 To Len(strWord.TrimEnd)

            lblResult.Text += "-" + " "
        Next
        lblPlayer1.Visible = True

    End Sub
    Private Sub txtLetter_Enter(sender As Object, e As EventArgs)
        txtLetter.SelectAll()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Dim strA As String
        strA = "A"
        btnA.Enabled = False
        strLetter = strA
        txtLetter.Text = String.Empty
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        Dim strB As String
        strB = "B"
        btnB.Enabled = False
        strLetter = strB
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Dim strC As String
        strC = "C"
        btnC.Enabled = False
        strLetter = strC
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        Dim strD As String
        strD = "D"
        btnD.Enabled = False
        strLetter = strD
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        Dim strE As String
        strE = "E"
        btnE.Enabled = False
        strLetter = strE
        txtLetter.Text = String.Empty
    End Sub
    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        Dim strF As String
        strF = "F"
        btnF.Enabled = False
        strLetter = strF
    End Sub
    Private Async Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        Dim strG As String
        strG = "G"
        btnG.Enabled = False
        strLetter = strG
        Me.BackgroundImage = My.Resources.Cow
        Await Task.Delay(10000)
        Me.BackgroundImage = Nothing
    End Sub
    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        Dim strH As String
        strH = "H"
        btnH.Enabled = False
        strLetter = strH
    End Sub
    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        Dim strI As String
        strI = "I"
        btnI.Enabled = False
        strLetter = strI
    End Sub
    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        Dim strJ As String
        strJ = "J"
        btnJ.Enabled = False
        strLetter = strJ
    End Sub
    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        Dim strK As String
        strK = "K"
        btnK.Enabled = False
        strLetter = strK
    End Sub
    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        Dim strL As String
        strL = "L"
        btnL.Enabled = False
        strLetter = strL
    End Sub
    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        Dim strM As String
        strM = "M"
        btnM.Enabled = False
        strLetter = strM
    End Sub
    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        Dim strN As String
        strN = "N"
        btnN.Enabled = False
        strLetter = strN
    End Sub
    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        Dim strO As String
        strO = "O"
        btnO.Enabled = False
        strLetter = strO
    End Sub
    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        Dim strP As String
        strP = "P"
        btnP.Enabled = False
        strLetter = strP
    End Sub
    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        Dim strQ As String
        strQ = "Q"
        btnQ.Enabled = False
        strLetter = strQ
    End Sub
    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        Dim strR As String
        strR = "R"
        btnR.Enabled = False
        strLetter = strR
    End Sub
    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        Dim strS As String
        strS = "S"
        btnS.Enabled = False
        strLetter = strS
    End Sub
    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        Dim strT As String
        strT = "T"
        btnT.Enabled = False
        strLetter = strT
    End Sub
    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        Dim strU As String
        strU = "U"
        btnU.Enabled = False
        strLetter = strU
    End Sub
    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        Dim strW As String
        strW = "W"
        strLetter = strW
        btnW.Enabled = False
    End Sub
    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        Dim strW As String
        strW = "W"
        btnW.Enabled = False
        strLetter = strW
    End Sub
    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Dim strX As String
        strX = "X"
        btnX.Enabled = False
        strLetter = strX
    End Sub
    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        Dim strY As String
        strY = "Y"
        btnY.Enabled = False
        strLetter = strY
    End Sub
    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        Dim strZ As String
        strZ = "Z"
        btnZ.Enabled = False
        strLetter = strZ
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        btnSpin.Enabled = False
    End Sub
    Private Sub btnTryLetter_Click(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click, btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click, btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click, btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click, btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click
        ' Determine whether player 2 has guessed the word.
        Dim strResult As String

        strResult = lblResult.Text.Trim.ToUpper

        'MsgBox(strLetter & strWord & strResult)

        If strWord.Contains(strLetter) Then

            ' Replace the hyphen(s) in strResult.
            For intIndex As Integer = 0 To strWord.Length - 1
                If strWord(intIndex) = strLetter Then
                    strResult = strResult.Remove(intIndex * 2, 1)
                    strResult = strResult.Insert(intIndex * 2, strLetter)
                End If
            Next intIndex
            ' Display the contents of strResult.
            lblResult.Text = strResult

            ' Determine whether strResult contains any hyphens.
            If strResult.Contains("-") = False Then
                MessageBox.Show("You guessed it: " & strWord,
"Guess the Word Game",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
                grpLetter.Enabled = False
                lblResult.Text = String.Empty
            End If
        Else
            MessageBox.Show("Try again!", "Guess the Word Game",
                 MessageBoxButtons.OK, MessageBoxIcon.Information)
            grpLetter.Enabled = False
            btnSpin.Enabled = True
        End If
        Dim Mynumber As Integer
        Dim isEven As Boolean
        Mynumber = Val(player)
        If Mynumber Mod 2 = 0 Then
            isEven = True
            lblP1.Text = Label2.Text
        Else
            lblP2.Text = Label2.Text
        End If
        grpLetter.Enabled = False
    End Sub
    'Validates a string of alpha characters
    Function CheckForAlphaCharacters(ByVal StringToCheck As String)
        For i = 0 To StringToCheck.Length - 1
            If Not Char.IsLetter(StringToCheck.Chars(i)) Then
                Return False
            End If
        Next

        Return True 'Return true if all elements are characters
    End Function

    Private Sub FrmSpin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Start As Integer = 1
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblPlayer1.Click

    End Sub
End Class