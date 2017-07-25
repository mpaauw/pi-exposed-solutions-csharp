public static int[] selectionSort(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < input.Length; j++)
        {
            if (input[j] < input[minIndex])
            {
                minIndex = j;
            }
        }
        if (minIndex != i)
        {
            int temp = input[i];
            input[i] = input[minIndex];
            input[minIndex] = temp;
        }
    }
    return input;
}