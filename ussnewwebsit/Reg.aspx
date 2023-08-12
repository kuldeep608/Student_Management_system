<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reg.aspx.cs" Inherits="Reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #00FFFF; height: 597px;" dir="ltr">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 431px; top: 22px; position: absolute" Text="Registration From" BorderStyle="Ridge"></asp:Label>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" style="z-index: 1; left: 331px; top: 95px; position: absolute; bottom: 476px" Text="StudentId"></asp:Label>
        <asp:Label ID="Label3" runat="server" Font-Bold="True" style="z-index: 1; left: 328px; top: 149px; position: absolute; bottom: 422px" Text="Sname"></asp:Label>
        <asp:Label ID="Label4" runat="server" Font-Bold="True" style="z-index: 1; left: 325px; top: 199px; position: absolute" Text="Age"></asp:Label>
        <asp:Label ID="Label5" runat="server" Font-Bold="True" style="z-index: 1; left: 323px; top: 248px; position: absolute" Text="UserId"></asp:Label>
        <asp:Label ID="Label6" runat="server" Font-Bold="True" style="z-index: 1; left: 322px; top: 303px; position: absolute; bottom: 268px;" Text="Password"></asp:Label>
        <asp:Label ID="txt_cpwd" runat="server" Font-Bold="True" style="z-index: 1; left: 322px; top: 360px; position: absolute; right: 648px;" Text="Conrfrom Password"></asp:Label>
        <asp:Label ID="Label8" runat="server" Font-Bold="True" style="z-index: 1; left: 320px; top: 421px; position: absolute" Text="EmailId"></asp:Label>
        <asp:Label ID="Label9" runat="server" Font-Bold="True" style="z-index: 1; left: 317px; top: 468px; position: absolute" Text="Address1"></asp:Label>
    
        <asp:TextBox ID="txt_sid" runat="server" style="z-index: 1; left: 554px; top: 87px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txt_sname" runat="server" style="z-index: 1; left: 555px; top: 140px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txt_age" runat="server" style="z-index: 1; left: 554px; top: 193px; position: absolute; bottom: 375px"></asp:TextBox>
        <asp:TextBox ID="txt_userid" runat="server" style="z-index: 1; left: 554px; top: 243px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txt_pwd" runat="server" style="z-index: 1; left: 552px; top: 299px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 550px; top: 355px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txt_emailid" runat="server" style="z-index: 1; left: 552px; top: 411px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txt_address" runat="server" style="z-index: 1; left: 550px; top: 468px; position: absolute"></asp:TextBox>
        <asp:Button ID="btn_insert" runat="server" Font-Bold="True" OnClick="btn_insert_Click" style="z-index: 1; left: 252px; top: 543px; position: absolute" Text="Insert" />
        <asp:Button ID="btn_update" runat="server" Font-Bold="True" OnClick="btn_update_Click" style="z-index: 1; left: 442px; top: 542px; position: absolute" Text="Update" />
        <asp:Button ID="btn_delete" runat="server" Font-Bold="True" OnClick="btn_delete_Click" style="z-index: 1; left: 646px; top: 538px; position: absolute" Text="Delete" />
    
    </div>
    </form>
</body>
</html>
