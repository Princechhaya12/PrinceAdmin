<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Site1.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="PrinceAdmin.Panel.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <link rel="stylesheet" href="Dashboard.css" />

    <style>
       .GridView1{
            text-align:center;
            color:white;
            border:none;
            border-width:1px;
            border-color:#323232;
        }

        .LinkButton1 {
            background:#18A7B5;
            color:black;
            padding:10px;
            border-radius:5px;
            text-decoration:none;
        }

        .button1 {
    width: 18%;
    background-color: #18A7B5;
    color: white;
    float:right;
    padding: 14px 20px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
}

    .button1:hover {
        background-color: #18A7B5;
    }


    </style>

    <section style="background:#18191a; height:auto">

    <div class="text">Dashboard</div>

     
     <div class="home-content">
      <div class="overview-boxes">
        <div class="box">
          <div class="right-side">
            <div class="box-topic" style="color:#18A7B5">Total Users </div>
            <div class="number">
                <asp:Label ID="Label1" runat="server" Text="45,452"></asp:Label>
            </div>
               <br />
            <div class="indicator">
              <i class='bx bx-up-arrow-alt'></i>
              <span class="textaa">Refreshed a minute ago</span>
            </div>
          </div>
          <i class='bx bx-user cart'></i>
        </div>
        <div class="box">
          <div class="right-side">
            <div class="box-topic" style="color:#18A7B5">Master Users</div>
            <div class="number">
                <asp:Label ID="Label2" runat="server" Text="5,156"></asp:Label>
            </div>
              <br />
            <div class="indicator">
             <i class='bx bx-up-arrow-alt'></i>
              <span class="textaa">Refreshed a minute ago</span>
            </div>
          </div>
          <i class='bx bxs-phone cart two' ></i>
        </div>
        <div class="box">
          <div class="right-side">
            <div class="box-topic" style="color:#18A7B5">Probability</div>
            <div class="number">
                <asp:Label ID="Label3" runat="server" Text="45,452"></asp:Label>
            </div>
               <br />
            <div class="indicator">
              <i class='bx bx-up-arrow-alt'></i>
              <span class="textaa">Refreshed a minute ago</span>
            </div>
          </div>
          <i class='bx bx-time cart three' ></i>
        </div>
       
      </div>
   
       <div class="text">Registered Users</div>
     
         <br />
       <div class="sales-boxes">
            <div class="recent-sales box" style="width:1050px">
          <div class="title">Recent New Users
                
          </div>
               
                <br />
          <div class="sales-details">
              <asp:GridView ID="GridView1" DataSourceID="SqlDataSource2" Font-Size="Small" CssClass="GridView1" runat="server" AutoGenerateColumns="False" Height="643px" Width="1000px" CellPadding="3" GridLines="Horizontal"  BackColor="White">
            <AlternatingRowStyle BackColor="#2a2a2a" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="S.No." InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="Firstname" HeaderText="First Name" SortExpression="Fullname" />
                <asp:BoundField DataField="Lastname" HeaderText="Last Name" SortExpression="Fullname" />
                <asp:BoundField DataField="Emailid" HeaderText="Email Id" SortExpression="Fullname" />
                <asp:BoundField DataField="Phone" HeaderText="Phone no." SortExpression="Fullname" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="Fullname" />
             
                
                <asp:TemplateField>
            <ItemTemplate>
             </ItemTemplate>
        </asp:TemplateField>
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
        </asp:GridView>
              <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PrinceAdminConnectionString %>" SelectCommand="select top 10 * from [Register] Order by id DESC"></asp:SqlDataSource>
        
</div>
                </div>
                </div>
            </div>
        <br />
          </section>

</asp:Content>
