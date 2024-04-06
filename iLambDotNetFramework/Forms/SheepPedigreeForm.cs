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
    public partial class SheepPedigreeForm : Form
    {
        public SheepPedigreeForm()
        {
            InitializeComponent();
        }

        //***********************Used by sheep UC
        public SheepPedigreeForm(Sheep sheep)
        {
            InitializeComponent();
        }
    }
}
