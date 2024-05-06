using OpenCvSharp.XFeatures2D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace iLambDotNetFramework.Forms
{
    public partial class DashboardForm : Form
    {
        //fields & properties----------------------------------------------------------------
        SheepService sheepService;
        SheepList lambList;

        //constructor------------------------------------------------------------------------
        public DashboardForm()
        {
            InitializeComponent();
            this.sheepService = new SheepService();
            this.lambList = new SheepList();
            initCountLabels();
            initChartFlockSzOverTime();
        }

        //methods-----------------------------------------------------------------------------
        
        //initialize the chart showing the growth of the flock over time
        private void initChartFlockSzOverTime()
        {
            chartFlockSzOverTime.Series.Clear();
            chartFlockSzOverTime.Series.Add(lambList.getFlockTimeSeries());
            chartFlockSzOverTime.Series[0].BorderWidth = 4;
            chartFlockSzOverTime.Titles.Add("Growth of Flock over Time");
            chartFlockSzOverTime.Titles[0].Font = new Font("Microsoft Sans Serif",20f, FontStyle.Bold);
            chartFlockSzOverTime.ChartAreas[0].AxisX.Title = "Date";
            chartFlockSzOverTime.ChartAreas[0].AxisY.Title = "Number of Sheep";
            chartFlockSzOverTime.DataBind();
        }

        /// <summary>
        /// initialize all labels that display count
        /// </summary>
        private void initCountLabels()
        {
            //get count of sheep, ram and ewes
            int sheepNum = sheepService.getSheepCount();
            int ramNum = sheepService.getRamCount();
            int eweNum = sheepNum - ramNum;

            //initialize labels
            initLabelSheepCount(sheepNum);
            initLabelRamCount(ramNum);
            initLabelEweCount(eweNum);
        }

        /// <summary>
        /// update labels that count sheep in flock
        /// </summary>
        /// <param name="sheepNum">int - number of sheep</param>
        private void initLabelSheepCount(int sheepNum)
        {
            //over 999 sheep?
            if (sheepNum > 999)//yes
            {
                //set text to 999 and show greater than symbol
                labelSheepCount.Text = "999";
                labelSheepGreater.Visible = true;
            }
            else
            {
                labelSheepCount.Text = sheepNum.ToString();
            }
        }

        /// <summary>
        /// update labels that count Rams in flock
        /// </summary>
        /// <param name="ramNum">int - count of rams</param>
        private void initLabelRamCount(int ramNum)
        {

            //only 1 ram??
            if (ramNum == 1)
            {
                //correct label grammar
                labelRam.Text = "Ram";
            }

            //if more than 999 stop counting and show greater than symbol otherwise show count
            if (ramNum > 999)
            {
                labelRamCount.Text = "999";
                labelRamGreater.Visible = true;
            }
            else
            {
                labelRamCount.Text = ramNum.ToString();
            }

        }

        /// <summary>
        /// update labels that show number of ewes
        /// </summary>
        /// <param name="eweNum">int - number of ewes</param>
        private void initLabelEweCount(int eweNum)
        {

            //only 1 ewe?
            if (eweNum == 1)
            {
                //correct label grammar
                labelEwe.Text = "Ewe";

            }

            //if more than 999 ewes show greater than symbol otherwise show count
            if (eweNum > 999)
            {
                labelEweCount.Text = "999";
                labelEweGreater.Visible = true;
            }
            else
            {
                labelEweCount.Text = eweNum.ToString();
            }

        }  
    }
}
