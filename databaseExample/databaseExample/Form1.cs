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
            string query = "SELECT * FROM Recipe";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                lstRecipes.DisplayMember = "Name";
                lstRecipes.ValueMember = "Id";
                lstRecipes.DataSource = recipeTable;

            }
            
        }

        private void populateIngredients()
        {
            string query = "SELECT a.Name FROM Ingredient a " + 
                "INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId " +
                "WHERE b.RecipeId = @RecipeId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query,connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeId", lstRecipes.SelectedValue);

                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                lstIngredients.DisplayMember = "Name";
                lstIngredients.ValueMember = "Id";
                lstIngredients.DataSource = ingredientTable;

            }

        }

        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lstRecipes.SelectedValue.ToString());
            
            populateIngredients();
        }

        private void btnAddRecipes_Click(object sender, EventArgs e)
        {
                string query = "INSERT INTO Recipe VALUES(@RecipeName, 80, 'Hard coded, Replace me')";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text);

                    command.ExecuteNonQuery();

                }
            populateRecipes();
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {

            string query = "UPDATE Recipe SET Name = @RecipeName WHERE Id = @RecipeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text);
                command.Parameters.AddWithValue("@RecipeId", lstRecipes.SelectedValue);

                command.ExecuteNonQuery();

            }
            populateRecipes();
        }
    }
}
