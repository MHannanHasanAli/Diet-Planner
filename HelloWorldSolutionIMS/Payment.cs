using Guna.UI2.WinForms;
using Svg;
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
using Win32Interop.Enums;

namespace HelloWorldSolutionIMS
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        static int edit = 0;
        static string PaymentIDToEdit;
        private void ShowPayments(DataGridView dgv, DataGridViewColumn no, DataGridViewColumn pay, DataGridViewColumn first, DataGridViewColumn family, DataGridViewColumn amount, DataGridViewColumn amountpro, DataGridViewColumn promopercent, DataGridViewColumn date)
        {
            SqlCommand cmd;
            try
            {
                MainClass.con.Open();

                cmd = new SqlCommand("SELECT FILENO, FIRSTNAME, FAMILYNAME, PAYMENTNAME, AMOUNT, AMOUNTAFTERPROMOTION, PROMOTIONPERCENTAGE, DATE FROM Payment", MainClass.con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                no.DataPropertyName = dt.Columns["FILENO"].ToString();
                pay.DataPropertyName = dt.Columns["PAYMENTNAME"].ToString();
                first.DataPropertyName = dt.Columns["FIRSTNAME"].ToString();
                family.DataPropertyName = dt.Columns["FAMILYNAME"].ToString();
                amount.DataPropertyName = dt.Columns["AMOUNT"].ToString();
                amountpro.DataPropertyName = dt.Columns["AMOUNTAFTERPROMOTION"].ToString();
                promopercent.DataPropertyName = dt.Columns["PROMOTIONPERCENTAGE"].ToString();
                date.DataPropertyName = dt.Columns["DATE"].ToString();
               


                dgv.DataSource = dt;
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
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
                        SqlCommand cmd = new SqlCommand("INSERT INTO Payment (FirstName, FamilyName, Gender, Age, MobileNo, PaymentName, Amount, Date, AmountAfterPromotion, PromotionPercentage, PromotionCode, PromotionName, PromotionDetails) " +
                            "VALUES (@FirstName, @FamilyName, @Gender, @Age, @MobileNo, @PaymentName, @Amount, @Date, @AmountAfterPromotion, @PromotionPercentage, @PromotionCode, @PromotionName, @PromotionDetails)", MainClass.con);

                        cmd.Parameters.AddWithValue("@FirstName", firstname.Text);
                        cmd.Parameters.AddWithValue("@FamilyName", familyname.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender.Text);
                        cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(age.Text));
                        cmd.Parameters.AddWithValue("@MobileNo", mobileno.Text);
                        cmd.Parameters.AddWithValue("@PaymentName", paymentname.Text);
                        cmd.Parameters.AddWithValue("@Amount", Convert.ToDouble(amount.Text));
                        cmd.Parameters.AddWithValue("@Date", DateTime.Parse(date.Text));
                        cmd.Parameters.AddWithValue("@AmountAfterPromotion", Convert.ToDouble(amountafterpromotion.Text));
                        cmd.Parameters.AddWithValue("@PromotionPercentage", Convert.ToDouble(promotionpercentage.Text));
                        cmd.Parameters.AddWithValue("@PromotionCode", promotioncode.Text);
                        cmd.Parameters.AddWithValue("@PromotionName", promotionname.Text);
                        cmd.Parameters.AddWithValue("@PromotionDetails", promotiondetails.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Payment added successfully");

                        // Clear the input controls or set them to default values.
                        fileno.Text = "";
                        firstname.Text = "";
                        familyname.Text = "";
                        gender.Text = "";
                        age.Text = "";
                        mobileno.Text = "";
                        paymentname.Text = "";
                        amount.Text = "";
                        date.Text = "";
                        amountafterpromotion.Text = "";
                        promotionpercentage.Text = "";
                        promotioncode.Text = "";
                        promotionname.Text = "";
                        promotiondetails.Text = "";

                        MainClass.con.Close();

                        // Refresh the DataGridView to display the updated data.
                        // Replace the arguments with your actual DataGridView and column names.
                        ShowPayments(guna2DataGridView1, filenodgv, paymentnamedgv, firstnamedgv, familynamedgv, amountdgv, amountaftrpromotiondgv, promotionpercentagedgv, datedgv);
                        tabControl1.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Customer Name cannot be empty.");
                }
            }
            else
            {
                if (firstname.Text != "")
                {
                    try
                    {
                        MainClass.con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Payment SET FirstName = @FirstName, FamilyName = @FamilyName, Gender = @Gender, Age = @Age, MobileNo = @MobileNo, PaymentName = @PaymentName, Amount = @Amount, Date = @Date, AmountAfterPromotion = @AmountAfterPromotion, PromotionPercentage = @PromotionPercentage, PromotionCode = @PromotionCode, PromotionName = @PromotionName, PromotionDetails = @PromotionDetails WHERE FILENO = @ID", MainClass.con);

                        cmd.Parameters.AddWithValue("@ID", PaymentIDToEdit);
                        cmd.Parameters.AddWithValue("@FirstName", firstname.Text);
                        cmd.Parameters.AddWithValue("@FamilyName", familyname.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender.Text);
                        cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(age.Text));
                        cmd.Parameters.AddWithValue("@MobileNo", mobileno.Text);
                        cmd.Parameters.AddWithValue("@PaymentName", paymentname.Text);
                        cmd.Parameters.AddWithValue("@Amount", Convert.ToDouble(amount.Text));
                        cmd.Parameters.AddWithValue("@Date", DateTime.Parse(date.Text));
                        cmd.Parameters.AddWithValue("@AmountAfterPromotion", Convert.ToDouble(amountafterpromotion.Text));
                        cmd.Parameters.AddWithValue("@PromotionPercentage", Convert.ToDouble(promotionpercentage.Text));
                        cmd.Parameters.AddWithValue("@PromotionCode", promotioncode.Text);
                        cmd.Parameters.AddWithValue("@PromotionName", promotionname.Text);
                        cmd.Parameters.AddWithValue("@PromotionDetails", promotiondetails.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Payment updated successfully");

                        // Clear the input controls or set them to default values.
                        fileno.Text = "";
                        firstname.Text = "";
                        familyname.Text = "";
                        gender.Text = "";
                        age.Text = "";
                        mobileno.Text = "";
                        paymentname.Text = "";
                        amount.Text = "";
                        date.Text = "";
                        amountafterpromotion.Text = "";
                        promotionpercentage.Text = "";
                        promotioncode.Text = "";
                        promotionname.Text = "";
                        promotiondetails.Text = "";

                        MainClass.con.Close();

                        // Refresh the DataGridView to display the updated data.
                        // Replace the arguments with your actual DataGridView and column names.
                        ShowPayments(guna2DataGridView1, filenodgv, paymentnamedgv, firstnamedgv, familynamedgv, amountdgv, amountaftrpromotiondgv, promotionpercentagedgv, datedgv);
                        tabControl1.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Customer Name cannot be empty.");
                }
            }

        }
        private void Payment_Load(object sender, EventArgs e)
        {
            MainClass.HideAllTabsOnTabControl(tabControl1);
            ShowPayments(guna2DataGridView1, filenodgv, paymentnamedgv, firstnamedgv, familynamedgv, amountdgv, amountaftrpromotiondgv, promotionpercentagedgv, datedgv);

        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1 != null)
            {
                if (guna2DataGridView1.Rows.Count > 0)
                {
                    if (guna2DataGridView1.SelectedRows.Count == 1)
                    {
                        fileno.Text = "";
                        firstname.Text = "";
                        familyname.Text = "";
                        gender.Text = "";
                        age.Text = "";
                        mobileno.Text = "";
                        paymentname.Text = "";
                        amount.Text = "";
                        date.Text = "";
                        amountafterpromotion.Text = "";
                        promotionpercentage.Text = "";
                        promotioncode.Text = "";
                        promotionname.Text = "";
                        promotiondetails.Text = "";

                        // Get the Ingredient ID to display in the confirmation message
                        string paymentIDToDelete = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString(); // Assuming the Ingredient ID is in the first cell of the selected row.

                        // Ask for confirmation
                        DialogResult result = MessageBox.Show("Are you sure you want to delete Payment : " + paymentIDToDelete + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                MainClass.con.Open();
                                SqlCommand cmd = new SqlCommand("DELETE FROM Payment WHERE FILENO = @ID", MainClass.con);
                                cmd.Parameters.AddWithValue("@ID", guna2DataGridView1.CurrentRow.Cells[1].Value.ToString()); // Assuming the Ingredient ID is in the first cell of the selected row.
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Payment removed successfully");
                                MainClass.con.Close();
                                // Refresh the data grid view with the updated data
                                ShowPayments(guna2DataGridView1, filenodgv, paymentnamedgv, firstnamedgv, familynamedgv, amountdgv, amountaftrpromotiondgv, promotionpercentagedgv, datedgv);
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
                PaymentIDToEdit = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString(); // Assuming the ID is in the first cell
                MainClass.con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Payment WHERE FILENO = @paymentID", MainClass.con);
                cmd.Parameters.AddWithValue("@paymentID", PaymentIDToEdit);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Set the retrieved data into input controls
                        fileno.Text = reader["FileNo"].ToString();
                        firstname.Text = reader["FirstName"].ToString();
                        familyname.Text = reader["FamilyName"].ToString();
                        gender.Text = reader["Gender"].ToString();
                        age.Text = reader["Age"].ToString();
                        mobileno.Text = reader["MobileNo"].ToString();
                        paymentname.Text = reader["PaymentName"].ToString();
                        amount.Text = reader["Amount"].ToString();
                        date.Text = reader["Date"].ToString();
                        amountafterpromotion.Text = reader["AmountAfterPromotion"].ToString();
                        promotionpercentage.Text = reader["PromotionPercentage"].ToString();
                        promotioncode.Text = reader["PromotionCode"].ToString();
                        promotionname.Text = reader["PromotionName"].ToString();
                        promotiondetails.Text = reader["PromotionDetails"].ToString();
                    }
                    tabControl1.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("Payment data not found with ID: " + PaymentIDToEdit);
                }

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
        private void Add_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void promotionpercentage_Leave(object sender, EventArgs e)
        {
            float percentage = float.Parse(promotionpercentage.Text);

            if (amount.Text != "")
            {
                int amountvalue = int.Parse(amount.Text);

                var amountupdate = (percentage / 100.00) * amountvalue;

                amountafterpromotion.Text = amountupdate.ToString();
            }
        }
    }
}
