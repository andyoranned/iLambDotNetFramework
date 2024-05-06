using iLambDotNetFramework;
using iLambDotNetFramework.Properties;
using iLambDotNetFramework.RanchDataSetTableAdapters;
using OpenCvSharp.Aruco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

public class DataAccessLayer
{
    //Fields and Properties-------------------------------------------------------
    //connection string
	private string myConn = "Data Source=localhost;Initial Catalog=Ranch;Integrated Security=True;Encrypt=False";

	//Create queries
	private const string addSheepQ = "INSERT INTO Ranch.dbo.Sheep (SheepName, DoB, Gender, Scrapies, EarTag, SheepPic) VALUES (@SheepName, @DoB, @Gender, @Scrapies, @EarTag, @SheepPic);  SELECT SCOPE_IDENTITY();";
	private const string addMarkingsQ = "INSERT INTO Ranch.dbo.SheepColours (SheepID, Colour, BodyPart) VALUES (@SheepID, @Colour, @BodyPart)";

	//Read queries
	private const string readSheepID = "SELECT SheepID FROM Ranch.dbo.Sheep";
    private const string selectFlockQ = "SELECT SheepID, SheepName, DoB, Gender, Scrapies, EarTag, SheepPic, DateAdded FROM Ranch.dbo.Sheep ";
    private const string selectSheepColoursQ = "SELECT Colour FROM Ranch.dbo.SheepColours WHERE SheepID = @sheepID AND BodyPart = @bodyPart";

    //Update queries
    private const string updateSheepQ = "UPDATE Ranch.dbo.Sheep SET SheepName = @sheepName, DoB = @doB, Gender = @gender, Scrapies = @scrapies, EarTag = @earTag WHERE SheepID = @sheepID";


    //Delete queries
    private const string deleteSheepQ = "DELETE FROM Ranch.dbo.Sheep WHERE SheepID = @sheepID";
    private const string deleteSheepMarkingsQ = "DELETE FROM Ranch.dbo.SheepColours WHERE SheepID = @sheepID";

    //Aggregate queries
    private const string getSheepCountQ = "SELECT COUNT(*) From Ranch.dbo.Sheep";
    private const string getRamCountQ = "SELECT COUNT(*) FROM Ranch.dbo.Sheep WHERE Gender = 'Ram'";
    private const string getSheepColourCountQ = "SELECT COUNT(*) From Ranch.dbo.SheepColours WHERE SheepID = @sheepID and BodyPart = @bodyPart";

    //Methods-------------------------------------------------------------------

    public List<int> searchFunction (Dictionary<string, List<string>> selectedValues)
    {
        List<int> result = new List<int>();

        if (selectedValues.Count == 0)
        {
            string q = "SELECT DISTINCT SheepID FROM Ranch.dbo.SheepColours";

            // Execute the query
            using (SqlConnection con = new SqlConnection(myConn))
            {
                SqlCommand com = new SqlCommand(q, con);
                con.Open();
                SqlDataReader reader = com.ExecuteReader();

                // Process the results
                while (reader.Read())
                {
                    // Add the SheepID to the list
                    result.Add(reader.GetInt32(reader.GetOrdinal("SheepID")));
                }
                return result;
            }
        }
        

        // Build the SQL query dynamically
        string query = "SELECT DISTINCT SheepID FROM Ranch.dbo.SheepColours WHERE ";

        // Construct the WHERE clause 
        List<string> conditions = new List<string>();

        foreach (var kvp in selectedValues)
        {
            string bodyPart = kvp.Key;
            List<string> colors = kvp.Value;

            // Add condition for each selected color and body part
            foreach (string color in colors)
            {
                conditions.Add($"(BodyPart = '{bodyPart}' AND Colour = '{color}')");
            }
        }

        // Combine all conditions with AND
        string whereClause = string.Join(" AND ", conditions);
        query += whereClause;

        // Execute the query
        using (SqlConnection con = new SqlConnection(myConn))
        {
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();

            // Process the results
            while (reader.Read())
            {
                // Add the SheepID to the list
                result.Add(reader.GetInt32(reader.GetOrdinal("SheepID")));
            }
        }

        // Return the list of matching SheepIDs

        return result;
    }

