<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Site1.Master" AutoEventWireup="true" CodeBehind="Reels.aspx.cs" Inherits="PrinceAdmin.Panel.Reels" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <link rel="stylesheet" href="TextBox.css"/>
       <style>

           .button1 {
    width: 18%;
    background-color: #009a98;
    color: white;
    float:right;
    padding: 14px 20px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
}

        .FileUpload1{
           margin-left:10px;
        }
        
        .Hello{
            margin-left:40px;
            width:95%;
            border:none;
            border-radius:20px;
        }

         .Hello1{
            margin-left:20px;
            width:98%;
            border:none;
            color:white;
            background-color:#313131;
            border-radius:10px;
           
        }

    </style>

      <section style="background:#18191a; height:auto">
    <div class="text">Reels/Story</div>

         <br />
    <asp:DataList ID="DataList1" runat="server" CssClass="Hello" >  
            <ItemTemplate>  
                <table cellpadding="1" cellspacing="20" class="Hello1" runat="server">
                    <div>
                       

                    <tr>
                        
                                              <td>
                           <img src='<%#"/Images/"+Eval("Uprofile") %>' height:"50px" width="50px"/>
                            </td>  


                         <td>

                            <asp:Label ID="Label3" runat="server" Text=<%#"ID : "+Eval("id") %>  style="margin-left:20px;" CssClass="Label1" Visible="true"></asp:Label>
                          <br />
                               <br />
                             <asp:Label ID="Label1" runat="server" Text=<%#"Video : "+Eval("Video") %>  style="margin-left:20px;" CssClass="Label1" ></asp:Label>
                  <br />
                             <br /> 
                             <asp:Label ID="Label2" runat="server" Text=<%#"Tags : "+Eval("Tags") %>  style="margin-left:20px;" CssClass="Label1" ></asp:Label>
                               <br />
                             <br />
                              <asp:Label ID="Label6" runat="server" Text=<%#"Hastage : "+Eval("Hastage") %>  style="margin-left:20px;" CssClass="Label1" ></asp:Label>
                             <br />
                             <br />
                               <asp:Label ID="Label4" runat="server" Text=<%#"Description : "+Eval("Description") %>  style="margin-left:20px;" CssClass="Label1" ></asp:Label>
                               <br />
                             <br />
                               <asp:Label ID="Label5" runat="server" Text=<%#"Creater : "+Eval("Creater") %>  style="margin-left:20px;" CssClass="Label1" ></asp:Label>
               
                             </td>  
                    </tr>  
                        
               </div>
                    </table>  

                <br />
            </ItemTemplate>  
        </asp:DataList>
          </section>
</asp:Content>
