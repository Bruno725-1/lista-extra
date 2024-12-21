using System;
class Ex2 {
    public static void Rodar() {
        Console.WriteLine("Digite um número inteiro");
        int num = int.Parse(Console.ReadLine());
        int fat = 1;
        for(int i = 1; i < fat; i++) {
            fat *= num;
        }
        Console.WriteLine(fat);
    }
}