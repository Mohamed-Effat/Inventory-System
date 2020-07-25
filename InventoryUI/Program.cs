using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GetServerName();
            Application.Run(new adminForm ());
        }
        static void GetServerName()
        {
            using (System.IO.FileStream fs = new System.IO.FileStream(Utility.SettingsPath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read, System.IO.FileShare.None))
            {
                // read data from file
                try
                {
                    System.IO.StreamReader file = new System.IO.StreamReader(fs);
                    if (new System.IO.FileInfo(Utility.SettingsPath).Length == 0)
                    {
                        MessageBox.Show(null, "You must specify the Connection String", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fs.Close();
                        Application.Run(new SettingsForm());
                    }
                    else
                        Utility.ConString = file.ReadLine();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, "File Read Error\n" + ex.Message, "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
