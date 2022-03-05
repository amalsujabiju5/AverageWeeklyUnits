///Author:AMAL  SUJA BIJU
///Date Created:03/3/2022
///Description:This app will  take input from the user by Region wise and show the average of the region and overall average of the regions
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageWeeklyUnit
{
    public partial class AverageWeeklyUnitForm : Form
    {
        private int[,] unitArray = new int[3, 7];
        private int region = 0, day = 0;
        public AverageWeeklyUnitForm()
        {
            InitializeComponent();
        }
/// <summary>
/// This will fill the region1 for the richbox
/// </summary>
        private void populateRegion1()
        {
            richTextRegion1.Text = "";
            for (int i = 0; i < (region > 0 ? 7 : day); i++)
            {
                richTextRegion1.Text += unitArray[0, i].ToString() + "\n";
            }
        }

        /// <summary>
        /// This will fill the region2 for the richbox
        /// </summary>
        private void populateRegion2()
        {
            richTextRegion2.Text = "";
            for (int i = 0; i < (region > 1 ? 7 : day); i++)
            {
                richTextRegion2.Text += unitArray[1, i].ToString() + "\n";
            }
        }

        /// <summary>
        /// This will fill the region3 for the richbox
        /// </summary>
        private void populateRegion3()
        {
            richTextRegion3.Text = "";
            for (int i = 0; i < (region > 2 ? 7 : day); i++)
            {
                richTextRegion3.Text += unitArray[2, i].ToString() + "\n";
            }
        }

       /// <summary>
       /// Calculating the average for the region1
       /// </summary>
       
        private double calculateAverageRegion1()
        {
            int sum = 0;
            for (int i = 0; i < 7; i++)
            {
                sum += unitArray[0, i];
            }
            double average = sum / 7;
            textAverage1.Text = average.ToString("F2");
            return average;
        }
        /// <summary>
        /// Calculating the average for the region2
        /// </summary>

        private double calculateAverageRegion2()
        {
            int sum = 0;
            for (int i = 0; i < 7; i++)
            {
                sum += unitArray[1, i];
            }
            double average = sum / 7;
            textAverage2.Text = average.ToString("F2");
            return average;
        }
        /// <summary>
        /// Calculating the average for the region3
        /// </summary>

        private double calculateAverageRegion3()
        {
            int sum = 0;
            for (int i = 0; i < 7; i++)
            {
                sum += unitArray[2, i];
            }
            double average = sum / 7;
            textAverage3.Text = average.ToString("F2");
            return average;
        }

   /// <summary>
   /// This will calculate the overall for the three region
   /// </summary>
        private void calculateFinalAverage()
        {
            double finalSum = calculateAverageRegion1() + calculateAverageRegion2() + calculateAverageRegion3();
            double finalAverage = finalSum / 3;
            textOverAllAverage.Text = finalAverage.ToString("F2");
        }
        /// <summary>
        /// Reseting the form 
        /// </summary>
        private void resetForm()
        {
            // clear array and reset region and day variable
            Array.Clear(unitArray, 0, unitArray.Length);
            region = 0;
            day = 0;

            //to clear the average, errors and overall average
            labelErrors.Text = "";
            textAverage1.Text = "";
            textAverage2.Text = "";
            textAverage3.Text = "";
            textBoxInput.Text = "";
            textOverAllAverage.Text = "";

            // This will remove the entries from the region
            populateRegion1();
            populateRegion2();
            populateRegion3();

            //enable enter button
            buttonEnter.Enabled = true;
            // make input true
            textBoxInput.ReadOnly = false;
        }
        /// <summary>
        /// function will be executed when the reset button is clicked
        /// </summary>
       
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();

        }

        /// <summary>
        /// function will be executed when the exit button is clicked
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AverageWeeklyUnitForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// function will be executed when the enter button is clicked
        /// </summary>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // empty error
            labelErrors.Text = "";
            // checking  for null
            if (string.IsNullOrEmpty(textBoxInput.Text))
            {
                labelErrors.Text = "Cases can not be empty!";
                return;
            }

            //checking  for if there is any negetive value
            int cases = -1;
            if(int.TryParse(textBoxInput.Text, out cases))
            {
                if (cases <= -1)
                {
                    labelErrors.Text = "Cases must be a positive number!";
                    textBoxInput.SelectAll();
                    return;
                }
            }
            else
            {
                labelErrors.Text = "Cases must be a numeric. Please try again!";
                textBoxInput.SelectAll();
                return;
            }   
                
            //checking the range
            if (region < 3 && day < 7)
            {
                unitArray[region, day] = Convert.ToInt32(textBoxInput.Text);
            }

            // increment by day and region
            day++;
            if (day == 7)
            {
                day = 0;
                region++;
            }

            // Populate required regions
            if (region >= 0)
            {
                populateRegion1();

            }
            if (region >= 1)
            {
                populateRegion2();

            }
            if (region >= 2)
            {
                populateRegion3();
            }

            /// calculate the average and overall average 
            ///
            if (region > 0)
            {
                calculateAverageRegion1();
            }
            if (region > 1)
            {
                calculateAverageRegion2();
            }
            if (region > 2)
            {
                calculateAverageRegion3();
                calculateFinalAverage();
                buttonEnter.Enabled = false;
                textBoxInput.Clear();
                textBoxInput.ReadOnly = true;
            }

            textBoxInput.Clear();
        }
    }
}
