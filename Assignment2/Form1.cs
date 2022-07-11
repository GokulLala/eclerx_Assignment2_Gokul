using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Sql Connection
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLQuery3"].ConnectionString);

            //Create Sql Command 
            cmd = new SqlCommand("Select cEmployeeNo, vEmployeeName, cSalary, cEmployeeType ", con);

            //Open the connection
            con.Open();
            reader = cmd.ExecuteReader();
            //Reads first row
            reader.Read();
            txtEmpNo.Text = reader["cEmployeeNo"].ToString();
            txtEmpName.Text = reader["vEmployeeName"].ToString();
            txtSalary.Text = reader["cSalary"].ToString();
            gpemptp.Text = reader["cEmployeeType"];
            reader.Close();
            cmd.Dispose();
            //Close the connection
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLQuery3"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_AddNewEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeNo", txtEmpNo.Text);
                    cmd.Parameters.AddWithValue("@EmployeeName", txtEmpName.Text);
                    cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
                    cmd.Parameters.AddWithValue("@EmployeeType", gpemptp.Text);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    cmd.ExecuteNonQuery();


                }
            }
            MessageBox.Show("New Employee Created");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLQuery3"].ConnectionString))
            {
                using (cmd = new SqlCommand("Select vEmployeeName, cSalary, cEmployeeType from SQLQuery3 Where cEmployeeNo=@EmployeeNo", con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeNo", txtEmpNo.Text);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            txtEmpName.Text = reader["vEmployeeName"].ToString();
                            txtSalary.Text = reader["CSalary"].ToString();
                            gpemptp.Text = reader["cEmployeeCode"];

                        }
                        else
                        {
                            MessageBox.Show("No Record");

                        }


                    }
                }
            }

        }
    }
}
