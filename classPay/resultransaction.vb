Public Class Payer
    Public Property document As String
    Public Property documentType As String
    Public Property name As String
    Public Property surname As String
    Public Property email As String
    Public Property mobile As Integer
End Class

Public Class Field
    Public Property keyword As String
    Public Property value As String
    Public Property displayOn As String
End Class

Public Class Request
    Public Property locale As String
    Public Property buyer As Buyer
    Public Property payer As Payer
    Public Property payment As Payment
    Public Property fields As List(Of Field)
    Public Property returnUrl As String
    Public Property ipAddress As String
    Public Property userAgent As String
    Public Property expiration As DateTime
End Class

Public Class Status2
    Public Property status As String
    Public Property reason As String
    Public Property message As String
    Public Property _date As DateTime
End Class

Public Class From
    Public Property currency As String
    Public Property total As Integer
End Class

Public Class [To]
    Public Property currency As String
    Public Property total As Integer
End Class

Public Class Amount2
    Public Property from As From
    Public Property [to] As [To]
    Public Property factor As String
End Class

Public Class ProcessorField
    Public Property keyword As String
    Public Property value As String
    Public Property displayOn As String
End Class

Public Class Payment2
    Public Property status As Status2
    Public Property internalReference As String
    Public Property paymentMethod As String
    Public Property paymentMethodName As String
    Public Property issuerName As String
    Public Property amount As Amount2
    Public Property authorization As String
    Public Property reference As String
    Public Property receipt As String
    Public Property franchise As String
    Public Property refunded As Boolean
    Public Property processorFields As List(Of ProcessorField)
End Class

Public Class resultransaction
    Public Property requestId As Integer
    Public Property status As Status
    Public Property request As Request
    Public Property payment As List(Of Payment2)
    Public Property subscription As Object
End Class
