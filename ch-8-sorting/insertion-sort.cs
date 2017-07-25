public static int[] insertionSort(int[] input)
{
    for (int i = 0; i < input.Length - 1; i++)
    {
        int j = i + 1;
        while ((j > 0) && (input[j] < input[j - 1]))
        {
            int temp = input[j - 1];
            input[j - 1] = input[j];
            input[j] = temp;
            j -= 1;
        }
    }
    return input;
}