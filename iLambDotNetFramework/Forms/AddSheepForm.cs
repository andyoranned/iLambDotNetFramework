using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Drawing.Imaging;
using System.Threading;
using System.IO;




namespace iLambDotNetFramework.Forms
{
    public partial class AddSheepForm : Form
    {
        //Fields & Properties---------------------------
        VideoCapture capture;           //video capture device
        Mat frame;                      //captured frame as matrix
        Bitmap image;                   //captured frame as bitmap
        private Thread camera;          //Thread for camera's operations
        bool isCameraRunning = false;   //flag to detect camera running
        Sheep sheep;
        
        string imagePath = "C:\\Users\\mosul\\source\\repos\\andyoranned\\iLambDotNetFramework\\iLambDotNetFramework\\Resources\\";

        //Constructor(s)--------------------------------
        public AddSheepForm()
        {
            InitializeComponent();
            //this.image = new Bitmap(pictureBoxCamera.Width, pictureBoxCamera.Height);
        }


        //Methods----------------------------------------

        private void AddSheepForm_Load(object sender, EventArgs e)
        {

        }
        /*
        /// <summary>
        /// Starts running the camera 
        /// </summary>
        private void CaptureCamera()
        {
            //initialize thread with method for capturing frames
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            //starts thread
            camera.Start();
        }

        /// <summary>
        /// Captures frames from the camera & displays feed in pictureBoxCamera
        /// </summary>
        private void CaptureCameraCallback()
        {
            //initialize Mat object to store frame
            frame = new Mat();
            //object to access camera where 0=default camera
            capture = new VideoCapture(0);
            //open default,0, camera
            capture.Open(0);

            //Did camera successfully turn on?
            if (capture.IsOpened())     //yes
            {
                //Keep capturing frames while camera is on
                while (isCameraRunning)
                {
                    //read a frame from camera and store in frame Mat object
                    capture.Read(frame);

                    frame.Resize(pictureBoxCamera.Height, pictureBoxCamera.Width);
                    //convert Mat object to Bitmap
                    image = BitmapConverter.ToBitmap(frame);

                    Bitmap resizedImg = new Bitmap(pictureBoxCamera.Width, pictureBoxCamera.Height);
                    using(Graphics graphics = Graphics.FromImage(resizedImg))
                    {
                        graphics.InterpolationMode  = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphics.DrawImage(image, 0, 0,pictureBoxCamera.Width, pictureBoxCamera.Height);
                    }

                    image = resizedImg;
                    


                    //Does picturebox contain Image?
                    if (pictureBoxCamera.Image != null)//yes
                    {
                        //dispose of previous image to prevent memory leaks
                        pictureBoxCamera.Image.Dispose();
                    }

                    //display the freshly converted bitmap in picturebox
                    pictureBoxCamera.Image = image;
                }
            }
        }//end CaptureCameraCallback()

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartCam_Click(object sender, EventArgs e)
        {
            //Does buttonStartCam say "Start"?
            if (buttonStartCam.Text.Equals("Start"))//yes
            {
                //turn on camera feed
                CaptureCamera();
                //change text on button
                buttonStartCam.Text = "Off";
                //set flag to designate camera is on
                isCameraRunning = true;

            }
            else
            {                                       //no
                //
                capture.Release();
                //change text back
                buttonStartCam.Text = "Start";
                //set flag to camera off
                isCameraRunning = false;
            }
        }//end buttonStatCam_Click()


        //***********************************************************************************
        //Change the name of image to sheep ID#
        private void buttonSavePic_Click(object sender, EventArgs e)
        {
            string imageName = "image.png";

            if (isCameraRunning)
            {
                Bitmap sheepPic = new Bitmap(pictureBoxCamera.Image);
                
                sheepPic.Save(Path.Combine(imagePath, imageName), ImageFormat.Png);
            }
            else
            {
                MessageBox.Show("Cannot save picture if the camera isn't caputeing");
            }

        }//end buttonSavePic_Click()
        */
        private void pictureBoxCamera_Click(object sender, EventArgs e)
        {

        }
    }//end AddSheepForm
}//end Namespace
