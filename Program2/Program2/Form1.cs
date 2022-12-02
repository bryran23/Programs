//Grading ID: C4517
//Program #2
//Due Date: 10/18/2018
//CIS 199-75
//This program takes the user's first letter of their last name and class and tells them the earliest date they can register for spring classes.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string day; //this is the string that takes the namespace of the day.
        string time;//this is the string that takes the namespace of the time.
        char lastname;//this is the veriable for the letter of the lastname. 
        private void submitBtn_Click(object sender, EventArgs e)//submit click event handler.
        {
            //this is where the constants for each day used in this progaram are declared.
            const string DAY1 = "Friday, Nov.2";
            const string DAY2 = "Monday, Nov.5";
            const string DAY3 = "Tuesday, Nov.6";
            const string DAY4 = "Wednesday, Nov.7";
            const string DAY5 = "Thursday, Nov.8";
            const string DAY6 = "Friday, Nov.9";
            //this is where the constants for each time used in this progaram are declared.
            const string TIME2 = "10:00AM";
            const string TIME3 = "11:30AM";
            const string TIME4 = "2:00PM";
            const string TIME1 = "8:30AM";
            const string TIME5 = "4:00PM";

            if (char.TryParse(nameTxt.Text, out lastname))//this is where the input is tested.
            {

                if (char.IsLetter(lastname))//this is where the ltter is taken into the formulas. 
                {

                    lastname = char.ToUpper(lastname);//this is where the letter is made an upper case to fit into the program.
                    if (seniorBtn.Checked || juniorBtn.Checked)//this tests if the senior button or the junior button are checked. 
                    {
                        //this is where the letters of the lastname are tested in order to determine the time the seniors or juniors can register.
                        if (lastname <= 'D')
                            time = TIME5;
                        else if (lastname <= 'I')
                            time = TIME1;
                        else if (lastname <= 'O')
                            time = TIME2;
                        else if (lastname <= 'S')
                            time = TIME3;
                        else
                            time = TIME4;

                        //This determines the days the seniors or juniors can register.
                        if (seniorBtn.Checked)
                            day = DAY1;

                        else
                            day = DAY2;


                    }

                    else if(sophomoreBtn.Checked || freshmanBtn.Checked)//this determines if the sophemore or freshman button are checked.
                    {
                        //This determines the time for the freshman and sophemores by the first letter of their last name
                        if (lastname <= 'B' || (lastname >= 'M' && lastname <= 'O' ))
                            time = TIME4;
                        else if (lastname <= 'D' || (lastname >= 'P' &&lastname <= 'Q'))
                            time = TIME5;
                        else if (lastname <= 'F' || (lastname >= 'R' && lastname <= 'S'))
                            time = TIME1;
                        else if (lastname <= 'I' || (lastname >= 'T' && lastname <= 'V'))
                            time = TIME2;
                        else
                            time = TIME3;

                        //This area determines the days the freshman can register based on their first letter of their last name.
                        if (freshmanBtn.Checked)
                        {
                            if (lastname <= 'Q' && lastname >= 'E')
                                day = DAY5;
                            else
                                day = DAY6;
                        }
                        //This determines the sophemore days they can register by their first letter of their last name.
                        else
                            if (lastname <= 'Q' && lastname >= 'E')
                            day = DAY3;
                        else
                            day = DAY4;

                    }

                }
                //This is where the messagebox is displayed with the day and time based on the information given by the user.
                MessageBox.Show($"{day} at {time}");
                //after the messagebox is exited the focus goes back to where the user inputs a letter and the last letter entered is cleared, also the senior button is givven focus.
                nameTxt.Focus();
                nameTxt.Clear();
                seniorBtn.Focus();
            }
            else
            MessageBox.Show("Enter a character(just one character)");//if the user enters more than one letter or not a character this is displayed. 
            //focus goes back to the user input, user input is cleared, and the senior button gets the focus.
            nameTxt.Focus();
            nameTxt.Clear();
            seniorBtn.Focus();
        }

        private void resetBtn_Click(object sender, EventArgs e)//clears all user input and puts focus on the senior button.
        {
            nameTxt.Focus();
            nameTxt.Clear();
            seniorBtn.Focus();
        }
    }
}
     
 
    




    


        
    
