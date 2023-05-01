Public Class Form1


    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim randGen As New Random
        Dim intRand As Integer
        Dim delay As ta
        delay = Task.Delay(1)
        For IntTimer As Integer = 1 To 50
            intRand = randGen.Next(1, 26)

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
        Next IntTimer

        Select Case
                Case 1 randGen = 1


        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'tick += 1

        'If tick = 1 Then
        '    PictureBox1.Image = My.Resources.Cow
        'ElseIf tick = 2 Then
        '    PictureBox1.Image = My.Resources.Screenshot_2023_04_24_133137
        'ElseIf tick = 4 Then
        '    PictureBox1.Image = My.Resources.Cow
        'End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
