public static string convertIntToString(int num)
{
    bool signed = (num < 0) ? true : false;
    StringBuilder builder = new StringBuilder();
    if(num < 0)
    {
        num *= -1;
    }
    while(num > 0)
    {
        int indInt = num % 10;
        builder.Insert(0, (char)(indInt + '0'));
        num /= 10;
    }
    if (signed)
    {
        builder.Insert(0, '-');
    }
    return builder.ToString();
}

public static int convertStringToInt(string str)
{
    char[] strCharArr = str.ToCharArray();
    bool signed = (strCharArr[0] == '-') ? true : false;
    int finalInt = 0;
    int power = 1;
    for(int i = strCharArr.Length - 1; i >= 0; i--)
    {
        if(strCharArr[i] == '-')
        {
            continue;
        }
        int actualInt = strCharArr[i] - '0';
        finalInt += actualInt * power;
        power *= 10;
    }
    if (signed)
    {
        finalInt *= -1;
    }
    return finalInt;
}