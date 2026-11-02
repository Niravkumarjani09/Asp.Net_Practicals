using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace p9_26
{
    public partial class Companies : System.Web.UI.Page
    {
        private readonly string cs =
            ConfigurationManager.ConnectionStrings["PlacementDB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCompanies();
                LoadPlacements();
            }
        }

        private void LoadCompanies()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    SELECT CompanyName,
                           COUNT(*) AS TotalPlacements,
                           ISNULL(MAX(PackageLPA), 0) AS HighestPackage
                    FROM Students
                    GROUP BY CompanyName
                    ORDER BY CompanyName";

                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    rptCompanies.DataSource = dt;
                    rptCompanies.DataBind();
                }
            }
        }

        private void LoadPlacements()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT PlacementId, StudentId, CompanyName, JobRole, PackageLPA
                                 FROM Students ORDER BY CompanyName, StudentId";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dlPlacements.DataSource = dt;
                    dlPlacements.DataBind();
                }
            }
        }
    }
}
