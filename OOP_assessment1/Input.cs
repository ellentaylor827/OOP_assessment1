using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP_assessment1
{
    class Input
    {
        public string inputText()
        {
            //allows the user to input text to be analysed
            bool endOfText = false;
            List<string> inputtedText = new List<string>(); //contains all inputted text to be analysed
            while (endOfText == false)
            {
                Console.WriteLine("enter text, end with * to stop inputting");
                string userText = Console.ReadLine();
                inputtedText.Add(userText); //adds the input to all the inputted text
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

            return textToAnalyse;
        }
        public string textFileRead()
        {
            //takes a file directory and analyses the text
            string text = " ";
            bool valid = false;
            while (valid == false)
            {
                Console.WriteLine("input file directory: ");
                string fileDirectory = Console.ReadLine();
                //error handling - allows another input if the directory is incorrect
                try
                {
                    text = File.ReadAllText(fileDirectory); //locates the text file for reading
                    valid = true;
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("invalid file directory, input again: ");
                }
            }
            
            Console.WriteLine(text);
            string textToAnalyse = text;

            return textToAnalyse;
        }
    }
}
