Imports System.IO

Class autplacetopay
    Private login As String
    Private tranKey As String
    Private seed As String
    Private nonce As String

    Public Sub New(ByVal login As String, ByVal tranKey As String)
        Me.login = login
        Me.tranKey = tranKey
        Generate()
    End Sub

    Public Function Generate() As autplacetopay
        nonce = (New Random()).GetHashCode().ToString()
        seed = (DateTime.Now).ToString("yyyy-MM-ddTHH:mm:sszzz")
        Return Me
    End Function

    Public Function getTranKey() As String
        Return Base64(ToSha1(nonce & seed & tranKey))
    End Function

    Public Function getSeed() As String
        Return Me.seed
    End Function

    Public Function getNonce() As String
        Return Base64(nonce)
    End Function

    Public Shared Function Base64(ByVal input As Byte()) As String
        Return System.Convert.ToBase64String(input)
    End Function

    Public Shared Function Base64(ByVal input As String) As String
        If input IsNot Nothing Then
            Return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input))
        End If

        Return ""
    End Function

    Public Shared Function ToSha1(ByVal text As String) As Byte()
        Dim hashString As System.Security.Cryptography.SHA1 = New System.Security.Cryptography.SHA1CryptoServiceProvider()
        Return hashString.ComputeHash(ToStream(text))
    End Function

    Public Shared Function ToStream(ByVal text As String) As Stream
        Dim stream As MemoryStream = New MemoryStream()
        Dim sw As StreamWriter = New StreamWriter(stream)
        sw.Write(text)
        sw.Flush()
        stream.Position = 0
        Return stream
    End Function
End Class
