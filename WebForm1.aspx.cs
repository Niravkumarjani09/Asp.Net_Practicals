using System;
using System.Text;

namespace p4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                return;
            }

            // Name
            lblName.Text = txtName.Text;

            // Surname
            lblSurname.Text = txtSurname.Text;

            // Email
            lblEmail.Text = txtEmail.Text;

            // Age
            lblAge.Text = txtAge.Text;

            // Contact
            lblContact.Text = txtContact.Text;

            // College
            lblCollege.Text = txtCollege.Text;

            // Department
            if (rdoComputer.Checked)
            {
                lblDepartment.Text = "Computer";
            }
            else if (rdoMechanical.Checked)
            {
                lblDepartment.Text = "Mechanical";
            }
            else if (rdoChemical.Checked)
            {
                lblDepartment.Text = "Chemical";
            }
            else if (rdoCivil.Checked)
            {
                lblDepartment.Text = "Civil";
            }
            else
            {
                lblDepartment.Text = "Not Selected";
            }

            // Event
            if (ddlEvent.SelectedIndex > 0)
            {
                lblEvent.Text = ddlEvent.SelectedItem.Text;
            }
            else
            {
                lblEvent.Text = "Not Selected";
            }

            // Gender
            if (rdoMale.Checked)
            {
                lblGender.Text = "Male";
            }
            else if (rdoFemale.Checked)
            {
                lblGender.Text = "Female";
            }
            else
            {
                lblGender.Text = "Not Selected";
            }

            // Skills
            StringBuilder skills = new StringBuilder();

            if (chkCSharp.Checked)
            {
                skills.Append("C# ");
            }

            if (chkPython.Checked)
            {
                skills.Append("Python ");
            }

            if (chkAI.Checked)
            {
                skills.Append("AI ");
            }

            if (skills.Length > 0)
            {
                lblSkills.Text = skills.ToString();
            }
            else
            {
                lblSkills.Text = "No Skills Selected";
            }

            // Address
            lblAddress.Text = txtAddress.Text;

            // Terms
            if (chkTerms.Checked)
            {
                lblTerms.Text = "Accepted";
            }
            else
            {
                lblTerms.Text = "Not Accepted";
            }

            // Display result
            pnlResult.Visible = true;
        }
    }
}