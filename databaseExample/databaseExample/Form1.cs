using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace databaseExample
{
    public partial class frmMain : Form
    {
        SqlConnection connection;
        string connectionString;

        public frmMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["databaseExample.Properties.Settings.cookbookConnectionString"].ConnectionString;
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            populateRecipes();
        }

        private void populateRecipes()
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe",connection))
            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                lstRecipes.DisplayMember = "Name";
                lstRecipes.ValueMember = "Id";
                lstRecipes.DataSource = recipeTable;

            }
            
        }

        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(lstRecipes.SelectedValue.ToString());
        }
    }
}
