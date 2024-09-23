using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagmentSystem
{
    class NursesDataStorage
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Age { set; get; }
        public string Gender { set; get; }
        public string Phone { set; get; }
        public int Salary { set; get; }


        SqlConnection connect = new SqlConnection(@"Data Source=None\SQLEXPRESS;Initial Catalog=PatientsData;Integrated Security=True;Encrypt=False");

        public List<NursesDataStorage> nurseListData()
        {
            List<NursesDataStorage> listData = new List<NursesDataStorage>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM NursesStore";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            NursesDataStorage nd = new NursesDataStorage();

                            nd.Id = (int)reader["id"];
                            nd.Name = reader["name"].ToString();
                            nd.Age = reader["age"].ToString();
                            nd.Gender = reader["gender"].ToString();
                            nd.Phone = reader["phone"].ToString();
                            nd.Salary = (int)reader["salary"];

                            listData.Add(nd);
                        }
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

            return listData;

        }

    }
}