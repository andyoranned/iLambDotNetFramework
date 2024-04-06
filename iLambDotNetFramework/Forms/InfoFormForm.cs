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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace iLambDotNetFramework.Forms
{
    public partial class InfoFormForm : Form
    {

        //Fields & Properties---------------------------
        VideoCapture _capture;           //video capture device
        Mat _frame;                      //captured frame as matrix
        private Thread _camera;          //Thread for camera's operations
        bool isCameraRunning;   //flag to detect camera running

        //stuff I might(not) need
        // private const int width = 239;  //dimensions of SheepUserControl Image
        //private const int height = 198;
        //Bitmap _image;                   //captured frame as bitmap



        public InfoFormForm()
        {
            InitializeComponent();
            
        }


        private void InfoFormForm_Load(object sender, EventArgs e)
        {
            //start camera feed
            CaptureCamera();
            isCameraRunning = true;

        }

        /// <summary>
        /// Starts running the camera 
        /// </summary>
        private void CaptureCamera()
        {
            //initialize thread with method for capturing frames
            _camera = new Thread(new ThreadStart(CaptureCameraCallback));
            //starts thread
            _camera.Start();
        }

        /// <summary>
        /// Captures frames from the camera & displays feed in pictureBoxCamera after resizing
        /// </summary>
        private void CaptureCameraCallback()
        {
            //initialize Mat object to store frame
            _frame = new Mat();
            //object to access camera where 0=default camera
            _capture = new VideoCapture(1);
            //open default,0, camera
            _capture.Open(1);

            //Did camera successfully turn on?
            if (_capture.IsOpened())     //yes
            {
                //Keep capturing frames while camera is on
                while (isCameraRunning)
                {

                    //read a frame from camera and store in frame Mat object
                    _capture.Read(_frame);
                    
                    //convert Mat object to Bitmap
                    //_image = BitmapConverter.ToBitmap(_frame);

                    Bitmap resizedImg = new Bitmap(pictureBoxCamera.Width, pictureBoxCamera.Height);
                    using (Graphics graphics = Graphics.FromImage(resizedImg))
                    {
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphics.DrawImage(BitmapConverter.ToBitmap(_frame), 0, 0, pictureBoxCamera.Width, pictureBoxCamera.Height);
                    }


                    //_image = resizedImg; 
                   
                    
                    //Does picturebox contain Image?
                    if (pictureBoxCamera.Image != null)//yes
                    {
                        //dispose of previous image to prevent memory leaks
                        pictureBoxCamera.Image.Dispose();
                        
                    }

                    //display the freshly converted bitmap in picturebox
                    pictureBoxCamera.Image = resizedImg;

                    //dispose of bitmap *******************CRASHES PROGRAM***************************
                    //resizedImg.Dispose();
                }
            }
        }//end CaptureCameraCallback()
        
        /// <summary>
        /// Clicking the camera button captures a picture and freezes camera feed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSnap_Click(object sender, EventArgs e)
        {
            if (isCameraRunning)
            {
                _capture.Release();
                isCameraRunning = false;
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
            //*************************************************Executed 3x results in crash********
           
            if (!isCameraRunning)
            {
                //turn on camera feed
                CaptureCamera();
                //set flag to designate camera is on
                isCameraRunning = true;
            }  
        }

        /// <summary>
        /// If camera is running, shut it off before closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoFormForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// The following 7 event handlers for highlight the body part that correlates to the colors selecting from
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
        
    }
}
