using iLambDotNetFramework.Properties;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using System.Windows.Controls;
using System.Windows.Forms;

namespace iLambDotNetFramework.Forms
{
    public partial class InfoFormForm : Form
    {
        private VideoCapture videoCapture;  //webcam object
        private Mat frame;                  //frame coming from webcam
        private int webcam = 0;             //0 = default camera, 1= usb webcam

        public InfoFormForm()
        {
            InitializeComponent(); 
        }


        private void InfoFormForm_Load(object sender, EventArgs e)
        {
            InitializeWebcam();
        }


        /// <summary>
        /// Start the webcam
        /// </summary>
        private void InitializeWebcam()
        {
            videoCapture = new VideoCapture(webcam); // 1 for usb webcam
            if (!videoCapture.IsOpened())
            {
                MessageBox.Show("Failed to open webcam!");
                return;
            }

            frame = new Mat();
            Application.Idle += ProcessFrame;
        }
        /// <summary>
        /// Gets a fframe from camera shrinks to picture box size and displays it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessFrame(object sender, EventArgs e)
        {
            if (videoCapture.Read(frame))
            {
                Bitmap resizedImg = new Bitmap(pictureBoxCamera.Width, pictureBoxCamera.Height);
                using (Graphics graphics = Graphics.FromImage(resizedImg))
                {
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphics.DrawImage(BitmapConverter.ToBitmap(frame), 0, 0, pictureBoxCamera.Width, pictureBoxCamera.Height);
                }

                //Does picturebox contain Image?
                if (pictureBoxCamera.Image != null)//yes
                {
                    //dispose of previous image to prevent memory leaks
                    pictureBoxCamera.Image.Dispose();

                }

                //display the freshly converted bitmap in picturebox
                pictureBoxCamera.Image = resizedImg;

            }
        }
        /// <summary>
        /// Clicking the camera button captures a picture and freezes camera feed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSnap_Click(object sender, EventArgs e)
        {
            //new
            if (videoCapture != null)
            {
                videoCapture.Release();
            }
            else
            {
                MessageBox.Show("If you want a different picture, click the retry button.");
            }

        }

        /// <summary>
        /// Clicking retry button restarts camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRetry_Click(object sender, EventArgs e)
        {
            //new
            if (videoCapture != null && !videoCapture.IsOpened())
            {
                videoCapture = new VideoCapture(webcam); // Reopen the webcam
            }
        }

        /// <summary>
        /// If camera is running, shut it off before closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoFormForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            videoCapture?.Release();
            frame?.Dispose();
        }

        //The following 7 event handlers for highlight the body part that correlates to the colors selecting from
        private void panelHead_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSheep.Image = Resources.headSheepImg;
        }

        private void panelBody_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSheep.Image= Resources.bodySheepImg;
        }

        private void panelFtLfLeg_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSheep.Image = Resources.frontLeftLegSheepImg;
        }

        private void panelFtRtLeg_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSheep.Image = Resources.frontRightLegSheepImg;
        }

        private void panelBkLfLeg_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSheep.Image = Resources.backLeftLegSheepImg;
        }

        private void panelBkRtLeg_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSheep.Image = Resources.backRightLegSheepImg;
        }

        private void panelColor_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxSheep.Image = Resources.sheepImg;
        }
        /// <summary>
        /// Determine which Gender radio button is checked
        /// </summary>
        /// <returns></returns>
        public string getRadioButtonGender()
        {
            if (radioButtonEwe.Checked)
            {
                return "Ewe";
            }
            if (radioButtonRam.Checked) { return "Ram"; }

            return "invalid";
        }
        /// <summary>
        /// get date of birth DateTime
        /// </summary>
        /// <returns></returns>
        public DateTime getDoB() { return dateTimePickerDoB.Value; }

        public System.Drawing.Image getSheepPic() {  return pictureBoxCamera.Image; }

        public string[] getHeadColours ()
        {
            string[] colours = getColorsArray(this.panelHead);
            return colours;

        }

        public string[] getBodyColours()
        {
            string[] colours = getColorsArray(this.panelBody);
            return colours;

        }


        public string[] getFrontLFLegColours()
        {

            string[] colours = getColorsArray(this.panelFtLfLeg);
            return colours;
        }

        public string[] getFrontRTLegColours()
        {
            string[] colours = getColorsArray(this.panelFtRtLeg);
            return colours;

        }

        public string[] getBackLFLegColours()
        {

            string[] colours = getColorsArray(this.panelBkLfLeg);
            return colours;
        }

        public string[] getBackRTLegColours()
        {
            string[] colours = getColorsArray(this.panelBkRtLeg);
            return colours;
        }

        //count how many boxes are checked inside paenl
        public int countCheckedBoxInPanel(System.Windows.Forms.Panel panel)
        {
            int count = 0;

            foreach (System.Windows.Forms.Control control in panel.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    count++;
                }
            }

            return count;
        }
        //get an array of the colors selected
        public string[] getColorsArray(System.Windows.Forms.Panel panel)
        {
            string[] colours = new string[countCheckedBoxInPanel(panel)];
            int i = 0;

            foreach (System.Windows.Forms.Control control in panel.Controls)
            {
                
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    colours[i] = control.Text;
                    i++;
                }
            }

            return colours;
        }
    }
}
