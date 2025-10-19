' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form1

    Private Sub Button_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_1.Click
        AudioHelper.PlaySound(My.Resources.A1)
    End Sub

    Private Sub Button_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_2.Click
        AudioHelper.PlaySound(My.Resources.A2)
    End Sub

    Private Sub Button_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_3.Click
        AudioHelper.PlaySound(My.Resources.A3)
    End Sub

    Private Sub Button_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_4.Click
        AudioHelper.PlaySound(My.Resources.A4)
    End Sub

    Private Sub Button_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_5.Click
        AudioHelper.PlaySound(My.Resources.A5)
    End Sub

    Private Sub Button_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_6.Click
        AudioHelper.PlaySound(My.Resources.A6)
    End Sub

    Private Sub Button_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_7.Click
        AudioHelper.PlaySound(My.Resources.A7)
    End Sub

    Private Sub Button_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_8.Click
        AudioHelper.PlaySound(My.Resources.A8)
    End Sub

    Private Sub Button_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_9.Click
        AudioHelper.PlaySound(My.Resources.A9)
    End Sub

    Private Sub Button_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_10.Click
        AudioHelper.PlaySound(My.Resources.A10)
    End Sub

    Private Sub Button_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Next.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Back.Click
        Me.Close()
        Form0.Show()
    End Sub

    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Close()
        Form0.Show()
    End Sub

    Private Sub Button_11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_11.Click
        AudioHelper.PlaySound(My.Resources.A11)
    End Sub

    Private Sub Button_12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_12.Click
        AudioHelper.PlaySound(My.Resources.A12)
    End Sub
End Class
