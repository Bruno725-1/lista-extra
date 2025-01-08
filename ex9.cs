using System;
class Ex9 {
    public static void Rodar () {
        Console.WriteLine("Digite um número inteiro");
        if (int.TryParse(Console.ReadLine(), out int numero)) {
            bool primo = false;
            Verificar(numero, ref primo);
            if (primo)
            Console.WriteLine("Número primo");
            else
            Console.WriteLine("Este número não é primo");
        }
        else
        Console.WriteLine("Entrada inválida. Digite um número");
    }
    public static void Verificar (int numero, ref bool primo) {
        if (numero < 2) {
            primo = false;
            return;
        }
        for (int i = 2; i <= Math.Sqrt(numero); i++) { // Verifica até a raíz quadrada do número
            if (numero % i == 0) {
                primo = false;
                return;
            }
        }
        primo = true;
    }
}