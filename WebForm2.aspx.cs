using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace p5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if name is already stored in cookie
                if (Request.Cookies["EmpName"] != null)
                {
                    TextBox3.Text = Request.Cookies["EmpName"].Value;
                }

                // Get selected date from Session
                if (Session["leaveDate"] != null)
                {
                    DateTime leaveDate = (DateTime)Session["leaveDate"];

                    lblleaveDate.Text =
                        leaveDate.ToString("dd-MM-yyyy");
                }
                else
                {
                    lblleaveDate.Text = "No date selected.";
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Leave type selection
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Remember name using Cookie
            if (CheckBox1.Checked)
            {
                Response.Cookies["EmpName"].Value = TextBox3.Text;

                Response.Cookies["EmpName"].Expires =
                    DateTime.Now.AddDays(7);
            }
            else
            {
                Response.Cookies["EmpName"].Expires =
                    DateTime.Now.AddDays(-1);
            }
        }

        protected void Btnsubmit_Click(object sender, EventArgs e)
        {
            string empName = TextBox3.Text;
            string leaveType = DropDownList1.SelectedValue;
            string reason = TextBox2.Text;

            // Store details in Session
            Session["Empnm"] = empName;
            Session["leaveType"] = leaveType;
            Session["Reason"] = reason;

            // Create Cookie if checkbox is selected
            if (CheckBox1.Checked)
            {
                Response.Cookies["EmpName"].Value = empName;

                Response.Cookies["EmpName"].Expires =
                    DateTime.Now.AddDays(7);
            }

            lblMsg.Text = "<b>Leave Application Submitted Successfully!</b><br/>" +
                          "Your Name: " + empName + "<br/>" +
                          "Leave Type: " + leaveType + "<br/>" +
                          "Reason: " + reason;
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}