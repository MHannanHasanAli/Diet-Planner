using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldSolutionIMS
{
    public partial class MealAction : Form
    {
        public MealAction()
        {
            InitializeComponent();

            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void MealAction_Load(object sender, EventArgs e)
        {
           

        }
        public class Ingredients
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        private List<Ingredients> GetIngredients()
        {
            return new List<Ingredients>
            {
                new Ingredients {ID = 1, Name = "Alpha"},
                new Ingredients {ID = 2, Name = "Beta"}
            };
        }
       
        private void BindList()
        {
            var combobox = (DataGridViewComboBoxColumn)guna2DataGridView1.Columns[1];
            combobox.DisplayMember = "Name";
            combobox.ValueMember = "ID";
            combobox.DataSource = GetIngredients();
        }
        private void AddIngredient_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            // Define the values for each cell in the row.
            string value1 = "Cell 1 Value";

            // Create a DataGridViewComboBoxCell for the second cell.
            DataGridViewComboBoxCell comboCell = new DataGridViewComboBoxCell();
            comboCell.DataSource = GetIngredients();
            comboCell.DisplayMember = "Name";
            comboCell.ValueMember = "ID";

            // Set the default selected value for the combo box.
            comboCell.Value = GetIngredients()[0].ID; // Replace with the desired default value.

            // Create a DataGridViewTextBoxCell for the first cell.
            DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell { Value = value1 };

            // Add the cells to the row in the desired order.
            row.Cells.Add(cell1);
            row.Cells.Add(comboCell);

            // Add the row to the DataGridView.
            guna2DataGridView1.Rows.Add(row);
        }

        private void guna2DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3) // Check if the "Quantity" cell value changed.
            {
                // Get the selected Ingredient ID from the ComboBox cell.
                int selectedIngredientID = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value);

                // Get the new quantity value from the "Quantity" cell.
                int newQuantity = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value);

                // Fetch additional data based on the selected Ingredient ID and new quantity from your database.
                // You can use a SQL query to retrieve data for other cells.
                string query = "SELECT CALORIES, FATS, CARBOHYDRATES, FIBERS, CALCIUM, PROTEIN, SODIUM, CLASSIFICATION FROM Ingredient WHERE ID = @IngredientID";

                using (SqlCommand cmd = new SqlCommand(query, MainClass.con))
                {
                    cmd.Parameters.AddWithValue("@IngredientID", selectedIngredientID);
                    MainClass.con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Calculate the values for other cells in the row based on the fetched data and the new quantity.
                        double calories = (Convert.ToDouble(reader["CALORIES"]) * newQuantity)/ 100;
                        double fats = (Convert.ToDouble(reader["FATS"]) * newQuantity)/100;
                        double carbohydrates = (Convert.ToDouble(reader["CARBOHYDRATES"]) * newQuantity)/ 100;
                        double fibers = (Convert.ToDouble(reader["FIBERS"]) * newQuantity)/ 100;
                        double Protein = (Convert.ToDouble(reader["PROTEIN"]) * newQuantity) / 100;
                        double calcium = (Convert.ToDouble(reader["CALCIUM"]) * newQuantity) / 100;
                        double sodium = (Convert.ToDouble(reader["SODIUM"]) * newQuantity) / 100;
                        string unit = (reader["CLASSIFICATION"]).ToString();

                        // Set the calculated values for other cells in the row.
                        guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value = calories;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value = Protein;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value = fats;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value = carbohydrates;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value = calcium;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value = fibers;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[10].Value = sodium;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value = unit;
                    }

                    MainClass.con.Close();
                }
            }
        }
    }
}
