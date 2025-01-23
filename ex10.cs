using System;
class Ex10 {
    public static void Rodar () {
        Console.WriteLine("Digite um número inteiro e o programa irá verificar se ele é perfeito");
        if (int.TryParse(Console.ReadLine(), out int num )) {
            if (ehPerfeito(num))
            Console.WriteLine("Número perfeito");
            else
            Console.WriteLine("Este número não é perfeito");
        }
        else {
            Console.WriteLine("Entrada inválida. Digite um número inteiro");
        }
    }
    public static bool ehPerfeito (int num) {
        double soma = 0;
        for (int i = 1; i <= num / 2; i++) {
            if (num % i == 0)
            soma += i;
        }
        return soma == num;
    }
}