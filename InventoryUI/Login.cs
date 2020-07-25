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

namespace InventoryUI
{ 
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(connection.ConStr);
         //public int permition=0,empID;
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "checkpass";
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value =txtusername.Text;
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 50).Value =txtpassword.Text;
                SqlDataReader reader1 = cmd.ExecuteReader();

                while (reader1.Read())
                {

                    connection.permition = (int)reader1[0];
                    connection.empID = (int)reader1[1];
                } 
                   

                    reader1.Close();
                    con.Close();
                    if (connection.permition == 0)
                    {
                        MessageBox.Show("these account doesnt exist");
                    }
                    else if (connection.permition == 2)
                    {
                        adminForm f = new adminForm();
                        f.Show();
                        this.Hide();
                    }
                    else if (connection.permition == 1)
                    {
                        adminForm f = new adminForm();
                        f.Show();
                        this.Hide();
                    }
                   
                    
                }
           
         
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
                
            }
            
        }
    }
}
