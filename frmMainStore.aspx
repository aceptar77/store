<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/store.Master" CodeBehind="frmMainStore.aspx.vb" Inherits="store.frmMainStore" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <div class="checkout-left">
        <table class="timetable_sub">
            <thead>
                <tr>
                    <th>SL No.</th>
                    <th>Product</th>
                    <th>Quality</th>
                    <th>Product Name</th>
                    <th>Price</th>
                </tr>
            </thead>
            <tbody>
                <tr class="rem1">
                    <td class="invert">1</td>
                    <td class="invert-image"><a href="single.html">
                        <img src="images/1.png" alt=" " class="img-responsive"></a></td>
                    <td class="invert">
                        <div class="quantity">
                            <div class="quantity-select">
                                <div class="entry value-minus">&nbsp;</div>
                                <div class="entry value"><span>1</span></div>
                                <div class="entry value-plus active">&nbsp;</div>
                            </div>
                        </div>
                    </td>
                    <td class="invert">Fortune Sunflower Oil</td>

                    <td class="invert" id="price">290</td>

                </tr>
            </tbody>
        </table>
    </div>

    <section class="creditly-wrapper wthree, w3_agileits_wrapper">
        <div class="clear"></div>

        <div class="information-wrapper">
            <div class="w3_agileits_card_number_grid_left">
                <div class="controls">
                    <label class="control-label">CC: </label>
                    <asp:TextBox ID="txtID" Text="" runat="server" class="form-control" placeholder="Full Name" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'ID';}" required="" />
                </div>
            </div>
            <div class="w3_agileits_card_number_grid_left">
                <div class="controls">
                    <label class="control-label">Full name: </label>
                    <asp:TextBox ID="txtFullName" Text="" runat="server" class="form-control" placeholder="Full Name" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Full Name';}" required="" />
                </div>
            </div>
            <div class="w3_agileits_card_number_grid_left">
                <div class="controls">
                    <label class="control-label">Mobile number:</label>
                    <asp:TextBox ID="txtMovilNumber" Text="" runat="server" class="form-control" placeholder="Mobile number" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Movil Number';}" required="" />
                </div>
            </div>
            <div class="w3_agileits_card_number_grid_right">
                <div class="controls">
                    <label class="control-label">Email: </label>
                    <asp:TextBox ID="txtEmail" Text="" runat="server" class="form-control" placeholder="Email" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Email';}" required="" />
                </div>
            </div>

            <div class="clear"></div>
        </div>
    </section>
    <div class="w3_agileits_card_number_grid_right">
        <div class="controls">
            <asp:Button OnClick="btnMakePayment" Text="Make Payment" runat="server" CssClass="btn-primary" />
        </div>
    </div>

</asp:Content>

