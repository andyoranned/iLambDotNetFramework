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
    public partial class AddLambForm : Form
    {
        public AddLambForm()
        {
            InitializeComponent();
            DisplayFormForm();
        }

        /// <summary>
        /// Loads a new InfoFormForm in splitContainerNav.Panel1 (top panel)
        /// </summary>
        public void DisplayFormForm()
        {
            //create a new instance of InfoFormForm
            InfoFormForm sheepInfo = new InfoFormForm() { TopLevel = false, TopMost = true, Parent = splitContainerNav.Panel1 };
            //Remove border
            sheepInfo.FormBorderStyle = FormBorderStyle.None;
            //Make sheepInfo a child control of panel
            splitContainerNav.Panel1.Controls.Add(sheepInfo);
            sheepInfo.Show();
            //Fill the panel
            sheepInfo.Dock = DockStyle.Fill;

        }
    }
}
