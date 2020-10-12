Public Class Rootobject
    Public Property auth As Auth
    Public Property locale As String
    Public Property buyer As Buyer
    Public Property payment As Payment
    Public Property expiration As Date
    Public Property returnUrl As String
    Public Property ipAddress As String
    Public Property userAgent As String
End Class

Public Class Auth
    Public Property login As String
    Public Property tranKey As String
    Public Property nonce As String
    Public Property seed As Date
End Class

Public Class Buyer
    Public Property name As String
    Public Property surname As String
    Public Property email As String
    Public Property document As String
    Public Property documentType As String
    Public Property mobile As Long
End Class

Public Class Payment
    Public Property reference As String
    Public Property description As String
    Public Property amount As Amount
    Public Property allowPartial As Boolean
End Class

Public Class Amount
    Public Property currency As String
    Public Property total As String
End Class


