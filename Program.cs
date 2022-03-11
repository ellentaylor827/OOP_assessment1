//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                string text = File.ReadAllText(@"C:\Users\ellen\Documents\Uni\OOP_assessment1\readFile.txt");
                Console.WriteLine(text);
                string textToAnalyse = text;

                AnalyseText analyseAll = new AnalyseText();
                analyseAll.countSentences(textToAnalyse);
                analyseAll.countVowels(textToAnalyse);
                analyseAll.countConsonants(textToAnalyse);
                analyseAll.countUpper(textToAnalyse);
                analyseAll.countLower(textToAnalyse);

            }
            else
            {
                Console.WriteLine("invalid input");
            }
            //TO ADD: Get the frequency of individual letters?


        }



    }
}
