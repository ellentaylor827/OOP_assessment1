//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            string enterOrRead;
            Console.WriteLine("do you want to enter text via the keyboard (enter), or read from a text file(read): ");
            enterOrRead = Console.ReadLine();
            if (enterOrRead == "enter")
            {
                Console.WriteLine("enter text");
            }
            else if (enterOrRead == "read")
            {
                Console.WriteLine("read text");
            }
            else
            {
                Console.WriteLine("invalid input");
            }

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }



    }
}
