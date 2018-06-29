using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class RoleManager : System.Web.UI.Page
    {
        RolesBase roles = RolesBase.Instance;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (string item in roles.GetAll())
                {
                    ListBox1.Items.Add(item);
                }
            }
        }

        protected void CreateButton_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length <= 0)
                return;

            if(IsValid)
            {
                if (ViewState["roleToEdit"] != null)
                {
                    roles.Remove(ViewState["roleToEdit"].ToString());
                    ViewState["roleToEdit"] = null;
                }
                roles.Create(TextBox1.Text);
            }
            Response.Redirect(url: Request.RawUrl);
        }

        protected void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (string item in ListBox1.Items.OfType<ListItem>().Where(item => item.Selected).Select(item => item.ToString()))
            {
                roles.Remove(item);
            }
            Response.Redirect(url: Request.RawUrl);
        }
        protected void EditButton_Click(object sender, EventArgs e)
        {
            foreach (string item in ListBox1.Items.OfType<ListItem>().Where(item => item.Selected).Select(item => item.ToString()))
            {
                ViewState["roleToEdit"] = item;
                TextBox1.Text = item;
                break;
            }

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditButton.Enabled = RemoveButton.Enabled = ListBox1.SelectedItem == null ? false : true;
        }
    }
}