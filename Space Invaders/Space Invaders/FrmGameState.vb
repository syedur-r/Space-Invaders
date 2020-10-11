Imports System.Drawing

Public Class FrmGameState

    '********************************************************************************************************************'
    'SPACE INVADERS on VB
    'Programmed by S Rahman
    '15/10/17
    '********************************************************************************************************************'

    Dim Aliens(11) As PictureBox
    Dim Locations(11) As Point 'storing location of x and y coordinate 
    Dim aishot(11) As Boolean
    Dim aishot2(11) As Label

    Dim PLeft As Boolean
    Dim PRight As Boolean

    Dim Fire As Boolean
    Dim Fire1 As Boolean
    Dim Fire2 As Boolean
    Dim Fire3 As Boolean
    Dim Fire4 As Boolean
    Dim Fire5 As Boolean

    Dim aliensmove As Integer = 1
    Dim whichalien As Integer
    Dim finished As Integer
    Dim level As Integer = 1
    Dim score As Integer
    Dim ran As Integer

    Dim score1 As Integer = 50
    Dim score2 As Integer = 40
    Dim score3 As Integer = 30
    Dim score4 As Integer = 20
    Dim score5 As Integer = 10
    Dim scoretext1 As String = "Syedur"
    Dim scoretext2 As String = "Fraz"
    Dim scoretext3 As String = "Sana"
    Dim scoretext4 As String = "Mashob"
    Dim scoretext5 As String = "Javed"

    Private Sub FrmGameState_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            e.Handled = True
        End If
    End Sub

    Private Sub FrmGameState_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.Select()
        GameDeveloper()
    End Sub

    Private Function GameDeveloper()
        Dim developer As New Label
        Dim developerfont As New Font("OCR A Extended", 8, FontStyle.Bold)
        developer.Font = developerfont
        developer.Size = New Size(250, 13) 'set your size
        developer.Location = New Point(315, 585) 'set your location
        developer.Text = "Developed by Syedur Rahman" 'set your name
        Controls.Add(developer)  'add your new control to your forms control collection
        Return developer
    End Function

#Region "Buttons"
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Title.Hide()
        btnStart.Hide()
        btnQuit.Hide()
        btnHelp.Hide()
        PictureBox1.Hide()
        PictureBox2.Hide()
        Panel1.BringToFront()
        Panel1.Show()
        Movecomp.Enabled = True
        Movecomp.Start()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Title.Hide()
        btnStart.Hide()
        btnQuit.Hide()
        btnHelp.Hide()
        PictureBox1.Hide()
        PictureBox2.Hide()
        Panel3.BringToFront()
        Panel3.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Title.Show()
        btnStart.Show()
        btnQuit.Show()
        btnHelp.Show()
        PictureBox1.Show()
        PictureBox2.Show()
        Panel3.Hide()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Panel1.Hide()
        Panel2.Hide()
        Title.Show()
        btnStart.Show()
        btnQuit.Show()
        btnHelp.Show()
        PictureBox1.Show()
        PictureBox2.Show()
        ResetGame()
    End Sub
#End Region

#Region "Timers"
    Private Sub Movecomp_Tick(sender As Object, e As EventArgs) Handles Movecomp.Tick
        If PRight = True Then
            picSpaceship.Left = picSpaceship.Left + 3
            RestartShot.Left = RestartShot.Left + 3
            If Fire1 = False Then
                shot1.Left = shot1.Left + 3
            ElseIf Fire2 = False Then
                shot2.Left = shot2.Left + 3
            ElseIf Fire3 = False Then
                shot3.Left = shot3.Left + 3
            ElseIf Fire4 = False Then
                shot4.Left = shot4.Left + 3
            ElseIf Fire5 = False Then
                shot5.Left = shot5.Left + 3
            End If
            If picSpaceship.Left > Me.Width - picSpaceship.Width Then
                picSpaceship.Left = picSpaceship.Left - 3
                RestartShot.Left = RestartShot.Left - 3
                If Fire1 = False Then
                    shot1.Left = shot1.Left - 3
                ElseIf Fire2 = False Then
                    shot2.Left = shot2.Left - 3
                ElseIf Fire3 = False Then
                    shot3.Left = shot3.Left - 3
                ElseIf Fire4 = False Then
                    shot4.Left = shot4.Left - 3
                ElseIf Fire5 = False Then
                    shot5.Left = shot5.Left - 3
                End If
            End If
        End If
        If PLeft = True Then
            picSpaceship.Left = picSpaceship.Left - 3
            RestartShot.Left = RestartShot.Left - 3
            If Fire1 = False Then
                shot1.Left = shot1.Left - 3
            ElseIf Fire2 = False Then
                shot2.Left = shot2.Left - 3
            ElseIf Fire3 = False Then
                shot3.Left = shot3.Left - 3
            ElseIf Fire4 = False Then
                shot4.Left = shot4.Left - 3
            ElseIf Fire5 = False Then
                shot5.Left = shot5.Left - 3
            End If
        End If
        If picSpaceship.Left < 0 Then
            picSpaceship.Left = picSpaceship.Left + 3
            RestartShot.Left = RestartShot.Left + 3
            If Fire1 = False Then
                shot1.Left = shot1.Left + 3
            ElseIf Fire2 = False Then
                shot2.Left = shot2.Left + 3
            ElseIf Fire3 = False Then
                shot3.Left = shot3.Left + 3
            ElseIf Fire4 = False Then
                shot4.Left = shot4.Left + 3
            ElseIf Fire5 = False Then
                shot5.Left = shot5.Left + 3
            End If
        End If
        movealiens()
        If Fire = True Then
            checkshot()
        End If
        moveshot()
        movealienshots()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Panel2.Show()
        alienshot1.Hide()
        alienshot2.Hide()
        alienshot3.Hide()
        alienshot4.Hide()
        alienshot5.Hide()
        alienshot6.Hide()
        alienshot7.Hide()
        alienshot8.Hide()
        alienshot9.Hide()
        alienshot10.Hide()
        alienshot11.Hide()
        alienshot12.Hide()
    End Sub
