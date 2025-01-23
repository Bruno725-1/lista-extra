using System;
class Ex3 {
    public static void Rodar() {
        double a = 160000000;
        double b = 120000000;
        int anos = 0;
        while (b <= a) {
            a = a + (a * 0.015);
            b = b + (b * 0.024);
            anos++;
        }
        Console.WriteLine($"A população do País B ultrapassará a população do país A em {anos} anos");
    }
}