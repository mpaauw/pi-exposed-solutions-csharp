public static void combinationsOfString(string str)
{
    printCombinations(0, new StringBuilder(), str.ToCharArray());
}

private static void printCombinations(int start, StringBuilder printer, char[] charArr)
{
    for (int i = start; i < charArr.Length; i++)
    {
        printer.Append(charArr[i]);
        System.Diagnostics.Debug.WriteLine(printer);
        printCombinations(i + 1, printer, charArr);
        printer.Remove(printer.Length - 1, 1);
    }
}