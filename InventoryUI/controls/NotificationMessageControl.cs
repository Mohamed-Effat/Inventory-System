using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI
{
    public partial class NotificationMessageControl : UserControl
    {
        public int _notificationID;
        public NotificationMessageControl(string message, int notificationID)
        {
            InitializeComponent();
            btnMessage.Text = message;
            //rtxtbxMessage.Text = message;
            _notificationID = notificationID;
        }


        private void btnMessage_Click(object sender, EventArgs e)
        {

            if (this.Parent.Controls.Count == 1)
            {
                this.Parent.Visible = false;
            }
            List<Utility.ProcedureParameter> parameters = new List<Utility.ProcedureParameter>()
                {
                    new Utility.ProcedureParameter(){ parameterName = "notificationID", DType = SqlDbType.Int, SourceObject =_notificationID},
                };
            Utility.InsertProcedure("deleteNotificationMessage", parameters);

            ((adminForm)this.ParentForm).fillNotificationList();
            this.Parent.Controls.Remove(this);
            this.Dispose();


        }
    }
}
