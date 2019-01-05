public static string[] Permutation(string[] words)
	{
		//validate if an word between spaces are not lower than 3 chars
		for (int index = 0; index < words.Count(); index++)
		{
			if (words[index].Length < 3)
			{
				return words;
			}
		}

		int tmpIndex = 0, wordsCount = words.Count();
		bool ite = false;
		string[] result = new string[wordsCount];
		result[0] = string.Join(" ", words);
		string tmpResult = "";

		for (int searchIndex = 1; searchIndex < wordsCount; searchIndex++)
		{
			ite = false;
			for (int index = searchIndex; index < (wordsCount + searchIndex); index++)
			{
				if (index >= wordsCount)
				{
					tmpIndex = index - wordsCount;
				}
				else
				{
					tmpIndex = index;
				}
				if (ite) tmpResult += " ";
				tmpResult += words[tmpIndex];
				ite = true;
			}
			result[searchIndex] = tmpResult;
			tmpResult = "";
		}
		result = result.Concat(words).ToArray();
		return result;
	}