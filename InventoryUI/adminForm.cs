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
using System.IO;
using InventoryUI.controls;
namespace InventoryUI
{
    public partial class adminForm : Form
    {
        public class notifications
        {
            public int notificationID { get; set; }
            public string notificationMessage { get; set; }


        }

        public adminForm()
        {
            InitializeComponent();
            dt.Columns.Add("notificationID", typeof(int));
            dt.Columns.Add("notificationMessage", typeof(string));
            fillNotificationList();
        }
        public List<notifications> dataList = new List<notifications>();
        protected override void OnLoad(EventArgs e)
        {

            // do stuff before Load-event is raised
            base.OnLoad(e);
            // do stuff after Load-event is raised
            Utility.CreateControl(dashboardControl, pnlControl, "dashboardControl");
            Utility.currentButton = btnDashboard;
            //timerNotification.Start();



        }

        public void fillNotificationList()
        {
            dataList.Clear();
            dt = (DataTable)Utility.FillDataTable(dt, "notificationProduct");
            foreach (DataRow data in dt.Rows)
            {
                dataList.Add(new notifications
                {
                    notificationID = data.Field<int>("notificationID"),
                    notificationMessage = data.Field<string>("notificationMessage")
                });
            }
            if (dataList.Count > 99)
                lblNotification.Text = "99+";
            else
                lblNotification.Text = (dataList.Count).ToString();
            lblNotification.Refresh();
        }
        DashboardControl dashboardControl = null;
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (Utility.currentMainControl.GetType() != typeof(DashboardControl))
            {
                Utility.DistroyControlOnPanel();
                Utility.CreateControl(dashboardControl, pnlControl);
                Utility.currentButton = btnDashboard;
            }
        }
        TransactionAddControl transactionAddControl = null;
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if (Utility.currentMainControl.GetType() != typeof(TransactionAddControl))
            {
                Utility.DistroyControlOnPanel();
                Utility.CreateControl(transactionAddControl, pnlControl);
                Utility.currentButton = btnTransaction;
            }
        }
        StockControl stockControl = null;
        private void btnStocks_Click(object sender, EventArgs e)
        {
            if (Utility.currentMainControl.GetType() != typeof(StockControl))
            {
                Utility.DistroyControlOnPanel();
                Utility.CreateControl(stockControl, pnlControl);
                Utility.currentButton = btnStocks;
            }
        }
        setupControl setupControl = null;
        private void btnSetup_Click(object sender, EventArgs e)
        {
            if (Utility.currentMainControl.GetType() != typeof(setupControl))
            {
                Utility.DistroyControlOnPanel();
                Utility.CreateControl(setupControl, pnlControl);
                Utility.currentButton = btnSetup;
            }
        }


        private void pnlDropdown_Click(object sender, EventArgs e)
        {
            if (pnlOptions.Visible == true)
            {
                pnlOptions.Visible = false;
                pnlOptions.Dock = DockStyle.None;
                pnlOptions.Location = new Point(0, 0);

            }
            else
            {
                pnlOptions.Visible = true;
                pnlOptions.Dock = DockStyle.Fill;
                pnlOptions.Location = new Point(0, 46);
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SettingsForm settingsForm = new SettingsForm();
        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!pnlNotifications.Visible)
            {
                for (int i = pnlNotifications.Controls.Count - 1; i >= 0; i--)
                {
                    pnlNotifications.Controls[i].Dispose();
                }
                pnlNotifications.Visible = true;
                foreach (notifications item in dataList)
                {
                    NotificationMessageControl msg = new NotificationMessageControl(item.notificationMessage, item.notificationID);
                    pnlNotifications.Controls.Add(msg);
                    msg.Dock = DockStyle.Bottom;
                }

            }
            else
            {
                pnlNotifications.Visible = false;
            }
        }
        private void pnlControl_Paint(object sender, PaintEventArgs e)
        {

        }
        DataTable dt = new DataTable();


        private void timerNotification_Tick(object sender, EventArgs e)
        {
            fillNotificationList();
        }
    }
}
