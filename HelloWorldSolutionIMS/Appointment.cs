﻿using Guna.UI2.WinForms;
using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Claims;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win32Interop.Enums;

namespace HelloWorldSolutionIMS
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        static int edit = 0;
        static int conn = 0;
        static int check = 0;

        private void ShowAppointments(DataGridView dgv, DataGridViewColumn id, DataGridViewColumn fileno, DataGridViewColumn firstname, DataGridViewColumn familyname, DataGridViewColumn room, DataGridViewColumn slot, DataGridViewColumn date)
        {
            SqlCommand cmd;
            try
            {
                MainClass.con.Open();

                cmd = new SqlCommand("SELECT Id, Fileno, Firstname, Familyname, Room, Slot, Date FROM Appointment", MainClass.con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                id.DataPropertyName = dt.Columns["Id"].ColumnName;
                fileno.DataPropertyName = dt.Columns["Fileno"].ColumnName;
                firstname.DataPropertyName = dt.Columns["Firstname"].ColumnName;
                familyname.DataPropertyName = dt.Columns["Familyname"].ColumnName;
                room.DataPropertyName = dt.Columns["Room"].ColumnName;
                slot.DataPropertyName = dt.Columns["Slot"].ColumnName;
                date.DataPropertyName = dt.Columns["Date"].ColumnName;

                dgv.DataSource = dt;
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void InsertColumnsAndRowsToRoom1(Guna2DataGridView Room1)
        {
           
            // Insert 4 columns without headers
            for (int i = 1; i <= 4; i++)
            {
                Room1.Columns.Add("Column" + i, "");
            }

            // Insert 14 rows
            for (int i = 0; i < 13; i++)
            {
                Room1.Rows.Add();
            }
            Room1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            Room1.GridColor = Color.Black;
            Room1.RowTemplate.DefaultCellStyle.SelectionBackColor = Room1.RowTemplate.DefaultCellStyle.BackColor;
            Room1.RowTemplate.DefaultCellStyle.SelectionForeColor = Room1.RowTemplate.DefaultCellStyle.ForeColor;
            DateTime startTime = DateTime.Today.AddHours(7); // Starting time at 7:00 AM        
            DateTime endTime = DateTime.Today.AddHours(20).AddMinutes(45);
            for (int j = 0; j < 14; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    
                    if(startTime <= endTime)
                    {
                        Room1.Rows[j].Cells[i].Value = startTime.ToString("HH:mm");
                        startTime = startTime.AddMinutes(15);
                    }
                   
                }
            }

            Room1.ClearSelection();
            Room1.CurrentCell = null;
        }
        private void InsertColumnsAndRowsToRoom2(Guna2DataGridView Room2)
        {
            // Insert 4 columns without headers
            for (int i = 1; i <= 4; i++)
            {
                Room2.Columns.Add("Column" + i, "");
            }

            // Insert 14 rows
            for (int i = 0; i < 13; i++)
            {
                Room2.Rows.Add();
            }
            Room2.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            Room2.GridColor = Color.Black;
            Room2.RowTemplate.DefaultCellStyle.SelectionBackColor = Room2.RowTemplate.DefaultCellStyle.BackColor;
            Room2.RowTemplate.DefaultCellStyle.SelectionForeColor = Room2.RowTemplate.DefaultCellStyle.ForeColor;
            DateTime startTime = DateTime.Today.AddHours(7); // Starting time at 7:00 AM        
            DateTime endTime = DateTime.Today.AddHours(20).AddMinutes(45);
            for (int j = 0; j < 14; j++)
            {
                for (int i = 0; i < 4; i++)
                {

                    if (startTime <= endTime)
                    {
                        Room2.Rows[j].Cells[i].Value = startTime.ToString("HH:mm");
                        startTime = startTime.AddMinutes(15);
                    }

                }
            }
            Room2.ClearSelection();
            Room2.CurrentCell = null;
        }
        private void InsertColumnsAndRowsToRoom3(Guna2DataGridView Room3)
        {
            // Insert 4 columns without headers
            for (int i = 1; i <= 4; i++)
            {
                Room3.Columns.Add("Column" + i, "");
            }

            // Insert 14 rows
            for (int i = 0; i < 13; i++)
            {
                Room3.Rows.Add();
            }
            Room3.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            Room3.GridColor = Color.Black;
            Room3.RowTemplate.DefaultCellStyle.SelectionBackColor = Room3.RowTemplate.DefaultCellStyle.BackColor;
            Room3.RowTemplate.DefaultCellStyle.SelectionForeColor = Room3.RowTemplate.DefaultCellStyle.ForeColor;
            DateTime startTime = DateTime.Today.AddHours(7); // Starting time at 7:00 AM        
            DateTime endTime = DateTime.Today.AddHours(20).AddMinutes(45);
            for (int j = 0; j < 14; j++)
            {
                for (int i = 0; i < 4; i++)
                {

                    if (startTime <= endTime)
                    {
                        Room3.Rows[j].Cells[i].Value = startTime.ToString("HH:mm");
                        startTime = startTime.AddMinutes(15);
                    }

                }
            }
            Room3.ClearSelection();
            Room3.CurrentCell = null;
        }
        private void InsertColumnsAndRowsToRoom4(Guna2DataGridView Room4)
        {
            // Insert 4 columns without headers
            for (int i = 1; i <= 4; i++)
            {
                Room4.Columns.Add("Column" + i, "");
            }

            // Insert 14 rows
            for (int i = 0; i < 13; i++)
            {
                Room4.Rows.Add();
            }
            Room4.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            Room4.GridColor = Color.Black;
            Room4.RowTemplate.DefaultCellStyle.SelectionBackColor = Room4.RowTemplate.DefaultCellStyle.BackColor;
            Room4.RowTemplate.DefaultCellStyle.SelectionForeColor = Room4.RowTemplate.DefaultCellStyle.ForeColor;
            DateTime startTime = DateTime.Today.AddHours(7); // Starting time at 7:00 AM        
            DateTime endTime = DateTime.Today.AddHours(20).AddMinutes(45);
            for (int j = 0; j < 14; j++)
            {
                for (int i = 0; i < 4; i++)
                {

                    if (startTime <= endTime)
                    {
                        Room4.Rows[j].Cells[i].Value = startTime.ToString("HH:mm");
                        startTime = startTime.AddMinutes(15);
                    }

                }
            }
            Room4.ClearSelection();
            Room4.CurrentCell = null;
        }
        private (int RowIndex, int ColumnIndex,int RoomNo, string time) GetSelectedCellIndexes(Guna2DataGridView Room)
        {
            int rowIndex = -1;
            int columnIndex = -1;
            int roomno = 0;
            string timeselected = "none";
            if (Room.CurrentCell != null)
            {
                rowIndex = Room.CurrentCell.RowIndex;
                columnIndex = Room.CurrentCell.ColumnIndex;
            }

            if (rowIndex != -1 && columnIndex != -1)
            {
                timeselected = Room.Rows[rowIndex].Cells[columnIndex].Value.ToString();

            }


            if (Room.Name == "Room1")
            {
                roomno = 1;
            }
            else if(Room.Name == "Room2")
            {
                roomno = 2;
            }
            else if (Room.Name == "Room3")
            {
                roomno = 3;
            }
            else
            {
                roomno = 4;
            }
            return (rowIndex, columnIndex,roomno,timeselected);
        }
        private void ChangeCellColor(Guna2DataGridView Room, int rowIndex, int columnIndex)
        {
            if (rowIndex >= 0 && rowIndex < Room.RowCount && columnIndex >= 0 && columnIndex < Room.ColumnCount)
            {
                Room.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.Red;
            }
        }
        private void Appointment_Load(object sender, EventArgs e)
        {
            MainClass.HideAllTabsOnTabControl(tabControl1);
            InsertColumnsAndRowsToRoom1(Room1);
            InsertColumnsAndRowsToRoom2(Room2);
            InsertColumnsAndRowsToRoom3(Room3);
            InsertColumnsAndRowsToRoom4(Room4);
            ShowAppointments(guna2DataGridView1, iddgv, filenodgv, firstnamedgv, familynamedgv, roomdgv, slotdgv, datedgv);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            int totalValidSelections = 0;

            var selectedCellIndexesRoom1 = GetSelectedCellIndexes(Room1);
            var selectedCellIndexesRoom2 = GetSelectedCellIndexes(Room2);
            var selectedCellIndexesRoom3 = GetSelectedCellIndexes(Room3);
            var selectedCellIndexesRoom4 = GetSelectedCellIndexes(Room4);

            if (selectedCellIndexesRoom1.RowIndex != -1) totalValidSelections++;
            if (selectedCellIndexesRoom2.RowIndex != -1) totalValidSelections++;
            if (selectedCellIndexesRoom3.RowIndex != -1) totalValidSelections++;
            if (selectedCellIndexesRoom4.RowIndex != -1) totalValidSelections++;

            if (totalValidSelections > 1)
            {
                MessageBox.Show("More than one table has a selected cell.");
            }
            else
            {
                if (edit == 0)
                {
                    if (firstname.Text != "" || familyname.Text != "" || mobileno.Text != "")
                    {
                        if(selectedCellIndexesRoom1.RowIndex != -1)
                        {
                            try
                            {
                                MainClass.con.Open();
                                SqlCommand cmd = new SqlCommand("INSERT INTO Appointment (Fileno, Firstname, Familyname, Mobileno, Date, Room, RowIndex, ColumnIndex, Slot) " +
                                    "VALUES (@Fileno, @Firstname, @Familyname, @Mobileno, @Date, @Room, @RowIndex, @ColumnIndex, @Slot)", MainClass.con);

                                cmd.Parameters.AddWithValue("@Fileno", fileno.Text); // Assuming 'fileno' is a control related to 'Fileno' in the database
                                cmd.Parameters.AddWithValue("@Firstname", firstname.Text);
                                cmd.Parameters.AddWithValue("@Familyname", familyname.Text);
                                cmd.Parameters.AddWithValue("@Mobileno", mobileno.Text);
                                cmd.Parameters.AddWithValue("@Date", date.SelectionStart); // Assuming it's the current date
                                cmd.Parameters.AddWithValue("@Room", selectedCellIndexesRoom1.RoomNo); // Assuming 'room' is a control related to 'Room' in the database
                                cmd.Parameters.AddWithValue("@RowIndex", selectedCellIndexesRoom1.RowIndex); // Assuming 'rowIndex' is a control related to 'RowIndex' in the database
                                cmd.Parameters.AddWithValue("@ColumnIndex", selectedCellIndexesRoom1.ColumnIndex); // Assuming 'columnIndex' is a control related to 'ColumnIndex' in the database
                                cmd.Parameters.AddWithValue("@Slot", selectedCellIndexesRoom1.time); // Assuming 'slot' is a control related to 'Slot' in the database

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Appointment added successfully");
                                MainClass.con.Close();

                                // Clear the text fields after successful insertion
                                fileno.Text = "";
                                firstname.Text = "";
                                familyname.Text = "";
                                mobileno.Text = "";
                                date.SetDate(DateTime.Today);

                                // Switch to the first tab of your tab control
                                tabControl1.SelectedIndex = 0;

                                // Refresh the DataGridView (if it displays the Appointment data)
                                ShowAppointments(guna2DataGridView1, iddgv, filenodgv, firstnamedgv, familynamedgv, roomdgv, slotdgv, datedgv);
                            }
                            catch (Exception ex)
                            {
                                MainClass.con.Close();
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else if(selectedCellIndexesRoom2.RowIndex != -1)
                        {
                            try
                            {
                                MainClass.con.Open();
                                SqlCommand cmd = new SqlCommand("INSERT INTO Appointment (Fileno, Firstname, Familyname, Mobileno, Date, Room, RowIndex, ColumnIndex, Slot) " +
                                    "VALUES (@Fileno, @Firstname, @Familyname, @Mobileno, @Date, @Room, @RowIndex, @ColumnIndex, @Slot)", MainClass.con);

                                cmd.Parameters.AddWithValue("@Fileno", fileno.Text); // Assuming 'fileno' is a control related to 'Fileno' in the database
                                cmd.Parameters.AddWithValue("@Firstname", firstname.Text);
                                cmd.Parameters.AddWithValue("@Familyname", familyname.Text);
                                cmd.Parameters.AddWithValue("@Mobileno", mobileno.Text);
                                cmd.Parameters.AddWithValue("@Date", date.SelectionStart); // Assuming it's the current date
                                cmd.Parameters.AddWithValue("@Room", selectedCellIndexesRoom2.RoomNo); // Assuming 'room' is a control related to 'Room' in the database
                                cmd.Parameters.AddWithValue("@RowIndex", selectedCellIndexesRoom2.RowIndex); // Assuming 'rowIndex' is a control related to 'RowIndex' in the database
                                cmd.Parameters.AddWithValue("@ColumnIndex", selectedCellIndexesRoom2.ColumnIndex); // Assuming 'columnIndex' is a control related to 'ColumnIndex' in the database
                                cmd.Parameters.AddWithValue("@Slot", selectedCellIndexesRoom2.time); // Assuming 'slot' is a control related to 'Slot' in the database

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Appointment added successfully");
                                MainClass.con.Close();

                                // Clear the text fields after successful insertion
                                fileno.Text = "";
                                firstname.Text = "";
                                familyname.Text = "";
                                mobileno.Text = "";
                                date.SetDate(DateTime.Today);

                                // Switch to the first tab of your tab control
                                tabControl1.SelectedIndex = 0;

                                // Refresh the DataGridView (if it displays the Appointment data)
                                ShowAppointments(guna2DataGridView1, iddgv, filenodgv, firstnamedgv, familynamedgv, roomdgv, slotdgv, datedgv);
                            }
                            catch (Exception ex)
                            {
                                MainClass.con.Close();
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else if (selectedCellIndexesRoom3.RowIndex != -1)
                        {
                            try
                            {
                                MainClass.con.Open();
                                SqlCommand cmd = new SqlCommand("INSERT INTO Appointment (Fileno, Firstname, Familyname, Mobileno, Date, Room, RowIndex, ColumnIndex, Slot) " +
                                    "VALUES (@Fileno, @Firstname, @Familyname, @Mobileno, @Date, @Room, @RowIndex, @ColumnIndex, @Slot)", MainClass.con);

                                cmd.Parameters.AddWithValue("@Fileno", fileno.Text); // Assuming 'fileno' is a control related to 'Fileno' in the database
                                cmd.Parameters.AddWithValue("@Firstname", firstname.Text);
                                cmd.Parameters.AddWithValue("@Familyname", familyname.Text);
                                cmd.Parameters.AddWithValue("@Mobileno", mobileno.Text);
                                cmd.Parameters.AddWithValue("@Date", date.SelectionStart); // Assuming it's the current date
                                cmd.Parameters.AddWithValue("@Room", selectedCellIndexesRoom3.RoomNo); // Assuming 'room' is a control related to 'Room' in the database
                                cmd.Parameters.AddWithValue("@RowIndex", selectedCellIndexesRoom3.RowIndex); // Assuming 'rowIndex' is a control related to 'RowIndex' in the database
                                cmd.Parameters.AddWithValue("@ColumnIndex", selectedCellIndexesRoom3.ColumnIndex); // Assuming 'columnIndex' is a control related to 'ColumnIndex' in the database
                                cmd.Parameters.AddWithValue("@Slot", selectedCellIndexesRoom3.time); // Assuming 'slot' is a control related to 'Slot' in the database

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Appointment added successfully");
                                MainClass.con.Close();

                                // Clear the text fields after successful insertion
                                fileno.Text = "";
                                firstname.Text = "";
                                familyname.Text = "";
                                mobileno.Text = "";
                                date.SetDate(DateTime.Today);

                                // Switch to the first tab of your tab control
                                tabControl1.SelectedIndex = 0;

                                // Refresh the DataGridView (if it displays the Appointment data)
                                ShowAppointments(guna2DataGridView1, iddgv, filenodgv, firstnamedgv, familynamedgv, roomdgv, slotdgv, datedgv);
                            }
                            catch (Exception ex)
                            {
                                MainClass.con.Close();
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            try
                            {
                                MainClass.con.Open();
                                SqlCommand cmd = new SqlCommand("INSERT INTO Appointment (Fileno, Firstname, Familyname, Mobileno, Date, Room, RowIndex, ColumnIndex, Slot) " +
                                    "VALUES (@Fileno, @Firstname, @Familyname, @Mobileno, @Date, @Room, @RowIndex, @ColumnIndex, @Slot)", MainClass.con);

                                cmd.Parameters.AddWithValue("@Fileno", fileno.Text); // Assuming 'fileno' is a control related to 'Fileno' in the database
                                cmd.Parameters.AddWithValue("@Firstname", firstname.Text);
                                cmd.Parameters.AddWithValue("@Familyname", familyname.Text);
                                cmd.Parameters.AddWithValue("@Mobileno", mobileno.Text);
                                cmd.Parameters.AddWithValue("@Date", date.SelectionStart); // Assuming it's the current date
                                cmd.Parameters.AddWithValue("@Room", selectedCellIndexesRoom4.RoomNo); // Assuming 'room' is a control related to 'Room' in the database
                                cmd.Parameters.AddWithValue("@RowIndex", selectedCellIndexesRoom4.RowIndex); // Assuming 'rowIndex' is a control related to 'RowIndex' in the database
                                cmd.Parameters.AddWithValue("@ColumnIndex", selectedCellIndexesRoom4.ColumnIndex); // Assuming 'columnIndex' is a control related to 'ColumnIndex' in the database
                                cmd.Parameters.AddWithValue("@Slot", selectedCellIndexesRoom4.time); // Assuming 'slot' is a control related to 'Slot' in the database

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Appointment added successfully");
                                MainClass.con.Close();

                                // Clear the text fields after successful insertion
                                fileno.Text = "";
                                firstname.Text = "";
                                familyname.Text = "";
                                mobileno.Text = "";
                                date.SetDate(DateTime.Today);

                                // Switch to the first tab of your tab control
                                tabControl1.SelectedIndex = 0;

                                // Refresh the DataGridView (if it displays the Appointment data)
                                ShowAppointments(guna2DataGridView1, iddgv, filenodgv, firstnamedgv, familynamedgv, roomdgv, slotdgv, datedgv);
                            }
                            catch (Exception ex)
                            {
                                MainClass.con.Close();
                                MessageBox.Show(ex.Message);
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Please fill First name, Family name and Mobile No.");
                    }
                }
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Room1.ClearSelection();
            Room1.CurrentCell = null;
            Room2.ClearSelection();
            Room2.CurrentCell = null;
            Room3.ClearSelection();
            Room3.CurrentCell = null;
            Room4.ClearSelection();
            Room4.CurrentCell = null;
        }
        private void mobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the keypress if it's not a number or a control character
            }
        }
        private void fileno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the keypress if it's not a number or a control character
            }
        }
        private void fileno_TextChanged(object sender, EventArgs e)
        {
            if (fileno.Text != "")
            {
                int value = int.Parse(fileno.Text);

                try
                {
                    if (MainClass.con.State != ConnectionState.Open)
                    {
                        MainClass.con.Open();
                        conn = 1;
                    }

                    SqlCommand cmd2 = new SqlCommand("SELECT  FIRSTNAME, FAMILYNAME, MOBILENO, GENDER, AGE FROM CUSTOMER " +
                        "WHERE FILENO = @fileno", MainClass.con);

                    cmd2.Parameters.AddWithValue("@fileno", value);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    if (reader2.Read())
                    {
                        // Assign values from the reader to the respective text boxes
                        firstname.Text = reader2["FIRSTNAME"].ToString();
                        familyname.Text = reader2["FAMILYNAME"].ToString();
                        mobileno.Text = reader2["MOBILENO"].ToString();
                        date.SetDate(DateTime.Today);
                    }
                    else
                    {
                        MessageBox.Show("No customer with this file no exist!");
                    }
                    if (conn == 1)
                    {
                        MainClass.con.Close();
                        conn = 0;
                    }
                }
                catch (Exception ex)
                {
                    MainClass.con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                firstname.Text = "";
                familyname.Text = "";
                mobileno.Text = "";
                date.SetDate(DateTime.Today);
            }
            check = 0;
        }
        private void slotupdate()
        {
            SqlCommand cmd;

            try
            {
                if (MainClass.con.State != ConnectionState.Open)
                {
                    MainClass.con.Open();
                    conn = 1;
                }

                DateTime selectedDate = date.SelectionStart;

                cmd = new SqlCommand("SELECT Room, RowIndex, ColumnIndex FROM Appointment WHERE CONVERT(date, Date) = @SelectedDate", MainClass.con);
                cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);

                SqlDataReader reader = cmd.ExecuteReader();
                
                    while (reader.Read())
                    {
                       
                            int roomNo = int.Parse(reader["Room"].ToString());
                            int row = int.Parse(reader["RowIndex"].ToString());
                            int column = int.Parse(reader["ColumnIndex"].ToString());

                            if (roomNo == 1)
                            {
                                ChangeCellColor(Room1, row, column);
                            }
                            else if (roomNo == 2)
                            {
                                ChangeCellColor(Room2, row, column);
                            }
                            else if (roomNo == 3)
                            {
                                ChangeCellColor(Room3, row, column);
                            }
                            else
                            {
                                ChangeCellColor(Room4, row, column);
                            }
                        
                    }
                

                if (conn == 1)
                {
                    MainClass.con.Close();
                    conn = 0;
                }
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void date_DateChanged(object sender, DateRangeEventArgs e)
        {
            slotupdate();
        }
        private void New_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            slotupdate();
        }
    }
}

