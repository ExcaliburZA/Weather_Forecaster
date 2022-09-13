using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Weather_Forecaster
{

    public partial class frmForecaster : Form
    {
        /* public static */
        string[] citiesView = new string[100];
        string newLine = Environment.NewLine;

        Forecasts[] myForecasts = new Forecasts[100];

        Forecasts[] toDisplay = new Forecasts[100];
        public frmForecaster()
        {
            InitializeComponent();
        }



        private void btnSubmitNew_Click(object sender, EventArgs e)
        {
            //receiving values for the new forecast
            String city = txtCityNew.Text;
            DateTime date = (dtmDateNew.Value).Date;
            float minTemp = float.Parse(txtMinTempNew.Text);
            float maxTemp = float.Parse(txtMaxTempNew.Text);
            int precipitation = int.Parse(txtPrecipitationNew.Text);
            int humidity = int.Parse(txtHumidityNew.Text);
            float windSpeed = float.Parse(txtWindSpeedNew.Text);

            //instancing the Forecasts class using the above values as parameters for the constructor
            Forecasts forecast = new Forecasts(city, date, minTemp, maxTemp, precipitation, humidity, windSpeed);



            //finding the next empty cell in the array of Forecasts objects and adding the new forecast to it
            for (int i = 0; i < myForecasts.Length; ++i)
            {
                if (myForecasts[i] == null)
                {
                    myForecasts[i] = forecast;
                    i = 101;
                }
            }

            //displaying the details of the newly added forecast
            txtDisplay.Text += "City:\t\t\t" + city + newLine;
            txtDisplay.Text += "Date:\t\t\t" + date.Date + newLine;
            txtDisplay.Text += "Minimum Temperature:\t" + minTemp + newLine;
            txtDisplay.Text += "Maximum Temperature\t" + maxTemp + newLine;
            txtDisplay.Text += "Precipitation Chance:\t" + precipitation + newLine;
            txtDisplay.Text += "Humidity:\t\t\t" + humidity + newLine;
            txtDisplay.Text += "Wind Speed:\t\t" + windSpeed + newLine;
            //txtDisplay.Text += forecast.returnForecastProperties();
        }



        private void addForecast_Click(object sender, EventArgs e)
        {
            showNewComps();
            hideViewComps();
            btnUpdate.Visible = false;
            btnView.Visible = false;
            lblNew.Text = "New Forecast";
        }

        private void updateForecast_Click(object sender, EventArgs e)
        {
            showUpdateComps();
            hideViewComps();
            showNewComps();
            lblNew.Text = "New values";
            pctNew.Visible = true;
            pctUpdateView.Visible = false;
            pctUpdateView2.Visible = false;
            btnSubmitNew.Visible = false;
            pctNew2.Visible = false;
        }

        private void viewForecasts_Click(object sender, EventArgs e)
        {
            showViewComps();
            hideNewComps();
            hideUpdateComps();
            pctUpdateView.Visible = true;
            pctUpdateView2.Visible = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //creating and assiging values to the variables that will be passed to the rangeCheck method of the Forecasts class to indicate the range of dates to display the forecasts for
            DateTime startDate = dtmStartDateView.Value;
            DateTime endDate = dtmEndDateView.Value;

            //creating and initializing the loop counter variables
            int i = 0, x;

            //looping through the array of forecasts and testing each of them to see if they fall within the specified date range and if they correspond to one of the specified cities
            while (myForecasts[i] != null)
            {
                Forecasts forecast = myForecasts[i];

                //performing the date and city checks on the current cell of the array of forecasts 
                if ((forecast.rangeCheck(startDate, endDate) == true) && (forecast.cityCheckMulti(citiesView) == true))
                {
                    for (x = 0; x < toDisplay.Length; ++x)
                    {
                        if (toDisplay[x] == null)
                        {
                            toDisplay[x] = forecast;
                            x = 101;
                        }
                    }
                }
                ++i;
            }
            txtDisplay.Clear();

            //looping through the array of forecasts to display and displaying them
            int y = 0;
            while (toDisplay[y] != null)
            {
                txtDisplay.Text += "City:\t\t\t" + toDisplay[y].City + newLine;
                txtDisplay.Text += "Date:\t\t\t" + (toDisplay[y].Date).Date + newLine;
                txtDisplay.Text += "Minimum Temperature:\t" + toDisplay[y].MinTemp + newLine;
                txtDisplay.Text += "Maximum Temperature\t" + toDisplay[y].MaxTemp + newLine;
                txtDisplay.Text += "Precipitation Chance:\t" + toDisplay[y].Precipitation + newLine;
                txtDisplay.Text += "Humidity:\t\t\t" + toDisplay[y].Humidity + newLine;
                txtDisplay.Text += "Wind Speed:\t\t" + toDisplay[y].WindSpeed + newLine;
                txtDisplay.Text += newLine;
                ++y;
            }
            /* 
             * At this point in the program we have an array of all forecasts that correspond to one of the specified cities and fall within the specified date range
             * What we now need to do is loop through that same array, collect the numeric attributes of each forecast and determine the highest one for each day
             * */

            //Creating a list of all unique Dates stored in the toDisplay array
            HashSet<DateTime> HashSetOfDates = new HashSet<DateTime>();

            //Capturing all unique dates and storing them in the HashSet of unique dates
            int z = 0;
            while (toDisplay[z] != null)
            {
                Forecasts forecast = toDisplay[z];
                HashSetOfDates.Add(forecast.Date);
                ++z;
            }

            List<DateTime> listOfDates = HashSetOfDates.ToList(); //creating a list of all unique date values that are present in the list of forecasts

            //displaying headings
            txtDisplay.Text += "---------------------------------------------------------------------------------------------" + newLine;
            if (listOfDates.Count() > 1)
            {
                txtDisplay.Text += "MIN AND MAX RECORDS FOR EACH DATE" + newLine;
            }
            else
            {
                txtDisplay.Text += "MIN AND MAX RECORDS FOR " + listOfDates[0].Date+newLine;
            }

            //populating the list of date values
            for (int z1 = 0; z1 < listOfDates.Count(); z1++)
            {
                y = 0;
                List<Forecasts> listForDate = new List<Forecasts>();

                while (toDisplay[y] != null)
                {
                    if ((toDisplay[y].Date).Equals(listOfDates[z1]) == true)
                    {
                        listForDate.Add(toDisplay[y]);
                    }
                    ++y;
                }

                //creating lists for each forecast attribnute 
                List<float> maxTemps = new List<float>();
                List<float> minTemps = new List<float>();
                List<int> precipitation = new List<int>();
                List<int> humiditiy = new List<int>();
                List<float> windSpeed = new List<float>();

                for (int j = 0; j < listForDate.Count(); j++)
                {
                    maxTemps.Add(listForDate[j].MaxTemp);
                    minTemps.Add(listForDate[j].MinTemp);
                    precipitation.Add(listForDate[j].Precipitation);
                    humiditiy.Add(listForDate[j].Humidity);
                    windSpeed.Add(listForDate[j].WindSpeed);
                }

                //determining min and max values for each forecast attribute
                if (listOfDates.Count() > 1)
                { txtDisplay.Text += listOfDates[z1] + newLine; }               
                txtDisplay.Text += "Minimum Temperature: \t\t" + minTemps.Min() + newLine;
                txtDisplay.Text += "Maximum Temperature: \t\t" + maxTemps.Max() + newLine;
                txtDisplay.Text += "Highest Precipitation Chance: \t\t" + precipitation.Max() + newLine;
                txtDisplay.Text += "Highest Humidity: \t\t\t" + humiditiy.Max() + newLine;
                txtDisplay.Text += "Fastest Wind Speed: \t\t" + windSpeed.Max() + newLine + newLine;

            }

            z = 0;

            //creating a list of all cities present across the forecasts and calculating the min and max values for each of them
            HashSet<String> HashSetOfCities = new HashSet<String>();
            while (toDisplay[z] != null)
            {
                Forecasts forecast = toDisplay[z];
                HashSetOfCities.Add(forecast.City);
                ++z;
            }

            List<String> listOfCities = HashSetOfCities.ToList();

            txtDisplay.Text += "---------------------------------------------------------------------------------------------" + newLine;
            if (HashSetOfCities.Count() > 1)
            { 
                txtDisplay.Text += "MIN AND MAX RECORDS FOR EACH CITY" + newLine; 
            }
            else 
            {
                txtDisplay.Text += "MIN AND MAX RECORDS FOR " + listOfCities[0]; 
            }       
           

            for (int y1 = 0; y1 < listOfCities.Count; y1++)
            {
                z = 0;
                List<Forecasts> listForCity = new List<Forecasts>();

                while (toDisplay[z] != null)
                {
                    if ((toDisplay[z].City).Equals(listOfCities[y1]) == true)
                    {
                        listForCity.Add(toDisplay[z]);
                    }
                    ++z;
                }

                List<float> maxTemps = new List<float>();
                List<float> minTemps = new List<float>();
                List<int> precipitation = new List<int>();
                List<int> humiditiy = new List<int>();
                List<float> windSpeed = new List<float>();

                for (int j = 0; j < listForCity.Count(); j++)
                {
                    maxTemps.Add(listForCity[j].MaxTemp);
                    minTemps.Add(listForCity[j].MinTemp);
                    precipitation.Add(listForCity[j].Precipitation);
                    humiditiy.Add(listForCity[j].Humidity);
                    windSpeed.Add(listForCity[j].WindSpeed);
                }

                if (listOfCities.Count() > 1)
                { txtDisplay.Text += listOfCities[y1] + newLine; }               
                txtDisplay.Text += "Minimum Temperature: \t\t" + minTemps.Min() + newLine;
                txtDisplay.Text += "Maximum Temperature: \t\t" + maxTemps.Max() + newLine;
                txtDisplay.Text += "Highest Precipitation Chance: \t\t" + precipitation.Max() + newLine;
                txtDisplay.Text += "Highest Humidity: \t\t\t" + humiditiy.Max() + newLine;
                txtDisplay.Text += "Fastest Wind Speed: \t\t" + windSpeed.Max() + newLine + newLine;
            }
            txtDisplay.Text += "---------------------------------------------------------------------------------------------" + newLine;
        }


        //method used to generate a list of forecasts with random values for testing purposes
        private void btnPopulate_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (myForecasts[i] != null)
            {
                myForecasts[i] = null;
                ++i;
            }

            Random randGen = new Random();
            for (int x = 0; x < (myForecasts.Length / 10); ++x)
            {
                int rand1 = randGen.Next(1, 51);
                int rand2 = randGen.Next(1, 51);
                int rand3 = randGen.Next(1, 51);
                int rand4 = randGen.Next(1, 51);
                int rand5 = randGen.Next(1, 51);
                int rand6 = randGen.Next(0, 4);

                Random gen = new Random();
                int range = 5 * 365; //5 years           
                DateTime randomDate = DateTime.Today.AddDays(-gen.Next(range));

                string city = "";
                switch (rand6)
                {
                    case 1:
                        city = "Cape Town";
                        break;
                    case 2:
                        city = "Durban";
                        break;
                    case 3:
                        city = "Johannesburg";
                        break;
                    default:
                        city = "Pretoria";
                        break;
                }

                myForecasts[x] = new Forecasts(city, randomDate, rand1, rand2, rand3, rand4, rand5);

                if (myForecasts[x].MinTemp > myForecasts[x].MaxTemp)
                {
                    float tempMax = myForecasts[x].MaxTemp;
                    myForecasts[x].MaxTemp = myForecasts[x].MinTemp;
                    myForecasts[x].MinTemp = tempMax;
                }

                System.Threading.Thread.Sleep(200);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int x = 0;

            //looping through the array of forecasts and displaying each one
            while ((myForecasts[x] != null))
            {
                txtDisplay.Text += myForecasts[x].toString();
                txtDisplay.Text += newLine;

                /*
                  txtDisplay.Text += "City:\t\t\t" + myForecasts[x].City + newLine;
                  txtDisplay.Text += "Date:\t\t\t" + myForecasts[x].Date + newLine;
                  txtDisplay.Text += "Minimum Temperature:\t" + myForecasts[x].MinTemp + newLine;
                  txtDisplay.Text += "Maximum Temperature\t" + myForecasts[x].MaxTemp + newLine;
                  txtDisplay.Text += "Precipitation Chance:\t" + myForecasts[x].Precipitation + newLine;
                  txtDisplay.Text += "Humidity:\t\t\t" + myForecasts[x].Humidity + newLine;
                  txtDisplay.Text += "Wind Speed:\t\t" + myForecasts[x].WindSpeed + newLine;
                  txtDisplay.Text += newLine;                 
                */
                ++x;
            }
        }

        public void showNewComps()
        {
            lblNew.Visible = true;
            lblCityNew.Visible = true;
            lblDateNew.Visible = true;
            lblMinTempNew.Visible = true;
            lblMaxTempNew.Visible = true;
            lblPrecipitationNew.Visible = true;
            lblHumidityNew.Visible = true;
            lblWindSpeedNew.Visible = true;

            txtCityNew.Visible = true;
            dtmDateNew.Visible = true;
            txtMinTempNew.Visible = true;
            txtMaxTempNew.Visible = true;
            txtPrecipitationNew.Visible = true;
            txtHumidityNew.Visible = true;
            txtWindSpeedNew.Visible = true;
            btnSubmitNew.Visible = true;

            pctNew.Visible = true;
            pctNew2.Visible = true;
            pctUpdateView.Visible = false;
            pctUpdateView2.Visible = false;
        }

        public void hideNewComps()
        {
            lblNew.Visible = false;
            lblCityNew.Visible = false;
            lblDateNew.Visible = false;
            lblMinTempNew.Visible = false;
            lblMaxTempNew.Visible = false;
            lblPrecipitationNew.Visible = false;
            lblHumidityNew.Visible = false;
            lblWindSpeedNew.Visible = false;

            txtCityNew.Visible = false;
            dtmDateNew.Visible = false;
            txtMinTempNew.Visible = false;
            txtMaxTempNew.Visible = false;
            txtPrecipitationNew.Visible = false;
            txtHumidityNew.Visible = false;
            txtWindSpeedNew.Visible = false;
            btnSubmitNew.Visible = false;

            pctNew.Visible = false;
            pctUpdateView.Visible = false;
        }

        public void showViewComps()
        {
            lblView.Visible = true;
            lblStartDate.Visible = true;
            lblEndDate.Visible = true;
            dtmStartDateView.Visible = true;
            dtmEndDateView.Visible = true;
            btnView.Visible = true;
            btnAddCity.Visible = true;
            txtCityView.Visible = true;
            lblCityView.Visible = true;
            btnUpdate.Visible = false;
            pctUpdateView.Visible = true;
            pctUpdateView2.Visible = true;
            pctNew.Visible = false;
            pctNew2.Visible = false;
        }

        public void hideViewComps()
        {
            lblView.Visible = false;
            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            dtmStartDateView.Visible = false;
            dtmEndDateView.Visible = false;
            btnView.Visible = false;
            btnAddCity.Visible = false;
            txtCityView.Visible = false;
            lblCityView.Visible = false;
            pctUpdateView.Visible = false;
        }

        public void showUpdateComps()
        {
            lblUpdate.Visible = true;
            lblCityUpdate.Visible = true;
            lblDateUpdate.Visible = true;
            txtCityUpdate.Visible = true;
            dtmDateUpdate.Visible = true;
            btnUpdate.Visible = true;
            btnView.Visible = false;
            pctUpdateView.Visible = true;
            pctUpdateView2.Visible = true;
            pctNew.Visible = false;
            pctNew2.Visible = false;
        }

        public void hideUpdateComps()
        {
            lblUpdate.Visible = false;
            lblCityUpdate.Visible = false;
            lblDateUpdate.Visible = false;
            txtCityUpdate.Visible = false;
            dtmDateUpdate.Visible = false;
            btnUpdate.Visible = false;
            pctUpdateView.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //creating variables that will be used to determine the forecast the user wishes to update 
            string city = txtCityUpdate.Text;
            DateTime date = (dtmDateUpdate.Value).Date;
            int x = 0;

            //creating a boolean value that will be used to determine if the specified forecast has been found
            bool breakFlag = false;

            //looping through the array of forecasts and testing each one to see if corresponds with both the user's date and city
            while ((myForecasts[x] != null) && (breakFlag == false))
            {
                Forecasts forecast = myForecasts[x];

                if ((forecast.cityCheckSingle(city) == true) && (forecast.dateCheckSingle(date)))
                {
                    //testing to see if the user has entered new values for the forecast and changing them only if they have
                    if ((txtCityNew.Text).Equals(null) == false)
                        forecast.City = txtCityNew.Text;

                    if (forecast.Date != dtmDateNew.Value)
                        forecast.Date = dtmDateNew.Value;

                    if ((txtMinTempNew.Text).Equals(null) == false)
                        forecast.MinTemp = Int16.Parse(txtMinTempNew.Text);

                    if ((txtMaxTempNew.Text).Equals(null) == false)
                        forecast.MaxTemp = Int16.Parse(txtMaxTempNew.Text);

                    if ((txtPrecipitationNew.Text).Equals(null) == false)
                        forecast.Precipitation = Int16.Parse(txtPrecipitationNew.Text);

                    if ((txtHumidityNew.Text).Equals(null) == false)
                        forecast.Humidity = Int16.Parse(txtHumidityNew.Text);

                    if ((txtWindSpeedNew.Text).Equals(null) == false)
                        forecast.WindSpeed = Int16.Parse(txtWindSpeedNew.Text);

                    //changing the boolean to indicate that changes have been made to the specified forecast
                    breakFlag = true;

                    //clearing the display area and writing new text to indicate that the neccessary changes have been made
                    txtDisplay.Clear();
                    txtDisplay.Text += "Forecast updated for " + forecast.City + " on " + (forecast.Date).Date + newLine;

                    //replacing the old forecast with the new one that has the updated attributes
                    myForecasts[x] = forecast;
                    //displaying the updated forecast
                    txtDisplay.Text += forecast.toString();
                }
                //incrementing the loop counter
                ++x;
            }


        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            //creating a boolean to indicate whether the city has been added to the array of cities to view the forecasts for or not
            bool inserted = false;
            int x = 0;

            //finding the next empty cell in the array of cities to view the forecasts for and adding the new city to it
            while (inserted == false)
            {
                //++x;
                if (citiesView[x] == null)
                {
                    citiesView[x] = txtCityView.Text;
                    inserted = true;
                }
                ++x;
            }

            //clearing the display area
            txtDisplay.Clear();

            //looping through the array of cities to view the forecasts for and displaying them in the display area
            int y = 0;
            while (citiesView[y] != null)
            {
                txtDisplay.Text += citiesView[y] + newLine;
                ++y;
            }
        }





    }
}
