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

namespace DentalManagmentSystem
{
    public partial class NurseData : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=None\SQLEXPRESS;Initial Catalog=PatientsData;Integrated Security=True;Encrypt=False");

        public NurseData()
        {
            InitializeComponent();
        }
        public void displayNursesData()
        {
            NursesDataStorage nd = new NursesDataStorage();
            List<NursesDataStorage> listData = nd.nurseListData();

            NursesDataGridView.DataSource = listData;
            NursesDataGridView.ClearSelection();

            NursesDataGridView.Columns[0].Width = 50;
            NursesDataGridView.Columns[1].Width = 240;
            NursesDataGridView.Columns[2].Width = 55;
            NursesDataGridView.Columns[3].Width = 100;
            NursesDataGridView.Columns[4].Width = 125;

        }
        public void clear2()
        {
            idInput2.Text = "";
            nameInput2.Text = "";
            ageInput2.Text = "";
            genderInput2.SelectedIndex = -1;
            phoneInput2.Text = "";
            salaryInput2.Text = "";

            NursesDataGridView.ClearSelection();
        }
        private void addBtn2_Click(object sender, EventArgs e)
        {
            if (nameInput2.Text == ""
                || ageInput2.Text == ""
                || genderInput2.Text == ""
                || phoneInput2.Text == ""
                || salaryInput2.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string insertData = "INSERT INTO NursesStore " +
                               "(name, age, gender, phone, salary)" +
                               "VALUES(@name, @age, @gender, @phone, @salary)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@name", nameInput2.Text.Trim());
                            cmd.Parameters.AddWithValue("@age", ageInput2.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", genderInput2.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", phoneInput2.Text.Trim());
                            cmd.Parameters.AddWithValue("@salary", salaryInput2.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayNursesData();

                            MessageBox.Show("Nurse Added Successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clear2();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
        private void displayBtn2_Click(object sender, EventArgs e)
        {
            displayNursesData();
        }
        private void clearBtn2_Click(object sender, EventArgs e)
        {
            clear2();
        }
        private void updateBtn2_Click(object sender, EventArgs e)
        {
            if (nameInput2.Text == ""
                || ageInput2.Text == ""
                || genderInput2.Text == ""
                || phoneInput2.Text == ""
                || salaryInput2.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update: " +
                    "ID: " + idInput2.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string updateData = "UPDATE NursesStore SET name = @name" +
                            ", age = @age, gender = @gender, phone = @phone, salary = @salary" +
                            " WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", idInput2.Text.Trim());
                            cmd.Parameters.AddWithValue("@name", nameInput2.Text.Trim());
                            cmd.Parameters.AddWithValue("@age", ageInput2.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", genderInput2.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", phoneInput2.Text.Trim());
                            cmd.Parameters.AddWithValue("@salary", salaryInput2.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayNursesData();

                            MessageBox.Show("Nurse Updated Successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clear2();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void NursesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = NursesDataGridView.Rows[e.RowIndex];
            idInput2.Text = row.Cells[0].Value.ToString();
            nameInput2.Text = row.Cells[1].Value.ToString();
            ageInput2.Text = row.Cells[2].Value.ToString();
            genderInput2.Text = row.Cells[3].Value.ToString();
            phoneInput2.Text = row.Cells[4].Value.ToString();
            salaryInput2.Text = row.Cells[5].Value.ToString();
        }
        private void deleteBtn2_Click(object sender, EventArgs e)
        {
            if (idInput2.Text == "")
            {
                MessageBox.Show("Please choose the nurse to delete"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to delete: " +
                    "ID: " + idInput2.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM NursesStore WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", idInput2.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayNursesData();

                            MessageBox.Show("Nurse Deleted Successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clear2();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}