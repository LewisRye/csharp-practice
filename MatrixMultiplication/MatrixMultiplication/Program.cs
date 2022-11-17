using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            int columns;

            // FIRST MATRIX
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("How many rows in the first matrix?: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many columns in the first matrix?: ");
            columns = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            double[,] matrix1 = new double[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                Console.Write($"Enter the values of row {row + 1} (separated by spaces): ");
                string userInput = Console.ReadLine();

                string[] splitInput = userInput.Split(null);

                for (int column = 0; column < columns; column++)
                {
                    matrix1[row, column] = Convert.ToInt32(splitInput[column]);
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nHere is your first matrix:\n");
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Console.Write($"{matrix1[x,y]} ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            // SECOND MATRIX

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("How many rows in the second matrix?: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many columns in the second matrix?: ");
            columns = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            double[,] matrix2 = new double[rows, columns]; // ROWS then COLUMNS

            for (int row = 0; row < rows; row++)
            {
                Console.Write($"Enter the values of row {row + 1} (separated by spaces): ");
                string userInput = Console.ReadLine();

                string[] splitInput = userInput.Split(null);

                for (int column = 0; column < columns; column++)
                {
                    matrix2[row, column] = Convert.ToInt32(splitInput[column]);
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nHere is your second matrix:\n");
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Console.Write($"{matrix2[x, y]} ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            // OUTPUTS ANSWER

            double[,] answer = MultiplyMatrix(matrix1, matrix2);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nHere is the answer:\n");
            for (int x = 0; x < answer.GetLength(0); x++)
            {
                for (int y = 0; y < answer.GetLength(1); y++)
                {
                    Console.Write($"{answer[x,y]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public static double[,] MultiplyMatrix(double[,] matrix1, double[,] matrix2)
        {
            // MULTIPLIES THE MATRICES

            int rows1 = matrix1.GetLength(0);
            int columns1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int columns2 = matrix2.GetLength(1);

            if (columns1 != rows2)
            {
                Console.WriteLine("The number of columns in your first matrix must equal the amount of rows in the second matrix.");
                return null;
            }
            else
            {
                double[,] answer = new double[rows1, columns2];
                double total = 0;

                for (int i = 0; i < rows1; i++)
                {
                    for (int j = 0; j < columns2; j++)
                    {
                        total = 0;

                        for (int k = 0; k < columns1; k++)
                        {
                            total += (matrix1[i, k] * matrix2[k, j]); // goes along matrix 1, but down matrix 2
                        }

                        answer[i, j] = total; // sets the multiplied answer for the i and j point in answer matrix
                    }
                }

                return answer;
            }
        }
    }
}
