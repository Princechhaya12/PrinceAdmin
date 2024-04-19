<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Site1.Master" AutoEventWireup="true" CodeBehind="Coins.aspx.cs" Inherits="PrinceAdmin.Panel.Coins" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <link rel="stylesheet"  href="dash.css"/>
     <link rel="stylesheet" href="TextBox.css"/>

     <style>
        .GridView1{
            text-align:center;
            color:white;
            margin-left:50px;
            border:none;
            border-radius:10px 10px;
            border-width:1px;
            border-color:#323232;
        }
        .LinkButton1{
            background:#45f3ff;
            color:black;
            padding:10px;
            border-radius:5px;
            text-decoration:none;
        }

        .GridPager a, .GridPager span
    {
        display: block;
        height: 25px;
        width: 25px;
        border-radius:50px;
        color:white;
        font-weight: bold;
        text-align: center;
        text-decoration: none;
    }
    .GridPager span
    {
        margin:4px;
        background-color: #006d78;
        color: white;
        border: 1px solid #3AC0F2;
    }
        </style>

    <div class="text">Coins</div>
    <br />
    <label for="fname" style="color:white; margin-left:50px;">Indian Rupees</label>
    <asp:TextBox ID="TextBox1" runat="server" placeHolder="Rupees" CssClass="TextBox"></asp:TextBox>
    <br />
    <br />
    <label for="fname" style="color:white; margin-left:50px;">Coins Values</label>
    <asp:TextBox ID="TextBox2" runat="server" placeHolder="Coins" CssClass="TextBox"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Create Coins" CssClass="button" OnClick="Button1_Click" />

    <br />
    <br />

     <section style="background:#18191a; margin-left:00px;">
      
              <asp:GridView ID="GridView1" Font-Size="Small" AllowPaging="true" CssClass="GridView1" runat="server" AutoGenerateColumns="False" HeaderStyle-Height="60px"  Height="690px" Width="1070px" CellPadding="3" GridLines="Horizontal" BackColor="White" DataKeyNames="id" OnRowDeleting="GridView1_RowDeleting" >
                  <RowStyle Height="65px" />
            <AlternatingRowStyle BackColor="#2a2a2a" />
            <Columns>
                 <asp:BoundField DataField="id" HeaderText="S.No." InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="Rupees" HeaderText="Indian Rupees" SortExpression="Fullname" ReadOnly="true" />
                <asp:BoundField DataField="coins" HeaderText="Coins" SortExpression="Fullname" ReadOnly="true" />
                 

                <asp:CommandField ShowDeleteButton="true" ButtonType="Button" />

                </Columns>

            <FooterStyle BackColor="#2a2a2a" ForeColor="#2a2a2a" />
            <HeaderStyle BackColor="#2a2a2a" Font-Bold="True" ForeColor="white" />
            <PagerStyle BackColor="#2a2a2a" ForeColor="#18191a" HorizontalAlign="Right" />
            <RowStyle BackColor="#2a2a2a" ForeColor="white" />
            <SelectedRowStyle BackColor="#18191a" Font-Bold="True" ForeColor="black" />
            <SortedAscendingCellStyle BackColor="#2a2a2a" />
            <SortedAscendingHeaderStyle BackColor="#2a2a2a" />
            <SortedDescendingCellStyle BackColor="#2a2a2a" />
            <SortedDescendingHeaderStyle BackColor="#18191a" />
        <PagerStyle HorizontalAlign = "Center" CssClass = "GridPager" ForeColor="white" />
                  
              </asp:GridView>
        <br />
    </section>
</asp:Content>
