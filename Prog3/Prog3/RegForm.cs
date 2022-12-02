// Program 3
// CIS 199-75
// Due: 11/8/18
// Grading ID: C4517

// This application calculates the earliest registration date
// and time for an undergraduate student given their class standing
// and last name.
// Decisions based on UofL Spring 2019 Priority Registration Schedule

// Solution 3
// This solution keeps the first letter of the last name as a char
// and uses if/else logic for the times.
// It uses defined strings for the dates and times to make it easier
// to maintain.
// It only uses programming elements introduced in the text or
// in class.
// This solution takes advantage of the fact that there really are
// only two different time patterns used. One for juniors and seniors
// and one for sophomores and freshmen. The pattern for sophomores
// and freshmen is complicated by the fact that certain letter ranges
// get one date and other letter ranges get another date.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        // Find and display earliest registration time
        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            const string SENIORDAY = "November 2"; // 1st day of registration
            const string JUNIORDAY = "November 5"; // 2nd day of registration
            const string SOPH1 = "November 6";     // 3rd day of registration
            const string SOPH2 = "November 7";     // 4th day of registration
            const string FRESH1 = "November 8";    // 5th day of registration
            const string FRESH2 = "November 9";    // 6th day of registration

            
            
            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration
            bool isUpperClass;        // Upperclass or not?
            bool found = false;       // if it is found or not

            lastNameStr = lastNameTxt.Text;
            if (lastNameStr.Length > 0) // Empty string?
            {
                lastNameLetterCh = lastNameStr[0];   // First char of last name

                if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                {
                    lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                    isUpperClass = (seniorRBtn.Checked || juniorRBtn.Checked);

                    // Juniors and Seniors share same schedule but different days
                    if (isUpperClass)
                    {
                        string[] TIME1 = { "4:00 PM", "8:30 AM", "10:00 AM", "11:30 AM", "2:00 PM" };//array for the uppercalssman times
                        char[] NAME1 = {'A','E','J','P','T'};//array for the upper calassman names
                        int index = NAME1.Length - 1;//sets the length to zero
                        if (seniorRBtn.Checked)//senior button checked
                                dateStr = SENIORDAY;
                            else // Must be juniors
                                dateStr = JUNIORDAY;
                           while(index >= 0 && !found)
                             {
                            if (lastNameLetterCh >= NAME1[index])//if the lastname letter is in the index it pulls from the senior names. 
                                found = true;//if input is found it stops
                            else
                                --index;//if not found it continues
                              }
                        if (found)
                            timeStr = TIME1[index];//if found it shows the time based on the name
                        
                    }
                    // Sophomores and Freshmen
                    else // Must be soph/fresh
                    {
                        //string arrays the times for the freshman and sophemores
                        string[] TIME2 = {"2:00 PM","4:00 PM","8:30 AM","10:00 AM","11:30 AM","2:00 PM","4:00 PM","8:30 AM","10:00 AM","11:30 AM"};
                        //char array for the names of freshman and sophemore names
                        char[] NAME2 = {'A','C','E','G','J','M','P','R','T','W'};
                        int index = NAME2.Length - 1;//indx of the name for the lower classmen is set to zero
                        if (sophomoreRBtn.Checked)
                        {

                            // E-Q on one day
                            if ((lastNameLetterCh >= 'E') && // >= E and
                                (lastNameLetterCh <= 'Q'))   // <= Q
                                dateStr = SOPH1;
                            else // All other letters on next day
                                dateStr = SOPH2;

                            while (index >= 0 && !found)//if the index is greater or equal to zero and not found it continues
                            {
                                if (lastNameLetterCh >= NAME2[index])//checks to see if the first letter matches to the lower classman names
                                    found = true;//the letter is found
                                else
                                    --index;//the program continues to look
                            }
                            if (found)
                                timeStr = TIME2[index];//if the letter is found the time will match up

                        }
                        else // must be freshman
                        {
                            // E-Q on one day
                            if ((lastNameLetterCh >= 'E') && // >= E and
                                (lastNameLetterCh <= 'Q'))   // <= Q
                                dateStr = FRESH1;
                            else // All other letters on next day
                                dateStr = FRESH2;

                            while (index >= 0 && !found)//if the index is greater or equal to zero and not found it continues
                            {
                                if (lastNameLetterCh >= NAME2[index])//checks to see if the first letter matches to the lower classman names
                                    found = true;//the letter is found
                                else
                                    --index;//the program continues to look
                            }
                            if (found)
                                timeStr = TIME2[index];//if the letter is found the time will match up
                        }

                        // This block of code is being replaced
                        // by range matching with arrays and loops
                       
                    }

                    // Output results
                    dateTimeLbl.Text = $"{dateStr} at {timeStr}";
                }
                else // First char not a letter
                    MessageBox.Show("Make sure last name starts with a letter");
            }
            else // Empty textbox
                MessageBox.Show("Enter a last name!");
        }
    }
}
