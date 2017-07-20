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

public static int convertStringToInt(string str) {
    int[] asciiMap = new int[129];
    for(int i = 0; i < asciiMap.Length; i++) {
        asciiMap[i] = -1;
    }
    char[] strCharArr = str.ToCharArray();
    boolean signed = (strCharArr[0] == '-') ? true : false;
    int size = 0;
    if(signed) {
        size = strCharArray.Length - 1;
    }
    else {
        size = strCharArray.Length;
    }
    int power = 10 * (size - 1);
    int finalInt = 0;
    for(int i = 0; i < strCharArr.Length; i++) {
        if(strCharArr[i] == '-') {
            continue;
        }
        int workingIndex = 0;
        asciiMap[strCharArr[i]] = 0;
        for(int k = 0; k < asciiMap.Length; k++) {
            if(asciiMap[k] == 0) {
                workingIndex = k;
                asciiMap[k] = -1;
                break;
            }
        }
        int actualInt = workingIndex - 30;
        finalInt += actualInt * power;
        power /= 10;
    }
    if(signed) {
        finalInt *= -1;
    }
    return finalInt;
}