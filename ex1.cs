using System;
class Ex1 {
    public static void Rodar(){
        double tc = 0;
        Console.WriteLine("Digite a temperatura a ser convertida em graus centígrados");
        try {
            tc = double.Parse(Console.ReadLine());
            double tf = (1.8 * tc) + 32;
            Console.WriteLine(tc+"| "+tf);
        }
        catch (System.FormatException) {
            Console.WriteLine("Entrada inválida. Digite um número");
        }
    }
}