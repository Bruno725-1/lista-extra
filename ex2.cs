using System;
class Ex2 {
    public static void Rodar() {
        try {
            Console.WriteLine("Digite um número inteiro");
            double num = double.Parse(Console.ReadLine());
            double fat = 1;
            for(int i = 1; i <= num; i++) {
                fat *= i;
            }
            Console.WriteLine(fat);
        }
        catch (System.FormatException) {
            Console.WriteLine("Entrada inválida. Digite um número.");
        }
    }
}