<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuantumTv.aspx.cs" Inherits="QuantamTV" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div style="background-color: black; width: 704px; height: 480px">
        <span ></span> <hr style="width:704px;height:50px;background-color:maroon;" />
      
        <div style="font-size: 30px; color: maroon; text-align: center; padding-top: 100px">
            Welcome to FIOS Qunatum TV<br /><br />
        <span style="color: white; padding-top: 350px; font-size: 20px;">Press <asp:HyperLink ID="okId" runat="server" NavigateUrl="~/ChannelPackList.aspx">OK</asp:HyperLink> to subscribe this channel</span>
        </div>


    </div>



</body>
</html>
