<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/store.Master" CodeBehind="frmlistorder.aspx.vb" Inherits="store.frmlistorder" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server"> 
    <p>&nbsp;</p>
    <div class="checkout-left">
        <asp:GridView ID="gvOrder" runat="server" AutoGenerateColumns="false" class="timetable_sub">
            <Columns>
                <asp:BoundField DataField="customer_name" HeaderText="Name" />
                <asp:BoundField DataField="customer_email" HeaderText="Email" />
                <asp:BoundField DataField="customer_mobil" HeaderText="Mobil" />
                <asp:BoundField DataField="status" HeaderText="Status" />
                <asp:BoundField DataField="create_at" HeaderText="Create" />
                <asp:BoundField DataField="upadte_at" HeaderText="Update" />
            </Columns>
        </asp:GridView>
    </div>
        <p>&nbsp;</p>
</asp:Content>

