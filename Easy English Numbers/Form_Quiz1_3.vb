' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form_Quiz1_3


    'This Hides the Next button, continues previous score and disables question 8 and 9 answer buttons.

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblScore.Text = "Score: 6 out of 9"
        Button_Menu.Hide()
        Button_Close.Enabled = False
        Button_Close.BackColor = Color.Gray
        Number_27.Enabled = False
        Number_27.BackColor = Color.Gray
        Number_22.Enabled = False
        Number_22.BackColor = Color.Gray
        Number_24.Enabled = False
        Number_24.BackColor = Color.Gray
        Number_25.Enabled = False
        Number_25.BackColor = Color.Gray
        Number_23.Enabled = False
        Number_23.BackColor = Color.Gray
        Number_26.Enabled = False
        Number_26.BackColor = Color.Gray
    End Sub

    Private Sub Number_19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_19.Click
        YN1.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    'This Enables question 8 buttons and disables question 7 buttons. It also adds 1 point for the correct answer.

    Private Sub Number_20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_20.Click
        YN1.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 7 out of 9"
        Number_27.Enabled = True
        Number_27.BackColor = Color.White
        Number_22.Enabled = True
        Number_22.BackColor = Color.White
        Number_24.Enabled = True
        Number_24.BackColor = Color.White
        Number_19.Enabled = False
        Number_19.BackColor = Color.Gray
        Number_21.Enabled = False
        Number_21.BackColor = Color.Gray
        Number_20.Enabled = False
        Number_20.BackColor = Color.Gray
    End Sub

    Private Sub Number_21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_21.Click
        YN1.Image = Image.FromFile("Resources/cross2png")
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub


    'This Enables question 9 buttons and disables question 8 buttons. It also adds 1 point for the correct answer.


    Private Sub Number_22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_22.Click
        YN2.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 8 out of 9"
        Number_27.Enabled = False
        Number_27.BackColor = Color.Gray
        Number_22.Enabled = False
        Number_22.BackColor = Color.Gray
        Number_24.Enabled = False
        Number_24.BackColor = Color.Gray
        Number_25.Enabled = True
        Number_25.BackColor = Color.White
        Number_23.Enabled = True
        Number_23.BackColor = Color.White
        Number_26.Enabled = True
        Number_26.BackColor = Color.White
    End Sub


    Private Sub Number_27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_27.Click
        YN2.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_24.Click
        YN2.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_26.Click
        YN3.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub

    Private Sub Number_23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_23.Click
        YN3.Image = My.Resources.cross2
 AudioHelper.PlaySound(My.Resources.NoSound)
    End Sub


    'This Enables the Next button and disables question 8 buttons. It also adds 1 point for the correct answer.
    'This also pops up a results form of all completed questions for print out.

    Private Sub Number_25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number_25.Click
        YN3.Image = My.Resources.tick2
 AudioHelper.PlaySound(My.Resources.YesSound)
        lblScore.Text = "Score: 9 out of 9 - Congratulations!"
        Number_25.Enabled = False
        Number_25.BackColor = Color.Gray
        Number_23.Enabled = False
        Number_23.BackColor = Color.Gray
        Number_26.Enabled = False
        Number_26.BackColor = Color.Gray
        Button_Menu.Show()
        'This pops up a results form of all completed questions for print out.
        FormQ1_Done.Show()
        Button_Close.Enabled = True
        Button_Close.BackColor = Color.WhiteSmoke
        Button_Close.ForeColor = Color.Black
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Close()
        Form_Quiz1_1.Close()
        Form_Quiz1_2.Close()
        Form_TakeQuiz1.txtUserName.Text = ""
        Me.Close()
        Form0.Close()
    End Sub

    Private Sub Button_Menu_Click(sender As Object, e As EventArgs) Handles Button_Menu.Click
        Form_Quiz1_1.Close()
        Form_Quiz1_2.Close()
        Form_TakeQuiz1.txtUserName.Text = ""
        Me.Close()
        Form0.Show()
    End Sub
End Class
