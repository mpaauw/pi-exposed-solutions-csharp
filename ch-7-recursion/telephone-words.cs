public class TelephoneNumber
{
    private const int TELEPHONE_NUM_SIZE = 7;
    private int[] number = new int[TELEPHONE_NUM_SIZE];
    private char[] word = new char[TELEPHONE_NUM_SIZE];
    private int wordCount = 0;

    public TelephoneNumber(int[] num)
    {
        this.number = num;
    }

    public void printWords()
    {
        recurse(0);
    }

    private void recurse(int currentDigit)
    {
        if (currentDigit == TELEPHONE_NUM_SIZE)
        {
            wordCount += 1;
            System.Diagnostics.Debug.WriteLine(new string(word) + this.wordCount);
            return;
        }
        for (int i = 0; i < 3; i++)
        {
            word[currentDigit] = getChar(number[currentDigit], i);
            recurse(currentDigit + 1);
            if (number[currentDigit] == 1 || number[currentDigit] == 0)
            {
                return;
            }
        }
    }

    private char getChar(int num, int place)
    {
        string[] keys = { "", "", "abc", "def", "ghi", "jkl", "mno", "prs", "tuv", "wxy" };
        return keys[num][place];
    }
}