    /// <summary>
    /// update Sheep data values from sheepInfoForm
    /// </summary>
    /// <param name="sheep">Updated sheep object</param>
    public void updateSheepInDB(Sheep sheep)
    {
        using (SqlConnection con = new SqlConnection(myConn))
        {
            con.Open();
            using (SqlCommand com = new SqlCommand(updateSheepQ, con))
            {
                com.Parameters.AddWithValue("@sheepName", sheep.Name);
                com.Parameters.AddWithValue("@doB", sheep.DoB);
                com.Parameters.AddWithValue("@scrapies", sheep.Scrapies);
                com.Parameters.AddWithValue("@gender", sheep.Gender);
                com.Parameters.AddWithValue("@earTag", sheep.EarTag);
                com.Parameters.AddWithValue("@sheepID", sheep.ID);

                com.ExecuteNonQuery();
            
            }
        }

    }


    /// <summary>
    /// Drop sheep from both SheepColours and Sheep tables
    /// </summary>
    /// <param name="sheep">Sheep object to be dropped</param>
    public void dropSheepFromDB(Sheep sheep)
    {
        deleteSheepMarkingsFromDB(sheep);
        deleteSheepFromDB(sheep);
    }

    /// <summary>
    /// Delete sheep row from Ranch.dbo.Sheep
    /// </summary>
    /// <param name="sheep">Sheep obj to be dropped</param>
    public void deleteSheepFromDB(Sheep sheep)
    {
        using (SqlConnection con = new SqlConnection(myConn))
        {
            con.Open();
            using (SqlCommand com = new SqlCommand(deleteSheepQ, con))
            {
                com.Parameters.AddWithValue("@sheepID", sheep.ID);
                com.ExecuteNonQuery();
            }
        }
    }

    /// <summary>
    /// Delete rows with sheep's colours from Ranch.dbo.SheepColours
    /// </summary>
    /// <param name="sheep">Sheep obj to be dropped</param>
    public void deleteSheepMarkingsFromDB(Sheep sheep)
    {
        using (SqlConnection con = new SqlConnection(myConn))
        {
            con.Open();
            using (SqlCommand com = new SqlCommand(deleteSheepMarkingsQ, con))
            {
                com.Parameters.AddWithValue("@sheepID", sheep.ID);
                com.ExecuteNonQuery();
            }
        }
    }

