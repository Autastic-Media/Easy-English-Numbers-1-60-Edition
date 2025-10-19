' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form2

    Private Sub Button_13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_13.Click
 AudioHelper.PlaySound(My.Resources.A13)
    End Sub

    Private Sub Button_14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_14.Click
 AudioHelper.PlaySound(My.Resources.A14)
    End Sub

    Private Sub Button_15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_15.Click
 AudioHelper.PlaySound(My.Resources.A15)
    End Sub

    Private Sub Button_16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_16.Click
 AudioHelper.PlaySound(My.Resources.A16)
    End Sub

    Private Sub Button_17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_17.Click
 AudioHelper.PlaySound(My.Resources.A17)
    End Sub

    Private Sub Button_18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_18.Click
 AudioHelper.PlaySound(My.Resources.A18)
    End Sub

    Private Sub Button_19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_19.Click
 AudioHelper.PlaySound(My.Resources.A19)
    End Sub

    Private Sub Button_20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_20.Click
 AudioHelper.PlaySound(My.Resources.A20)
    End Sub

    Private Sub Button_21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_21.Click
 AudioHelper.PlaySound(My.Resources.A21)
    End Sub

    Private Sub Button_22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_22.Click
 AudioHelper.PlaySound(My.Resources.A22)
    End Sub

    Private Sub Button_23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_23.Click
 AudioHelper.PlaySound(My.Resources.A23)
    End Sub

    Private Sub Button_24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_24.Click
 AudioHelper.PlaySound(My.Resources.A24)
    End Sub

    Private Sub Button_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Next.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Button_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Back.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Close()
        Form0.Show()
    End Sub

End Class
