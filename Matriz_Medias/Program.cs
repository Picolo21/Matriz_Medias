internal class Program
{
    private static void Main(string[] args)
    {
        double[,] matrix = new double[5, 3];

        char choice;

        try
        {
            do
            {
                try
                {
                    matrix = InsertNumbersMatrix();
                    Console.Clear();
                    matrix = CalculatesAverage(matrix);
                }
                catch (Exception e)
                {
                    ExceptionMessage(e);
                    break;
                }

                do
                {
                    Console.Clear();
                    PrintMatrix(matrix);
                    Console.WriteLine();
                    Console.Write("Deseja preencher uma nova matriz [Y / N]? ");
                    choice = char.Parse(Console.ReadLine().ToUpper());
                } while ((choice != 'Y') || (choice != 'N'));
            } while (choice.Equals('Y'));
        }
        catch (Exception e)
        {
            ExceptionMessage(e);
        }

        Console.WriteLine();
        Console.WriteLine("Fim do programa!");
    }

    private static double[,] InsertNumbersMatrix()
    {
        double[,] matrix = new double[5, 3];

        do
        {
            Console.Clear();
            Console.Write("Aperte ENTER para começar a inserir os valores na matriz");
        } while (Console.ReadKey().Key != ConsoleKey.Enter);

        Console.Clear();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Digite um valor na posição matriz[{i}, {j}] = ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        return matrix;
    }

    private static double[,] CalculatesAverage(double[,] matrix)
    {
        for (int i = 0; i < 5; i++)
        {
            matrix[i, 2] = (matrix[i, 0] + matrix[i, 1]) / 2;
        }

        return matrix;
    }

    private static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j].ToString("F2").PadRight(7));
            }
            Console.WriteLine();
        }
    }

    private static void ExceptionMessage(Exception e)
    {
        Console.Clear();
        Console.WriteLine(e.Message);
        Thread.Sleep(5000);
        Console.Clear();
    }
}