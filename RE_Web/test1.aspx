<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="test1.aspx.cs" Inherits="RE_Web.test1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="logIn_count" runat="server" Text="---"></asp:Label>
    </br>
    <asp:Label ID="Label1" runat="server" Text="在這邊輸入"></asp:Label>
    <asp:TextBox ID="chatInput" runat="server"></asp:TextBox>
    
    <asp:Button ID="send" runat="server" Text="發送" OnClick="send_Click" />
    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
    </asp:Timer>
    </br>
    </br>
    <asp:Button ID="Sign_out" runat="server" Text="登出" OnClick="Sign_out_Click" />
    </br>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="chatOutput" runat="server"></asp:Label>
            <asp:Label ID="time2" runat="server" Text="time"></asp:Label>
            
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
