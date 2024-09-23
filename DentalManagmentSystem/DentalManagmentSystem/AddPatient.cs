using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DentalManagmentSystem
{
    public partial class AddPatient : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=None\SQLEXPRESS;Initial Catalog=PatientsData;Integrated Security=True;Encrypt=False");

        public AddPatient()
        {
            InitializeComponent();
        }
        public void displayPatientsData()
        {
            PatientsDataStorage pd = new PatientsDataStorage();
            List<PatientsDataStorage> listData = pd.patientListData();

            PatientsDataGridView.DataSource = listData;
            PatientsDataGridView.ClearSelection();

            PatientsDataGridView.Columns[0].Width = 46;
            PatientsDataGridView.Columns[1].Width = 240;
            PatientsDataGridView.Columns[3].Width = 70;
            PatientsDataGridView.Columns[6].Width = 57;

        }
        public void clear()
        {
            idInput.Text = "";
            nameInput.Text = "";
            ageInput.Text = "";
            genderInput.SelectedIndex = -1;
            dateInput.Text = "";
            phoneInput.Text = "";
            teethInput.Text = "";
            amountInput.Text = "";
            remainInput.Text = "";

            PatientsDataGridView.ClearSelection();

        }
        private void addDataBtn_Click(object sender, EventArgs e)
        {
            if (nameInput.Text == ""
                || ageInput.Text == ""
                || genderInput.Text == ""
                || dateInput.Text == ""
                || phoneInput.Text == ""
                || teethInput.Text == ""
                || amountInput.Text == ""
                || remainInput.Text == "")
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
                        string insertData = "INSERT INTO patientsStore " +
                               "(name, age, gender, date, phone, teeth, amount, remain)" +
                               "VALUES(@name, @age, @gender, @date, @phone, @teeth, @amount, @remain)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@name", nameInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@age", ageInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", genderInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@date", dateInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", phoneInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@teeth", teethInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@amount", amountInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@remain", remainInput.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayPatientsData();

                            MessageBox.Show("Patient Added Successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clear();
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
        private void displayBtn_Click(object sender, EventArgs e)
        {
            displayPatientsData();
        }
        private void PatientsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = PatientsDataGridView.Rows[e.RowIndex];
            idInput.Text = row.Cells[0].Value.ToString();
            nameInput.Text = row.Cells[1].Value.ToString();
            ageInput.Text = row.Cells[2].Value.ToString();
            genderInput.Text = row.Cells[3].Value.ToString();
            dateInput.Text = row.Cells[4].Value.ToString();
            phoneInput.Text = row.Cells[5].Value.ToString();
            teethInput.Text = row.Cells[6].Value.ToString();
            amountInput.Text = row.Cells[7].Value.ToString();
            remainInput.Text = row.Cells[8].Value.ToString();
        }
        private void updateDataBtn_Click(object sender, EventArgs e)
        {
            if (nameInput.Text == ""
                || ageInput.Text == ""
                || genderInput.Text == ""
                || dateInput.Text == ""
                || phoneInput.Text == ""
                || teethInput.Text == ""
                || amountInput.Text == ""
                || remainInput.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update: " +
                    "ID: " + idInput.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string updateData = "UPDATE patientsStore SET name = @name" +
                            ", age = @age, gender = @gender, date = @date, phone = @phone, teeth = @teeth" +
                            ", amount = @amount, remain = @remain " +
                            "WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", idInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@name", nameInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@age", ageInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", genderInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@date", dateInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", phoneInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@teeth", teethInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@amount", amountInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@remain", remainInput.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayPatientsData();

                            MessageBox.Show("Patient Updated Successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clear();
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
        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void deleteDataBtn_Click(object sender, EventArgs e)
        {
            if (idInput.Text == "")
            {
                MessageBox.Show("Please choose your patient to delete"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to delete: " +
                    "ID: " + idInput.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM patientsStore WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", idInput.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayPatientsData();

                            MessageBox.Show("Patient Deleted Successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clear();
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