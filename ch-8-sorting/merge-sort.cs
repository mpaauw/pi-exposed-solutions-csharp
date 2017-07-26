public static int[] mergeSort(int[] input)
{
    if (input.Length < 2)
    {
        return input;
    }

    int midIndex = (input.Length / 2) - 1;

    int[] leftArr = new int[input.Length / 2];
    Array.Copy(input, 0, leftArr, 0, leftArr.Length);

    int[] rightArr = new int[input.Length - leftArr.Length];
    Array.Copy(input, midIndex + 1, rightArr, 0, rightArr.Length);

    leftArr = mergeSort(leftArr);
    rightArr = mergeSort(rightArr);

    int[] sortedArr = new int[input.Length];

    return merge(sortedArr, leftArr, rightArr);
}

private static int[] merge(int[] sortedArr, int[] leftArr, int[] rightArr)
{
    int l = 0, r = 0, d = 0;

    while (l < leftArr.Length && r < rightArr.Length)
    {
        if (leftArr[l] <= rightArr[r])
        {
            sortedArr[d++] = leftArr[l++];
        }
        else if (leftArr[l] > rightArr[r])
        {
            sortedArr[d++] = rightArr[r++];
        }
    }

    while (l < leftArr.Length)
    {
        sortedArr[d++] = leftArr[l++];
    }

    while (r < rightArr.Length)
    {
        sortedArr[d++] = rightArr[r++];
    }

    return sortedArr;
}