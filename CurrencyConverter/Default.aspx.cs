using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CurrencyConverter
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            decimal conversion = 0;
            imgGraph.Visible = false;
            //check if user input can be converted and is positive (greater than 0)
            //if the user input can't be converted or is less than 0
            if ((!decimal.TryParse(txbxAmount.Text, out decimal usd)) || (usd < 0))
            {
                //Controls have access to its CSS attributes through its Style collection
                lblResult.Style["color"] = "Red";
                lblResult.Text = "Only positive numbers allowed! Try again...";
                return;
            }
            else
            {
                lblResult.Style["color"] = "black";
                lblResult.Text = "";
            }

            switch (DropDownList1.SelectedIndex)
            {
                //case 0 is a blank value
                case 1: //Euro Dollar
                    conversion = usd * .82M;    // the 'M' is used to implicate that we are dealing with decimal values
                    break;
                case 2: //Japanese Yen
                    conversion = usd * 103.94M;
                    break;
                case 3: //Great British Pound
                    conversion = usd * 0.7370M;
                    break;
                case 4: //Canadian Dollar
                    conversion = usd * 1.269M;
                    break;
            }
            //lblResult.Style["color"] = "black";
            lblResult.Text = usd.ToString("c") + " USD = " + conversion.ToString("c")
                + " " + DropDownList1.SelectedValue;
        }

        protected void btnShowGraph_Click(object sender, EventArgs e)
        {
            imgGraph.ImageUrl = "/Images/chart" + DropDownList1.SelectedIndex.ToString() 
                + ".PNG";
            imgGraph.Visible = true;
        }
    }
}