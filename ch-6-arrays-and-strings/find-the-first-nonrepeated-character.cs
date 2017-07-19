public static char findFirstNonrepeatedCharacter(string s)
{
    char[] charArr = s.ToCharArray();
    int[] asciiMap = new int[129];
    for(int i = 0; i < asciiMap.Length; i++) // initialize ascii map with default values
    {
        asciiMap[i] = -1;
    }
    for (int i = 0; i < charArr.Length; i++) // iterate through character array, populate ascii map with actual data
    {
        int charIndex = charArr[i];
        if (asciiMap[charIndex] >= 0)
        {
            asciiMap[charIndex] = -2;
        }
        else if (asciiMap[charIndex] == -1)
        {
            asciiMap[charIndex] = i;
        }
    }
    int minLoc = int.MaxValue;
    for (int i = 0; i < asciiMap.Length; i++) // iterate through ascii map, find result (if any)
    {
        if (asciiMap[i] > -1 && asciiMap[i] < minLoc)
        {
            minLoc = asciiMap[i];
        }
    }
    if (minLoc != -1)
    {
        return charArr[minLoc];
    }
    return '\0'; // no solution exists
}