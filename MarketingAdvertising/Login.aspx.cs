using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarketingAdvertising
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseDataContext dbContext = new DataBaseDataContext();


                if (!dbContext.LoginInfos.Any(a => a.txtEmailId == txtemail.Value))
                {
                    dbContext.spInsertLogin(txtemail.Value, txtPassword.Value);
                    Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    lblErrorRegister.Text = "User already Exists.";
                    lblErrorRegister.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Login button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseDataContext dbContext = new DataBaseDataContext();
                var user = dbContext.LoginInfos.First(f => f.txtEmailId == txtEmailId.Value);

                if (user != null)
                {
                    Session["User"] = user;
                    Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    lblError.Text = "Not Valid User";
                    lblError.Visible = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}