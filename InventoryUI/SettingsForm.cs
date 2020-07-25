using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        string StringOnFile;
        protected override void OnLoad(EventArgs e)
        {
            // do stuff before Load-event is raised
            base.OnLoad(e);
            using (FileStream fs = new FileStream(Utility.SettingsPath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
            {
                // read string from file
                StreamReader file = new StreamReader(fs);
                StringOnFile = file.ReadLine();
            }
            if (String.IsNullOrWhiteSpace(StringOnFile))
            {
                txtbxServer.Text = Utility.ConString;
            }
            else
            {
                txtbxServer.Text = StringOnFile; 
            }
        }
        private void btnExitHeader_Click(object sender, EventArgs e)
        {
            if (txtbxServer.Text != StringOnFile)
            {
                DialogResult dr = MessageBox.Show(null, "Exit without saving?", "Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();
        }

        private void btnSaveConnection_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream(Utility.SettingsPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                {
                    // writing data in string
                    StreamWriter file = new StreamWriter(fs);
                    string dataString = txtbxServer.Text;
                    byte[] info = new UTF8Encoding(true).GetBytes(dataString);
                    fs.Write(info, 0, info.Length);
                    Utility.ConString = txtbxServer.Text;
                    MessageBox.Show(null, "Connection Saved", "Connection Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Saving Failed\n\n" + ex.Message, "Connection Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxServer.Text))
            {
                lblStringError.Visible = true;
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            else
            {
                lblStringError.Visible = false;
                try
                {
                    using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(txtbxServer.Text))
                    {

                        con.Open();
                        MessageBox.Show(null, "Connection Successful", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(null, "Bad Connection String Arguments\n\n" + ex.Message, "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, "Connection Failed\n\n" + ex.Message, "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }


    }
}
