using iTextSharp.text.pdf.codec.wmf;
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
using System.Windows.Forms.DataVisualization.Charting;
using static HelloWorldSolutionIMS.MealAction;

namespace HelloWorldSolutionIMS
{
    public partial class DietPlan : Form
    {
        public DietPlan()
        {
            InitializeComponent();
            calories.TextChanged += UpdateChart;
            fats.TextChanged += UpdateChart;
            protein.TextChanged += UpdateChart;
            fibers.TextChanged += UpdateChart;
        }
        static int removeflag = 0;
        static int edit = 0;
        static int titlecheck = 0;

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

        private void UpdateChart(object sender, EventArgs e)
        {
            // Create a sample DataTable with data (replace this with your data source).
            DataTable dt = new DataTable();
            dt.Columns.Add("Nutrient", typeof(string));
            dt.Columns.Add("Value", typeof(double));

            if (calories.Text != "")
            {
                dt.Rows.Add("Calories", double.Parse(calories.Text));

            }
            if (fats.Text != "")
            {
                dt.Rows.Add("Fats", double.Parse(fats.Text));

            }
            if (protein.Text != "")
            {
                dt.Rows.Add("Protein", double.Parse(protein.Text));

            }
            if (fibers.Text != "")
            {
                dt.Rows.Add("Fibers", double.Parse(fibers.Text));
            }

            if (titlecheck != 1)
            {
                chart1.Titles.Add("Chart Title");
                titlecheck = 1;
            }
            chart1.Titles[0].Alignment = ContentAlignment.TopCenter; // Align the title to the top center

            // Your existing code for chart settings
            chart1.Legends[0].Enabled = true; // Enable the legend.
            chart1.Legends[0].Alignment = StringAlignment.Center; // Align the legend to the center.
            chart1.Legends[0].Docking = Docking.Bottom; // Dock the legend at the bottom.

            // Your existing code for chart settings
            chart1.Series.Clear();
            chart1.Palette = ChartColorPalette.Pastel;

            Series series = new Series("Series1");
            series.Points.DataBind(dt.AsEnumerable(), "Nutrient", "Value", "");

            series.ChartType = SeriesChartType.Pie;
            chart1.Series.Add(series);
            chart1.Series[0].Label = "#PERCENT{P0}";
            chart1.Series[0].LegendText = "#VALX";

            // Refresh the chart.
            chart1.Refresh();


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
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView2 != null)
            {
                if (guna2DataGridView1.Rows.Count > 0)
                {
                    if (guna2DataGridView1.SelectedRows.Count == 1)
                    {
                        
                        firstname.Text = "";
                        familyname.Text = "";
                        gender.Text = "";
                        age.Text = "";
                        mobileno.Text = "";
                        dietplantemplate.Text = "";
                        dietplantemplatename.Text = "";
                        previousdietplan.Text = "";
                        dietplandays.Text = "";
                        calories.Text = "";
                        fats.Text = "";
                        fibers.Text = "";
                        potassium.Text = "";
                        water.Text = "";
                        sugar.Text = "";
                        calcium.Text = "";
                        abox.Text = "";
                        protein.Text = "";
                        carbohydrates.Text = "";
                        sodium.Text = "";
                        phosphor.Text = "";
                        magnesium.Text = "";
                        iron.Text = "";
                        iodine.Text = "";
                        bbox.Text = "";
                        // Get the Ingredient ID to display in the confirmation message
                        string ingredientIDToDelete = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString(); // Assuming the Ingredient ID is in the first cell of the selected row.

                        // Ask for confirmation
                        DialogResult result = MessageBox.Show("Are you sure you want to delete Diet Plan with file no : " + ingredientIDToDelete + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            string id = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                            try
                            {
                                MainClass.con.Open();
                                SqlCommand cmd = new SqlCommand("DELETE FROM DietPlan WHERE FILENO = @ID", MainClass.con);
                                cmd.Parameters.AddWithValue("ID", guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()); // Assuming the Ingredient ID is in the first cell of the selected row.
                                cmd.ExecuteNonQuery();
                                MainClass.con.Close();

                                //MainClass.con.Open();
                                //SqlCommand cmdingredients = new SqlCommand("DELETE FROM DietPlan WHERE ID = @MealID", MainClass.con);
                                //cmdingredients.Parameters.AddWithValue("@MealID", id); // Assuming the Ingredient ID is in the first cell of the selected row.
                                //cmdingredients.ExecuteNonQuery();
                                //MessageBox.Show("Meal removed successfully");
                                //MainClass.con.Close();

                                ShowDietPlans(guna2DataGridView1, filenodgv, namedgv, agedgv, dietnamedgv);
                            }
                            catch (Exception ex)
                            {
                                MainClass.con.Close();
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (edit == 0)
            {
                if (firstname.Text != "")
                {
                    try
                    {
                        MainClass.con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO DietPlan (Firstname, Familyname, DietPlanDate, DietPlanTemplateName, DietPlanTemplate, DietPlanDays, Instructions, Gender, Age, MobileNo, PreviousDiePlan, Calories, Fats, Fibers, Potassium, Water, Sugar, Calcium, A, Protein, Carbohydrates, Sodium, Phosphor, Magnesium, Iron, Iodine, B) " +
                            "VALUES (@Firstname, @Familyname, @DietPlanDate, @DietPlanTemplateName, @DietPlanTemplate, @DietPlanDays, @Instructions, @Gender, @Age, @MobileNo, @PreviousDietPlan, @Calories, @Fats, @Fibers, @Potassium, @Water, @Sugar, @Calcium, @A, @Protein, @Carbohydrates, @Sodium, @Phosphor, @Magnesium, @Iron, @Iodine, @B)", MainClass.con);

                        // Assuming appropriate text boxes for each field in the DietPlan table
                        //cmd.Parameters.AddWithValue("@Fileno", fileno.Text);
                        cmd.Parameters.AddWithValue("@Firstname", firstname.Text);
                        cmd.Parameters.AddWithValue("@Familyname", familyname.Text);
                        cmd.Parameters.AddWithValue("@DietPlanDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@DietPlanTemplateName", dietplantemplatename.Text);
                        cmd.Parameters.AddWithValue("@DietPlanTemplate", dietplantemplate.Text);
                        cmd.Parameters.AddWithValue("@DietPlanDays", dietplandays.Text);
                        cmd.Parameters.AddWithValue("@Instructions", instruction.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender.Text);
                        cmd.Parameters.AddWithValue("@Age", int.Parse(age.Text));
                        cmd.Parameters.AddWithValue("@MobileNo", mobileno.Text);
                        cmd.Parameters.AddWithValue("@PreviousDietPlan", previousdietplan.Text);
                        cmd.Parameters.AddWithValue("@Calories", Convert.ToDouble(calories.Text));
                        cmd.Parameters.AddWithValue("@Fats", Convert.ToDouble(fats.Text));
                        cmd.Parameters.AddWithValue("@Fibers", Convert.ToDouble(fibers.Text));
                        cmd.Parameters.AddWithValue("@Potassium", Convert.ToDouble(potassium.Text));
                        cmd.Parameters.AddWithValue("@Water", Convert.ToDouble(water.Text));
                        cmd.Parameters.AddWithValue("@Sugar", Convert.ToDouble(sugar.Text));
                        cmd.Parameters.AddWithValue("@Calcium", Convert.ToDouble(calcium.Text));
                        cmd.Parameters.AddWithValue("@A", Convert.ToDouble(abox.Text));
                        cmd.Parameters.AddWithValue("@Protein", Convert.ToDouble(protein.Text));
                        cmd.Parameters.AddWithValue("@Carbohydrates", Convert.ToDouble(carbohydrates.Text));
                        cmd.Parameters.AddWithValue("@Sodium", Convert.ToDouble(sodium.Text));
                        cmd.Parameters.AddWithValue("@Phosphor", Convert.ToDouble(phosphor.Text));
                        cmd.Parameters.AddWithValue("@Magnesium", Convert.ToDouble(magnesium.Text));
                        cmd.Parameters.AddWithValue("@Iron", Convert.ToDouble(iron.Text));
                        cmd.Parameters.AddWithValue("@Iodine", Convert.ToDouble(iodine.Text));
                        cmd.Parameters.AddWithValue("@B", Convert.ToDouble(bbox.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Diet Plan added successfully");
                        MainClass.con.Close();

                        firstname.Text = "";
                        familyname.Text = "";
                        dietplantemplatename.Text = "";
                        dietplantemplate.Text = "";
                        dietplandays.Text = "";
                        instruction.Text = "";
                        gender.Text = "";
                        age.Text = "";
                        mobileno.Text = "";
                        previousdietplan.Text = "";
                        calories.Text = "";
                        fats.Text = "";
                        fibers.Text = "";
                        potassium.Text = "";
                        water.Text = "";
                        sugar.Text = "";
                        calcium.Text = "";
                        abox.Text = "";
                        protein.Text = "";
                        carbohydrates.Text = "";
                        sodium.Text = "";
                        phosphor.Text = "";
                        magnesium.Text = "";
                        iron.Text = "";
                        iodine.Text = "";
                        bbox.Text = "";


                        MainClass.con.Close();

                        // Switch to the first tab of your tab control (assuming it's called tabControl1)
                        tabControl1.SelectedIndex = 0;

                        // Refresh the DataGridView
                        ShowDietPlans(guna2DataGridView1, filenodgv, namedgv, agedgv, dietnamedgv);
                    }
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the first name."); // Or any other required field.
                }
            }
            else
            {

                if (firstname.Text != "")
                {
                    try
                    {
                        MainClass.con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE DietPlan SET FIRSTNAME = @Firstname, FAMILYNAME = @Familyname, DietPlanDate = @DietPlanDate, DietPlanTemplateName = @DietPlanTemplateName, DietPlanTemplate = @DietPlanTemplate, DietPlanDays = @DietPlanDays, Instructions = @Instructions, Gender = @Gender, Age = @Age, MobileNo = @MobileNo, PreviousDiePlan = @PreviousDietPlan, CALORIES = @Calories, FATS = @Fats, FIBERS = @Fibers, POTASSIUM = @Potassium, WATER = @Water, SUGAR = @Sugar, CALCIUM = @Calcium, A = @A, PROTEIN = @Protein, CARBOHYDRATES = @Carbohydrates, SODIUM = @Sodium, PHOSPHOR = @Phosphor, MAGNESIUM = @Magnesium, IRON = @Iron, IODINE = @Iodine, B = @B WHERE FILENO = @Fileno", MainClass.con);

                        // Assuming appropriate text boxes for each field in the DietPlan table
                        cmd.Parameters.AddWithValue("@Fileno", dietPlanIDToEdit);
                        cmd.Parameters.AddWithValue("@Firstname", firstname.Text);
                        cmd.Parameters.AddWithValue("@Familyname", familyname.Text);
                        cmd.Parameters.AddWithValue("@DietPlanDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@DietPlanTemplateName", dietplantemplatename.Text);
                        cmd.Parameters.AddWithValue("@DietPlanTemplate", dietplantemplate.Text);
                        cmd.Parameters.AddWithValue("@DietPlanDays", dietplandays.Text);
                        cmd.Parameters.AddWithValue("@Instructions", instruction.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender.Text);
                        cmd.Parameters.AddWithValue("@Age", int.Parse(age.Text));
                        cmd.Parameters.AddWithValue("@MobileNo", mobileno.Text);
                        cmd.Parameters.AddWithValue("@PreviousDietPlan", previousdietplan.Text);
                        cmd.Parameters.AddWithValue("@Calories", Convert.ToDouble(calories.Text));
                        cmd.Parameters.AddWithValue("@Fats", Convert.ToDouble(fats.Text));
                        cmd.Parameters.AddWithValue("@Fibers", Convert.ToDouble(fibers.Text));
                        cmd.Parameters.AddWithValue("@Potassium", Convert.ToDouble(potassium.Text));
                        cmd.Parameters.AddWithValue("@Water", Convert.ToDouble(water.Text));
                        cmd.Parameters.AddWithValue("@Sugar", Convert.ToDouble(sugar.Text));
                        cmd.Parameters.AddWithValue("@Calcium", Convert.ToDouble(calcium.Text));
                        cmd.Parameters.AddWithValue("@A", Convert.ToDouble(abox.Text));
                        cmd.Parameters.AddWithValue("@Protein", Convert.ToDouble(protein.Text));
                        cmd.Parameters.AddWithValue("@Carbohydrates", Convert.ToDouble(carbohydrates.Text));
                        cmd.Parameters.AddWithValue("@Sodium", Convert.ToDouble(sodium.Text));
                        cmd.Parameters.AddWithValue("@Phosphor", Convert.ToDouble(phosphor.Text));
                        cmd.Parameters.AddWithValue("@Magnesium", Convert.ToDouble(magnesium.Text));
                        cmd.Parameters.AddWithValue("@Iron", Convert.ToDouble(iron.Text));
                        cmd.Parameters.AddWithValue("@Iodine", Convert.ToDouble(iodine.Text));
                        cmd.Parameters.AddWithValue("@B", Convert.ToDouble(bbox.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Diet Plan updated successfully");
                        MainClass.con.Close();

                        firstname.Text = "";
                        familyname.Text = "";
                        dietplantemplatename.Text = "";
                        dietplantemplate.Text = "";
                        dietplandays.Text = "";
                        instruction.Text = "";
                        gender.Text = "";
                        age.Text = "";
                        mobileno.Text = "";
                        previousdietplan.Text = "";
                        calories.Text = "";
                        fats.Text = "";
                        fibers.Text = "";
                        potassium.Text = "";
                        water.Text = "";
                        sugar.Text = "";
                        calcium.Text = "";
                        abox.Text = "";
                        protein.Text = "";
                        carbohydrates.Text = "";
                        sodium.Text = "";
                        phosphor.Text = "";
                        magnesium.Text = "";
                        iron.Text = "";
                        iodine.Text = "";
                        bbox.Text = "";


                        MainClass.con.Close();

                        // Switch to the first tab of your tab control (assuming it's called tabControl1)
                        tabControl1.SelectedIndex = 0;

                        // Refresh the DataGridView
                        ShowDietPlans(guna2DataGridView1, filenodgv, namedgv, agedgv, dietnamedgv);
                    }
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the first name."); // Or any other required field.
                }
            }

        }

        static string dietPlanIDToEdit;
        private void viewEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = 1;
            try
            {
                dietPlanIDToEdit = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                MainClass.con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DietPlan WHERE FILENO = @DietPlanID", MainClass.con);
                cmd.Parameters.AddWithValue("@DietPlanID", dietPlanIDToEdit);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Set the retrieved data into input controls
                        firstname.Text = reader["FIRSTNAME"].ToString();
                        familyname.Text = reader["FAMILYNAME"].ToString();
                        dietplantemplatename.Text = reader["DietPlanTemplateName"].ToString();
                        dietplantemplate.Text = reader["DietPlanTemplate"].ToString();
                        dietplandays.Text = reader["DietPlanDays"].ToString();
                        instruction.Text = reader["Instructions"].ToString();
                        gender.Text = reader["Gender"].ToString();
                        age.Text = reader["Age"].ToString();
                        mobileno.Text = reader["MobileNo"].ToString();
                        previousdietplan.Text = reader["PreviousDiePlan"].ToString();
                        calories.Text = reader["CALORIES"].ToString();
                        fats.Text = reader["FATS"].ToString();
                        fibers.Text = reader["FIBERS"].ToString();
                        potassium.Text = reader["POTASSIUM"].ToString();
                        water.Text = reader["WATER"].ToString();
                        sugar.Text = reader["SUGAR"].ToString();
                        calcium.Text = reader["CALCIUM"].ToString();
                        abox.Text = reader["A"].ToString();
                        protein.Text = reader["PROTEIN"].ToString();
                        carbohydrates.Text = reader["CARBOHYDRATES"].ToString();
                        sodium.Text = reader["SODIUM"].ToString();
                        phosphor.Text = reader["PHOSPHOR"].ToString();
                        magnesium.Text = reader["MAGNESIUM"].ToString();
                        iron.Text = reader["IRON"].ToString();
                        iodine.Text = reader["IODINE"].ToString();
                        bbox.Text = reader["B"].ToString();
                    }
                    reader.Close();
                    MainClass.con.Close();
                    //extrafunc();
                    tabControl1.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("Diet Plan not found with ID: " + dietPlanIDToEdit);
                }
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }

        }
    }
}
