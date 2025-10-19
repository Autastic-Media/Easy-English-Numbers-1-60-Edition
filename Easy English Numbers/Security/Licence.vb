Imports System.IO

Namespace Security
    Public Class Licence

        Public Shared Function IsValid() As Boolean
            Dim result As Boolean = False

            If File.Exists(Globals.LicenceFile) Then
                Dim decryptedLicence As String = ""

                Using tw As StreamReader = My.Computer.FileSystem.OpenTextFileReader(Path.Combine(Globals.LicencePath, "licence.lic"))
                    Dim licence As String = tw.ReadLine()
                    decryptedLicence = Security.Cryptography.Decrypt(licence)
                End Using

                If decryptedLicence.Contains(";") Then
                    Dim lic As String() = Split(decryptedLicence, ";")

                    If lic(1) = Globals.ComputerName AndAlso Globals.LicenceKeys.Contains(lic(0)) Then
                        result = True
                    End If
                End If
            End If

            Return result
        End Function

        Public Shared Sub Save(licenceKey As String)
            Dim licence As String = String.Format("{0};{1}", licenceKey, Globals.ComputerName)
            Dim encryptedLicence As String = Security.Cryptography.Encrypt(licence)

            Directory.CreateDirectory(Globals.LicencePath)

            If File.Exists(Globals.LicenceFile) Then
                File.Delete(Globals.LicenceFile)
            End If

            Using tw As StreamWriter = File.CreateText(Globals.LicenceFile)
                tw.WriteLine(encryptedLicence)
            End Using
        End Sub

    End Class

End Namespace