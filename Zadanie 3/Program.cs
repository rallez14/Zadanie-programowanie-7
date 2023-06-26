int[] numbers = { 1, 4, 7, 2, 9, 5, 3 };
int median = CalculateMedian(numbers);
Console.WriteLine(median);

int CalculateMedian(int[] numbers)
{
    int length = numbers.Length;
    Array.Sort(numbers);

    if (length % 2 == 0)
    {
        int midIndex1 = length / 2 - 1;
        int midIndex2 = length / 2;
        int median = (numbers[midIndex1] + numbers[midIndex2]) / 2;
        return median;
    }
    else
    {
        int midIndex = length / 2;
        int median = numbers[midIndex];
        return median;
    }
}