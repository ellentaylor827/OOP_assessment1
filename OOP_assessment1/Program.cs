//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OOP_assessment1;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            string enterOrRead; // allows the player to choose to either enter text to analyse, or to analyse text from a given text file
            bool valid = false; // checks for a valid user input
            string textToAnalyse = " ";
            bool readFile = false;
            Input textInput = new Input();

            while (valid == false)
            {
                Console.WriteLine("do you want to enter text via the keyboard (enter), or read from a text file(read): ");
                enterOrRead = Console.ReadLine();
                if (enterOrRead == "enter")
                {
                    //creates an InputText object to allow the user to input text
                    string text = textInput.inputText();
                    textToAnalyse = text;
                    valid = true;
                }
                else if (enterOrRead == "read")
                {
                    string text = textInput.textFileRead();
                    textToAnalyse = text;
                    valid = true;
                    readFile = true;
                }
                else
                {
                    //if the user doesn't input enter or read, it is invalid
                    Console.WriteLine("invalid input");
                }
            }

            //creates a new instance and uses the AnalyseText class
            Analyse analyseAll = new Analyse();
            int[] returnedResults = analyseAll.analyseText(textToAnalyse);
            if (readFile == true)
            {
                analyseAll.longWords(textToAnalyse); // only finds long words if reading from the text file
            }
            else
            {
                analyseAll.frequencyOfLetters(textToAnalyse); // only finds frequency of letters if text is inputted
            }

            //creates a results object to print out all the results
            Results getResults = new Results();
            getResults.printResults(returnedResults);
        }
    }
}
