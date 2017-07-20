 public static string reverseWords(string str)
{
    StringBuilder builder = new StringBuilder();
    StringBuilder subBuilder = new StringBuilder();
    char[] charArr = str.ToCharArray();
    for (int i = 0; i < charArr.Length; i++)
    {
        if (charArr[i] != ' ')
        {
            subBuilder.Append(charArr[i]);
        }
        else
        {
            builder.Insert(0, subBuilder);
            if (i != charArr.Length - 1)
            {
                builder.Insert(0, " ");
            }
            subBuilder.Clear();
        }
    }
    builder.Insert(0, subBuilder);
    return builder.ToString();
}