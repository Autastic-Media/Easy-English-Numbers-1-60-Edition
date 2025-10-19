' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form_Quiz4_2

    'This Hides the Next button, continues previous score and disables question 5 and 6 answer buttons.

    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblScore.Text = "Score: 3 out of 9"
        Button_Close.Enabled = False
        Button_Close.BackColor = Color.Gray
        Button_Next.Hide()
        Number_38.Enabled = False
        Number_38.BackColor = Color.Gray
        Number_41.Enabled = False
        Number_41.BackColor = Color.Gray
        Number_39.Enabled = False
        Number_39.BackColor = Color.Gray
        Number_43.Enabled = False
        Number_43.BackColor = Color.Gray()
        Number_44.Enabled = False
        Number_44.BackColor = Color.Gray()
        Number_45.Enabled = False
        Number_45.BackColor = Color.Gray()
    End Sub

    'This Enables question 5 buttons and disables question 4 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_37.Click
        YN1.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 4 out of 9"
        Number_38.Enabled = True
        Number_38.BackColor = Color.White
        Number_41.Enabled = True
        Number_41.BackColor = Color.White
        Number_39.Enabled = True
        Number_39.BackColor = Color.White
        Number_42.Enabled = False
        Number_42.BackColor = Color.Gray()
        Number_37.Enabled = False
        Number_37.BackColor = Color.Gray()
        Number_40.Enabled = False
        Number_40.BackColor = Color.Gray()
    End Sub

    Private Sub Number_40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_40.Click
        YN1.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_42.Click
        YN1.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    'This Enables question 6 buttons and disables question 5 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_41.Click
        YN2.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 5 out of 9"
        Number_38.Enabled = False
        Number_38.BackColor = Color.Gray
        Number_41.Enabled = False
        Number_41.BackColor = Color.Gray
        Number_39.Enabled = False
        Number_39.BackColor = Color.Gray
        Number_43.Enabled = True
        Number_43.BackColor = Color.White
        Number_44.Enabled = True
        Number_44.BackColor = Color.White
        Number_45.Enabled = True
        Number_45.BackColor = Color.White
    End Sub

    Private Sub Number_38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_38.Click
        YN2.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_39.Click
        YN2.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_44.Click
        YN3.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    'This Enables the Next button and disables question 5 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_43.Click
        YN3.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 6 out of 9"
        Number_43.Enabled = False
        Number_43.BackColor = Color.Gray
        Number_44.Enabled = False
        Number_44.BackColor = Color.Gray
        Number_45.Enabled = False
        Number_45.BackColor = Color.Gray
        Button_Next.Show()
    End Sub

    Private Sub Number_45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_45.Click
        YN3.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Button_Next_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Next.Click
        Form_Quiz4_3.Show()
        Me.Hide()
    End Sub

End Class
