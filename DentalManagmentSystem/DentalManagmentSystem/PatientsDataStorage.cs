using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DentalManagmentSystem
{
    class PatientsDataStorage
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Age { set; get; }
        public string Gender { set; get; }
        public string Date {  set; get; }
        public string Phone { set; get; }
        public string Teeth { set; get; }
        public string Amount { set; get; }
        public string Remain { set; get; }


        SqlConnection connect = new SqlConnection(@"Data Source=None\SQLEXPRESS;Initial Catalog=PatientsData;Integrated Security=True;Encrypt=False");

        public List<PatientsDataStorage> patientListData()
        {
            List<PatientsDataStorage> listData = new List<PatientsDataStorage>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM patientsStore";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) 
                        {
                            PatientsDataStorage pd = new PatientsDataStorage();

                            pd.Id = (int)reader["id"];
                            pd.Name = reader["name"].ToString();
                            pd.Age = reader["age"].ToString();
                            pd.Gender = reader["gender"].ToString();
                            pd.Date = reader["date"].ToString();
                            pd.Phone = reader["phone"].ToString();
                            pd.Teeth = reader["teeth"].ToString();
                            pd.Amount = reader["amount"].ToString();
                            pd.Remain = reader["remain"].ToString();

                            listData.Add(pd);

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex
                    ,"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;

        }
   
    }
}