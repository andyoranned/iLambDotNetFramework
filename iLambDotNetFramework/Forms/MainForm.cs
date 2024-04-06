using iLambDotNetFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLambDotNetFramework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When AddSheep button is clicked, display AddSheepForm in panelNavDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void toolStripButtonAddSheep_Click(object sender, EventArgs e)
        {
            //create a new instance of AddSheep form
            AddLambForm addSheep = new AddLambForm() { TopLevel=false, TopMost=true, Parent = panelNavDisplay };
            //Remove border
            addSheep.FormBorderStyle = FormBorderStyle.None;
            //Make AddSheep a child control of panel
            panelNavDisplay.Controls.Add(addSheep);
            addSheep.Show();
            //Fill the panel
            addSheep.Dock= DockStyle.Fill;
        }

        private void panelNavDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }//end MainForm class
}
