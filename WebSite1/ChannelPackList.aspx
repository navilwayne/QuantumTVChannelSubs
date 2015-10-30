<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChannelPackList.aspx.cs" Inherits="QuantamTV" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div style="background-color: black; width: 704px; height: 480px">
        <hr style="width: 704px; height: 50px; background-color: maroon;" />
        <div style="font-size: 22px; color: white; text-align: center; padding-top: 20px">
            <b>Upgrade Your TV Plan</b>
            <br />
            <table style="font-size: 18px; color: white; margin-left:130px; margin-top:30px;text-align:left; padding-left:50px;border:solid;border-color:white">

                <tr>
                    <td>Ultimate HD
                    </td>
                    <%--   <td></td><td></td><td></td><td></td><td>--%>
                    <td style="padding-left: 150px">$77.00
                    </td>
                </tr>

                <tr>
                    <td style="font-size: 13px">380+ (120+ in HD)
                    </td>

                    <td style="font-size: 13px;padding-left: 150px">More Per Month
                    </td>
                </tr>

            </table>
               <table style="font-size: 18px; color: white; margin-left:130px; margin-top:15px;text-align:left; padding-left:50px;border-color:white">

                <tr>
                    <td>Custom HD
                    </td>
                    <%--   <td></td><td></td><td></td><td></td><td>--%>
                    <td style="padding-left: 150px">$13.00
                    </td>
                </tr>

                <tr>
                    <td style="font-size: 13px">380+ (120+ in HD)
                    </td>

                    <td style="font-size: 13px;padding-left: 150px">More Per Month
                    </td>
                </tr>

            </table>
            <table style="font-size: 18px; color: white; margin-left:130px; margin-top:15px;text-align:left; padding-left:50px;border-color:white">

                <tr>
                    <td>Extreme HD
                    </td>
                    <%--   <td></td><td></td><td></td><td></td><td>--%>
                    <td style="padding-left: 150px">$60.00
                    </td>
                </tr>

                <tr>
                    <td style="font-size: 13px">380+ (120+ in HD)
                    </td>

                    <td style="font-size: 13px;padding-left: 150px">More Per Month
                    </td>
                </tr>

            </table>
            <span style="color:white; padding-top:100px;position:absolute; font-size: 20px;text-align:right;padding-left:350px">Press
                <asp:HyperLink ID="okId" runat="server" NavigateUrl="~/UpgradeCompleted.aspx">OK</asp:HyperLink>
                to select this Plan</span>
        </div>


    </div>



</body>
</html>
