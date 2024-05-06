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
    public partial class SheepInfoForm : Form
    {
        SheepService sheepService;      //performs sheep business logic 
        Sheep sheep;                    //sheep whose info is being displaye
        SheepList lambList;             //master list of sheep
        FlockForm displayForm;          //parent form
        SearchForm searchForm;          //potential partent form

        //Used when loading from FlockForm
        public SheepInfoForm(Sheep sheep, FlockForm displayForm)
        {
            InitializeComponent();
            this.displayForm = displayForm;
            this.lambList = new SheepList();
            this.sheepService = new SheepService();
            this.sheep = sheep;
        }

        //Used when loading from search form
        public SheepInfoForm(Sheep sheep, SearchForm searchForm)
        {
            InitializeComponent();
            this.searchForm = searchForm ;
            this.lambList = new SheepList();
            this.sheepService = new SheepService();
            this.sheep = sheep;
        }

        //run when form is loaded
        private void SheepInfoForm_Load(object sender, EventArgs e)
        {
            pictureBoxSheep.Image = sheep.SheepPic;
            textBoxName.Text = sheep.Name;
            textBoxEarTag.Text = sheep.EarTag;
            textBoxScrapies.Text = sheep.Scrapies;
            dateTimePickerDoB.Value = sheep.DoB;
            comboBoxGender.Text = sheep.Gender;

        }

        /// <summary>
        /// Close window when back button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// after confirming with user, deletes sheep and closes window when delete button is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //confirm user wants to delete sheep
            string boxDialog = "Delete sheep?\nThis operation cannot be undone.";
            string caption = " ";
            var result = MessageBox.Show(boxDialog, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //user confirms, delete sheep
            if (result == DialogResult.OK)
            {
                sheepService.deleteSheep(sheep);
                lambList.deleteSheepFromList(sheep);

                if (displayForm != null)
                {
                    displayForm.refreshFlockDisplay();
                }
                else
                {
                    searchForm.refreshSearch();
                }
                this.Dispose();
            }
        }


        //update row related to sheep
        private void buttonSave_Click(object sender, EventArgs e)
        {
            sheep.DoB = dateTimePickerDoB.Value;
            sheep.Gender = comboBoxGender.Text;
            sheep.Scrapies = textBoxScrapies.Text;
            sheep.EarTag = textBoxEarTag.Text;
            sheep.Name = textBoxName.Text;

            //send updated sheep to sheep service to sync data
            sheepService.updateSheep(sheep);
            displayForm.refreshFlockDisplay();
            this.Dispose();


        }
    }
}
