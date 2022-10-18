<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Plane_Tickets.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body {background-color:beige;}
        h1,h2,h3,h4,h5,p,label,button{color:black;font-family:Arial;}
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p></p>
<h2>Air Euro  <asp:Image ID="Logo" runat="server" Height="50px" ImageUrl="~/Images/Logo.png" Width="60px" />
        </h2>
<h4>From:</h4>
        <asp:RadioButton ID="fromLondon" runat="server" GroupName="fromRadioButton" Text="London" /> 
        <asp:RadioButton ID="fromParis" runat="server" Text="Paris" GroupName="fromRadioButton" />
        <asp:RadioButton ID="fromRiga" runat="server" Text="Riga" GroupName="fromRadioButton" />
        <asp:RadioButton ID="fromMadrid" runat="server" Text="Madrid" GroupName="fromRadioButton" />
<h4>To:</h4>
        <asp:RadioButton ID="toLondon" runat="server" Text="To London" GroupName="toRadioButton"/>
        <asp:RadioButton ID="toParis" runat="server" Text="To Paris" GroupName="toRadioButton"/>
        <asp:RadioButton ID="toRiga" runat="server" Text="To Riga" GroupName="toRadioButton" />
        <asp:RadioButton ID="toMadrid" runat="server" Text="To Madrid" GroupName="toRadioButton" />
        <br />
        <br />
        <asp:CheckBox ID="returnCheckBox" runat="server" Text="Add Return Flight?" />
        <br />
        <br />
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
