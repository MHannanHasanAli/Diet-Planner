using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win32Interop.Enums;

namespace HelloWorldSolutionIMS
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        static int edit = 0;
        private int GetLastFileno()
        {

            int fileno = 0;
            // Create a connection a
            MainClass.con.Open();

            // Create a SQL command to retrieve the last meal
            using (SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Customer ORDER BY ID DESC", MainClass.con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Create a Meal object and populate it with data from the database

                        fileno = reader.GetInt32(reader.GetOrdinal("FILENO"));
                        // Retrieve other columns as needed

                    }
                }
            }
            MainClass.con.Close();


            return fileno;
        }
        private void ShowCustomer(DataGridView dgv, DataGridViewColumn id, DataGridViewColumn file, DataGridViewColumn name, DataGridViewColumn familyname, DataGridViewColumn start, DataGridViewColumn end, DataGridViewColumn nutritionist)
        {
            SqlCommand cmd;
            try
            {
                MainClass.con.Open();
               
              cmd = new SqlCommand("select ID,FileNo,FirstName,FamilyName,SubscriptionStartDate,SubscriptionEndDate,NutritionistName from Customer order by FileNo", MainClass.con);
               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                id.DataPropertyName = dt.Columns["ID"].ToString();
                file.DataPropertyName = dt.Columns["FileNo"].ToString();
                name.DataPropertyName = dt.Columns["FirstName"].ToString();
                familyname.DataPropertyName = dt.Columns["FamilyName"].ToString();
                start.DataPropertyName = dt.Columns["SubscriptionStartDate"].ToString();
                end.DataPropertyName = dt.Columns["SubscriptionEndDate"].ToString();
                nutritionist.DataPropertyName = dt.Columns["NutritionistName"].ToString();
                dgv.DataSource = dt;
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void SearchCustomer(DataGridView dgv, DataGridViewColumn id, DataGridViewColumn file, DataGridViewColumn name, DataGridViewColumn familyname, DataGridViewColumn start, DataGridViewColumn end, DataGridViewColumn nutritionist)
        {
            string file_no = fileno.Text;
            string searchname = firstname.Text;
            if (file_no != "" && searchname != "")
            {
                try
                {
                    MainClass.con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT ID, FileNo, FirstName, FamilyName, SubscriptionStartDate, SubscriptionEndDate, NutritionistName FROM Customer WHERE FileNo LIKE @FileNo AND FirstName LIKE @FirstName", MainClass.con);

                    cmd.Parameters.AddWithValue("@FileNo", "%" + file_no + "%");
                    cmd.Parameters.AddWithValue("@FirstName", "%" + searchname + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    id.DataPropertyName = dt.Columns["ID"].ToString();
                    file.DataPropertyName = dt.Columns["FileNo"].ToString();
                    name.DataPropertyName = dt.Columns["FirstName"].ToString();
                    familyname.DataPropertyName = dt.Columns["FamilyName"].ToString();
                    start.DataPropertyName = dt.Columns["SubscriptionStartDate"].ToString();
                    end.DataPropertyName = dt.Columns["SubscriptionEndDate"].ToString();
                    nutritionist.DataPropertyName = dt.Columns["NutritionistName"].ToString();
                    dgv.DataSource = dt;
                    MainClass.con.Close();
                }

                catch (Exception ex)
                {
                    MainClass.con.Close();
                    MessageBox.Show(ex.Message);
                }
            }else if(file_no == "" && searchname != "")
            {
                try
                {
                    MainClass.con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT ID, FileNo, FirstName, FamilyName, SubscriptionStartDate, SubscriptionEndDate, NutritionistName FROM Customer WHERE FirstName LIKE @FirstName", MainClass.con);

                    cmd.Parameters.AddWithValue("@FileNo", "%" + file_no + "%");
                    cmd.Parameters.AddWithValue("@FirstName", "%" + searchname + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    id.DataPropertyName = dt.Columns["ID"].ToString();
                    file.DataPropertyName = dt.Columns["FileNo"].ToString();
                    name.DataPropertyName = dt.Columns["FirstName"].ToString();
                    familyname.DataPropertyName = dt.Columns["FamilyName"].ToString();
                    start.DataPropertyName = dt.Columns["SubscriptionStartDate"].ToString();
                    end.DataPropertyName = dt.Columns["SubscriptionEndDate"].ToString();
                    nutritionist.DataPropertyName = dt.Columns["NutritionistName"].ToString();
                    dgv.DataSource = dt;
                    MainClass.con.Close();
                }

                catch (Exception ex)
                {
                    MainClass.con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else if (file_no != "" && searchname == "")
            {
                try
                {
                    MainClass.con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT ID, FileNo, FirstName, FamilyName, SubscriptionStartDate, SubscriptionEndDate, NutritionistName FROM Customer WHERE FileNo LIKE @FileNo", MainClass.con);

                    cmd.Parameters.AddWithValue("@FileNo", "%" + file_no + "%");
                    cmd.Parameters.AddWithValue("@FirstName", "%" + searchname + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    id.DataPropertyName = dt.Columns["ID"].ToString();
                    file.DataPropertyName = dt.Columns["FileNo"].ToString();
                    name.DataPropertyName = dt.Columns["FirstName"].ToString();
                    familyname.DataPropertyName = dt.Columns["FamilyName"].ToString();
                    start.DataPropertyName = dt.Columns["SubscriptionStartDate"].ToString();
                    end.DataPropertyName = dt.Columns["SubscriptionEndDate"].ToString();
                    nutritionist.DataPropertyName = dt.Columns["NutritionistName"].ToString();
                    dgv.DataSource = dt;
                    MainClass.con.Close();
                }

                catch (Exception ex)
                {
                    MainClass.con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                ShowCustomer(guna2DataGridView1, IDDGV, FILENODGV, firstnamedgv, familynamedgv, subscriptionstartdatedgv, subscriptionenddatedgv, nutritionistnamedgv);
                MessageBox.Show("Fill File No or First Name");
            }
        }
        private void New_Click(object sender, EventArgs e)
        {
            int fileno_new = GetLastFileno();
            fileno_new = fileno_new + 1;
            if (edit == 0)
            {
                if (firstname.Text != "" || familyname.Text != "" || gender.Text != "" || mobileno.Text != "" || dob.Text != "" )
                {
                    try
                    {
                        MainClass.con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Customer (FileNo, FirstName, FamilyName, Gender, DOB, Age, MobileNo, Landline, Email, SubscriptionStatus, SubscriptionStartDate, SubscriptionEndDate, Branch, LastVisitDate, NutritionistName) VALUES (@FileNo, @FirstName, @FamilyName, @Gender, @DOB, @Age, @MobileNo, @Landline, @Email, @SubscriptionStatus, @SubscriptionStartDate, @SubscriptionEndDate, @Branch, @LastVisitDate, @NutritionistName)", MainClass.con);

                        cmd.Parameters.AddWithValue("@FileNo", fileno_new); // Replace fileNoValue with the actual file number.
                        cmd.Parameters.AddWithValue("@FirstName", firstname.Text);
                        cmd.Parameters.AddWithValue("@FamilyName", familyname.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender.Text);
                        cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(dob.Value)); // Assuming dateTimePickerDOB is used to select the date of birth.
                        cmd.Parameters.AddWithValue("@Age", age.Text); // Replace ageValue with the actual age.
                        cmd.Parameters.AddWithValue("@MobileNo", mobileno.Text);
                        cmd.Parameters.AddWithValue("@Landline", landline.Text);
                        cmd.Parameters.AddWithValue("@Email", email.Text);
                        cmd.Parameters.AddWithValue("@SubscriptionStatus", subscriptionstatus.Text);
                        cmd.Parameters.AddWithValue("@SubscriptionStartDate", Convert.ToDateTime(startdate.Value)); // Assuming dateTimePickerSubscriptionStart is used to select the subscription start date.
                        cmd.Parameters.AddWithValue("@SubscriptionEndDate", Convert.ToDateTime(enddate.Value)); // Assuming dateTimePickerSubscriptionEnd is used to select the subscription end date.
                        cmd.Parameters.AddWithValue("@Branch", branch.Text);
                        cmd.Parameters.AddWithValue("@LastVisitDate", Convert.ToDateTime(lastvisitdate.Value)); // Assuming dateTimePickerLastVisit is used to select the last visit date.
                        cmd.Parameters.AddWithValue("@NutritionistName", nutritionistname.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer added successfully");
                        fileno.Text = "";
                        firstname.Text = "";
                        familyname.Text = "";
                        gender.Text = "";
                        dob.Value = DateTime.Now; // Reset the date of birth to the current date or your default value.
                        age.Text = "";
                        mobileno.Text = "";
                        landline.Text = "";
                        email.Text = "";
                        subscriptionstatus.Text = "";
                        startdate.Value = DateTime.Now; // Reset the subscription start date to the current date or your default value.
                        enddate.Value = DateTime.Now; // Reset the subscription end date to the current date or your default value.
                        branch.Text = "";
                        lastvisitdate.Value = DateTime.Now; // Reset the last visit date to the current date or your default value.
                        nutritionistname.Text = "";
                        MainClass.con.Close();

                        ShowCustomer(guna2DataGridView1, IDDGV, FILENODGV, firstnamedgv, familynamedgv, subscriptionstartdatedgv, subscriptionenddatedgv, nutritionistnamedgv);
                    }
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("First name, Family name, gender, mobile no, Date of birth are mandory!.");
                }
            }
            else
            {
                if (firstname.Text != "" || familyname.Text != "" || gender.Text != "" || mobileno.Text != "" || dob.Text != "")
                {
                    try
                    {
                        MainClass.con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Customer SET FileNo = @FileNo, FirstName = @FirstName, FamilyName = @FamilyName, Gender = @Gender, DOB = @DOB, Age = @Age, MobileNo = @MobileNo, Landline = @Landline, Email = @Email, SubscriptionStatus = @SubscriptionStatus, SubscriptionStartDate = @SubscriptionStartDate, SubscriptionEndDate = @SubscriptionEndDate, Branch = @Branch, LastVisitDate = @LastVisitDate, NutritionistName = @NutritionistName WHERE FileNo = @FileNo", MainClass.con);

                        cmd.Parameters.AddWithValue("@FileNo", fileno_new); // Replace fileNoValue with the actual file number.
                        cmd.Parameters.AddWithValue("@FirstName", firstname.Text);
                        cmd.Parameters.AddWithValue("@FamilyName", familyname.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender.Text);
                        cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(dob.Value)); // Assuming dateTimePickerDOB is used to select the date of birth.
                        cmd.Parameters.AddWithValue("@Age", age.Text); // Replace ageValue with the actual age.
                        cmd.Parameters.AddWithValue("@MobileNo", mobileno.Text);
                        cmd.Parameters.AddWithValue("@Landline", landline.Text);
                        cmd.Parameters.AddWithValue("@Email", email.Text);
                        cmd.Parameters.AddWithValue("@SubscriptionStatus", subscriptionstatus.Text);
                        cmd.Parameters.AddWithValue("@SubscriptionStartDate", Convert.ToDateTime(startdate.Value)); // Assuming dateTimePickerSubscriptionStart is used to select the subscription start date.
                        cmd.Parameters.AddWithValue("@SubscriptionEndDate", Convert.ToDateTime(enddate.Value)); // Assuming dateTimePickerSubscriptionEnd is used to select the subscription end date.
                        cmd.Parameters.AddWithValue("@Branch", branch.Text);
                        cmd.Parameters.AddWithValue("@LastVisitDate", Convert.ToDateTime(lastvisitdate.Value)); // Assuming dateTimePickerLastVisit is used to select the last visit date.
                        cmd.Parameters.AddWithValue("@NutritionistName", nutritionistname.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer updated successfully");
                        fileno.Text = "";
                        firstname.Text = "";
                        familyname.Text = "";
                        gender.Text = "";
                        dob.Value = DateTime.Now; // Reset the date of birth to the current date or your default value.
                        age.Text = "";
                        mobileno.Text = "";
                        landline.Text = "";
                        email.Text = "";
                        subscriptionstatus.Text = "";
                        startdate.Value = DateTime.Now; // Reset the subscription start date to the current date or your default value.
                        enddate.Value = DateTime.Now; // Reset the subscription end date to the current date or your default value.
                        branch.Text = "";
                        lastvisitdate.Value = DateTime.Now; // Reset the last visit date to the current date or your default value.
                        nutritionistname.Text = "";
                        MainClass.con.Close();

                        ShowCustomer(guna2DataGridView1, IDDGV, FILENODGV, firstnamedgv, familynamedgv, subscriptionstartdatedgv, subscriptionenddatedgv, nutritionistnamedgv);
                    }
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("First name, Family name, gender, mobile no, Date of birth are mandory!.");
                }
            }
           
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            int fileno_new = GetLastFileno();
            fileno_new = fileno_new + 1;

            fileno.Text = fileno_new.ToString();

            subscriptionstatus.Text = "No";
            ShowCustomer(guna2DataGridView1, IDDGV, FILENODGV, firstnamedgv, familynamedgv, subscriptionstartdatedgv, subscriptionenddatedgv, nutritionistnamedgv);

        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = 1;
             try
                {
                    string customerIDToEdit = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string customerFilenoToEdit = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                    MainClass.con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE ID = @CustomerID", MainClass.con);
                    cmd.Parameters.AddWithValue("@CustomerID", customerIDToEdit); // Replace 'customerIdToFind' with the actual ID you want to find.

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Set the retrieved data into input boxes
                            fileno.Text = reader["FileNo"].ToString();
                            firstname.Text = reader["FirstName"].ToString();
                            familyname.Text = reader["FamilyName"].ToString();
                            gender.Text = reader["Gender"].ToString();
                            dob.Value = Convert.ToDateTime(reader["DOB"]);
                            age.Text = reader["Age"].ToString();
                            mobileno.Text = reader["MobileNo"].ToString();
                            landline.Text = reader["Landline"].ToString();
                            email.Text = reader["Email"].ToString();
                            subscriptionstatus.Text = reader["SubscriptionStatus"].ToString();
                            startdate.Value = Convert.ToDateTime(reader["SubscriptionStartDate"]);
                            enddate.Value = Convert.ToDateTime(reader["SubscriptionEndDate"]);
                            branch.Text = reader["Branch"].ToString();
                            lastvisitdate.Value = Convert.ToDateTime(reader["LastVisitDate"]);
                            nutritionistname.Text = reader["NutritionistName"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Customer not found with FILE NO : " + customerFilenoToEdit);
                    }

                    MainClass.con.Close();
                }
                catch (Exception ex)
                {
                    MainClass.con.Close();
                    MessageBox.Show(ex.Message);
                }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1 != null)
            {
                if (guna2DataGridView1.Rows.Count > 0)
                {
                    if (guna2DataGridView1.SelectedRows.Count == 1)
                    {
                        // Get the CustomerID to display in the confirmation message
                        string customerIDToDelete = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();

                        // Ask for confirmation
                        DialogResult result = MessageBox.Show("Are you sure you want to delete Customer with FILE NO: " + customerIDToDelete + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                MainClass.con.Open();
                                SqlCommand cmd = new SqlCommand("delete from Customer where ID = @CustomerID", MainClass.con);
                                cmd.Parameters.AddWithValue("@CustomerID", guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Customer removed successfully");
                                MainClass.con.Close();
                                ShowCustomer(guna2DataGridView1, IDDGV, FILENODGV, firstnamedgv, familynamedgv, subscriptionstartdatedgv, subscriptionenddatedgv, nutritionistnamedgv);
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
        private void Update_Click(object sender, EventArgs e)
        {
           
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
        private void Search_Click(object sender, EventArgs e)
        {

            SearchCustomer(guna2DataGridView1, IDDGV, FILENODGV, firstnamedgv, familynamedgv, subscriptionstartdatedgv, subscriptionenddatedgv, nutritionistnamedgv);

        }
        private void mobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the keypress if it's not a number or a control character
            }
        }
        private void landline_TextChanged(object sender, EventArgs e)
        {

        }
        private void landline_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the keypress if it's not a number or a control character
            }
        }
        private void dob_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dob.Value;
            DateTime currentDate = DateTime.Today;

            int years = currentDate.Year - selectedDate.Year;
            if (selectedDate.Date > currentDate.AddYears(-years)) years--;

            // Use the 'years' variable as needed, for instance, displaying it in a label
            age.Text = years.ToString();
        }
    }
}
