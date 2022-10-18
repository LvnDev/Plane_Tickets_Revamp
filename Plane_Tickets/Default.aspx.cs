using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Plane_Tickets
{
    public partial class Default : System.Web.UI.Page
    {
        double[,] priceGrid;
        protected void Page_Load(object sender, EventArgs e)
        {
            

            string[] cities = new string[4]; //4 arrays of cities
            cities[0] = "London"; //london
            cities[1] = "Paris"; // paris
            cities[2] = "Riga"; // Riga
            cities[3] = "Madrid"; // Madrid

            priceGrid = new double[4, 4];
            //0 London
            //1 Paris
            //2 Riga
            //3 Madrid
            priceGrid[0, 1] = 35.0; //London
            priceGrid[0, 2] = 45.99;
            priceGrid[0, 3] = 49.99;

            priceGrid[1, 0] = 35.0; //Paris
            priceGrid[1, 2] = 40.0;
            priceGrid[1, 3] = 44.99;

            priceGrid[2, 0] = 45.99; //Riga
            priceGrid[2, 1] = 40.0;
            priceGrid[2, 3] = 55.0;

            priceGrid[3, 0] = 49.99; //Madrid
            priceGrid[3, 1] = 44.99;
            priceGrid[3, 2] = 55.0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    resultLabel.Text += cities[i] + " To " + cities[j] + " £" +  priceGrid[i, j].ToString() + "<br>" + "<br>";
                }
            }    
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            int fromCity;
            if (fromLondon.Checked) fromCity = 0;
            else if (fromParis.Checked) fromCity = 1;
            else if (fromRiga.Checked) fromCity = 2;
            else fromCity = 3;

            int toCity;
            if (toLondon.Checked) toCity = 0;
            else if (toParis.Checked) toCity = 1;
            else if (toRiga.Checked) toCity = 2;
            else toCity = 3;

            resultLabel.Text = " £" + priceGrid[fromCity, toCity].ToString();

            if (returnCheckBox.Checked)
            {
                double times2 = priceGrid[toCity, fromCity] + priceGrid[toCity, fromCity];
                resultLabel.Text = " £" + times2.ToString();
            }

            if (fromCity == toCity)
            {
                resultLabel.Text = "ERROR! Please Select 2 cities thar are not the same.";
                return;
            }

        }
    }
}