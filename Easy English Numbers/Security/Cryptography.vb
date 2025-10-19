Imports System.Security.Cryptography

Namespace Security

    Public Class Cryptography

        Private Shared EncryptionKey As String = "Genting@It'sBestTM2019"

        Public Shared Function Encrypt(str As String) As String

            Dim Results As Byte()
            Dim UTF8 As New System.Text.UTF8Encoding()

            ' Step 1. We hash the passphrase using MD5
            ' We use the MD5 hash generator as the result is a 128 bit byte array
            ' which is a valid length for the TripleDES encoder we use below

            Dim HashProvider As New MD5CryptoServiceProvider()
            Dim TDESKey As Byte() = HashProvider.ComputeHash(UTF8.GetBytes(EncryptionKey))

            ' Step 2. Create a new TripleDESCryptoServiceProvider object
            Dim TDESAlgorithm As New TripleDESCryptoServiceProvider()

            ' Step 3. Setup the encoder
            TDESAlgorithm.Key = TDESKey
            TDESAlgorithm.Mode = CipherMode.ECB
            TDESAlgorithm.Padding = PaddingMode.PKCS7

            ' Step 4. Convert the input string to a byte[]
            Dim DataToEncrypt As Byte() = UTF8.GetBytes(str)

            ' Step 5. Attempt to encrypt the string
            Try
                Dim Encryptor As ICryptoTransform = TDESAlgorithm.CreateEncryptor()
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length)
            Finally
                ' Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear()
                HashProvider.Clear()
            End Try

            ' Step 6. Return the encrypted string as a base64 encoded string

            Return Convert.ToBase64String(Results)

        End Function


        Public Shared Function Decrypt(str As String) As String

            Try
                Dim Results As Byte()
                Dim UTF8 As New System.Text.UTF8Encoding()

                ' Step 1. We hash the passphrase using MD5
                ' We use the MD5 hash generator as the result is a 128 bit byte array
                ' which is a valid length for the TripleDES encoder we use below

                Dim HashProvider As New MD5CryptoServiceProvider()
                Dim TDESKey As Byte() = HashProvider.ComputeHash(UTF8.GetBytes(EncryptionKey))

                ' Step 2. Create a new TripleDESCryptoServiceProvider object
                Dim TDESAlgorithm As New TripleDESCryptoServiceProvider()

                ' Step 3. Setup the decoder
                TDESAlgorithm.Key = TDESKey
                TDESAlgorithm.Mode = CipherMode.ECB
                TDESAlgorithm.Padding = PaddingMode.PKCS7

                ' Step 4. Convert the input string to a byte[]
                Dim DataToDecrypt As Byte() = Convert.FromBase64String(str)

                ' Step 5. Attempt to decrypt the string
                Try
                    Dim Decryptor As ICryptoTransform = TDESAlgorithm.CreateDecryptor()
                    Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length)
                Finally
                    ' Clear the TripleDes and Hashprovider services of any sensitive information
                    TDESAlgorithm.Clear()
                    HashProvider.Clear()
                End Try

                ' Step 6. Return the decrypted string in UTF8 format
                Return UTF8.GetString(Results)
            Catch generatedExceptionName As Exception

                Return str
            End Try

        End Function
    End Class

End Namespace
