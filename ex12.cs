using System;
class Ex12 {
    public static void Rodar() {
        double idade = 0, maior = 0, media = 0, soma = 0, participantes = 0;
        while (true) {
            Console.WriteLine("Digite a idade de uma pessoa ou um número negativo para finalizar o programa");
            if (double.TryParse(Console.ReadLine(), out idade)) {
                if (idade < 0)
                break;
                if (idade > maior)
                maior = idade;
                soma += idade;
                participantes++;
            }
            else {
                Console.WriteLine("Entrada inválida. Digite um número");
            }
        }
        media = soma / participantes;
        Console.WriteLine("Maior idade: "+maior);
        Console.WriteLine($"Idade média: {media:F2}");
        Console.WriteLine("Quantidade de participantes: "+participantes);
    }
}