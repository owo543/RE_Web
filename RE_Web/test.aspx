<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="RE_Web.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="UserID" runat="server" Text="帳號"></asp:Label>
    <asp:TextBox ID="ID_input" runat="server"></asp:TextBox>
    <asp:Label ID="Label1" runat="server" ></asp:Label>
    </br>
    <asp:Label ID="UserPasswd" runat="server" Text="密碼"></asp:Label>
    <asp:TextBox ID="Passwd_input" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" ></asp:Label>
    </br>
    <asp:Label ID="userName" runat="server" Text="暱稱"></asp:Label>
    <asp:TextBox ID="name" runat="server"></asp:TextBox>
    </br>
    <asp:Button ID="Sign_in" runat="server" Text="登入" OnClick="Sign_in_Click" />
    <asp:Button ID="creatAccount" runat="server" OnClick="creatAccount_Click" Text="建立帳號" />
    </br>
    <input id="Checkbox1" type="checkbox" /><asp:Label ID="Label3" runat="server" Text="記住我的帳號"></asp:Label>
&nbsp;&nbsp;</asp:Content>
