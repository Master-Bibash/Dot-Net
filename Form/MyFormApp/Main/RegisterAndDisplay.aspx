<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterAndDisplay.aspx.cs"
     Inherits="YourNamespace.RegisterAndDisplay" %>

     <!DOCTYPE html>

     <html xmlns="http://www.w3.org/1999/xhtml">

     <head runat="server">
          <title>Register and Display Data</title>
     </head>

     <body>
          <form id="formRegister" runat="server">
               <div>
                    <label for="txtUsername">Username:</label>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
               </div>
               <div>
                    <label for="txtEmail">Email:</label>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
               </div>
               <div>
                    <label for="txtPassword">Password:</label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
               </div>
               <div>
                    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
               </div>
          </form>

          <div id="divDisplayData" runat="server" visible="false">
               <h2>Display Data</h2>
               <div>
                    <label>Username:</label>
                    <asp:Label ID="lblUsername" runat="server"></asp:Label>
               </div>
               <div>
                    <label>Email:</label>
                    <asp:Label ID="lblEmail" runat="server"></asp:Label>
               </div>
          </div>
     </body>

     </html>