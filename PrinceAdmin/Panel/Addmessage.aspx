<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Site1.Master" AutoEventWireup="true" CodeBehind="Addmessage.aspx.cs" Inherits="PrinceAdmin.Panel.Addmessage" %>
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

<div class="text">Message</div>
<br />
<label for="fname" style="color:white; margin-left:50px;">Message title</label>
<asp:TextBox ID="TextBox1" runat="server" placeHolder="Enter Message Title" CssClass="TextBox"></asp:TextBox>
<br />
<br />
<label for="fname" style="color:white; margin-left:50px;">Message</label>
<asp:TextBox ID="TextBox2" runat="server" placeHolder="Enter Message" CssClass="TextBox"></asp:TextBox>
<br />
<br />
<asp:Button ID="Button1" runat="server" Text="Send Now" CssClass="button" OnClick="Button1_Click" />
</asp:Content>
