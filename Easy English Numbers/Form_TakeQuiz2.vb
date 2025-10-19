' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media
Imports System.Drawing.Printing

Public Class Form_TakeQuiz2
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnStartQuiz_Click(sender As Object, e As EventArgs) Handles btnStartQuiz.Click
        Globals.UserName = txtUserName.Text
        Globals.QuizDate = DateTime.Now.ToString("dddd, dd MMMM yyyy, HH:mm")

        Dim quizForm As New Form_Quiz2_1()
        quizForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Form0.Show()
        txtUserName.Text = ""
        Me.Hide()
    End Sub
End Class