    /// <summary>
    /// add markings info to dbo.SheepColours
    /// </summary>
    /// <param name="sheepID"></param>
    /// <param name="headColour"></param>
    /// <param name="bodyColour"></param>
    /// <param name="frontLfLegColour"></param>
    /// <param name="frontRtLegColour"></param>
    /// <param name="backLfLegColour"></param>
    /// <param name="backRtLegColour"></param>
    public void addSheepColoursToDB(int sheepID, string[] headColour, string[] bodyColour, string[] frontLfLegColour, string[] frontRtLegColour, string[] backLfLegColour, string[] backRtLegColour)
    {
        //create connection
        using (SqlConnection con = new SqlConnection(myConn))
        {
            //open connection w/ dbo.Sheep
            con.Open();
            using (SqlCommand command = new SqlCommand(addMarkingsQ, con))
            {
                // Add parameters for sheepID, color, and bodypart
                command.Parameters.Add("@SheepID", SqlDbType.Int);
                command.Parameters.Add("@Colour", SqlDbType.VarChar);
                command.Parameters.Add("@BodyPart", SqlDbType.VarChar);

                //add rows for colors on head
                foreach (string clr in headColour)
                {
                    command.Parameters["@SheepID"].Value = sheepID;
                    command.Parameters["@Colour"].Value = clr;
                    command.Parameters["@BodyPart"].Value = "Head";
                    command.ExecuteNonQuery();
                }
                //for body
                foreach (string clr in bodyColour)
                {
                    command.Parameters["@SheepID"].Value = sheepID;
                    command.Parameters["@Colour"].Value = clr;
                    command.Parameters["@BodyPart"].Value = "Body";
                    command.ExecuteNonQuery();
                }
                //for front left leg
                foreach (string clr in frontLfLegColour)
                {
                    command.Parameters["@SheepID"].Value = sheepID;
                    command.Parameters["@Colour"].Value = clr;
                    command.Parameters["@BodyPart"].Value = "FrontLfLeg";
                    command.ExecuteNonQuery();
                }


                foreach (string clr in frontRtLegColour)
                {
                    command.Parameters["@SheepID"].Value = sheepID;
                    command.Parameters["@Colour"].Value = clr;
                    command.Parameters["@BodyPart"].Value = "FrontRtLeg";
                    command.ExecuteNonQuery();
                }


                foreach (string clr in backLfLegColour)
                {

                    command.Parameters["@SheepID"].Value = sheepID;
                    command.Parameters["@Colour"].Value = clr;
                    command.Parameters["@BodyPart"].Value = "BackLfLeg";
                    command.ExecuteNonQuery();
                }

                
                foreach (string clr in backRtLegColour)
                {

                    command.Parameters["@SheepID"].Value = sheepID;
                    command.Parameters["@Colour"].Value = clr;
                    command.Parameters["@BodyPart"].Value = "BackRtLeg";
                    command.ExecuteNonQuery();
                }

            }
        }
    }
    /// <summary>
    /// Add sheep to dbo.Sheep
    /// </summary>
    /// <param name="doB"></param>
    /// <param name="gender"></param>
    /// <param name="sheepName"></param>
    /// <param name="scrapies"></param>
    /// <param name="earTag"></param>
    /// <param name="sheepPic"></param>
    /// <returns>SheepID</returns>
	public int addSheepToDB(DateTime doB, string gender, string sheepName = " ", string scrapies= " ", string earTag= " ", Image sheepPic= null)
	{
        byte[] sheepPicArray;

        //create connection
        using (SqlConnection con = new SqlConnection(myConn))
        {
            //open connection w/ dbo.Sheep
            con.Open();
            using (SqlCommand command = new SqlCommand(addSheepQ, con))
            {
                //Add values
                command.Parameters.AddWithValue("@DoB", doB);
                command.Parameters.AddWithValue("@Gender", gender );
                command.Parameters.AddWithValue("@SheepName", sheepName );
                command.Parameters.AddWithValue("@Scrapies", scrapies);
                command.Parameters.AddWithValue("@EarTag", earTag);

                //Use either provided image or default if none is provided
                if (sheepPic != null)
                {

                    using (MemoryStream ms = new MemoryStream())
                    {
                        //save sheep image to memorystream in jpeg format
                        sheepPic.Save(ms, ImageFormat.Jpeg);

                        //convert to a byte array
                        sheepPicArray = ms.ToArray();
                    }
                }
                else
                {

                    using (MemoryStream ms = new MemoryStream())
                    {
                        //save sheep image to memorystream in jpeg format
                        Resources.sheep_head_publicdomain.Save(ms, ImageFormat.Jpeg);

                        //convert to a byte array
                        sheepPicArray = ms.ToArray();
                    }
                   
                }

                command.Parameters.AddWithValue("@SheepPic", sheepPicArray);
                //return sheepID
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
    }//end addsheeptodb()

    /// <summary>
    /// Counts sheep in database
    /// </summary>
    /// <returns>Int count of sheep</returns>
    public int getSheepCountFromDB()
    {
        int count = 0;  

        using (SqlConnection con = new SqlConnection(myConn))
        {
            con.Open();
            using (SqlCommand com = new SqlCommand(getSheepCountQ,con))
            {
               count= (int) com.ExecuteScalar();
            }
        }

        return count;
    }//end getSheepCountFromDB()

    /// <summary>
    /// Count rams in Sheep database
    /// </summary>
    /// <returns>int - number of rams</returns>
    public int getRamCountFromDB()
    {
        int count = 0;

        using (SqlConnection con = new SqlConnection(myConn))
        {
            con.Open();
            using (SqlCommand com = new SqlCommand(getRamCountQ, con))
            {
                count = (int)com.ExecuteScalar();
            }
        }

        return count;
    }

    /// <summary>
    /// gets all sheep rows from Ranch.dbo.Sheep
    /// </summary>
    /// <returns>Sheep array with all sheep</returns>
    public Sheep[] getFlockFromDB()
    {
        Sheep[] flock = new Sheep[getSheepCountFromDB()];

        using (SqlConnection con = new SqlConnection(myConn))
        {
            con.Open();

            using (SqlCommand com = new SqlCommand(selectFlockQ, con))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    //counter for while loop
                    int i = 0;

                    //read every row
                    while (reader.Read())
                    {
                        int sheepID = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        DateTime dob = reader.GetDateTime(2);
                        string gender = reader.GetString(3);
                        string scrapies = reader.GetString(4);
                        string eartag = reader.GetString(5);
                        DateTime dateAdded = reader.GetDateTime(7);

                        Image sheepImage = null;

                       
                        //if an image was saved?
                        if (!reader.IsDBNull(6)) //Yes,  read it
                        {
                            byte[] picArray = new byte[reader.GetBytes(6, 0, null, 0, int.MaxValue)];
                            reader.GetBytes(6, 0, picArray, 0, picArray.Length);

                            //convert byte array into an Image
                            using (MemoryStream ms = new MemoryStream(picArray))
                            {
                                sheepImage = Image.FromStream(ms);
                            }
                        }
                        else
                        {                       //no, use default image
                            sheepImage = Resources.headSheepImg;
                        }
                        

                        //get colours of sheep 
                        string[] headColours  = getSheepColours(sheepID,"Head" );
                        string[] bodyColours = getSheepColours(sheepID,"Body" );
                        string[] frontLfLegColours  = getSheepColours(sheepID,"FrontLfLeg" );
                        string[] frontRtLegColours  = getSheepColours(sheepID,"FrontRtLeg" );
                        string[] backLfLegColours  = getSheepColours(sheepID,"BackLfLeg" );
                        string[] backRtLegColours  = getSheepColours(sheepID,"BackRtLeg" );
                        
                        //create new sheep object and add to sheep array
                        flock[i] = new Sheep(sheepID,eartag, scrapies, name, dob, gender, sheepImage, headColours, bodyColours, frontLfLegColours, frontRtLegColours, backLfLegColours, backRtLegColours, dateAdded );

                        //increment counter
                        i++;

                    }//end while loop
                }//end datareader
            }//end command
        }//end connection

        return flock;
    }//end method

