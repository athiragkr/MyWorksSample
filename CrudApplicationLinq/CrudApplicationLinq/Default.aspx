<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CrudApplicationLinq._Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
 
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       
    <table class="nav-justified">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="color: #FFFFFF; background-color: #333333; font-size: x-large;">Crud Operation Using Linq</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblUserID" runat="server" Font-Bold="True" Font-Size="Medium" Text="User ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserID" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblUserName" runat="server" Font-Bold="True" Font-Size="Medium" Text="User Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblAddress" runat="server" Font-Bold="True" Font-Size="Medium" Text="Address"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlAddress" runat="server">
                    <asp:ListItem>London</asp:ListItem>
                    <asp:ListItem>United States</asp:ListItem>
                    <asp:ListItem>Netherlands</asp:ListItem>
                    <asp:ListItem>Japan</asp:ListItem>
                    <asp:ListItem>China</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblAge" runat="server" Font-Bold="True" Font-Size="Medium" Text="Age"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAge" runat="server" Font-Size="Medium"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblGender" runat="server" Font-Bold="True" Font-Size="Medium" Text="Gender"></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="RadioBtnGender" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDOB" runat="server" Font-Bold="True" Font-Size="Medium" Text="Date Of Birth"></asp:Label>
            </td>
            <td>
                
                <asp:TextBox ID="txtDOB" runat="server" Font-Size="Medium"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="txtDOB_CalendarExtender" runat="server" BehaviorID="txtDOB_CalendarExtender" TargetControlID="txtDOB" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnInsert" runat="server" BackColor="#660066" BorderColor="Black" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Insert" OnClick="btnInsert_Click" />
                <asp:Button ID="btnUpdate" runat="server" BackColor="#660066" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="btnUpdate_Click" Text="Update" />
                <asp:Button ID="btnDelete" runat="server" BackColor="#660066" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="btnDelete_Click" Text="Delete" />
            </td>
        </tr>
    </table>
    <asp:GridView ID="gvUser" runat="server" Width="1186px">
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
</asp:Content>
