' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form_Quiz2_3

    'This Hides the Next button, continues previous score and disables question 8 and 9 answer buttons.

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblScore.Text = "Score: 6 out of 9"
        Button_Menu.Hide()
        Form_Quiz2_2.Close()
        Button_Close.Enabled = False
        Button_Close.BackColor = Color.Gray
        Number_46.Enabled = False
        Number_46.BackColor = Color.Gray
        Number_53.Enabled = False
        Number_53.BackColor = Color.Gray
        Number_50.Enabled = False
        Number_50.BackColor = Color.Gray
        Number_52.Enabled = False
        Number_52.BackColor = Color.Gray
        Number_55.Enabled = False
        Number_55.BackColor = Color.Gray
        Number_48.Enabled = False
        Number_48.BackColor = Color.Gray
    End Sub

    'This Enables question 8 buttons and disables question 7 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_60.Click
        YN1.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 7 out of 9"
        Number_46.Enabled = True
        Number_46.BackColor = Color.White
        Number_53.Enabled = True
        Number_53.BackColor = Color.White
        Number_50.Enabled = True
        Number_50.BackColor = Color.White
        Number_51.Enabled = False
        Number_51.BackColor = Color.Gray
        Number_60.Enabled = False
        Number_60.BackColor = Color.Gray
        Number_49.Enabled = False
        Number_49.BackColor = Color.Gray
    End Sub

    Private Sub Number_51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_51.Click
        YN1.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_49.Click
        YN1.Image = Image.FromFile("Resources/cross2png")
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub


    Private Sub Number_46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_46.Click
        YN2.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_53.Click
        YN2.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    'This Enables question 9 buttons and disables question 8 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_50.Click
        YN2.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 8 out of 9"
        Number_46.Enabled = False
        Number_46.BackColor = Color.Gray
        Number_53.Enabled = False
        Number_53.BackColor = Color.Gray
        Number_50.Enabled = False
        Number_50.BackColor = Color.Gray
        Number_52.Enabled = True
        Number_52.BackColor = Color.White
        Number_55.Enabled = True
        Number_55.BackColor = Color.White
        Number_48.Enabled = True
        Number_48.BackColor = Color.White
    End Sub

    Private Sub Number_55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_55.Click
        YN3.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    'This Enables the Next button and disables question 8 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_52.Click

        YN3.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 9 out of 9 - Congratulations!"
        Number_52.Enabled = False
        Number_52.BackColor = Color.Gray
        Number_55.Enabled = False
        Number_55.BackColor = Color.Gray
        Number_48.Enabled = False
        Number_48.BackColor = Color.Gray
        Button_Menu.Show()
        'This pops up a results form of all completed questions for print out.
        FormQ2_Done.Show()
        Button_Close.Enabled = True
        Button_Close.BackColor = Color.WhiteSmoke
        Button_Close.ForeColor = Color.Black
    End Sub

    Private Sub Number_48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_48.Click
        YN3.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Close()
        Form_Quiz2_1.Close()
        Form_Quiz2_2.Close()
        Form_TakeQuiz2.txtUserName.Text = ""
        Me.Close()
        Form0.Close()
    End Sub

    Private Sub Button_Menu_Click(sender As Object, e As EventArgs) Handles Button_Menu.Click
        Form_Quiz2_1.Close()
        Form_Quiz2_2.Close()
        Form_TakeQuiz2.txtUserName.Text = ""
        Me.Close()
        Form0.Show()
    End Sub
End Class
