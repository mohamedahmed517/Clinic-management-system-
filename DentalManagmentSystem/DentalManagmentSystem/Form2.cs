using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalManagmentSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void addNurseBtn_Click(object sender, EventArgs e)
        {
            addPatient3.Visible = false;
            nurseData1.Visible = true;
            dashboard1.Visible = false;
        }
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            addPatient3.Visible = false;
            nurseData1.Visible = false;
            dashboard1.Visible = true;
        }
        private void signoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
                , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void addPatientBtn_Click(object sender, EventArgs e)
        {
            addPatient3.Visible = true;
            nurseData1.Visible = false;
            dashboard1.Visible = false;
        }
    }
}