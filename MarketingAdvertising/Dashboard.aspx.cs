using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarketingAdvertising
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindDeviceDetails();
                BindCustomerDetails();
            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DataBaseDataContext dbContext = new DataBaseDataContext();
            dbContext.spInsertDeviceDetails(txtDeviceMac.Text, txtAddress1.Text, txtAddress2.Text, txtCity.Text, txtState.Text, txtCountry.Text);

            BindDeviceDetails();
        }

        private void BindDeviceDetails()
        {
            DataBaseDataContext db = new DataBaseDataContext();

            grdDevice.DataSource = db.DeviceInfos.ToList();
            grdDevice.DataBind();
        }

        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            db.spInsertCustomerDetails(txtCustomerFName.Text, txtLastName.Text, txtCellNumber.Text, txtEmailId.Text);
            BindCustomerDetails();
        }

        private void BindCustomerDetails()
        {
            DataBaseDataContext db = new DataBaseDataContext();

            grdCustomer.DataSource = db.CustomerInfos.ToList();
            grdCustomer.DataBind();
        }

        protected void grdDevice_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lnkbtn = (LinkButton)e.Row.FindControl("lnkDeviceMac");
                lnkbtn.Text = e.Row.Cells[1].Text;
                lnkbtn.CommandArgument = e.Row.Cells[1].Text;
                lnkbtn.Command += DisplayRecord_Click;
            }
        }

        protected void DisplayRecord_Click(object sender, CommandEventArgs e)
        {
            string TransId = e.CommandArgument.ToString();

            Response.Redirect("slotinfo.aspx?id=" + TransId);
        }

    }
}