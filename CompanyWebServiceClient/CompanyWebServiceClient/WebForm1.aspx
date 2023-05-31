<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CompanyWebServiceClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnGetPublicInfo" runat="server" Text="Get Public Information" OnClick="btnGetPublicInfo_Click" />
            <br />
            <asp:Label ID="lblGetPublicInfo" runat="server" Text="Message Content:"></asp:Label>
            <br />
            <asp:Button ID="btnGetConfidentialInfo" runat="server" Text="Get Confidential Information" OnClick="btnGetConfidentialInfo_Click" />
            <br />
            <asp:Label ID="lblGetConfidentialInfo" runat="server" Text="Message Content: "></asp:Label>
        </div>
    </form>
</body>
</html>
