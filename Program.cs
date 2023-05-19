using System;

class Program
{
    static void Main(string[] args)
    {
        int row;
        do
        {
            Console.Write("INPUT\n");
            if (!int.TryParse(Console.ReadLine(), out row))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                continue;
            }

            if (row < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
                continue;
            }

            Console.WriteLine("\nOUTPUT");
            PrintPascalsTriangle(row);
            break;
        } while (true);
    }

    static void PrintPascalsTriangle(int row)
    {
        for (int i = 0; i <= row; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(CalculatePascalValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculatePascalValue(int row, int col)
    {
        if (col == 0 || col == row)
            return 1;

        return CalculatePascalValue(row - 1, col - 1) + CalculatePascalValue(row - 1, col);
    }
}

