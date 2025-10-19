' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Drawing.Printing
Imports System.Media

Public Class FormQ3_Done

    ' Declare PrintDocument with WithEvents to support print handling
    Private WithEvents PrintDocument1 As New PrintDocument()

    Private Sub FormQ3_Done_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateTime.Text = "On: " & Globals.QuizDate
        txtUserName.Text = Globals.UserName
        lblDateTime.Text = Globals.QuizDate
        ' Optional diagnostic
        ' MessageBox.Show("Loaded name: " & Globals.UserName)
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Close()
        Form_Quiz3_3.Show() ' Restore final quiz form after results sanctuary closes
    End Sub

    Private Sub Button_Result_Click(sender As Object, e As EventArgs) Handles Button_Result.Click
        ' Ritual correction: ensure correct form is visible before print
        Form_Quiz3_2.Hide()
        Form_Quiz3_3.Hide()

        ' Prepare print document
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintDocument1.DefaultPageSettings.Margins = New Margins(50, 50, 50, 50)

        ' Capture bitmap of current form
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        bmp.SetResolution(300, 300)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))

        ' Aspect-ratio–preserving print logic
        AddHandler PrintDocument1.PrintPage, Sub(sender2, e2)
                                                 Dim bmpWidth As Integer = bmp.Width
                                                 Dim bmpHeight As Integer = bmp.Height
                                                 Dim pageWidth As Integer = e2.MarginBounds.Width
                                                 Dim pageHeight As Integer = e2.MarginBounds.Height
                                                 Dim scaleFactor As Single = Math.Min(pageWidth / bmpWidth, pageHeight / bmpHeight)
                                                 Dim scaledWidth As Integer = CInt(bmpWidth * scaleFactor)
                                                 Dim scaledHeight As Integer = CInt(bmpHeight * scaleFactor)
                                                 Dim posX As Integer = e2.MarginBounds.Left + (pageWidth - scaledWidth) \ 2
                                                 Dim posY As Integer = e2.MarginBounds.Top + (pageHeight - scaledHeight) \ 2
                                                 e2.Graphics.DrawImage(bmp, posX, posY, scaledWidth, scaledHeight)
                                             End Sub

        ' Show print dialog
        Dim dlg As New PrintDialog()
        dlg.Document = PrintDocument1
        dlg.UseEXDialog = True

        If dlg.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
            ' Do NOT restore Form_Quiz3_3 again here
        End If
    End Sub

End Class