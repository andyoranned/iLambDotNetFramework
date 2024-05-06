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
        InfoFormForm sheepInfo;
        SheepService sheepService;
        SheepList lambList;
        

        public AddLambForm()
        {
            InitializeComponent();
            DisplayFormForm();
            this.sheepService = new SheepService();
            this.lambList = new SheepList();
           
        }

        /// <summary>
        /// Loads a new InfoFormForm in splitContainerNav.Panel1 (top panel)
        /// </summary>
        public void DisplayFormForm()
        {
            if (sheepInfo != null) { sheepInfo.Dispose(); }
            //create a new instance of InfoFormForm
            this.sheepInfo = new InfoFormForm() { TopLevel = false, TopMost = true, Parent = splitContainerNav.Panel1 };
            //Remove border
            sheepInfo.FormBorderStyle = FormBorderStyle.None;
            //Make sheepInfo a child control of panel
            splitContainerNav.Panel1.Controls.Add(sheepInfo);
            sheepInfo.Show();
            //Fill the panel
            sheepInfo.Dock = DockStyle.Fill;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = sheepInfo.panelInfoForm.Controls["textBoxName"].Text;
            string earTag = sheepInfo.panelInfoForm.Controls["textBoxEarTag"].Text;
            string scrapies = sheepInfo.panelInfoForm.Controls["textBoxScrapies"].Text;
            string gender = sheepInfo.getRadioButtonGender();

            DateTime dob = sheepInfo.getDoB();
            System.Drawing.Image image = sheepInfo.getSheepPic();

            //get colors of each bodypart
            String[] headColours = sheepInfo.getHeadColours();
            String[] bodyColours = sheepInfo.getBodyColours();
            String[] ftLfLegColours = sheepInfo.getFrontLFLegColours();
            String[] ftRtLegColours = sheepInfo.getFrontRTLegColours();
            String[] backLfLegColours = sheepInfo.getBackLFLegColours();
            String[] backRtLegColours = sheepInfo.getBackRTLegColours();

            //add sheep to dbo.sheep
            Sheep sheep = sheepService.addSheep(dob, gender, headColours, bodyColours, ftLfLegColours, ftRtLegColours, backLfLegColours, backRtLegColours, name, scrapies, earTag, image);
            
            //add sheep to master list
            lambList.addSheepToList(sheep);

            MessageBox.Show("Sheep Added!");

            //load new form to fill out another
            DisplayFormForm();
        }
       
    }//end class
}//end namespace
