class Program
{

    public static void Main(string[] args)
    {
        string[] times = Console.ReadLine().Split(' ');
        int row = int.Parse(times[0]);
        int column = int.Parse(times[1]);

        int[,] from = MakeIntArray(row, column);
        int[,] to = MakeIntArray(row, column);

        int count = 0;

        for (int i = 0; i <= row - 3; i++)
        {
            for (int j = 0; j <= column - 3; j++)
            {
                if (from[i, j] != to[i, j])
                {
                    Flip(from, i, j);
                    count++;
                }
            }
        }

        if (CheckSame(from, to))
        {
            Console.WriteLine(count);

        }
        else
        {
            Console.WriteLine("-1");
        }
    }


    static bool CheckSame(int[,] from, int[,] to)
    {
        for (int i = 0; i < from.GetLength(0); i++)
        {
            for (int j = 0; j < from.GetLength(1); j++)
            {
                if (from[i, j] != to[i, j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    static int[,] Flip(int[,] intArray, int x, int y)
    {
        for (int i = x; i < x + 3; i++)
        {
            for (int j = y; j < y + 3; j++)
            {
                intArray[i, j] = 1 - intArray[i, j];
            }
        }

        return intArray;
    }

    static int[,] MakeIntArray(int row, int column)
    {
        int[,] intArray = new int[row, column];
        for (int i = 0; i < row; i++)
        {
            string row_str = Console.ReadLine();
            for (int j = 0; j < column; j++)
            {
                intArray[i, j] = row_str[j] - '0';
            }
        }
        return intArray;
    }

}