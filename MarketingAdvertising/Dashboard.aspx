<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="MarketingAdvertising.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/Window.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script type="text/javascript">
        function ShowDialogForDeviceAddition() {
            $("#grayWindow").show();
            $("#divAddDeviceDetails").fadeIn(300);
            return false;
        }
        function ShowDialogForCustomerAddition() {
            $("#grayWindow").show();
            $("#divAddCustomerDetails").fadeIn(300);
            return false;
        }

        function HideDialogForDeviceAddition() {
            $("#grayWindow").hide();
            $("#divAddDeviceDetails").fadeOut(300);
        }
        function HideDialogForCustomerAddition() {
            $("#grayWindow").hide();
            $("#divAddCustomerDetails").fadeOut(300);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAddDeviceDetails" runat="server" Text="Add Device" OnClientClick="return ShowDialogForDeviceAddition()" />
        </div>
        <div>
            <asp:Button ID="btnAddCustomerInfo" runat="server" Text="Add Device" OnClientClick="return ShowDialogForCustomerAddition()" />
        </div>

        <asp:GridView runat="server" ID="grdDevice" OnRowDataBound="grdDevice_RowDataBound" HeaderStyle-BackColor="DimGray" AlternatingRowStyle-BackColor="LightGray">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkDeviceMac" runat="server" OnCommand="DisplayRecord_Click"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:GridView runat="server" ID="grdCustomer"></asp:GridView>

        <div id="grayWindow" class="ChetanGrayWindow">
        </div>
        <div id="divAddDeviceDetails" class="ChetanWindow" style="display: none;">
            <table>
                <tr>
                    <td class="windowTitle" style="width: 100%">
                        <label id="Label1" title="">
                            Add Device Details
                        </label>
                    </td>
                    <td class="windowTitle align_right">
                        <a href="#" id="btnCloseWindowAddUser" onclick="return HideDialogForDeviceAddition();">Close</a>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;
                    </td>
                    <td>&nbsp;
                    </td>
                </tr>
                <tr>
                    <td>Device Mac#
                    </td>
                    <td>
                        <asp:TextBox ID="txtDeviceMac" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Device Address 1
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Device Address 2
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Device City
                    </td>
                    <td>
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Device State
                    </td>
                    <td>
                        <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Device Country
                    </td>
                    <td>
                        <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>
        </div>


        <div id="divAddCustomerDetails" class="ChetanWindow" style="display: none;">
            <table>
                <tr>
                    <td class="windowTitle" style="width: 100%">
                        <label id="Label1" title="">
                            Add Customer Details
                        </label>
                    </td>
                    <td class="windowTitle align_right">
                        <a href="#" id="btnCloseWindowAddCustomer" onclick="return HideDialogForCustomerAddition();">Close</a>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;
                    </td>
                    <td>&nbsp;
                    </td>
                </tr>
                <tr>
                    <td>First Name
                    </td>
                    <td>
                        <asp:TextBox ID="txtCustomerFName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Last Name
                    </td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Cell Number
                    </td>
                    <td>
                        <asp:TextBox ID="txtCellNumber" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnAddCustomer" runat="server" Text="Submit" OnClick="btnAddCustomer_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
