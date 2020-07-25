using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace InventoryUI.controls
{
    public partial class ClientAddControl : UserControl
    {


        public ClientAddControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            List<Utility.ValidationItem> validationList = new List<Utility.ValidationItem>()
                {
                   new Utility.ValidationItem(){ control = txtbxName, lblError =lblNameError,},
                };

            if (!Utility.ValidateControlList(validationList))
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            //@clientID int,@clientName nvarchar(50),@clientAddress nvarchar(50),@clientPhone nvarchar(50),@cilentEmail varchar(50)
            List<Utility.ProcedureParameter> parameters = new List<Utility.ProcedureParameter>()
                {
                    new Utility.ProcedureParameter(){ parameterName = "ClientID", DType = SqlDbType.Int, SourceObject = DBNull.Value},
                    new Utility.ProcedureParameter(){ parameterName = "clientName", DType = SqlDbType.NVarChar, SourceObject = txtbxName},
                    new Utility.ProcedureParameter(){ parameterName = "clientAddress", DType = SqlDbType.NVarChar, SourceObject = txtbxAddress},
                    new Utility.ProcedureParameter(){ parameterName = "clientPhone", DType = SqlDbType.NVarChar, SourceObject = txtbxPhone},
                    new Utility.ProcedureParameter(){ parameterName = "cilentEmail", DType = SqlDbType.NVarChar, SourceObject = txtbxEmail},
                };

            if (Convert.ToBoolean(Utility.InsertProcedure("InsertClient", parameters)))
            {
                MessageBox.Show(null, "Client Added", "Clients", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Utility.clearPanel(pnlInfo);
            }


            /*
            //-----------------------------------------------------------------------------
            //-----------this is the old way, it's useless now , should delete-------------
            //-----------------------------------------------------------------------------
             
            using (SqlConnection con = new SqlConnection(Utility.ConString))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertClient";
                    //@clientID int,@clientName nvarchar(50),@clientAddress nvarchar(50),@clientPhone nvarchar(50),@cilentEmail varchar(50)
                    cmd.Parameters.Add("@ClientID", SqlDbType.Int).Value = DBNull.Value;
                    //selectedItem = (MainClass.ComboboxItem)cmbbxClientType.SelectedItem; for later use
                    cmd.Parameters.Add("@clientName", SqlDbType.NVarChar).Value = txtbxName.Text;
                    cmd.Parameters.Add("@clientAddress", SqlDbType.NVarChar).Value = txtbxAddress.Text;
                    cmd.Parameters.Add("@clientPhone", SqlDbType.NVarChar).Value = txtbxPhone.Text;
                    cmd.Parameters.Add("@cilentEmail", SqlDbType.VarChar).Value = txtbxEmail.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(null, "Client Added", "Clients", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, "InsertClient Procedure\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }
    }
}

