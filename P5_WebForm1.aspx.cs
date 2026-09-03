using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace p5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calAcademic(object sender, EventArgs e)
        {
            DateTime selectedDate = Calendar1.SelectedDate;

            lblselectDate.Text = "You have selected " +
                selectedDate.ToString("dd-MM-yyyy");

            // Store selected date in Session
            Session["leaveDate"] = selectedDate;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Open Leave Application page
            Response.Redirect("WebForm2.aspx");
        }
    }
}
