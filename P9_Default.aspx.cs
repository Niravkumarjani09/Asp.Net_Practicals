using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace p9_26
{
    public partial class Default : System.Web.UI.Page
    {
        private readonly string cs =
            ConfigurationManager.ConnectionStrings["PlacementDB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSummary();
                LoadPlacements();
            }
        }

        private void LoadSummary()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    SELECT COUNT(*) AS TotalRecords,
                           COUNT(DISTINCT StudentId) AS StudentsPlaced,
                           COUNT(DISTINCT CompanyName) AS TotalCompanies,
                           ISNULL(MAX(PackageLPA), 0) AS HighestPackage
                    FROM Students";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            lblTotal.Text = Convert.ToInt32(dr["TotalRecords"]).ToString();
                            lblPlaced.Text = Convert.ToInt32(dr["StudentsPlaced"]).ToString();
                            lblCompanies.Text = Convert.ToInt32(dr["TotalCompanies"]).ToString();
                            lblHighestPackage.Text = Convert.ToDecimal(dr["HighestPackage"]).ToString("N2");
                        }
                    }
                }
            }
        }

        private void LoadPlacements()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT PlacementId, StudentId, CompanyName, JobRole, PackageLPA
                                 FROM Students ORDER BY PlacementId";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvPlacements.DataSource = dt;
                    gvPlacements.DataBind();
                }
            }
        }
    }
}
