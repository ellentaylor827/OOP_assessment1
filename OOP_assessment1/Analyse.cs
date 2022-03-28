using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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

	//encapsulation so it can only be accessed by this class
	private string removePunctuation(string textToAnalyse)
    {
		char[] punctuation = { '.', ',', '!', '/', '\'', '*', ' ' };

		//replaces all punctation which whitespace so it isn't counted
		foreach (char character in textToAnalyse)
		{
			if (punctuation.Contains(character))
			{
				textToAnalyse = textToAnalyse.Replace(character, ' ');
			}
		}
		return textToAnalyse;
	}

	public void longWords(string textToAnalyse)
    {
		textToAnalyse = removePunctuation(textToAnalyse);

		char[] whitespace = new char[] { ' ', '\t' };//identifies all whitespace in the text
		string[] listOfWords = textToAnalyse.Split(whitespace);//seperates the words in the string by the whitespace

		List<string> allLongWords = new List<string>();

		foreach (string word in listOfWords)
        {
			if (word.Length >= 7) //if a word is longer than 7 characters then it is considered a long word
            {
				allLongWords.Add(word);
            }
        }

		File.WriteAllLines("allLongWords.txt", allLongWords);
		string path = Path.GetFullPath("allLongWords.txt");
		string readLong = File.ReadAllText(path);
		Console.WriteLine("Long Words:" + readLong);
	}

	public void frequencyOfLetters(string textToAnalyse)
    {

		textToAnalyse = removePunctuation(textToAnalyse);

		Dictionary<char, int> characterCount = new Dictionary<char, int>();// creates a dictionary to store the charcater and frequency
		foreach (char character in textToAnalyse)
		{
			if (Char.IsLetter(character))
            {
				if (characterCount.ContainsKey(character))//if the character is already in the list, it adds to the count
				{
					characterCount[character]++;
				}
				else
				{
					characterCount[character] = 1;//if it's not already in the list, the count starts at 1
				}
            }
			
		}

		//prints all the characters and counts
		foreach (KeyValuePair<char, int> pair in characterCount)
        {
			Console.WriteLine("Letter = {0}, Count = {1}", pair.Key, pair.Value);
        }
	}

}