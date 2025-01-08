using System;
class Ex8
{
    public static void Rodar()
    {
        try
        {
            Console.WriteLine("Digite um número inteiro");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            //preencher a matriz
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = i + j + 1;
                }
            }
            //exibição da matriz
            Console.WriteLine("Matriz gerada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write($"{n} "); // Preenche a diagonal principal com o número digitado
                    else
                        Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Entrada inválida. O número deve ser inteiro e positivo");
        }
        catch (System.OverflowException)
        {
            Console.WriteLine("Não foi possível gerar a matriz. Digite outro número e tente novamente");
        }
    }
}