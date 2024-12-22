using System;
class Ex5 {
    public static void Rodar () {
        double num = 0, soma = 0, negativos = 0;
        do {
            Console.WriteLine("Digite um número qualquer para contabilizar ou 0 para finalizar o programa");
            if(double.TryParse(Console.ReadLine(), out num)) {
                if (num < 0)
                negativos++;
                else if (num > 0)
                soma += num;
            }
            else {
                Console.WriteLine("Entrada inválida. Digite um número");
            }
        } while (num != 0);
        Console.WriteLine("Soma dos números positivos: "+soma);
        Console.WriteLine("Quantidade de números negativos: "+negativos);
    }
}