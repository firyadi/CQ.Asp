<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConnectToApi._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:TextBox 
            ID="txtSendData" 
            runat="server" 
            Width="1800px" 
            Height="120"
            TextMode="MultiLine"
            Text="%5B%7BKey%3A%20%27textinput14%27%2C%20Value%3A%20%27testingFM%27%7D%2C%20%7BKey%3A%27textinput12%27%2C%20Value%3A%20%27testingFund%27%7D%5D">
        </asp:TextBox>
    </div>
    <div>
        <asp:TextBox ID="txtSesionId" runat="server" Width="800"></asp:TextBox>
    </div>

    <div>
    <asp:Button 
            ID="Button1" 
            runat="server" 
            Text="Click Me!!" 
            OnClick="Button_Click"
            Font-Bold="true"
            ForeColor="DodgerBlue"
            Height="45"
            Width="150"
            />

        <iframe id="ContentIframe" runat="server" width = "100%" height = "2000px" style = "border: 0px"></iframe>    
</div>

</asp:Content>
