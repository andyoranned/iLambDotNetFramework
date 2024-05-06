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
        //Properties & Fields------------------------------------------------------
        SheepList lambList;
        FlockForm flockForm;
        AddLambForm addSheep;
        DashboardForm dashboardForm;
        SearchForm searchForm;

        public MainForm()
        {
            InitializeComponent();
            this.lambList = new SheepList();
            initDashboardForm();
        }

        /// <summary>
        /// When AddSheep button is clicked, display AddSheepForm in panelNavDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void toolStripButtonAddSheep_Click(object sender, EventArgs e)
        {
            if (addSheep != null)
            {
               addSheep.Dispose();
            }
            
            //create a new instance of AddSheep form
            addSheep = new AddLambForm() { TopLevel=false, TopMost=true, Parent = panelNavDisplay };
            //Remove border
            addSheep.FormBorderStyle = FormBorderStyle.None;
            //Make AddSheep a child control of panel
            panelNavDisplay.Controls.Add(addSheep);
            addSheep.Show();
            addSheep.BringToFront();
            //Fill the panel
            addSheep.Dock= DockStyle.Fill;
        }

        //open flock form in navigation display panel
        private void toolStripButtonFlock_Click(object sender, EventArgs e)
        {
            if (flockForm != null)
            {
                flockForm.Dispose();
            }

            flockForm = new FlockForm(lambList) { TopLevel=false, TopMost = true, Parent = panelNavDisplay };

            flockForm.FormBorderStyle = FormBorderStyle.None;
            panelNavDisplay.Controls.Add(flockForm);
            flockForm.Show();
            flockForm.Dock= DockStyle.Fill;
            flockForm.BringToFront();
            
        }
        //open dashboard form in navigation display panel
        private void toolStripButtonDashboard_Click(object sender, EventArgs e)
        {
            initDashboardForm();

        }

        //initialize dashboard form
        private void initDashboardForm()
        {
            if (dashboardForm != null)
            {
                dashboardForm.Dispose();
            }

            dashboardForm = new DashboardForm() { TopLevel = false, TopMost = true, Parent = panelNavDisplay };
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            panelNavDisplay.Controls.Add(dashboardForm);
            dashboardForm.Show();
            dashboardForm.Dock = DockStyle.Fill;
            dashboardForm.BringToFront();
        }

        //open search form in navigation display panel
        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            if (searchForm != null)
            {
                searchForm.Dispose(); 
            }

            searchForm = new SearchForm() { TopLevel = false, TopMost = true, Parent= panelNavDisplay };
            searchForm.FormBorderStyle= FormBorderStyle.None;
            panelNavDisplay.Controls.Add(searchForm);
            searchForm.Show();
            searchForm.Dock = DockStyle.Fill;
            searchForm.BringToFront();

        }
    }//end MainForm class
}
