internal class Program
{
    private static void Main(string[] args)
    {
        double[,] mat = new double[5, 3];

        Console.Write("Aperte ENTER para começar a inserir os valores na matriz");
        Console.ReadKey();

        char escolha;
        do
        {
            Console.Clear();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < (mat.GetLength(1) - 1); j++)
                {
                    Console.Write($"Digite um valor na posição mat[{i}, {j}] = ");
                    mat[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                mat[i, 2] = (mat[i, 0] + mat[i, 1]) / 2;
            }

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j].ToString("F2").PadRight(7) + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();

            Console.Write("Deseja preencher uma nova matriz [Y / N]? ");
            escolha = char.Parse(Console.ReadLine());
        } while ((escolha.Equals('y')) || (escolha.Equals('Y')));
        Console.WriteLine();

        Console.WriteLine("Fim do programa!");
    }
}