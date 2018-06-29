using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
    {
        UsersBase users = UsersBase.Instance;
        RolesBase roles = RolesBase.Instance;
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (string item in roles.GetAll())
            {
                DropDownListRole.Items.Add(item);
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                users.Create(new User()
                {
                    Email = EmailTextBox.Text,
                    FirstName = FnameTextBox.Text,
                    LastName = LnameTextBox.Text,
                    Password = PasswordTextBox.Text,
                    role = new Role(DropDownListRole.SelectedItem.ToString())
                });
                Response.Redirect("UsersList.aspx");
            }
        }
    }
}