//Grading ID: C4517
//Program 1
//Due Date: 9-25-18
//CIS 199-75
//This program is disigned to determiine how many gallons of paint someone would need to buy based on the measurements of the room. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;//This is the length the user inputs.
            double height;//This is the height the user inputs.
            double doors;//This is the number of doors entered by the user.
            const int DOORS = 20;//This is the constant measurement of the doors.
            double windows;//This is the munber of windows entered by the user.
            const int WINDOWS = 15;//This is the constant measurement of the windows.
            double coats;//This is the number of coats of paint the user intends to use.
            double minGallons;//The minimum number of gallons the user needs.
            double gallonsToBuy;//The actual amount of gallons the user will have to buy.
            const int COAT_FEET = 385;//This is where the amount of feet can be covered by one coat of paint is declared.
           

            Console.WriteLine("Welcome to the Handy-Dandy Paint Estimator");//The opening line in the program.
            Console.WriteLine("");//This is where there is a line skipped between the title and where the user inputs variables.
            Console.Write("Enter the total length of all walls (in feet): ");//This is the Line where the user inputs the length of the walls.
            length = double.Parse(Console.ReadLine());//This is where the length is able to be an input by the user. 
            Console.Write("Enter the height of the walls (in feet): ");//This is where the user inputs the height of the walls.
            height = double.Parse(Console.ReadLine());//This is where the height of the walls is giving the ability to be entered by the user.
            Console.Write("Enter the number of doors (non-neg int): ");//This is where the user inputs the number of doors.
            doors = int.Parse(Console.ReadLine());//This gives the number of doors the ability to be input by the user.
            Console.Write("Enter the number of windows (non-neg int): ");//This is where the user inputs the number of windows.
            windows = double.Parse(Console.ReadLine());//This is where the number of windows is given the ability to be input by the user. 
            Console.Write("Enter the number of coats of paint (non-neg int): ");//This is where the user inputs the number of coats of paint they want to apply.
            coats = double.Parse(Console.ReadLine());//This is where the number of coats is given the ability to be input by the user.
            Console.WriteLine("");//This is where there is a gap between where the user inputs variables and the program outputs what the user wants.

            minGallons = (length * height - doors * DOORS - windows * WINDOWS) * (coats) / COAT_FEET;//This is where the minimum number of gallons is calculated.
            gallonsToBuy = (int)Math.Ceiling(minGallons);//This is where the actual amount of gallons to be bought is calculated.

            Console.WriteLine($"You will need a minimum of {minGallons:F1} gallons of paint");//This is where the minimum number of gallons is displayed to the user.
            Console.WriteLine($"You'll need to buy {gallonsToBuy} gallons, though");//This is where the actual amount of gallons the user needs to buy is displayed to the user. 

            

        }
    }
}
