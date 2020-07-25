using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI.controls
{
    public partial class setupControl : UserControl
    {
        public setupControl()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            // do stuff before Load-event is raised
            base.OnLoad(e);
            // do stuff after Load-event is raised
            Utility.CreateControl(dependenciesControl, tabDependencies);
        }
       
        DependenciesControl dependenciesControl = null;
        ProdcutsAddControl prodcutsAddControl = null;
        ClientAddControl clientAddControl = null;
        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabDependencies)
            {
                if (Utility.currentTabControl.GetType() != typeof(DependenciesControl))
                {
                    Utility.DistroyControlOnTab();
                    Utility.CreateControl(dependenciesControl, tabDependencies);
                }
            }
            else if (e.TabPage == tabProducts)
            {
                if (Utility.currentTabControl.GetType() != typeof(ProdcutsAddControl))
                {
                    Utility.DistroyControlOnTab();
                    Utility.CreateControl(prodcutsAddControl, tabProducts);
                }
            }
            else if (e.TabPage == tabClient)
            {
                if (Utility.currentTabControl.GetType() != typeof(ClientAddControl))
                {
                    Utility.DistroyControlOnTab();
                    Utility.CreateControl(clientAddControl, tabClient);
                }
            }
               

        }
    }
}
