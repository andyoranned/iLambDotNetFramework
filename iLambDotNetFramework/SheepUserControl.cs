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
    [DefaultEvent(nameof(TextChanged))]
    public partial class UserControlLamb : UserControl
    {
        Sheep TheSheep {  get; set; }


        public UserControlLamb(Sheep sheep)
        {
            TheSheep = sheep;
            InitializeComponent();
            textBoxName.Text = TheSheep.Name;
            textBoxSex.Text = TheSheep.Gender;
            textBoxEarTag.Text = TheSheep.EarTag;
            textBoxDoB.Text = TheSheep.DoB.ToString("MMM-dd-yy");
        }

        private void buttonSheepInfo_Click(object sender, EventArgs e)
        {
            SheepInfoForm infoForm = new SheepInfoForm(TheSheep);
            infoForm.ShowDialog();
        }

        private void buttonPedigree_Click(object sender, EventArgs e)
        {
            SheepPedigreeForm pedigreeForm = new SheepPedigreeForm(TheSheep);
            pedigreeForm.ShowDialog();
        }
    }
}
