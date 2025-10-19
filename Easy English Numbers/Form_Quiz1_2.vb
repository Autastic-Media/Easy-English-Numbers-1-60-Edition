' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form_Quiz1_2

    'This Hides the Next button, continues previous score and disables question 5 and 6 answer buttons.

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblScore.Text = "Score: 3 out of 9"
        Button_Close.Enabled = False
        Button_Close.BackColor = Color.Gray
        Button_Next.Hide()
        Number_17.Enabled = False
        Number_17.BackColor = Color.Gray
        Number_14.Enabled = False
        Number_14.BackColor = Color.Gray
        Number_18.Enabled = False
        Number_18.BackColor = Color.Gray
        Number_11.Enabled = False
        Number_11.BackColor = Color.Gray()
        Number_16.Enabled = False
        Number_16.BackColor = Color.Gray()
        Number_13.Enabled = False
        Number_13.BackColor = Color.Gray()
    End Sub

    Private Sub Number_12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_12.Click
        YN1.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub


    Private Sub Number_15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_15.Click
        YN1.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    'This Enables question 5 buttons and disables question 4 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_10.Click
        YN1.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 4 out of 9"
        Number_17.Enabled = True
        Number_17.BackColor = Color.White
        Number_14.Enabled = True
        Number_14.BackColor = Color.White
        Number_18.Enabled = True
        Number_18.BackColor = Color.White
        Number_12.Enabled = False
        Number_12.BackColor = Color.Gray()
        Number_10.Enabled = False
        Number_10.BackColor = Color.Gray()
        Number_15.Enabled = False
        Number_15.BackColor = Color.Gray()
    End Sub

    Private Sub Number_17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_17.Click
        YN2.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    'This Enables question 6 buttons and disables question 5 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_18.Click
        YN2.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 5 out of 9"
        Number_17.Enabled = False
        Number_17.BackColor = Color.Gray
        Number_14.Enabled = False
        Number_14.BackColor = Color.Gray
        Number_18.Enabled = False
        Number_18.BackColor = Color.Gray
        Number_11.Enabled = True
        Number_11.BackColor = Color.White
        Number_16.Enabled = True
        Number_16.BackColor = Color.White
        Number_13.Enabled = True
        Number_13.BackColor = Color.White
    End Sub

    Private Sub Number_14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_14.Click
        YN2.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    'This Enables the Next button and disables question 5 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_11.Click
        YN3.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 6 out of 9"
        Number_11.Enabled = False
        Number_11.BackColor = Color.Gray
        Number_16.Enabled = False
        Number_16.BackColor = Color.Gray
        Number_13.Enabled = False
        Number_13.BackColor = Color.Gray
        Button_Next.Show()
    End Sub

    Private Sub Number_16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_16.Click
        YN3.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_13.Click
        YN3.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Button_Next_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Next.Click
        Form_Quiz1_3.Show()
        Me.Hide()
    End Sub
End Class
