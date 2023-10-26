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
using static HelloWorldSolutionIMS.MealAction;

namespace HelloWorldSolutionIMS
{
    public partial class DietPlan : Form
    {
        public DietPlan()
        {
            InitializeComponent();
        }
        static int removeflag = 0;

        public class MealsDropdown
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        List<MealsDropdown> Mealslist = new List<MealsDropdown>();

        private List<string> GetCategory()
        {
            return new List<string>
    {
        "Breakfast",
        "Lunch",
        "Dinner",
        "Snack",
        "Functional Food"
    };
        }

        private List<MealsDropdown> GetMeals()
        {
            try
            {
                MainClass.con.Open();
                Mealslist.Clear();
                SqlCommand cmd = new SqlCommand("SELECT ID, MealAr FROM Meal", MainClass.con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string mealname = reader["MealAr"].ToString();
                    Mealslist.Add(new MealsDropdown { ID = id, Name = mealname });
                }

                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
            return Mealslist;
        }

        private void ShowDietPlans(DataGridView dgv, DataGridViewColumn no, DataGridViewColumn name, DataGridViewColumn age, DataGridViewColumn dietname)
        {
            SqlCommand cmd;
            try
            {
                MainClass.con.Open();

                cmd = new SqlCommand("SELECT FILENO, FIRSTNAME, AGE,DIETPLANTEMPLATENAME  FROM DietPlan", MainClass.con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                no.DataPropertyName = dt.Columns["FILENO"].ToString();
                name.DataPropertyName = dt.Columns["FIRSTNAME"].ToString();
                age.DataPropertyName = dt.Columns["AGE"].ToString();
                dietname.DataPropertyName = dt.Columns["DIETPLANTEMPLATENAME"].ToString();


                dgv.DataSource = dt;
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void Backtomeal_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void Meals_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void Ingredienttab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void DietPlan_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            MainClass.HideAllTabsOnTabControl(tabControl1);
            ShowDietPlans(guna2DataGridView1, filenodgv, namedgv, agedgv, dietnamedgv);
        }
        private void AddIngredient_Click(object sender, EventArgs e)
        {
            
            // Create a single row for your DataGridView.
            DataGridViewRow row = new DataGridViewRow();

            // Create a DataGridViewComboBoxCell for the combo box.
            DataGridViewComboBoxCell comboCell = new DataGridViewComboBoxCell();
            DataGridViewComboBoxCell comboCellcategory = new DataGridViewComboBoxCell();

            // Clear the items in the combo cell to avoid duplicates.
            comboCell.Items.Clear();

            // Set the DataSource, DisplayMember, and ValueMember for the combo cell.
            comboCell.DataSource = GetMeals();
            comboCell.DisplayMember = "Name";
            comboCell.ValueMember = "ID";

            // Set the default selected value for the combo box.
            comboCell.Value = GetMeals()[0].ID; // Replace with the desired default value.

            comboCellcategory.Items.Clear();

            comboCellcategory.DataSource = GetCategory();

            

            for (int i = 1; i < guna2DataGridView2.ColumnCount; i++)
            {
                // Create a DataGridViewColumn for the current column.
                DataGridViewColumn column = guna2DataGridView2.Columns[i];

                if (i == 1)
                {
                    column.CellTemplate = comboCellcategory;
                }
                //else if(i == 9)
                //{
                //    DataGridViewButtonCell removeButtonCell = new DataGridViewButtonCell();
                //    removeButtonCell.Value = "Remove";
                //    row.Cells.Add(removeButtonCell);
                //}
                else
                {
                    if (i == 9)
                    {
                        continue;
                    }
                    else
                    {
                        column.CellTemplate = comboCell;

                    }
                }
            }
            //DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
            //buttonCell.Value = "Remove"; // Set the button text to "Remove"
            //row.Cells.Add(buttonCell);

            guna2DataGridView2.Rows.Add(row);

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == guna2DataGridView2.Columns["buttondgv"].Index && e.RowIndex >= 0)
            {
                // Remove the corresponding row when the remove button is clicked.
                guna2DataGridView2.Rows.RemoveAt(e.RowIndex);
            }
        }

    }
}
