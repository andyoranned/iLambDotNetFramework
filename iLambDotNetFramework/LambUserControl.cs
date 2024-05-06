using iLambDotNetFramework.Forms;
using iLambDotNetFramework.Properties;
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
    public partial class LambUserControl : UserControl
    {
        private Sheep sheep;        //sheep whose info is displayed
        private FlockForm displayForm;//form UC is displayed on
        private SearchForm searchForm;//form UC is displayed on
       

        public LambUserControl(Sheep sheep, FlockForm form)
        {
            InitializeComponent();
            this.displayForm = form;
            this.sheep = sheep;
            labelName.Text = sheep.Name;
            labelEarTag.Text = sheep.EarTag;
            pictureBoxSheep.Image = sheep.SheepPic;
            
            //if sheep is ram, change gender image
            if (sheep.Gender == "Ram")
            { 
                labelGender.Image = Resources.icons8_male_16; 
            }

            setAgeLabel();
            
        }

        public LambUserControl(Sheep sheep, SearchForm form)
        {
            InitializeComponent();
            this.searchForm = form;
            this.sheep = sheep;
            labelName.Text = sheep.Name;
            labelEarTag.Text = sheep.EarTag;
            pictureBoxSheep.Image = sheep.SheepPic;

            //if sheep is ram, change gender image
            if (sheep.Gender == "Ram")
            {
                labelGender.Image = Resources.icons8_male_16;
            }

            setAgeLabel();

        }

        //methods-----------------------------------------------------------------

        //logic for age labels
        private void setAgeLabel()
        {
            SheepService sheepService = new SheepService();
            int age = sheepService.getAgeInYears(sheep);

            string str = age.ToString() + " years";
            if (age == 0)
            {
                age = sheepService.getAgeInMonths(sheep);
                str = age.ToString() + " months";
            }

            labelAge.Text = str;
        }

        /// <summary>
        /// opens sheep info when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LambUserControl_Click(object sender, EventArgs e)
        {
            //is user control on searchform or displayform? pass the corresponding form
            if (searchForm != null)
            {
                SheepInfoForm sheepInfo = new SheepInfoForm(sheep, searchForm);
                sheepInfo.ShowDialog();
            }
            else if (displayForm != null)
            {

                SheepInfoForm sheepInfo = new SheepInfoForm(sheep, displayForm);
                sheepInfo.ShowDialog();
            }
            
        }
    }
}
