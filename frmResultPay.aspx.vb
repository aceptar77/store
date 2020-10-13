Imports System.Net.Http
Imports Newtonsoft.Json

Public Class frmResultPay
    Inherits System.Web.UI.Page

    Dim service As String = ConfigurationManager.AppSettings("service")
    ReadOnly login As String = ConfigurationManager.AppSettings("login")
    ReadOnly tranKey As String = ConfigurationManager.AppSettings("tranKey")

    Private Sub frmResultPay_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim paramPay As Rootobject = New Rootobject
        Dim autplacetopay As autplacetopay = New autplacetopay(login, tranKey)
        Dim requestId = String.Empty
        Dim auth As Auth = New Auth
        auth.login = login
        auth.tranKey = autplacetopay.getTranKey
        auth.nonce = autplacetopay.getNonce
        auth.seed = autplacetopay.getSeed
        requestId = Session("resultcreatepayrequestId" + Session.SessionID)
        service = service + requestId
        paramPay.auth = auth
        Dim value As Object = JsonConvert.SerializeObject(paramPay)
        Using client = New HttpClient()
            client.BaseAddress = New Uri(service)
            Dim content = New FormUrlEncodedContent({New KeyValuePair(Of String, String)("", "")})
            Dim result = client.PostAsync(service, New StringContent(value, Encoding.UTF8, "application/json")).Result
            If result.StatusCode = 200 Then
                Dim resultContent As String = result.Content.ReadAsStringAsync().Result
                Dim resultransaction As resultransaction = New resultransaction
                resultransaction = JsonConvert.DeserializeObject(Of resultransaction)(resultContent)

                lblName.Text = resultransaction.request.buyer.name
                lblDate.Text = Now()
                lblStatus.Text = resultransaction.status.status
                lblRef.Text = resultransaction.request.payment.reference
                lblValue.Text = resultransaction.request.payment.amount.total
                lblDescription.Text = resultransaction.request.payment.description
                lblPaymentMethod.Text = resultransaction.payment.FirstOrDefault().paymentMethodName
                lblAuthorization.Text = resultransaction.payment.FirstOrDefault().authorization
                lblReceipt.Text = resultransaction.payment.FirstOrDefault().receipt
            End If
        End Using
    End Sub
End Class