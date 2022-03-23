using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Analyse
{
	public int[] returnValues;

	public int[] analyseText(string textToAnalyse)
    {
		//creates all the counts
		string search = ".";
		int sentencesCount = 0;
		int vowelsCount = 0;
		int consonantsCount = 0;
		int upperCount = 0;
		int lowerCount = 0;
		int totalCharacters = 0;

		char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

		for (int i = 0; i < textToAnalyse.Length; i++)
		{
			// searches for full stops, which indicate the end of a sentence
			if (textToAnalyse[i] == char.Parse(search))
			{
				sentencesCount++;
			}

			//counts uppercase and lowercase
			bool isUpper = Char.IsUpper(textToAnalyse[i]);
			bool isLower = Char.IsLower(textToAnalyse[i]);
			if (isUpper == true)
			{
				upperCount++;
			}
			else if (isLower == true)
			{
				lowerCount++;
			}
		}

		//counts vowels and consonants
		foreach (char letter in textToAnalyse)
		{
			// checks if the letter is in the vowels list
			if (vowels.Contains(letter))
			{
				vowelsCount++;
			}
			//if not a vowel and a letter, then a consonant
			else if (Char.IsLetter(letter))
			{
				consonantsCount++;
			}
		}

		totalCharacters = vowelsCount + consonantsCount;

		//creates list of analysed values
		int[] returnValues = new int[6];

		returnValues[0] = sentencesCount;
		returnValues[1] = vowelsCount;
		returnValues[2] = consonantsCount;
		returnValues[3] = upperCount;
		returnValues[4] = lowerCount;
		returnValues[5] = totalCharacters;

		return returnValues;

	}
}