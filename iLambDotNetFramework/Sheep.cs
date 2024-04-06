using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLambDotNetFramework
{
    enum Sex { Ram, Ewe}
    //*******************************************************************************************
    enum Colour {Black, White, Brown  }

    ///<summary>
    ///Class which represents individual sheep
    ///</summary>
    public class Sheep
    {
        //properties--------------------------------
        public int ID { get; set; }                     //identification number auto-generated when inserted into database
        public string EarTag { get; set; }              //ear tag
        public string Scrapies {  get; set; }            //scrabes id
        public string Name { get; set; }                //Optional name 
        public DateTime DoB {  get; set; }              //Date of Birth
        public string Gender { get; set; }              //Sex/gender of sheep
        public Sheep Sire {  get; set; }                //The "father" of the sheep
        public Sheep Dam {  get; set; }                 //the "Mother" of the sheep
        public Image SheepPic { get; set; }             //picture

        public string[] HeadColour { get; set; }        //colour(s) of the head
        public string[] BodyColour { get; set; }        //colour(s) of the body
        public string[] FrontLfLegColour {  get; set; } //colour(s) of the front left leg
        public string[] FrontRtLegColour { get; set; }  //colour(s) of the front right leg
        public string[] BackLfLegColour { get; set; }   //colour(s) of the back left leg
        public string[] BackRtLegColour { get; set; }   //colour(s) of the back right leg

        public bool IsCDT { get; set; }                 //Has CDT vaccination?
        public DateTime CDTVacDate { get; set; }        //When CDT Vaccination last given

        //constructors---------------------------------


    }//end Sheep class
}//end namespace
