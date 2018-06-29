using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class UsersList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (User item in UsersBase.Instance.GetAll())
                {
                    CheckBoxList1.Items.Add(item.ToString());
				//	CheckBoxList1.Items.Add("<a href='#'>" + item.ToString() + "</a>");
				}
            }
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveButton.Enabled = CheckBoxList1.SelectedItem == null ? false : true;
        }

        protected void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (string item in CheckBoxList1.Items.OfType<ListItem>().Where(item => item.Selected).Select(item => item.ToString()))
            {
                UsersBase.Instance.Remove(item);
            }
            Response.Redirect(url: Request.RawUrl);
        }
    }
}