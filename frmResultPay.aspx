<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/store.Master" CodeBehind="frmResultPay.aspx.vb" Inherits="store.frmResultPay" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <div class="checkout-left">
            <p>&nbsp;</p>
        <h3>Hello
            <asp:Label id="lblName" Text="" runat="server" />
        </h3>
        <br>
        Your transaction in store - Trade has been
    <asp:Label id="lblStatus" Text="" runat="server" class="control-label" />
        <table class="timetable_sub">
            <tbody>
                <tr>
                    <td>Date</td>
                    <td>
                        <asp:Label id="lblDate" Text="" runat="server" class="control-label" />
                    </td>
                </tr>
                <tr>
                    <td>Ref</td>
                    <td>
                        <asp:Label id="lblRef" Text="" runat="server" class="control-label" />
                    </td>
                </tr>
                <tr>
                    <td>Value</td>
                    <td>
                        <asp:Label id="lblValue" Text="" runat="server" class="control-label" />
                    </td>
                </tr>
                <tr>
                    <td>Description</td>
                    <td>
                        <asp:Label id="lblDescription" Text="" runat="server" class="control-label" />
                    </td>
                </tr>
                <tr>
                    <td>Payment Method</td>
                    <td>
                        <asp:Label id="lblPaymentMethod" Text="" runat="server" class="control-label" />
                    </td>
                </tr>
                <tr>
                    <td>Card</td>
                    <td>
                        <asp:Label id="lblCard" Text="" runat="server" class="control-label" />
                    </td>
                </tr>
                <tr>
                    <td>Number of Payments</td>
                    <td>
                        <asp:Label id="lblNumberPayments" Text="" runat="server" class="control-label" />
                    </td>
                </tr>
                <tr>
                    <td>Authorization</td>
                    <td>
                        <asp:Label id="lblAuthorization" Text="" runat="server" class="control-label" />
                    </td>
                </tr>
                <tr>
                    <td>Receipt</td>
                    <td>
                        <asp:Label id="lblReceipt" Text="" runat="server" class="control-label" />
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
        <p>&nbsp;</p>
</asp:Content>
