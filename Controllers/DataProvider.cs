using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMayTinh.Controllers
{
    public class DataProvider
    {

        private static DataProvider instance;


        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider(); return DataProvider.instance;
            }
            private set
            {
                instance = value;
            }
        }

        private DataProvider() { }

        private string connectionString = @"Data Source=omitako;Initial Catalog=CuaHangMayTinh;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";



        public DataTable ExecuteQuery(string script, object[] parameter = null)
        {

            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(script, conn);

                if (parameter != null)
                {
                    string[] listParameter = script.Split(' ');

                    int i = 0;

                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);

                conn.Close();

            }

            return data;

        }

        public int ExecuteNonQuery(string script, object[] parameter = null)
        {

            int data = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(script, conn);

                if (parameter != null)
                {
                    string[] listParameter = script.Split(' ');

                    int i = 0;

                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();

                conn.Close();

            }

            return data;

        }

        public object ExecuteScalar(string script, object[] parameter = null)
        {

            object data = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(script, conn);

                if (parameter != null)
                {
                    string[] listParameter = script.Split(' ');

                    int i = 0;

                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();

                conn.Close();

            }

            return data;

        }

        public object ExecuteReader(string script, object[] parameter = null)
        {

            object data;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(script, conn);

                if (parameter != null)
                {
                    string[] listParameter = script.Split(' ');

                    int i = 0;

                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteReader();

                conn.Close();

            }

            return data;

        }


        public void FillDropDownList(string script, ComboBox DropDownName)
        {
            // If you use a DataTable (or any object which implmenets IEnumerable)
            // you can bind the results of your query directly as the 
            // datasource for the ComboBox. 
            DataTable dt = new DataTable();

            // Where possible, use the using block for data access. The 
            // using block handles disposal of resources and connection 
            // cleanup for you:
            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(script, conn))
                {
                    conn.Open();

                    try
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (SqlException e)
                    {
                        // Do some logging or something. 
                        MessageBox.Show("There was an error accessing your data. DETAIL: " + e.ToString());
                    }
                }
            }

            DropDownName.DataSource = dt;
            DropDownName.ValueMember = dt.Columns[0].ColumnName;
            DropDownName.DisplayMember = dt.Columns[1].ColumnName;
        }

    }
}
