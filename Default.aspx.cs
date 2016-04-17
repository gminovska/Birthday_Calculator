using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    /*This is a multiline comment. It's a good idea
    to put a header comment for every class */


    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        GetTimeTillBirthday();
    }

    protected void GetTimeTillBirthday()
    {
        DateTime birthDay;
        

        if (Calendar1.SelectedDate == null)
        {
            birthDay = DateTime.Now;
        }
        else
        {
            birthDay = Calendar1.SelectedDate;
        }
        Response.Write(birthDay); //writes out the selected date
        string name = Name.Text;  //stores the user input from the Name textbox into a variable 

        //this calculates the time until the birthday 
        TimeSpan daysUntilBirthday = birthDay.Subtract(DateTime.Now);
        ResultLabel.Text =name + ", you have " + daysUntilBirthday.Days.ToString() +
            " days until your birthday " + ". And this many hours " + daysUntilBirthday.Hours.ToString();





    }
    
    //this method was added to prevent past dates from being selected
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        if(e.Day.Date.CompareTo(DateTime.Now) < 0)
        {
            e.Day.IsSelectable = false;
        }
    }
}
