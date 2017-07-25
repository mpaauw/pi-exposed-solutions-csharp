public static int[] quickSort(int[] input)
{
    sort(input, 0, input.Length - 1);
    return input;       
}

private static void sort(int[] input, int start, int end)
{
    if(start < end)
    {
        int p = partition(input, start, end);
        sort(input, start, p - 1);
        sort(input, p + 1, end);
    }
}

private static int partition(int[] input, int start, int end)
{
    int pivot = input[end];
    int pIndex = start;
    for (int i = start; i < end; i++)
    {
        if (input[i] <= pivot)
        {
            int tempInner = input[pIndex];
            input[pIndex] = input[i];
            input[i] = tempInner;
            pIndex += 1;
        }
    }
    int temp = input[pIndex];
    input[pIndex] = input[end];
    input[end] = temp;
    return pIndex;
}