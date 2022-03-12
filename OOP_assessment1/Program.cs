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
            string enterOrRead; // allows the player to choose to either enter text to analyse, or to analyse text from a given text file
            Console.WriteLine("do you want to enter text via the keyboard (enter), or read from a text file(read): ");
            enterOrRead = Console.ReadLine();
            if (enterOrRead == "enter")
            {
                bool endOfText = false;
                List<string> inputtedText = new List<string>(); //contains all inputted text to be analysed
                while (endOfText == false)
                {
                    Console.WriteLine("enter text, end with * to stop inputting");
                    string userText = Console.ReadLine();
                    inputtedText.Add(userText);
                    char checkAsterix = userText[userText.Length - 1]; // check for the * to indicate the end of input
                    string checkAsterixs = checkAsterix.ToString();
                    if (checkAsterixs == "*")
                    {
                        endOfText = true;
                    }
                }
                string textToAnalyse = "";
                foreach (string item in inputtedText)
                {
                    textToAnalyse = textToAnalyse + item; // puts all inputted text into one string
                }

                //creates a new instance and uses the AnalyseText class
                AnalyseText analyseAll = new AnalyseText();
                analyseAll.countSentences(textToAnalyse);
                analyseAll.countVowels(textToAnalyse);
                analyseAll.countConsonants(textToAnalyse);
                analyseAll.countUpper(textToAnalyse);
                analyseAll.countLower(textToAnalyse);
            }
            else if (enterOrRead == "read")
            {
                string text = File.ReadAllText(@"C:\Users\ellen\Documents\Uni\OOP_assessment1\readFile.txt"); //locates the text file for reading
                Console.WriteLine(text);
                string textToAnalyse = text;

                //creates a new instance and uses the AnalyseText class
                AnalyseText analyseAll = new AnalyseText();
                analyseAll.countSentences(textToAnalyse);
                analyseAll.countVowels(textToAnalyse);
                analyseAll.countConsonants(textToAnalyse);
                analyseAll.countUpper(textToAnalyse);
                analyseAll.countLower(textToAnalyse);
            }
            else
            {
                //if the user doesn't input enter or read, it is invalid
                Console.WriteLine("invalid input");
            }
        }



    }
}
