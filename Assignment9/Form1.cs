using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayuCarRental
{
    //Create a Form for a car rental company and set the form text property to Car Rental and the form backcolor to GradientInactiveCaption.
    //Each button will have a Light Cyan backcolor property.
    public partial class Form1 : Form
    {
        DateTime dateStart = new DateTime();
        DateTime dateEnd = new DateTime();
        TimeSpan dayDiff;
        string carTypeSelected;
        public Form1()
        {
            InitializeComponent();

        }

        private void BtnExit(object sender, EventArgs e)
        {
            //Add an Exit button that will close the application.
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Allow the user to select from a list of car styles:  Compact, Standard, or Luxury.
            modelList.Items.Add("Compact");
            modelList.Items.Add("Standard");
            modelList.Items.Add("Luxury");
            this.Controls.Add(modelList);
            
        }
        //Add a Selection Complete button.
        //After these two selections are made, the user will click the Selection Complete button 
        //that will compute the total price of rental. 
        private void BtnSelection_Click(object sender, EventArgs e)
        {
            //The number of days that the customer will have the car will be determined by
            //the difference between the current date and the future date selected on the calendar.
            int dayDiffInt = Convert.ToInt32(dayDiff.TotalDays);
            if (dayDiffInt < 0)
            {
                MessageBox.Show("Incorrect Day selected! You can choose a day in the past!");
                dayDiffInt = 0;
            }
            //The total price will be the number of computed rental days times the cost for the model of car selected
            //($19.95/day for Compact, $24.95/day for Standard and $39/day for Luxury).
            double totalRentalPrice;
            if (carTypeSelected == "Compact")
            {
                Compact car1 = new Compact(dayDiffInt);
                totalRentalPrice = car1.Total();
            }
            else if (carTypeSelected == "Standard")
            {
                Standard car2 = new Standard(dayDiffInt);
                totalRentalPrice = car2.Total();
            }
            else if(carTypeSelected == "Luxury")
            {
                Luxury car3 = new Luxury(dayDiffInt);
                totalRentalPrice = car3.Total();
            }
            else
            {
                totalRentalPrice = 0;
            }
            //Display the Number of Rental Days: and Total Price is: values on the form in two separate non-updateable controls.
            totalDays.Text = Convert.ToString(dayDiffInt);
            totalCost.Text = totalRentalPrice.ToString("C2");
        }
        
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //Use a calendar that defaults to the current day and allows the user to select a future date when the car will be returned.
            dateStart = DateTime.Today;
            dateEnd = e.End.Date;
            dayDiff = dateEnd.Subtract(dateStart);
        }

        private void modelList_Click(object sender, EventArgs e)
        {
            carTypeSelected = modelList.SelectedItem.ToString();
        }
    }
}
