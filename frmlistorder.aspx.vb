Public Class frmlistorder
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim listorder As orderComponents = New orderComponents
        gvOrder.DataSource = listorder.selectOrder.ToList
        gvOrder.DataBind()
    End Sub

End Class