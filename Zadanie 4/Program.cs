int[,] array =
{
    { 1,2,3,4,5 },
    { 6,7,8,9,0 },
    { 10, 11, 12, 13, 14 },
    { 1,3,3,4,5 }
};

FindMostSimilarRows(array, out int row1, out int row2);
Console.WriteLine("Najbardziej zbliżone wiersze: " + row1 + ", " + row2);


void FindMostSimilarRows(int[,] array, out int row1, out int row2)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);
    double minDifference = double.MaxValue;
    row1 = -1;
    row2 = -1;

    for (int i = 0; i < numRows - 1; i++)
    {
        for (int j = i + 1; j < numRows; j++)
        {
            double difference = CalculateRowDifference(array, i, j, numCols);
            if (difference < minDifference)
            {
                minDifference = difference;
                row1 = i;
                row2 = j;
            }
        }
    }
}

double CalculateRowDifference(int[,] array, int row1, int row2, int numCols)
{
    double difference = 0.0;

    for (int k = 0; k < numCols; k++)
    {
        int aik = array[row1, k];
        int ajk = array[row2, k];
        difference += Math.Pow(aik - ajk, 2);
    }

    return difference;
}
