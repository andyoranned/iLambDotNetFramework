using iLambDotNetFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;


public class SheepList
{
    //holds all sheep with sheepID as key
    private static Dictionary<int, Sheep> sheepList = new Dictionary<int, Sheep>();
    private SheepService sheepService;

    //constructor
    public SheepList()
    {
        //instantiate fields
        this.sheepService = new SheepService();

        int dbCount = sheepService.getSheepCount();

        //add sheep from database
        if ( dbCount > 0 && (sheepList.Count == 0) )
        {
            importSheepList();
        }

    }

    //*************************************************************************DONT NEED???
    /// <summary>
    /// Count how many sheep were added in months that flock grew
    /// </summary>
    /// <returns>Dict<string, int> - "MM yyyy", number sheep added that month/year</string></returns>
    public Dictionary<string, int> getDateDict() 
    { 
        //keep track of how many sheep were added to the flock each month sheep were added
        Dictionary<string, int> flockByMonth = new Dictionary<string, int>();

        //go through all sheep in sheepList
        foreach (KeyValuePair<int, Sheep> kvp in sheepList)
        {
            //get month and year sheep was added
            string monthYear = kvp.Value.DateAdded.ToString("MM yyyy");

            //if other sheep were already added, add one more otherwise create a new monthyear to keep track of
            if (flockByMonth.ContainsKey(monthYear))
            {
                flockByMonth[monthYear]++;
            }
            else
            {
                flockByMonth.Add(monthYear, 1);
            }
        }
        return flockByMonth;
    }

    /// <summary>
    /// Find sheep in flock by id
    /// </summary>
    /// <param name="id">int - sheep id</param>
    /// <returns></returns>
    public Sheep getSheepByID(int id)
    {
        return sheepList[id];
    }

    public Series getFlockTimeSeries()
    {
        Series series = new Series("Size of Flock");
        series.ChartType = SeriesChartType.Spline;

        int sheepCount = 0;

        DateTime lastDate= DateTime.MinValue;
        int lastPoint = 0;

        //start from sheep added first and keep a tally of sheep in flock at each point
        foreach (var kvp in sheepList.OrderBy(x => x.Value.DateAdded))
        {
            DateTime dateAdded = kvp.Value.DateAdded;
            sheepCount++;

            //if multiples added on same day update y value
            if (dateAdded == lastDate)
            {
                series.Points[lastPoint].YValues[0] = sheepCount;
            }
            else//otherwise add a new point
            {
                lastPoint = series.Points.AddXY(dateAdded, sheepCount);
                lastDate = dateAdded;
            }            
        }
        return series;
    }


    /// <summary>
    /// Get count of sheep in master dictionary
    /// </summary>
    /// <returns>int count</returns>
    public int getCount()
    {
        return sheepList.Count;
    }

    /// <summary>
    /// Removes sheep from master sheep dictionary
    /// </summary>
    /// <param name="sheep">Sheep obj to be deleted</param>
    public void deleteSheepFromList(Sheep sheep)
    {
        sheepList.Remove(sheep.ID);

    }

    public Dictionary<int, Sheep> getSheepDictionary()
    {
        return sheepList;
    }

    /// <summary>
    /// Add sheep to sheep list dictionary
    /// </summary>
    /// <param name="sheep">Sheep object to add</param>
    public void addSheepToList(Sheep sheep)
    {
        sheepList.Add(sheep.ID, sheep);
    }

    /// <summary>
    /// Import all sheep from database into sheep list dictionary
    /// </summary>
    private void importSheepList()
    {
        Sheep[] flock = sheepService.getFlock();

        foreach (Sheep sheep in flock)
        {
            addSheepToList(sheep);
        }
    }

}//end sheepList class