﻿using iTextSharp.text.pdf.codec.wmf;
using RestSharp.Extensions;
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
    public partial class MealAction : Form
    {
        public MealAction()
        {
            InitializeComponent();
            calories.TextChanged += UpdateChart;
            fats.TextChanged += UpdateChart;
            protein.TextChanged += UpdateChart;
            fibers.TextChanged += UpdateChart;

        }

        public class Ingredients
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        List<Ingredients> ingredientsList = new List<Ingredients>();
        static int titlecheck = 0;
        static int edit = 0;
        static int removeflag = 0;
        static int dropdown = 0;
        static string mealIDToEdit;
        private void ShowMeals(DataGridView dgv, DataGridViewColumn no, DataGridViewColumn mealar, DataGridViewColumn mealen, DataGridViewColumn calories, DataGridViewColumn protein, DataGridViewColumn fats, DataGridViewColumn carbohydrates, DataGridViewColumn fibers, DataGridViewColumn calcium, DataGridViewColumn sodium)
        {
            SqlCommand cmd;
            try
            {
                MainClass.con.Open();

                cmd = new SqlCommand("SELECT ID, MealAr, MealEn,PROTEIN, CALORIES, FATS, CARBOHYDRATES, FIBERS, CALCIUM, SODIUM FROM Meal", MainClass.con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                no.DataPropertyName = dt.Columns["ID"].ToString();
                mealar.DataPropertyName = dt.Columns["MealAr"].ToString();
                mealen.DataPropertyName = dt.Columns["MealEn"].ToString();
                calories.DataPropertyName = dt.Columns["CALORIES"].ToString();
                fats.DataPropertyName = dt.Columns["FATS"].ToString();
                carbohydrates.DataPropertyName = dt.Columns["CARBOHYDRATES"].ToString();
                fibers.DataPropertyName = dt.Columns["FIBERS"].ToString();
                calcium.DataPropertyName = dt.Columns["CALCIUM"].ToString();
                sodium.DataPropertyName = dt.Columns["SODIUM"].ToString();
                protein.DataPropertyName = dt.Columns["PROTEIN"].ToString();

                dgv.DataSource = dt;
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowIngredients(DataGridView dgv, DataGridViewColumn unit, DataGridViewColumn ingar, DataGridViewColumn ingen, DataGridViewColumn quan, DataGridViewColumn calories, DataGridViewColumn protein, DataGridViewColumn fats, DataGridViewColumn carbohydrates, DataGridViewColumn fibers, DataGridViewColumn calcium, DataGridViewColumn sodium,DataGridViewColumn potas, DataGridViewColumn phos, DataGridViewColumn wat, DataGridViewColumn mag, DataGridViewColumn sug, DataGridViewColumn ir, DataGridViewColumn io, DataGridViewColumn aa, DataGridViewColumn bb)
        {
            SqlCommand cmd;
            try
            {
               
                cmd = new SqlCommand("SELECT  IngredientAr,IngredientEn, Unit, Calories, Fats, Carbohydrates, Fibers, Protein, Calcium, Sodium, Potassium, Iodine, A, B, Iron, Water, Suger, Magnesium, Phosphor, Quantity FROM MealIngredients  WHERE MealID = @MealID", MainClass.con);
                cmd.Parameters.AddWithValue("@MealID", mealIDToEdit);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                unit.DataPropertyName = dt.Columns["Unit"].ToString(); 
                ingen.DataPropertyName = dt.Columns["IngredientEn"].ToString();
                quan.DataPropertyName = dt.Columns["Quantity"].ToString();
                calories.DataPropertyName = dt.Columns["CALORIES"].ToString();
                fats.DataPropertyName = dt.Columns["FATS"].ToString();
                carbohydrates.DataPropertyName = dt.Columns["CARBOHYDRATES"].ToString();
                fibers.DataPropertyName = dt.Columns["FIBERS"].ToString();
                calcium.DataPropertyName = dt.Columns["CALCIUM"].ToString();
                sodium.DataPropertyName = dt.Columns["SODIUM"].ToString();
                protein.DataPropertyName = dt.Columns["PROTEIN"].ToString();
                potas.DataPropertyName = dt.Columns["POTASSIUM"].ToString();
                phos.DataPropertyName = dt.Columns["PHOSPHOR"].ToString();
                wat.DataPropertyName = dt.Columns["WATER"].ToString();
                mag.DataPropertyName = dt.Columns["MAGNESIUM"].ToString();
                sug.DataPropertyName = dt.Columns["SUGER"].ToString();
                ir.DataPropertyName = dt.Columns["IRON"].ToString();
                io.DataPropertyName = dt.Columns["IODINE"].ToString();
                aa.DataPropertyName = dt.Columns["A"].ToString();
                bb.DataPropertyName = dt.Columns["B"].ToString();
                
                dgv.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
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

            if(titlecheck != 1)
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
        private void MealAction_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            MainClass.HideAllTabsOnTabControl(tabControl1);
            save.Visible = false;
            tabControl1.SelectedIndex = 2;
            ShowMeals(guna2DataGridView2, iddgv, mealardgv, mealendgv, caloriesdgv, proteinmaindgv, fatsmaindgv, carbohydratesmaindgv, calciummaindgv, fibermaindgv, sodiummaindgv);
            //ShowMeals(guna2DataGridView2, iddgv, mealardgv, mealendgv, caloriedgv, proteindgv, fatsdgv, carbohydratesdgv, calciumdgv, fiberdgv, sodiumdgv);
        }
        private List<Ingredients> GetIngredientsForShow()
        {
            try
            {
                ingredientsList.Clear();
                SqlCommand cmd = new SqlCommand("SELECT ID, INGREDIENT_AR FROM Ingredient", MainClass.con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string ingredientAr = reader["INGREDIENT_AR"].ToString();
                    ingredientsList.Add(new Ingredients { ID = id, Name = ingredientAr });
                }

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
            return ingredientsList;
        }
        private List<Ingredients> GetIngredients()
        {
            try
            {
                MainClass.con.Open();
                ingredientsList.Clear();
                SqlCommand cmd = new SqlCommand("SELECT ID, INGREDIENT_AR FROM Ingredient", MainClass.con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string ingredientAr = reader["INGREDIENT_AR"].ToString();
                    ingredientsList.Add(new Ingredients { ID = id, Name = ingredientAr });
                }

                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
            return ingredientsList;
         }
        private void AddIngredient_Click(object sender, EventArgs e)
        {
            save.Visible = true;

            if (removeflag != 1)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "RemoveColumn";
                buttonColumn.HeaderText = "Action";
                buttonColumn.Text = "Remove";
                buttonColumn.UseColumnTextForButtonValue = true;
                guna2DataGridView1.Columns.Add(buttonColumn);
                removeflag = 1;

                // Set the custom cell style for the button cells
                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.BackColor = Color.Red; // Set the background color to red
                buttonColumn.DefaultCellStyle = cellStyle;

                // Handle the click event for the "Remove" button
                guna2DataGridView1.CellContentClick += (s, args) =>
                {
                    if (args.RowIndex >= 0 && args.ColumnIndex == guna2DataGridView1.Columns["RemoveColumn"].Index)
                    {
                        var caloriesu = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[4].Value.ToString());
                        var proteinu = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[5].Value.ToString());
                        var fatsu = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[6].Value.ToString());
                        var carbsu = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[7].Value.ToString());
                        var calciumu = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[8].Value.ToString());
                        var fiberu = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[9].Value.ToString());
                        var sodiumu = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[10].Value.ToString());
                        var potassiumu = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[11].Value.ToString());
                        var phosphoru = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[12].Value.ToString());
                        var wateru = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[13].Value.ToString());
                        var magnesiumu = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[14].Value.ToString());
                        var sugaru = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[15].Value.ToString());
                        var ironu = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[16].Value.ToString());
                        var iodineu = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[17].Value.ToString());
                        var au = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[18].Value.ToString());
                        var bu = int.Parse(guna2DataGridView1.Rows[args.RowIndex].Cells[19].Value.ToString());

                        double currentCalories = double.Parse(calories.Text);
                        double currentProteins = double.Parse(protein.Text);
                        double currentFats = double.Parse(fats.Text);
                        double currentCarbohydrates = double.Parse(carbohydrates.Text);
                        double currentCalcium = double.Parse(calcium.Text);
                        double currentFibers = double.Parse(fibers.Text);
                        double currentSodium = double.Parse(sodium.Text);
                        double currentPotassium = double.Parse(potassium.Text);
                        double currentPhosphor = double.Parse(phosphor.Text);
                        double currentWater = double.Parse(water.Text);
                        double currentMagnesium = double.Parse(magnesium.Text);
                        double currentSuger = double.Parse(sugar.Text);
                        double currentIron = double.Parse(iron.Text);
                        double currentIodine = double.Parse(iodine.Text);
                        double currenta = double.Parse(abox.Text);
                        double currentb = double.Parse(bbox.Text);

                        double updatedCalories = currentCalories - caloriesu;
                        double updatedProteins = currentProteins - proteinu;
                        double updatedFats = currentFats - fatsu;
                        double updatedCarbohydrates = currentCarbohydrates - carbsu;
                        double updatedCalcium = currentCalcium - calciumu;
                        double updatedFibers = currentFibers - fiberu;
                        double updatedSodium = currentSodium - sodiumu;
                        double updatedPotassium = currentPotassium - potassiumu;
                        double updatedPhosphor = currentPhosphor - phosphoru;
                        double updatedWater = currentWater - wateru;
                        double updatedMagnesium = currentMagnesium - magnesiumu;
                        double updatedSuger = currentSuger - sugaru;
                        double updatedIron = currentIron - ironu;
                        double updatedIodine = currentIodine - iodineu;
                        double updateda = currenta - au;
                        double updatedb = currentb - bu;

                        // Update the textboxes with the new values
                        calories.Text = updatedCalories.ToString();
                        protein.Text = updatedProteins.ToString();
                        fats.Text = updatedFats.ToString();
                        carbohydrates.Text = updatedCarbohydrates.ToString();
                        calcium.Text = updatedCalcium.ToString();
                        fibers.Text = updatedFibers.ToString();
                        sodium.Text = updatedSodium.ToString();
                        potassium.Text = updatedPotassium.ToString();
                        phosphor.Text = updatedPhosphor.ToString();
                        water.Text = updatedWater.ToString();
                        magnesium.Text = updatedMagnesium.ToString();
                        sugar.Text = updatedSuger.ToString();
                        iron.Text = updatedIron.ToString();
                        iodine.Text = updatedIodine.ToString();
                        abox.Text = updateda.ToString();
                        bbox.Text = updatedb.ToString();

                        guna2DataGridView1.Rows.RemoveAt(args.RowIndex);
                        if (guna2DataGridView1.Rows.Count == 0)
                        {
                            save.Visible = false;
                        }
                        else
                        {
                            save.Visible = true;
                        }
                    }
                };
            }

            DataGridViewRow row = new DataGridViewRow();

            // Create a DataGridViewComboBoxCell for the second cell.
            DataGridViewComboBoxCell comboCell = new DataGridViewComboBoxCell();

            // Clear the items in the combo cell to avoid duplicates
            comboCell.Items.Clear();

            comboCell.DataSource = GetIngredients();
            comboCell.DisplayMember = "Name";
            comboCell.ValueMember = "ID";

            // Set the default selected value for the combo box.
            comboCell.Value = GetIngredients()[0].ID; // Replace with the desired default value.

            // Create a DataGridViewTextBoxCell for the first cell.
            DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();

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
                string query = "SELECT CALORIES, FATS, CARBOHYDRATES, FIBERS, CALCIUM, PROTEIN, SODIUM, CLASSIFICATION, POTASSIUM, PHOSPHOR, WATER, MAGNESIUM, SUGAR, IRON, IODINE, A, B, INGREDIENT_EN FROM Ingredient WHERE ID = @IngredientID";

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
                        double potassium = (Convert.ToDouble(reader["POTASSIUM"]) * newQuantity) / 100;
                        double iodine = (Convert.ToDouble(reader["IODINE"]) * newQuantity) / 100;
                        double a = (Convert.ToDouble(reader["A"]) * newQuantity) / 100;
                        double b = (Convert.ToDouble(reader["B"]) * newQuantity) / 100;
                        double iron = (Convert.ToDouble(reader["IRON"]) * newQuantity) / 100;
                        double water = (Convert.ToDouble(reader["WATER"]) * newQuantity) / 100;
                        double suger = (Convert.ToDouble(reader["SUGAR"]) * newQuantity) / 100;
                        double magnesium = (Convert.ToDouble(reader["MAGNESIUM"]) * newQuantity) / 100;
                        double phosphor = (Convert.ToDouble(reader["PHOSPHOR"]) * newQuantity) / 100;
                        string ingredienten = reader["INGREDIENT_EN"].ToString();




                        string unit = (reader["CLASSIFICATION"]).ToString();

                        // Set the calculated values for other cells in the row.
                        guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value = ingredienten;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value = calories;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value = Protein;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value = fats;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value = carbohydrates;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value = calcium;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value = fibers;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[10].Value = sodium;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[11].Value = potassium;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[12].Value = phosphor;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[13].Value = water;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[14].Value = magnesium;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[15].Value = suger;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[16].Value = iron;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[17].Value = iodine;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[18].Value = a;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[19].Value = b;
                        guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value = unit;
                    }

                    double totalCalories = 0;
                    double totalProteins = 0;
                    double totalFats = 0;
                    double totalCarbohydrates = 0;
                    double totalCalcium = 0;
                    double totalFibers = 0;
                    double totalSodium = 0;
                    double totalPotassium = 0;
                    double totalPhosphor = 0;
                    double totalWater = 0;
                    double totalMagnesium = 0;
                    double totalSuger = 0;
                    double totalIron = 0;
                    double totalIodine = 0;
                    double totala = 0;
                    double totalb = 0;

                    foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                    {
                        if (row.Cells[4].Value != null)
                        {
                            totalCalories += Convert.ToDouble(row.Cells[4].Value);
                            totalProteins += Convert.ToDouble(row.Cells[5].Value);
                            totalFats += Convert.ToDouble(row.Cells[6].Value);
                            totalCarbohydrates += Convert.ToDouble(row.Cells[7].Value);
                            totalCalcium += Convert.ToDouble(row.Cells[8].Value);
                            totalFibers += Convert.ToDouble(row.Cells[9].Value);
                            totalSodium += Convert.ToDouble(row.Cells[10].Value);
                            totalPotassium += Convert.ToDouble(row.Cells[11].Value);
                            totalPhosphor += Convert.ToDouble(row.Cells[12].Value);
                            totalWater += Convert.ToDouble(row.Cells[13].Value);
                            totalMagnesium += Convert.ToDouble(row.Cells[14].Value);
                            totalSuger += Convert.ToDouble(row.Cells[15].Value);
                            totalIron += Convert.ToDouble(row.Cells[16].Value);
                            totalIodine += Convert.ToDouble(row.Cells[17].Value);
                            totala += Convert.ToDouble(row.Cells[18].Value);
                            totalb += Convert.ToDouble(row.Cells[19].Value);
                        }
                    }

                    calories.Text = totalCalories.ToString();
                    protein.Text = totalProteins.ToString();
                    fats.Text = totalFats.ToString();
                    carbohydrates.Text = totalCarbohydrates.ToString();
                    calcium.Text = totalCalcium.ToString();
                    fibers.Text = totalFibers.ToString();
                    sodium.Text = totalSodium.ToString();
                    potassium.Text = totalPotassium.ToString(); 
                    phosphor.Text = totalPhosphor.ToString();
                    water.Text = totalWater.ToString();
                    magnesium.Text = totalMagnesium.ToString();
                    sugar.Text = totalSuger.ToString();
                    iron.Text = totalIron.ToString();
                    iodine.Text = totalIodine.ToString();
                    abox.Text = totala.ToString();
                    bbox.Text = totalb.ToString();

                    MainClass.con.Close();
                }
            }
        }
        private int GetLastMeal()
        {

            int ID = 0;
            // Create a connection a

            // Create a SQL command to retrieve the last meal
            using (SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Meal ORDER BY ID DESC", MainClass.con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a Meal object and populate it with data from the database

                            ID = reader.GetInt32(reader.GetOrdinal("ID"));
                                // Retrieve other columns as needed
                            
                        }
                    }
                }
           

            return ID;
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (edit == 0)
            {
                if (mealar.Text != "")
                {
                    try
                    {
                        MainClass.con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Meal (MealAr, MealEn, GroupNAr, GroupNEn, GroupCAr, GroupCEn, CLASSIFICATION, CALORIES, FATS, FIBERS, POTASSIUM, WATER, SUGAR, CALCIUM, A, PROTEIN, CARBOHYDRATES, SODIUM, PHOSPHOR, MAGNESIUM, IRON, IODINE, B, Category, Notes, Preparation) " +
                            "VALUES (@MealAr, @MealEn, @GroupNAr, @GroupNEn, @GroupCAr, @GroupCEn, @CLASSIFICATION, @CALORIES, @FATS, @FIBERS, @POTASSIUM, @WATER, @SUGAR, @CALCIUM, @A, @PROTEIN, @CARBOHYDRATES, @SODIUM, @PHOSPHOR, @MAGNESIUM, @IRON, @IODINE, @B, @Category, @Notes, @Preparation)", MainClass.con);

                        cmd.Parameters.AddWithValue("@MealAr", mealar.Text);
                        cmd.Parameters.AddWithValue("@MealEn", mealen.Text);
                        cmd.Parameters.AddWithValue("@GroupNAr", groupnar.Text);
                        cmd.Parameters.AddWithValue("@GroupNEn", groupnen.Text);
                        cmd.Parameters.AddWithValue("@GroupCAr", groupcar.Text);
                        cmd.Parameters.AddWithValue("@GroupCEn", groupcen.Text);
                        cmd.Parameters.AddWithValue("@Category", category.Text);
                        cmd.Parameters.AddWithValue("@CLASSIFICATION", classification.Text);
                        cmd.Parameters.AddWithValue("@CALORIES", Convert.ToDouble(calories.Text));
                        cmd.Parameters.AddWithValue("@FATS", Convert.ToDouble(fats.Text));
                        cmd.Parameters.AddWithValue("@FIBERS", Convert.ToDouble(fibers.Text));
                        cmd.Parameters.AddWithValue("@POTASSIUM", Convert.ToDouble(potassium.Text));
                        cmd.Parameters.AddWithValue("@WATER", Convert.ToDouble(water.Text));
                        cmd.Parameters.AddWithValue("@SUGAR", Convert.ToDouble(sugar.Text));
                        cmd.Parameters.AddWithValue("@CALCIUM", Convert.ToDouble(calcium.Text));
                        cmd.Parameters.AddWithValue("@A", Convert.ToDouble(abox.Text));
                        cmd.Parameters.AddWithValue("@PROTEIN", Convert.ToDouble(protein.Text));
                        cmd.Parameters.AddWithValue("@CARBOHYDRATES", Convert.ToDouble(carbohydrates.Text));
                        cmd.Parameters.AddWithValue("@SODIUM", Convert.ToDouble(sodium.Text));
                        cmd.Parameters.AddWithValue("@PHOSPHOR", Convert.ToDouble(phosphor.Text));
                        cmd.Parameters.AddWithValue("@MAGNESIUM", Convert.ToDouble(magnesium.Text));
                        cmd.Parameters.AddWithValue("@IRON", Convert.ToDouble(iron.Text));
                        cmd.Parameters.AddWithValue("@IODINE", Convert.ToDouble(iodine.Text));
                        cmd.Parameters.AddWithValue("@B", Convert.ToDouble(bbox.Text));
                        cmd.Parameters.AddWithValue("@Notes", notes.Text);
                        cmd.Parameters.AddWithValue("@Preparation", preparation.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Meal added successfully");
                        MainClass.con.Close();
                        
                        mealar.Text = "";
                        mealen.Text = "";
                        groupnar.Text = "";
                        groupnen.Text = "";
                        groupcar.Text = "";
                        groupcen.Text = "";
                        classification.Text = "";
                        category.Text = "";
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
                        tabControl1.SelectedIndex = 2;
                        ShowMeals(guna2DataGridView2, iddgv, mealardgv, mealendgv, caloriesdgv, proteinmaindgv, fatsmaindgv, carbohydratesmaindgv, calciummaindgv, fibermaindgv, sodiummaindgv);


                    }
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {
                        foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                        {
                            if (!row.IsNewRow) // Skip the last empty row if present.
                            {
                                int ingredientAr = int.Parse(row.Cells["ingredientardgv"].Value.ToString());



                                string ingredientEn = row.Cells["ingredientendgv"].Value.ToString();
                                string unit = row.Cells["unitdgv"].Value.ToString();
                                double calories = Convert.ToDouble(row.Cells["caloriedgv"].Value);
                                double fats = Convert.ToDouble(row.Cells["fatsdgv"].Value);
                                double carbohydrates = Convert.ToDouble(row.Cells["carbohydratesdgv"].Value);
                                double fibers = Convert.ToDouble(row.Cells["fiberdgv"].Value);
                                double protein = Convert.ToDouble(row.Cells["proteindgv"].Value);
                                double calcium = Convert.ToDouble(row.Cells["calciumdgv"].Value);
                                double sodium = Convert.ToDouble(row.Cells["sodiumdgv"].Value);
                                double potassium = Convert.ToDouble(row.Cells["potassiumdgv"].Value);
                                double iodine = Convert.ToDouble(row.Cells["iodinedgv"].Value);
                                double a = Convert.ToDouble(row.Cells["adgv"].Value);
                                double b = Convert.ToDouble(row.Cells["bdgv"].Value);
                                double iron = Convert.ToDouble(row.Cells["irondgv"].Value);
                                double water = Convert.ToDouble(row.Cells["waterdgv"].Value);
                                double suger = Convert.ToDouble(row.Cells["sugerdgv"].Value);
                                double magnesium = Convert.ToDouble(row.Cells["magnesiumdgv"].Value);
                                double phosphor = Convert.ToDouble(row.Cells["phosphordgv"].Value);
                                int quantity = int.Parse(row.Cells["quantitydgv"].Value.ToString());

                                MainClass.con.Open();
                                using (SqlCommand command = new SqlCommand(
                                    "INSERT INTO MealIngredients (MealID, IngredientAr, IngredientEn, Unit, Calories, Fats, Carbohydrates, Fibers, Protein, Calcium, Sodium, Potassium, Iodine, A, B, Iron, Water, Suger, Magnesium, Phosphor, Quantity) " +
                                    "VALUES (@MealID, @IngredientAr, @IngredientEn, @Unit, @Calories, @Fats, @Carbohydrates, @Fibers, @Protein, @Calcium, @Sodium, @Potassium, @Iodine, @A, @B, @Iron, @Water, @Suger, @Magnesium, @Phosphor, @Quantity)", MainClass.con))
                                {
                                    // Add parameters to the SQL command
                                    command.Parameters.AddWithValue("@MealID", GetLastMeal());
                                    command.Parameters.AddWithValue("@IngredientAr", ingredientAr);
                                    command.Parameters.AddWithValue("@IngredientEn", ingredientEn);
                                    command.Parameters.AddWithValue("@Unit", unit);
                                    command.Parameters.AddWithValue("@Calories", calories);
                                    command.Parameters.AddWithValue("@Fats", fats);
                                    command.Parameters.AddWithValue("@Carbohydrates", carbohydrates);
                                    command.Parameters.AddWithValue("@Fibers", fibers);
                                    command.Parameters.AddWithValue("@Protein", protein);
                                    command.Parameters.AddWithValue("@Calcium", calcium);
                                    command.Parameters.AddWithValue("@Sodium", sodium);
                                    command.Parameters.AddWithValue("@Potassium", potassium);
                                    command.Parameters.AddWithValue("@Iodine", iodine);
                                    command.Parameters.AddWithValue("@A", a);
                                    command.Parameters.AddWithValue("@B", b);
                                    command.Parameters.AddWithValue("@Iron", iron);
                                    command.Parameters.AddWithValue("@Water", water);
                                    command.Parameters.AddWithValue("@Suger", suger);
                                    command.Parameters.AddWithValue("@Magnesium", magnesium);
                                    command.Parameters.AddWithValue("@Phosphor", phosphor);
                                    command.Parameters.AddWithValue("@Quantity", quantity);
                                    // Execute the SQL command
                                    command.ExecuteNonQuery();
                                }
                                MainClass.con.Close();
                            }
                        }
                        guna2DataGridView1.Rows.Clear();
                    }
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Meal AR name cannot be empty.");
                }
            }
            else
            {
                if (mealar.Text != "")
                {
                    try
                    {
                        MainClass.con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Meal SET MealAr = @MealAr, MealEn = @MealEn, GroupNAr = @GroupNAr, GroupNEn = @GroupNEn, GroupCAr = @GroupCAr, GroupCEn = @GroupCEn, CLASSIFICATION = @CLASSIFICATION, CALORIES = @CALORIES, FATS = @FATS, FIBERS = @FIBERS, POTASSIUM = @POTASSIUM, WATER = @WATER, SUGAR = @SUGAR, CALCIUM = @CALCIUM, A = @A, PROTEIN = @PROTEIN, CARBOHYDRATES = @CARBOHYDRATES, SODIUM = @SODIUM, PHOSPHOR = @PHOSPHOR, MAGNESIUM = @MAGNESIUM, IRON = @IRON, IODINE = @IODINE, B = @B, Category = @Category, Notes = @Notes, Preparation = @Preparation WHERE ID = @ID", MainClass.con);

                        //cmd.Parameters.AddWithValue("@ID", mealIDToEdit);
                        cmd.Parameters.AddWithValue("@MealAr", mealar.Text);
                        cmd.Parameters.AddWithValue("@MealEn", mealen.Text);
                        cmd.Parameters.AddWithValue("@GroupNAr", groupnar.Text);
                        cmd.Parameters.AddWithValue("@GroupNEn", groupnen.Text);
                        cmd.Parameters.AddWithValue("@GroupCAr", groupcar.Text);
                        cmd.Parameters.AddWithValue("@GroupCEn", groupcen.Text);
                        cmd.Parameters.AddWithValue("@Category", category.Text);
                        cmd.Parameters.AddWithValue("@CLASSIFICATION", classification.Text);
                        cmd.Parameters.AddWithValue("@CALORIES", Convert.ToDouble(calories.Text));
                        cmd.Parameters.AddWithValue("@FATS", Convert.ToDouble(fats.Text));
                        cmd.Parameters.AddWithValue("@FIBERS", Convert.ToDouble(fibers.Text));
                        cmd.Parameters.AddWithValue("@POTASSIUM", Convert.ToDouble(potassium.Text));
                        cmd.Parameters.AddWithValue("@WATER", Convert.ToDouble(water.Text));
                        cmd.Parameters.AddWithValue("@SUGAR", Convert.ToDouble(sugar.Text));
                        cmd.Parameters.AddWithValue("@CALCIUM", Convert.ToDouble(calcium.Text));
                        cmd.Parameters.AddWithValue("@A", Convert.ToDouble(abox.Text));
                        cmd.Parameters.AddWithValue("@PROTEIN", Convert.ToDouble(protein.Text));
                        cmd.Parameters.AddWithValue("@CARBOHYDRATES", Convert.ToDouble(carbohydrates.Text));
                        cmd.Parameters.AddWithValue("@SODIUM", Convert.ToDouble(sodium.Text));
                        cmd.Parameters.AddWithValue("@PHOSPHOR", Convert.ToDouble(phosphor.Text));
                        cmd.Parameters.AddWithValue("@MAGNESIUM", Convert.ToDouble(magnesium.Text));
                        cmd.Parameters.AddWithValue("@IRON", Convert.ToDouble(iron.Text));
                        cmd.Parameters.AddWithValue("@IODINE", Convert.ToDouble(iodine.Text));
                        cmd.Parameters.AddWithValue("@B", Convert.ToDouble(bbox.Text));
                        cmd.Parameters.AddWithValue("@Notes", notes.Text);
                        cmd.Parameters.AddWithValue("@Preparation", preparation.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Meal updated successfully");

                        // Clear the input controls or set them to default values.
                        mealar.Text = "";
                        mealen.Text = "";
                        groupnar.Text = "";
                        groupnen.Text = "";
                        groupcar.Text = "";
                        groupcen.Text = "";
                        classification.Text = "";
                        category.Text = "";
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
                        notes.Text = "";
                        preparation.Text = "";
                        MainClass.con.Close();



                    }
                     
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {
                        MainClass.con.Open();
                        SqlCommand cmdingredients = new SqlCommand("DELETE FROM MealIngredients WHERE MealID = @MealID", MainClass.con);
                        cmdingredients.Parameters.AddWithValue("@MealID", mealIDToEdit); // Assuming the Ingredient ID is in the first cell of the selected row.
                        cmdingredients.ExecuteNonQuery();
                        //MessageBox.Show("Meal removed successfully");
                        MainClass.con.Close();
                        foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                        {
                            if (!row.IsNewRow) // Skip the last empty row if present.
                            {
                                string ingredientAr = row.Cells["ingredientardgv"].Value.ToString();
                                string ingredientEn = row.Cells["ingredientendgv"].Value.ToString();
                                string unit = row.Cells["unitdgv"].Value.ToString();
                                double calories = Convert.ToDouble(row.Cells["caloriedgv"].Value);
                                double fats = Convert.ToDouble(row.Cells["fatsdgv"].Value);
                                double carbohydrates = Convert.ToDouble(row.Cells["carbohydratesdgv"].Value);
                                double fibers = Convert.ToDouble(row.Cells["fiberdgv"].Value);
                                double protein = Convert.ToDouble(row.Cells["proteindgv"].Value);
                                double calcium = Convert.ToDouble(row.Cells["calciumdgv"].Value);
                                double sodium = Convert.ToDouble(row.Cells["sodiumdgv"].Value);
                                double potassium = Convert.ToDouble(row.Cells["potassiumdgv"].Value);
                                double iodine = Convert.ToDouble(row.Cells["iodinedgv"].Value);
                                double a = Convert.ToDouble(row.Cells["adgv"].Value);
                                double b = Convert.ToDouble(row.Cells["bdgv"].Value);
                                double iron = Convert.ToDouble(row.Cells["irondgv"].Value);
                                double water = Convert.ToDouble(row.Cells["waterdgv"].Value);
                                double suger = Convert.ToDouble(row.Cells["sugerdgv"].Value);
                                double magnesium = Convert.ToDouble(row.Cells["magnesiumdgv"].Value);
                                double phosphor = Convert.ToDouble(row.Cells["phosphordgv"].Value);
                                int quantity = int.Parse(row.Cells["quantitydgv"].Value.ToString());

                                MainClass.con.Open();
                                using (SqlCommand command = new SqlCommand(
                                    "INSERT INTO MealIngredients (MealID, IngredientAr, IngredientEn, Unit, Calories, Fats, Carbohydrates, Fibers, Protein, Calcium, Sodium, Potassium, Iodine, A, B, Iron, Water, Suger, Magnesium, Phosphor, Quantity) " +
                                    "VALUES (@MealID, @IngredientAr, @IngredientEn, @Unit, @Calories, @Fats, @Carbohydrates, @Fibers, @Protein, @Calcium, @Sodium, @Potassium, @Iodine, @A, @B, @Iron, @Water, @Suger, @Magnesium, @Phosphor, @Quantity)", MainClass.con))
                                {
                                    // Add parameters to the SQL command
                                    command.Parameters.AddWithValue("@MealID", mealIDToEdit);
                                    command.Parameters.AddWithValue("@IngredientAr", ingredientAr);
                                    command.Parameters.AddWithValue("@IngredientEn", ingredientEn);
                                    command.Parameters.AddWithValue("@Unit", unit);
                                    command.Parameters.AddWithValue("@Calories", calories);
                                    command.Parameters.AddWithValue("@Fats", fats);
                                    command.Parameters.AddWithValue("@Carbohydrates", carbohydrates);
                                    command.Parameters.AddWithValue("@Fibers", fibers);
                                    command.Parameters.AddWithValue("@Protein", protein);
                                    command.Parameters.AddWithValue("@Calcium", calcium);
                                    command.Parameters.AddWithValue("@Sodium", sodium);
                                    command.Parameters.AddWithValue("@Potassium", potassium);
                                    command.Parameters.AddWithValue("@Iodine", iodine);
                                    command.Parameters.AddWithValue("@A", a);
                                    command.Parameters.AddWithValue("@B", b);
                                    command.Parameters.AddWithValue("@Iron", iron);
                                    command.Parameters.AddWithValue("@Water", water);
                                    command.Parameters.AddWithValue("@Suger", suger);
                                    command.Parameters.AddWithValue("@Magnesium", magnesium);
                                    command.Parameters.AddWithValue("@Phosphor", phosphor);
                                    command.Parameters.AddWithValue("@Quantity", quantity);
                                    // Execute the SQL command
                                    command.ExecuteNonQuery();
                                }
                                MainClass.con.Close();
                            }
                        }
                        guna2DataGridView1.Rows.Clear();
                    }
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Meal AR name cannot be empty.");
                }
            }

        }
        private void Ingredienttab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void Backtomeal_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void AddIngredient_Click_1(object sender, EventArgs e)
        {

        }
        private void Add_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView2 != null)
            {
                if (guna2DataGridView2.Rows.Count > 0)
                {
                    if (guna2DataGridView2.SelectedRows.Count == 1)
                    {
                        mealar.Text = "";
                        mealen.Text = "";
                        groupnar.Text = "";
                        groupnen.Text = "";
                        groupcar.Text = "";
                        groupcen.Text = "";
                        classification.Text = "";
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
                        string ingredientIDToDelete = guna2DataGridView2.CurrentRow.Cells[1].Value.ToString(); // Assuming the Ingredient ID is in the first cell of the selected row.

                        // Ask for confirmation
                        DialogResult result = MessageBox.Show("Are you sure you want to delete Meal : " + ingredientIDToDelete + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            string id = guna2DataGridView2.CurrentRow.Cells[0].Value.ToString();
                            try
                            {
                                MainClass.con.Open();
                                SqlCommand cmd = new SqlCommand("DELETE FROM Meal WHERE ID = @MealID", MainClass.con);
                                cmd.Parameters.AddWithValue("@MealID", guna2DataGridView2.CurrentRow.Cells[0].Value.ToString()); // Assuming the Ingredient ID is in the first cell of the selected row.
                                cmd.ExecuteNonQuery();
                                MainClass.con.Close();

                                MainClass.con.Open();
                                SqlCommand cmdingredients = new SqlCommand("DELETE FROM MealIngredients WHERE MealID = @MealID", MainClass.con);
                                cmdingredients.Parameters.AddWithValue("@MealID", id); // Assuming the Ingredient ID is in the first cell of the selected row.
                                cmdingredients.ExecuteNonQuery();
                                MessageBox.Show("Meal removed successfully");
                                MainClass.con.Close();

                                ShowMeals(guna2DataGridView2, iddgv, mealardgv, mealendgv, caloriedgv, proteindgv, fatsdgv, carbohydratesdgv, calciumdgv, fiberdgv, sodiumdgv);
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
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = 1;
            try
            {
                mealIDToEdit = guna2DataGridView2.CurrentRow.Cells[0].Value.ToString();
                MainClass.con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Meal WHERE ID = @MealID", MainClass.con);
                cmd.Parameters.AddWithValue("@MealID", mealIDToEdit);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Set the retrieved data into input controls
                        mealar.Text = reader["MealAr"].ToString();
                        mealen.Text = reader["MealEn"].ToString();
                        groupnar.Text = reader["GroupNAr"].ToString();
                        groupnen.Text = reader["GroupNEn"].ToString();
                        groupcar.Text = reader["GroupCAr"].ToString();
                        groupcen.Text = reader["GroupCEn"].ToString();
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
                        category.Text = reader["Category"].ToString();
                        notes.Text = reader["Notes"].ToString();
                        preparation.Text = reader["Preparation"].ToString();
                        classification.Text = reader["CLASSIFICATION"].ToString();
                    }
                    reader.Close(); // Close the first DataReader

                    ShowIngredients(guna2DataGridView1, unitdgv, ingredientardgv, ingredientendgv,quantitydgv, caloriedgv, proteindgv, fatsdgv, carbohydratesdgv, calciumdgv, fiberdgv, sodiumdgv, potassiumdgv, phosphordgv,waterdgv,magnesiumdgv,sugerdgv,irondgv,iodinedgv,adgv,bdgv);
                    MainClass.con.Close();
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Meal not found with ID: " + mealIDToEdit);
                }

                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }


        }
        private void Meals_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
    }
}
