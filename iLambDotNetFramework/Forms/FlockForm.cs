using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLambDotNetFramework.Forms
{
    public partial class FlockForm : Form
    {
        SheepList lambList;
        
        //constructor----------------------------------------------------
        public FlockForm(SheepList sheepList)
        {
            this.lambList = sheepList;
            InitializeComponent();
        }

        private void FlockForm_Load(object sender, EventArgs e)
        {
            if (lambList != null)
            {
                loadFlockUserControls();
            }
            
        }

        //refresh flock display
        public void refreshFlockDisplay()
        {
            flowLayoutPanelFlock.Controls.Clear();
            if (lambList.getCount() > 0) { loadFlockUserControls(); }
        }

        //load sheep user control
        private void loadFlockUserControls()
        {
            Dictionary<int, Sheep> sheepDict = lambList.getSheepDictionary();
            foreach (var kvp in sheepDict)
            {
                Sheep sheep = kvp.Value;
                LambUserControl lambControl = new LambUserControl(sheep, this);
                flowLayoutPanelFlock.Controls.Add(lambControl);
            }
        }
    }//end partial class
}
