Imports NAudio.Wave
Imports System.IO

Public Module AudioHelper
    Private currentOutput As WaveOutEvent

    Public Sub PlaySound(sound As Stream)
        If currentOutput IsNot Nothing Then
            currentOutput.Stop()
            currentOutput.Dispose()
        End If

        Dim reader As New WaveFileReader(sound)
        currentOutput = New WaveOutEvent()
        currentOutput.Init(reader)

        ' Volume scaling: 0.0 to 1.0
        currentOutput.Volume = Math.Min(Math.Max(Globals.VolumeLevel / 100.0F, 0.0F), 1.0F)

        currentOutput.Play()
    End Sub
End Module