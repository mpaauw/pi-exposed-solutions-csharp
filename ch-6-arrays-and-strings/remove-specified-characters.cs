public static string removeCharacters(string str, string remove) {
    bool[] asciiMap = new bool[128];
    char[] remCharArr = remove.ToCharArray();
    for(int i = 0; i< remCharArr.Length; i++) {
        asciiMap[remCharArr[i]] = true;
    }
    StringBuilder builder = new StringBuilder();
    char[] strCharArr = str.ToCharArray();
    for(int i = 0; i < strCharArr.Length; i++) {
        if(!asciiMap[strCharArr[i]]) {
            builder.Append(strCharArr[i]);
        }
    }
    return builder.ToString();
}