    /// <summary>
    /// Gets list of colours on sheep body part
    /// </summary>
    /// <param name="id">sheep id</param>
    /// <param name="bodyPart">body part colour is on</param>
    /// <returns>string array of colours if no colours returns singleton array containing "none"</returns>
    public string[] getSheepColours(int id, string bodyPart)
    {
        int count = getSheepColourCount(id, bodyPart);

        //no colour data saved
        if (count == 0)
        {
            string[] strArr = new string[1];
            strArr[0] = "none";
            return strArr;
        }

        string[] colours = new string[count];

        using (SqlConnection con = new SqlConnection(myConn))
        {
            con.Open();
            using (SqlCommand com = new SqlCommand(selectSheepColoursQ, con))
            {

                com.Parameters.AddWithValue("@sheepID", id);
                com.Parameters.AddWithValue("@bodyPart", bodyPart);

                using (SqlDataReader reader = com.ExecuteReader())
                {
                    //counter for loop
                    int i = 0;

                    while (reader.Read())
                    {
                        colours[i] = reader.GetString(0);
                        i++;
                    }
                }
            }//end command
        }//end connection
        return colours;
    }//end method

    /// <summary>
    /// counts how many colours on specifies bodypart of sheep
    /// </summary>
    /// <param name="id">sheep id</param>
    /// <param name="bodyPart">speficified bodypart</param>
    /// <returns>int count of colours</returns>
    public int getSheepColourCount(int id, string bodyPart)
    {
        int count = 0;
        using (SqlConnection con = new SqlConnection(myConn))
        {
            con.Open();
            using (SqlCommand com = new SqlCommand(getSheepColourCountQ, con))
            {
                com.Parameters.AddWithValue("@sheepId", id);
                com.Parameters.AddWithValue("@bodyPart", bodyPart);

                try
                {
                    count = (int)com.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    count = 0;
                }
            }


            return count;
        }
    }
}
