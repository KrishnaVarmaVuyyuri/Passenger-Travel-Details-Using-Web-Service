<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="APCRTC__Web_service.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <center><h1 style="font-family: Jokerman; background-color: #00FFFF; background-repeat: no-repeat; border: medium double #00FF00; font-variant: inherit; text-transform: capitalize; font-style: normal; text-decoration: underline overline; text-align: center; white-space: normal; word-spacing: normal">Passenger Details</h1></center>
        <form id="form1" runat="server">
        <asp:GridView id="gv" runat="server"></asp:GridView>
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Passenger Name"></asp:Label>
&nbsp;:
            <asp:TextBox ID="TextBox1" runat="server" />&nbsp;&nbsp;
            <br />
            Origin&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : <asp:TextBox ID="TextBox2" runat="server" /><br />
            Destination&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : <asp:TextBox ID="TextBox3" runat="server" /><br />
            <asp:Button ID="Button2" runat="server" Text="Click to add Passenger Details" OnClick="Button1_Click" BackColor="Black" BorderColor="Yellow" BorderStyle="Dotted" ForeColor="Yellow"/><br />
           <Center> <asp:Label ID="ResultLabel" runat="server" BorderStyle="Dotted" BackColor="#66FF33" Width="421px" /> </Center> 
        </div>
    </form>
    
</body>
</html>
