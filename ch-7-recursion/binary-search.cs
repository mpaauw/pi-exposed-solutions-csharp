public static int binarySearch(int[] sortedArray, int value)
{
    return recurseArray(sortedArray, 0, sortedArray.Length, value);
}

private static int recurseArray(int[] arr, int start, int end, int searchVal)
{
    int currentIndex = (end + start) / 2;
    if (arr[currentIndex] == searchVal)
    {
        return currentIndex;
    }
    if (searchVal < arr[currentIndex])
    {
        end = currentIndex;
        return recurseArray(arr, start, end, searchVal);
    }
    else
    {
        start = currentIndex;
        return recurseArray(arr, start, end, searchVal);
    }
}