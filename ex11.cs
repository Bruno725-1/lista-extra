using System;
class Ex11 {
    public static void Rodar () {
        Console.WriteLine("Números primos entre 1 e 50:");
        //percorrer números de 2 a 50
        for (int i = 2; i <= 50; i++) {
            if (ehPrimo (i)) {
                //exibir o número caso seja primo
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
    public static bool ehPrimo (int i) {
        // Um número é primo se não tiver divisores além de 1 e ele mesmo
        for (int j =2; j <= Math.Sqrt(i); j++) {
            if (i % j == 0)
            return false;
        }
        return true;
    }
}