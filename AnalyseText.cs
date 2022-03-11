using System;
using System.Collections.Generic;
using System.Text;

public class AnalyseText
{

	public void countSentences(string textToAnalyse)
	{
		string search = ".";
		int count = 0;
		for (int i = 0; i < textToAnalyse.Length; i++)
		{
			if (textToAnalyse[i] == char.Parse(search))
			{
				count++;

			}
		}
		Console.WriteLine("Amount of sentences: " + count);

	}

	public void countVowels(string textToAnalyse)
	{
		int vowelsCount = 0;
		string textLower = textToAnalyse.ToLower();

		string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U"};
		for (int i = 0; i < textToAnalyse.Length; i++)
        {
			foreach (string letter in vowels)
			{
				char letterToCompare = char.Parse(letter);
				if (letterToCompare == textToAnalyse[i])
				{
					vowelsCount++;
				}

			}
        }
		Console.WriteLine("Amount of vowels: " + vowelsCount);
	}

	public void countConsonants(string textToAnalyse)
    {
		int consonantsCount = 0;
		string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

		for (int i = 0; i < textToAnalyse.Length; i++)
		{
			bool isVowel = false;
			foreach (string letter in vowels)
			{
				if (textToAnalyse[i] == char.Parse(letter))
				{
					isVowel = true;
					break;
				}
			}

			if (Char.IsLetter(textToAnalyse[i]) && isVowel == false)
			{
				consonantsCount++;
			}
		}
		Console.WriteLine("Amount of consonants: " + consonantsCount);
	}


	public void countUpper(string textToAnalyse)
	{
		int upperCount = 0;
		for (int i = 0; i < textToAnalyse.Length; i++)
        {
			bool isUpper = Char.IsUpper(textToAnalyse[i]);
			if (isUpper == true)
            {
				upperCount++;
            }

		}
		Console.WriteLine("Amount of uppercase: " + upperCount);
	}

	public void countLower(string textToAnalyse)
	{
		int lowerCount = 0;
		for (int i = 0; i < textToAnalyse.Length; i++)
		{
			bool isLower = Char.IsLower(textToAnalyse[i]);
			if (isLower == true)
			{
				lowerCount++;
			}

		}
		Console.WriteLine("Amount of lowercase: " + lowerCount);
	}
}
