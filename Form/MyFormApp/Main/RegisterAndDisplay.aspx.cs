using System;
using System.Web.UI;
using System.Web;
using System.Windows.Controls;

namespace YourNamespace
{
     public partial class RegisterAndDisplay : Page
     {
          protected void btnRegister_Click(object sender, EventArgs e)
          {
               // Get the entered values from the form
               string username = txtUsername.Text;
               string email = txtEmail.Text;
               string password = txtPassword.Text;

               // Store the data in session (or database)
               Session["Username"] = username;
               Session["Email"] = email;

               // Show the display data section
               divDisplayData.Visible = true;

               // Display the filled data
               lblUsername.Text = username;
               lblEmail.Text = email;
          }
     }
}
