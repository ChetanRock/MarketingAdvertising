<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SlotInfo.aspx.cs" Inherits="MarketingAdvertising.SlotInfo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/bootstrap-datetimepicker.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $(".form_datetime").datetimepicker({ format: 'hh:mm' });
        })
      
</script>            
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table>
                <tr>
                    <td>Date:
                    </td>
                    <td>
                        <asp:Calendar ID="calDate" runat="server"></asp:Calendar>
                    </td>
                </tr>

                <tr>
                    <td>From :
                    </td>
                    <td>
                       <input size="16" type="text"  readonly class="form_datetime">
                    </td>
                </tr>
                <tr>
                    <td>To :
                    </td>
                    <td>
                       <input size="16" type="text"  readonly class="form_datetime">
                    </td>
                </tr>

                <tr>
                    <td>Media :
                    </td>
                    <td>
                       <input size="16" type="text"  readonly class="form_datetime">
                    </td>
                </tr>
            </table>

            <asp:Button ID="btnAddAdvertisement" runat="server" Text="Add Advertisement" />
        </div>
    </form>
</body>
</html>