#End Region

#Region "Key Presses"
    Private Sub MovecompLandR(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Right Then
            PRight = True
        ElseIf e.KeyValue = Keys.Left Then
            PLeft = True
        ElseIf e.KeyValue = Keys.S Then
            Fire = True
        End If
    End Sub

    Private Sub MovecompStop(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Right Then
            PRight = False
        ElseIf e.KeyValue = Keys.Left Then
            PLeft = False
        ElseIf e.KeyValue = Keys.S Then
            Fire = False
        End If
    End Sub
#End Region

#Region "Game Procedures"
    Public Sub New()
        InitializeComponent()
        CreateArray()
        AlienShotArray()
        CreateScoreBoard()
    End Sub

    Private Sub ResetGame()
        picSpaceship.Image = My.Resources.piq_128794_400x400 'changes picturebox 
        finished = 0
        lblLevel.Text = "LEVEL: 1" 'resets level back to 1
        score = 0 'resets score back to 0 
        aliensmove = 1
        Fire = False
        Fire1 = False
        Fire2 = False
        Fire3 = False
        Fire4 = False
        Fire5 = False
        shot1.Location = RestartShot.Location
        shot2.Location = RestartShot.Location
        shot3.Location = RestartShot.Location
        shot4.Location = RestartShot.Location
        shot5.Location = RestartShot.Location
        lblScore.Text = "SCORE: " & score
        lblDead.Hide()

        For i = 0 To 11
            Aliens(i).Location = Locations(i)
            Aliens(i).Show()
            aishot(i) = False
            aishot2(i).Hide()                           'This loop is preparing the aliens for the next game 
            aishot2(i).Location = Aliens(i).Location
            aishot2(i).Top = aishot2(i).Top + 105
            aishot2(i).Left = aishot2(i).Left + 52
        Next
    End Sub

    Private Sub CreateScoreBoard()
        Label2.Text = scoretext1
        Label5.Text = scoretext2
        Label9.Text = scoretext3
        Label6.Text = scoretext4
        Label8.Text = scoretext5
        Label3.Text = score1
        Label11.Text = score2
        Label10.Text = score3
        Label4.Text = score4
        Label7.Text = score5
    End Sub

    Private Sub CreateArray()
        Aliens(0) = alien1
        Aliens(1) = alien2
        Aliens(2) = alien3
        Aliens(3) = alien4
        Aliens(4) = alien5
        Aliens(5) = alien6
        Aliens(6) = alien7
        Aliens(7) = alien8
        Aliens(8) = alien9
        Aliens(9) = alien10
        Aliens(10) = alien11
        Aliens(11) = alien12
        For i = 0 To 11
            Locations(i) = Aliens(i).Location 'calling upon each picturebox and storing it in the array 
        Next
    End Sub

    Private Sub AlienShotArray()
        aishot2(0) = alienshot1
        aishot2(1) = alienshot2
        aishot2(2) = alienshot3
        aishot2(3) = alienshot4
        aishot2(4) = alienshot5
        aishot2(5) = alienshot6
        aishot2(6) = alienshot7
        aishot2(7) = alienshot8
        aishot2(8) = alienshot9
        aishot2(9) = alienshot10
        aishot2(10) = alienshot11
        aishot2(11) = alienshot12
    End Sub

    Private Sub movealiens()
        For i = 0 To 11
            Aliens(i).Left = Aliens(i).Left + aliensmove
            If aishot(i) = False Then
                aishot2(i).Left = aishot2(i).Left + aliensmove
            End If
            If Aliens(i).Bounds.IntersectsWith(picSpaceship.Bounds) Then
                gameover()
            End If
        Next
        If alien6.Left > Me.Width - alien6.Width Then
            aliensmove = aliensmove * -1
            For i = 0 To 11
                Aliens(i).Top = Aliens(i).Top + 10
                If aishot(i) = False Then
                    aishot2(i).Top = aishot2(i).Top + 10
                End If
            Next
        End If
        If alien1.Left < 0 Then
            aliensmove = aliensmove * -1
            For i = 0 To 11
                Aliens(i).Top = Aliens(i).Top + 10
                If aishot(i) = False Then
                    aishot2(i).Top = aishot2(i).Top + 10
                End If
            Next
        End If
    End Sub

    Private Sub checkshot()
        Fire = False
        If Fire1 = False Then
            Fire1 = True
            shot1.Show()
            Exit Sub
        End If
        If Fire2 = False Then
            Fire2 = True
            shot2.Show()
            Exit Sub
        End If
        If Fire3 = False Then
            Fire3 = True
            shot3.Show()
            Exit Sub
        End If
        If Fire4 = False Then
            Fire4 = True
            shot4.Show()
            Exit Sub
        End If
        If Fire5 = False Then
            Fire5 = True
            shot5.Show()
            Exit Sub
        End If
    End Sub

    Private Sub moveshot()
        If Fire1 = True Then
            shot1.Top = shot1.Top - 3
            For i = 0 To 11
                If shot1.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot1hit()
                End If
            Next
            If shot1.Top < 0 Then
                shot1.Hide()
                Fire1 = False
                shot1.Location = RestartShot.Location
            End If
        End If
        If Fire2 = True Then
            shot2.Top = shot2.Top - 3
            For i = 0 To 11
                If shot2.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot2hit()
                End If
            Next
            If shot2.Top < 0 Then
                shot2.Hide()
                Fire2 = False
                shot2.Location = RestartShot.Location
            End If
        End If
        If Fire3 = True Then
            shot3.Top = shot3.Top - 3
            For i = 0 To 11
                If shot3.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot3hit()
                End If
            Next
            If shot3.Top < 0 Then
                shot3.Hide()
                Fire3 = False
                shot3.Location = RestartShot.Location
            End If
        End If
        If Fire4 = True Then
            shot4.Top = shot4.Top - 3
            For i = 0 To 11
                If shot4.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot4hit()
                End If
            Next
            If shot4.Top < 0 Then
                shot4.Hide()
                Fire4 = False
                shot4.Location = RestartShot.Location
            End If
        End If
        If Fire5 = True Then
            shot5.Top = shot5.Top - 3
            For i = 0 To 11
                If shot5.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot5hit()
                End If
            Next
            If shot5.Top < 0 Then
                shot5.Hide()
                Fire5 = False
                shot5.Location = RestartShot.Location
            End If
        End If
    End Sub

    Private Sub shot1hit()
        Fire1 = False
        shot1.Hide()
        shot1.Location = RestartShot.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 1000000
        finished = finished + 1
        If finished = 12 Then
            levelfinished()
        End If
        score = score + 1
        lblScore.Text = "SCORE: " & score
    End Sub

    Private Sub shot2hit()
        Fire2 = False
        shot2.Hide()
        shot2.Location = RestartShot.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 1000000
        finished = finished + 1
        If finished = 12 Then
            levelfinished()
        End If
        score = score + 1
        lblScore.Text = "SCORE: " & score
    End Sub

    Private Sub shot3hit()
        Fire3 = False
        shot3.Hide()
        shot3.Location = RestartShot.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 1000000
        finished = finished + 1
        If finished = 12 Then
            levelfinished()
        End If
        score = score + 1
        lblScore.Text = "SCORE: " & score
    End Sub

    Private Sub shot4hit()
        Fire4 = False
        shot4.Hide()
        shot4.Location = RestartShot.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 1000000
        finished = finished + 1
        If finished = 12 Then
            levelfinished()
        End If
        score = score + 1
        lblScore.Text = "SCORE: " & score
    End Sub

    Private Sub shot5hit()
        Fire5 = False
        shot5.Hide()
        shot5.Location = RestartShot.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 100000
        finished = finished + 1
        If finished = 12 Then
            levelfinished()
        End If
        score = score + 1
        lblScore.Text = "SCORE: " & score
    End Sub

    Private Sub gameover()
        Movecomp.Stop()
        alien1.Hide()
        alien2.Hide()
        alien3.Hide()
        alien4.Hide()
        alien5.Hide()
        alien6.Hide()
        alien7.Hide()
        alien8.Hide()
        alien9.Hide()
        alien10.Hide()
        alien11.Hide()
        alien12.Hide()
        alienshot1.Hide()
        alienshot2.Hide()
        alienshot3.Hide()
        alienshot4.Hide()
        alienshot5.Hide()
        alienshot6.Hide()
        alienshot7.Hide()
        alienshot8.Hide()
        alienshot9.Hide()
        alienshot10.Hide()
        alienshot11.Hide()
        alienshot12.Hide()
        shot1.Hide()
        shot2.Hide()
        shot3.Hide()
        shot4.Hide()
        shot5.Hide()
        picSpaceship.Image = My.Resources.explosion12
        lblDead.Show()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub levelfinished()
        finished = 0
        level = level + 1
        aliensmove = aliensmove * -1.5
        lblLevel.Text = "LEVEL: " & level
        For i = 0 To 11
            Aliens(i).Location = Locations(i)
        Next
    End Sub

    Private Sub movealienshots()
        For i = 0 To 11
            If aishot(i) = False Then
                ran = CInt(Int((1000 * Rnd()) + 1))
                If ran = 1000 Then
                    aishot(i) = True
                    aishot2(i).Show()
                    If Aliens(i).Top > 1000 Then
                        aishot(i) = False
                        aishot2(i).Hide()
                    End If
                End If
            End If
        Next
        For i = 0 To 11
            If aishot(i) = True Then
                aishot2(i).Top = aishot2(i).Top + 3
                If aishot2(i).Bounds.IntersectsWith(picSpaceship.Bounds) Then
                    gameover()
                    level = 1
                End If
                If aishot2(i).Top > Me.Height Then
                    aishot(i) = False
                    aishot2(i).Hide()
                    aishot2(i).Location = Aliens(i).Location
                    aishot2(i).Top = aishot2(i).Top + 105
                    aishot2(i).Left = aishot2(i).Left + 52
                End If
            End If
        Next
    End Sub

    Private Sub scoreboard()
        If score > score1 Then
            score5 = score4
            score4 = score3
            score3 = score2
            score2 = score1
            score1 = score
            scoretext5 = scoretext4
            scoretext4 = scoretext3
            scoretext3 = scoretext2
            scoretext2 = scoretext1
            scoretext1 = TextBox1.Text
            Label2.Text = scoretext1
            Label5.Text = scoretext2
            Label9.Text = scoretext3
            Label6.Text = scoretext4
            Label8.Text = scoretext5
            Label3.Text = score1
            Label11.Text = score2
            Label10.Text = score3
            Label4.Text = score4
            Label7.Text = score5
            Exit Sub
        End If
        If score > score2 Then
            score5 = score4
            score4 = score3
            score3 = score2
            score2 = score
            scoretext5 = scoretext4
            scoretext4 = scoretext3
            scoretext3 = scoretext2
            scoretext2 = TextBox1.Text
            Label5.Text = scoretext2
            Label9.Text = scoretext3
            Label6.Text = scoretext4
            Label8.Text = scoretext5
            Label11.Text = score2
            Label10.Text = score3
            Label4.Text = score4
            Label7.Text = score5
            Exit Sub
        End If
        If score > score3 Then
            score5 = score4
            score4 = score3
            score3 = score
            scoretext5 = scoretext4
            scoretext4 = scoretext3
            scoretext3 = TextBox1.Text
            Label9.Text = scoretext3
            Label6.Text = scoretext4
            Label8.Text = scoretext5
            Label10.Text = score3
            Label4.Text = score4
            Label7.Text = score5
            Exit Sub
        End If
        If score > score4 Then
            score5 = score4
            score4 = score
            scoretext5 = scoretext4
            scoretext4 = TextBox1.Text
            Label6.Text = scoretext4
            Label8.Text = scoretext5
            Label4.Text = score4
            Label7.Text = score5
            Exit Sub
        End If
        If score > score5 Then
            score5 = score
            scoretext5 = TextBox1.Text
            Label8.Text = scoretext5
            Label7.Text = score5
        End If
    End Sub
#End Region

#Region "Textboxes"
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyValue = Keys.Enter Then
            scoreboard()
            Label2.Show()
            Label5.Show()
            Label9.Show()
            Label6.Show()
            Label8.Show()
            Label3.Show()
            Label11.Show()
            Label10.Show()
            Label4.Show()
            Label7.Show()
            btnMainMenu.Show()
        End If
    End Sub
#End Region

End Class
