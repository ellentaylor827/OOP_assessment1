using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_assessment1
{
    class Results
    {
        public void printResults(int[] returnedValues)
        {
            //prints out all the results
            Console.WriteLine("Number of sentences:" + returnedValues[0]);
            Console.WriteLine("Number of vowels:" + returnedValues[1]);
            Console.WriteLine("Number of consonants:" + returnedValues[2]);
            Console.WriteLine("Number of uppercase:" + returnedValues[3]);
            Console.WriteLine("Number of lowercase:" + returnedValues[4]);
            Console.WriteLine("Number of total characters:" + returnedValues[5]);

        }
    }
}
