using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace iLambDotNetFramework.Forms
{
    public partial class SearchForm : Form
    {
        SheepService service;

        public SearchForm()
        {
            this.service = new SheepService();
            InitializeComponent();
        }

        //***********************Used by sheep UC
        public SearchForm(Sheep sheep)
        {
            
            InitializeComponent();
        }

        //to correct when sheep is deleted from sheepinfoform
        public void refreshSearch()
        {
            flowLayoutPanelResults.Controls.Clear();
        }


        /// <summary>
        /// loads sheep user control when user searches
        /// </summary>
        /// <param name="sheeps">List of sheep results</param>
        public void loadSheepUserControl(List<Sheep> sheeps)
        {
            flowLayoutPanelResults.Controls.Clear();

            foreach (Sheep s in sheeps)
            {
                LambUserControl lambControl = new LambUserControl(s, this);
                flowLayoutPanelResults.Controls.Add(lambControl);
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> selectedValues = getSelectedValues();
            List<Sheep> results = service.searchByColours(selectedValues);
            loadSheepUserControl(results);
        }

        /// <summary>
        /// get all colors selected in search form
        /// </summary>
        /// <returns>Dictionary of selected values</returns>
        private Dictionary<string, List<string>> getSelectedValues()
        {
            Dictionary<string, List<string>> selectedValues = new Dictionary<string, List<string>>();

            //add any colours selected for head
            List<string> colours = getHeadColours();
            if (colours.Count > 0)
            {
                selectedValues["Head"]= colours;
            }

            //add any selected for body
            colours = getBodyColours();
            if (colours.Count > 0)
            {
                selectedValues["Body"]=colours;
            }

            //for front left leg
            colours=getFrontLFLegColours();
            if(colours.Count > 0)
            {
                selectedValues["FrontLfLeg"] = colours;
            }

            //front right
            colours = getFrontRTLegColours();
            if (colours.Count > 0) 
            {
                selectedValues["FrontRtLeg"] = colours;

            }

            //back left
            colours = getBackLFLegColours() ;
            if (colours.Count > 0)
            {
                selectedValues["BackLfLeg"] = colours;
            }

            //back right
            colours = getBackRTLegColours() ;
            if (colours.Count > 0)
            {
                selectedValues["BackRtLeg"] = colours;
            }

            return selectedValues;
        }

        //the following methods get the colors selected

        public List<string> getColorsList(System.Windows.Forms.Panel panel)
        {
            List<string> colours = new List<string>(); 

            foreach (System.Windows.Forms.Control control in panel.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    colours.Add(control.Text);
                }
            }

            return colours;
        }

        public List<string> getHeadColours()
        {
            List<string> colours = getColorsList(this.panelHead);
            return colours;
        }

    
        public List<string> getBodyColours()
        {
            List<string> colours = getColorsList(this.panelBody);
            return colours;
        }


        public List<string> getFrontLFLegColours()
        {

            List<string> colours = getColorsList(this.panelFtLfLeg);
            return colours;
        }

        public List<string> getFrontRTLegColours()
        {
            List<string> colours = getColorsList(this.panelFtRtLeg);
            return colours;

        }

        public List<string> getBackLFLegColours()
        {

            List<string> colours = getColorsList(this.panelBkLfLeg);
            return colours;
        }

        public List<string> getBackRTLegColours()
        {
            List<string> colours = getColorsList(this.panelBkRtLeg);
            return colours;
        }


    }

}
