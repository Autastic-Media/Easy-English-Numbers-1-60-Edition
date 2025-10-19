' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.IO

Public Class FormLog

    ' Here if the correct password is entered, the Login button is enabled and the user is allowed to go to Form0

    Private Sub Password_TextChanged(sender As System.Object, e As System.EventArgs) Handles Password.TextChanged
        If Security.Globals.LicenceKeys.Contains(Password.Text) Then
            Login.Enabled = True
            PassInfo.Text = "That is correct! Please Login."
        End If

        If Password.Text = "" Then
            Login.Enabled = False
            PassInfo.Text = ""
        End If

        If Len(Password.Text) = +2 Then
            Login.Enabled = False
            PassInfo.Text = "That is incorrect! Please try again."
        End If
    End Sub

    Private Sub FormLog_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Login.Enabled = False
    End Sub

    Private Sub Login_Click(sender As System.Object, e As System.EventArgs) Handles Login.Click
        Security.Licence.Save(Password.Text)

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Clear_Click(sender As System.Object, e As System.EventArgs) Handles Clear.Click
        Password.Text = ""
        PassInfo.Text = ""
        CheckBox1.Checked = False
    End Sub

    Private Sub Close_Click(sender As System.Object, e As System.EventArgs) Handles BTN_Close.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            CheckBox1.Text = "Hide Password"
            Password.PasswordChar = ""
        Else
            Password.PasswordChar = "*"
            CheckBox1.Text = "View Password"
        End If
    End Sub
End Class
