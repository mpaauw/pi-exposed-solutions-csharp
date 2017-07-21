public static void printPermutations(string str)
{
    permute(new bool[str.Length], new StringBuilder(), str.ToCharArray());
}

private static void permute(bool[] used, StringBuilder printer, char[] charArr)
{
    if (printer.Length == charArr.Length)
    {
        System.Diagnostics.Debug.WriteLine(printer);
        return;
    }
    for (int i = 0; i < charArr.Length; ++i)
    {
        if (used[i])
        {
            continue;
        }
        printer.Append(charArr[i]);
        used[i] = true;
        permute(used, printer, charArr);
        used[i] = false;
        printer.Remove(printer.Length - 1, 1);
    }
}