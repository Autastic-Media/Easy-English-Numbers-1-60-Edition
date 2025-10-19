' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form_Quiz2_1

    'This Hides the Next button and disables question 2 and 3 answer buttons.

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button_Next.Hide()
        Form_Quiz1_3.Close()
        Number_34.Enabled = False
        Number_34.BackColor = Color.Gray
        Number_30.Enabled = False
        Number_30.BackColor = Color.Gray
        Number_36.Enabled = False
        Number_36.BackColor = Color.Gray
        Number_35.Enabled = False
        Number_35.BackColor = Color.Gray
        Number_32.Enabled = False
        Number_32.BackColor = Color.Gray
        Number_29.Enabled = False
        Number_29.BackColor = Color.Gray
    End Sub

    Private Sub Number_28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_28.Click
        YN1.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    'This Enables question 2 buttons and disables question 1 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_33.Click
        YN1.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 1 out of 9"
        Number_34.Enabled = True
        Number_34.BackColor = Color.Gray
        Number_30.Enabled = True
        Number_30.BackColor = Color.Gray
        Number_36.Enabled = True
        Number_36.BackColor = Color.Gray
        Number_33.Enabled = False
        Number_33.BackColor = Color.Gray
        Number_28.Enabled = False
        Number_28.BackColor = Color.Gray()
        Number_31.Enabled = False
        Number_31.BackColor = Color.Gray
    End Sub

    Private Sub Number_31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_31.Click
        YN1.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    'This Enables question 3 buttons and disables question 2 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_36.Click
        YN2.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 2 out of 9"
        Number_34.Enabled = False
        Number_34.BackColor = Color.Gray
        Number_30.Enabled = False
        Number_30.BackColor = Color.Gray
        Number_36.Enabled = False
        Number_36.BackColor = Color.Gray
        Number_35.Enabled = True
        Number_35.BackColor = Color.Gray
        Number_32.Enabled = True
        Number_32.BackColor = Color.Gray
        Number_29.Enabled = True
        Number_29.BackColor = Color.Gray
    End Sub

    Private Sub Number_30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_30.Click
        YN2.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_34.Click
        YN2.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_35.Click
        YN3.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_32.Click
        YN3.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    'This Enables the Next button and disables question 3 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_29.Click
        YN3.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 3 out of 9"
        Button_Next.Show()
        Number_35.Enabled = False
        Number_35.BackColor = Color.Gray
        Number_32.Enabled = False
        Number_32.BackColor = Color.Gray
        Number_29.Enabled = False
        Number_29.BackColor = Color.Gray
    End Sub

    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
        Form_TakeQuiz1.txtUserName.Text = ""
        Form0.Show()
    End Sub

    Private Sub Button_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Next.Click
        Form_Quiz2_2.Show()
        Me.Hide()
    End Sub
End Class
