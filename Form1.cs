using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;

namespace Steam_Game_Randomizer
{
    public partial class Form1 : Form
    {


        string rootURL = "http://store.steampowered.com/app/";

        string appNumber;
        public Form1()
        {
            InitializeComponent();
        }


   

    private float cost(string url, string xmlString){
        StringBuilder output = new StringBuilder();
        

            //Will store our price string found after our tag searches;
            string nextChars = "";

            //Will store the location of the places each of these are found.
            //We can compare the locations of these to determine which to look at if
            //we find more than one. This will allow us to find the root price and not
            //DLC prices.
            int discountFinalPriceLoc, gamePurchasePriceLoc;
            string discountFinalPriceString = "discount_final_price";
            string gamePurchasePriceString = "game_purchase_price price";

            discountFinalPriceLoc = xmlString.IndexOf(discountFinalPriceString);
            gamePurchasePriceLoc = xmlString.IndexOf(gamePurchasePriceString);


            string priceString = "";

            if (gamePurchasePriceLoc < discountFinalPriceLoc)
            {
                priceString = GetXMLTag(discountFinalPriceString, xmlString);
            }
            else priceString = GetXMLTag(gamePurchasePriceString, xmlString);

            

            foreach (char c in nextChars)
            {
                if (c != '<')
                priceString += c;
                else break;
            }
         
            float price;
            priceString = priceString.Replace("$", "");
            float.TryParse(priceString, out price);
            return price;
            
    }



    string GetXMLTag(string tag, string xmlString) 
    {
        tag += "\">";

        //Read in string and remove any excess whitespace
        xmlString = xmlString.Replace("\t", "");
        xmlString = xmlString.Replace("\r", "");
        xmlString = xmlString.Replace("\n", "");

        string nextChars = "";

        int location = xmlString.IndexOf(tag);

        nextChars = xmlString.Substring(location + tag.Length, 50);

        string resultString = "";

        foreach (char c in nextChars)
        {
            if (c != '<')
            resultString += c;
            else break;
        }
         
        return resultString;

    }


        private void butSearch_Click(object sender, EventArgs e)
        {

            //clear text boxes
            txtAppNums.Text = "";

            Random generator = new Random();

            string fmt = "000000";

            while (true)
            {
                
                long number = generator.Next(30000, 50000);
                number *= 10;
                appNumber = number.ToString(fmt);

                string completeURL = rootURL + appNumber + "/";

                //txtAppNums.Text += appNumber + Environment.NewLine;
                txtAppNums.AppendText(appNumber + Environment.NewLine);
                Refresh();
                lblSearchStatus.Text = "Searching random app numbers...";

                
                try
                {
                    //Creating the HttpWebRequest
                    HttpWebRequest request = WebRequest.Create(completeURL) as HttpWebRequest;
                    //Setting the Request method HEAD, you can also use GET too.
                    request.Method = "HEAD";
                    //Getting the Web Response.
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    
                    //Returns TRUE if the Status code == 200
                    response.Close();
                    //return (response.StatusCode == HttpStatusCode.OK);
                    string responseURI = response.ResponseUri.ToString();
                    if(response.StatusCode == HttpStatusCode.OK && responseURI != "http://store.steampowered.com/"){
                        string xmlString = "";
                        lblSearchStatus.Text = "Getting XML...";
                        Refresh();
                        using (var client = new WebClient())
                                    {
                                        //Read in string and remove any excess whitespace
                                        xmlString = client.DownloadString(completeURL);
                                        xmlString = xmlString.Replace("\t", "");
                                        xmlString = xmlString.Replace("\r", "");
                                        xmlString = xmlString.Replace("\n", "");
                                }
                        if(xmlString.Contains("game_area_description") && xmlString.Contains("About This Game")
                            && !xmlString.Contains("game_area_comingsoon") && !xmlString.Contains("Install Demo")){
                        txtURL.Text = completeURL;
                            if (cost(completeURL, xmlString) <= (float)numMaxPrice.Value);
                            lblSearchStatus.Text = "Getting game data";
                            Refresh();
                            txtGameName.Text = GetXMLTag("apphub_AppName", xmlString);
                            txtPrice.Text = cost(completeURL, xmlString).ToString();
                            lblSearchStatus.Text = "Done";
                            break;
                        }
                    }
                }
                catch
                {
                    //Any exception will returns false.
                    //return false;
                }
            }
        }

        private void butVisitSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtURL.Text);
        }
    }
}
