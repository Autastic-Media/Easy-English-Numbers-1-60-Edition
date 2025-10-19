' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form_Quiz3_1

    'This Hides the Next button and disables question 2 and 3 answer buttons.

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button_Next.Hide()
        Number_7.Enabled = False
        Number_7.BackColor = Color.Gray
        Number_1.Enabled = False
        Number_1.BackColor = Color.Gray
        Number_4.Enabled = False
        Number_4.BackColor = Color.Gray
        Number_6.Enabled = False
        Number_6.BackColor = Color.Gray
        Number_2.Enabled = False
        Number_2.BackColor = Color.Gray
        Number_8.Enabled = False
        Number_8.BackColor = Color.Gray
    End Sub

    'This Enables question 2 buttons and disables question 1 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_9.Click
        YN1.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 1 out of 9"
        Number_7.Enabled = True
        Number_7.BackColor = Color.Gray
        Number_1.Enabled = True
        Number_1.BackColor = Color.Gray
        Number_4.Enabled = True
        Number_4.BackColor = Color.Gray
        Number_5.Enabled = False
        Number_5.BackColor = Color.Gray
        Number_3.Enabled = False
        Number_3.BackColor = Color.Gray()
        Number_9.Enabled = False
        Number_9.BackColor = Color.Gray
    End Sub

    Private Sub Number_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_3.Click
        YN1.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_5.Click
        YN1.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_1.Click
        YN2.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_4.Click
        YN2.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    'This Enables question 3 buttons and disables question 2 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_7.Click
        YN2.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 2 out of 9"
        Number_7.Enabled = False
        Number_7.BackColor = Color.Gray
        Number_1.Enabled = False
        Number_1.BackColor = Color.Gray
        Number_4.Enabled = False
        Number_4.BackColor = Color.Gray
        Number_6.Enabled = True
        Number_6.BackColor = Color.Gray
        Number_2.Enabled = True
        Number_2.BackColor = Color.Gray
        Number_8.Enabled = True
        Number_8.BackColor = Color.Gray
    End Sub

    Private Sub Number_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_6.Click
        YN3.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    'This Enables the Next button and disables question 3 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_2.Click
        YN3.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 3 out of 9"
        Button_Next.Show()
        Number_6.Enabled = False
        Number_6.BackColor = Color.Gray
        Number_2.Enabled = False
        Number_2.BackColor = Color.Gray
        Number_8.Enabled = False
        Number_8.BackColor = Color.Gray

    End Sub

    Private Sub Number_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_8.Click
        YN3.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
        Form_TakeQuiz1.txtUserName.Text = ""
        Form0.Show()
    End Sub

    Private Sub Button_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Next.Click
        Form_Quiz3_2.Show()
        Me.Hide()
    End Sub
End Class
