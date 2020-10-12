Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json

Public Class frmMainStore
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Const documentType = "CC"
    Const locale = "es_CO"
    Const currency = "USD"

    ReadOnly service As String = ConfigurationManager.AppSettings("service")
    ReadOnly login As String = ConfigurationManager.AppSettings("login")
    ReadOnly tranKey As String = ConfigurationManager.AppSettings("tranKey")
    ReadOnly paymentredirect As String = ConfigurationManager.AppSettings("paymentredirect")

    Protected Sub btnMakePayment(sender As Object, e As EventArgs)
        Dim paramPay As Rootobject = New Rootobject
        paramPay.ipAddress = Request.UserHostAddress
        paramPay.expiration = "2020-10-15T09:19:28-05:00"
        paramPay.returnUrl = paymentredirect
        paramPay.userAgent = Request.ServerVariables("HTTP_USER_AGENT")
        paramPay.locale = locale

        Dim autplacetopay As autplacetopay = New autplacetopay(login, tranKey)

        Dim auth As Auth = New Auth
        auth.login = login
        auth.tranKey = autplacetopay.getTranKey
        auth.nonce = autplacetopay.getNonce
        auth.seed = autplacetopay.getSeed

        Dim buyer As Buyer = New Buyer
        buyer.document = txtID.Text
        buyer.email = txtEmail.Text
        buyer.mobile = txtMovilNumber.Text
        buyer.name = txtFullName.Text
        buyer.surname = txtFullName.Text
        buyer.documentType = "CC"

        Dim payment As Payment = New Payment
        Dim amount As Amount = New Amount
        amount.currency = currency
        amount.total = "289"
        payment.amount = amount
        payment.allowPartial = False
        payment.description = "Pago"
        payment.reference = "1"

        paramPay.payment = payment
        paramPay.buyer = buyer
        paramPay.auth = auth

        Dim value As Object = JsonConvert.SerializeObject(paramPay)
        Using client = New HttpClient()
            client.BaseAddress = New Uri(service)
            Dim content = New FormUrlEncodedContent({New KeyValuePair(Of String, String)("", "")})
            Dim result = client.PostAsync(service, New StringContent(value, Encoding.UTF8, "application/json")).Result
            If result.StatusCode = 200 Then
                Dim resultcreatepay As resultcreatepay = New resultcreatepay
                Dim resultContent As String = result.Content.ReadAsStringAsync().Result
                resultcreatepay = JsonConvert.DeserializeObject(Of resultcreatepay)(resultContent)
                Session("resultcreatepayrequestId" + Session.SessionID) = resultcreatepay.requestId
                Response.Redirect(resultcreatepay.processUrl)
            End If
        End Using

    End Sub
End Class