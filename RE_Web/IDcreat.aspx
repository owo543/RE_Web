<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IDcreat.aspx.cs" Inherits="RE_Web.IDcreat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="帳號名稱"></asp:Label>
    <asp:TextBox ID="creatID_input" runat="server"></asp:TextBox></br>
    <asp:Label ID="Label2" runat="server" Text="設定密碼"></asp:Label>
    <asp:TextBox ID="creatPasswd_input" runat="server"></asp:TextBox><br>
    <asp:Label ID="Label3" runat="server" Text="確認密碼"></asp:Label>
    <asp:TextBox ID="checkPasswd_input" runat="server"></asp:TextBox>
    <asp:Label ID="errorText" runat="server" ForeColor="Red" Text="---"></asp:Label>
    </br>
    <asp:Button ID="creatCheck" runat="server" Text="確定建立" OnClick="creatCheck_Click" />
    <asp:Button ID="rePage" runat="server" Text="返回" OnClick="rePage_Click" />
</asp:Content>
