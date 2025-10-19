' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Public Class Form0

    Private Sub Form0_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim baseLeft As Integer = TrackBar_Volume.Left
        Dim labelTop As Integer = TrackBar_Volume.Top - -28

        ToolTip1.SetToolTip(TrackBar_Volume, "Adjust global playback volume")

        Label1.Left = baseLeft + 8
        Label3.Left = baseLeft + 67
        Label4.Left = baseLeft + 128
        Label5.Left = baseLeft + 190
        Label6.Left = baseLeft + 247

        Label1.Top = labelTop
        Label3.Top = labelTop
        Label4.Top = labelTop
        Label5.Top = labelTop
        Label6.Top = labelTop

        Dim storedVolume = My.Settings.LastVolume

        If storedVolume > 0 And storedVolume < 1 Then
            Globals.VolumeLevel = CInt(storedVolume * 100)
        Else
            Globals.VolumeLevel = 50 ' Start at half volume
            My.Settings.LastVolume = 0.5F
            My.Settings.Save()
        End If

        TrackBar_Volume.Value = Globals.VolumeLevel

        ' Security & FormLog disabled
        ' As not needed for private use.
        ' If Not Security.Licence.IsValid Then
        'Dim dlg As New FormLog
        'If dlg.ShowDialog <> DialogResult.OK Then
        'Me.Close()
        'End If
        ' End If

    End Sub

    Private Sub Button_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_3.Click
        Form3.Show()
        Me.Hide()
    End Sub


    Private Sub Button_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_4.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_5.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        End
    End Sub


    Private Sub Button_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Start.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_About.Click
        Form_About.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        System.Diagnostics.Process.Start("https://autastic-media.github.io/home")
    End Sub

    Private Sub Button_Quiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Quiz.Click
        Dim randomizer As New Random
        Dim randomnumber As Integer = randomizer.Next(0, 4)
        Select Case randomnumber
            Case 0
                Form_TakeQuiz1.Show()
            Case 1
                Form_TakeQuiz2.Show()
            Case 2
                Form_TakeQuiz3.Show()
            Case 3
                Form_TakeQuiz4.Show()
        End Select
        Me.Hide()
    End Sub

    Private Sub TrackBar_Volume_Scroll(sender As Object, e As EventArgs) Handles TrackBar_Volume.Scroll
        Dim raw = TrackBar_Volume.Value
        Dim snapPoints() As Integer = {0, 25, 50, 75, 100}
        Dim threshold As Integer = 3

        Dim closest = snapPoints.OrderBy(Function(p) Math.Abs(p - raw)).First()
        If Math.Abs(closest - raw) <= threshold Then
            TrackBar_Volume.Value = closest
            raw = closest
        End If

        Globals.VolumeLevel = raw

        My.Settings.LastVolume = Globals.VolumeLevel / 100.0F
        My.Settings.Save()
    End Sub

    Private lastVolumeBeforeMute As Integer = 80 ' Default fallback

    Private Sub Volume_Click(sender As Object, e As EventArgs) Handles Volume.Click
        If Globals.VolumeLevel > 0 Then
            ' 🔈 Mute
            lastVolumeBeforeMute = Globals.VolumeLevel
            Globals.VolumeLevel = 0
            TrackBar_Volume.Value = 0
            Volume.Text = "🔈"
            AudioState.Text = "Off"
        Else
            ' 🔊 Unmute
            Globals.VolumeLevel = lastVolumeBeforeMute
            TrackBar_Volume.Value = Globals.VolumeLevel
            Volume.Text = "🔊"
            AudioState.Text = "On"
        End If

        My.Settings.LastVolume = Globals.VolumeLevel / 100.0F
        My.Settings.Save()
    End Sub

    Private Sub AudioState_Click(sender As Object, e As EventArgs) Handles AudioState.Click
        If Globals.VolumeLevel > 0 Then
            ' 🔈 Mute
            lastVolumeBeforeMute = Globals.VolumeLevel
            Globals.VolumeLevel = 0
            TrackBar_Volume.Value = 0
            Volume.Text = "🔈"
            AudioState.Text = "Off"
        Else
            ' 🔊 Unmute
            Globals.VolumeLevel = lastVolumeBeforeMute
            TrackBar_Volume.Value = Globals.VolumeLevel
            Volume.Text = "🔊"
            AudioState.Text = "On"
        End If

        My.Settings.LastVolume = Globals.VolumeLevel / 100.0F
        My.Settings.Save()
    End Sub
End Class