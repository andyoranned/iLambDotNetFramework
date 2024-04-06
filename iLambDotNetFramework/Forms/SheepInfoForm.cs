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
        public SheepInfoForm()
        {
            InitializeComponent();
        }

        //needed for sheep user control
        public SheepInfoForm(Sheep sheep)
        {
            InitializeComponent();
        }
    }
}
