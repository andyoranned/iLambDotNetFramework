using iLambDotNetFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class SheepService
    {

    //properties & fields-------------------------------------------------------
    private readonly DataAccessLayer _DAL;       //DataAccessLayer object to communicate with Database

    
    //constructor---------------------------------------------------------------
    public SheepService()
    {
        this._DAL = new DataAccessLayer();
    }

    //methods--------------------------------------------------------------------

    /// <summary>
    /// Send updated sheep values to data access layer
    /// </summary>
    /// <param name="sheep">Updated sheep obj</param>
    public void updateSheep (Sheep sheep)
    {
        _DAL.updateSheepInDB(sheep);
    }

    /// <summary>
    /// Gets sheep data from InfoFormForm to create new sheep and add to dbo.Sheep 
    /// Returns : Sheep object
    /// </summary>
    public Sheep addSheep(DateTime doB, string gender, string[] headColour, string[] bodyColour, string[] frontLfLegColour, string[] frontRtLegColour, string[] backLfLegColour, string[] backRtLegColour, string sheepName = " ", string scrapies = " ", string earTag = " ", Image sheepPic = null)
    {
        //add sheep to Ranch.dbo.Sheep and record sheep id
        int sheepID = _DAL.addSheepToDB(doB, gender, sheepName, scrapies, earTag, sheepPic);

        //send sheep colour markings to DB
        _DAL.addSheepColoursToDB(sheepID, headColour, bodyColour, frontLfLegColour, frontRtLegColour, backLfLegColour, backRtLegColour);

        //create sheep object
        Sheep sheep = new Sheep(sheepID, earTag, scrapies, sheepName, doB, gender, sheepPic, headColour, bodyColour, frontLfLegColour, frontRtLegColour, backLfLegColour, backRtLegColour, DateTime.Now);

        return sheep;
    }
    /// <summary>
    /// gets a list of Sheep objects populated with data from Ranch.dbo.Sheep & SheepColours
    /// </summary>
    /// <returns>Sheep array of all sheep</returns>
    public Sheep[] getFlock() 
    { 
        return _DAL.getFlockFromDB();
    }

    /// <summary>
    /// count all rows in Ranch.dbo.Sheep
    /// </summary>
    /// <returns>int number of sheep</returns>
    public int getSheepCount()
    {
       return _DAL.getSheepCountFromDB();
    }

    public int getRamCount()
    {
        return _DAL.getRamCountFromDB();
    }

    /// <summary>
    /// Get the age of Sheep in years
    /// </summary>
    /// <param name="sheep">sheep object</param>
    /// <returns>int years old</returns>
    public int getAgeInYears(Sheep sheep)
    {
        int age = DateTime.Now.Year - sheep.DoB.Year;

        if (DateTime.Now.Month < sheep.DoB.Month || (DateTime.Now.Month == sheep.DoB.Month && DateTime.Now.Day < sheep.DoB.Day))
        {
            age--;
        }

        return age;
    }

    /// <summary>
    /// Get the age of a sheep in months
    /// </summary>
    /// <param name="sheep">sheep object</param>
    /// <returns>int months old</returns>
    public int getAgeInMonths(Sheep sheep)
    {
        int years = DateTime.Now.Year - sheep.DoB.Year;
        int months = DateTime.Now.Month - sheep.DoB.Month;

        // current month is before birth month?
        if (DateTime.Now.Day < sheep.DoB.Day)
        {
            months--;
        }

        // Calculate the age in months
        return years * 12 + months;
    }//end getAgeInMonths

    /// <summary>
    /// Remove all sheep info from Ranch database
    /// </summary>
    /// <param name="sheep"></param>
    public void deleteSheep(Sheep sheep)
    {
        _DAL.dropSheepFromDB(sheep);
    }

    /// <summary>
    /// Find sheep that meet selected colour combo
    /// </summary>
    /// <param name="selectedValues">List<> -colours selected on search form</param>
    /// <returns>List of sheep</returns>
    public List<Sheep> searchByColours(Dictionary<string, List<string>> selectedValues)
    {
        SheepList lambList = new SheepList();
        List <int> results = _DAL.searchFunction(selectedValues);
        List<Sheep> sheep = new List<Sheep>();

        foreach (int i in results)
        {
            sheep.Add(lambList.getSheepByID(i));

        }

        return sheep;
    }

    }//end SheepService class

