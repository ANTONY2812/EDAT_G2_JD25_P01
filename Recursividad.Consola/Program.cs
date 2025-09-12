using Recursividad.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== DEMOSTRACIÓN DE RECURSIVIDAD E ITERACIÓN ===\n");

        Recursividad.Logica.Recursividad oRecursividad = new Recursividad.Logica.Recursividad();

        // Factorial
        Console.WriteLine($"[Recursivo] Factorial de 5 = {oRecursividad.FactorialRecursivo(5)}");
        Console.WriteLine($"[Iterativo] Factorial de 5 = {oRecursividad.FactorialIterativo(5)}\n");

        // Serie Fibonacci
        Console.WriteLine($"[Recursivo] Fibonacci en posición 6 = {oRecursividad.FibonacciRecursivo(6)}");
        Console.WriteLine($"[Iterativo] Fibonacci en posición 6 = {oRecursividad.FibonacciIterativo(6)}\n");

        // Inversión de número
        Console.WriteLine($"[Recursivo] Invertir 1234 = {oRecursividad.InvertirRecursivo("1234")}");
        Console.WriteLine($"[Iterativo] Invertir 1234 = {oRecursividad.InvertirIterativo("1234")}\n");

        // Imprimir letras del abecedario
        Console.Write("Letras de f a m (Recursivo): ");
        oRecursividad.ImprimirAbecedarioRecursivo('f', 'm');
        Console.WriteLine();
        Console.Write("Letras de f a m (Iterativo): ");
        oRecursividad.ImprimirAbecedarioIterativo('f', 'm');
        Console.WriteLine("\n");

        // Contador de vocales
        string texto = "Hola Mundo";
        Console.WriteLine($"[Recursivo] Vocales en \"{texto}\" = {oRecursividad.ContarVocalesRecursivo(texto)}");
        Console.WriteLine($"[Iterativo] Vocales en \"{texto}\" = {oRecursividad.ContarVocalesIterativo(texto)}\n");

        // Número con mayor suma de dígitos
        int[] numeros = { 123, 456, 789, 99 };
        var r1 = oRecursividad.MayorSumaRecursivo(numeros);
        var r2 = oRecursividad.MayorSumaIterativo(numeros);
        Console.WriteLine($"[Recursivo] Mayor suma de dígitos: {r1.numero} (suma {r1.suma})");
        Console.WriteLine($"[Iterativo] Mayor suma de dígitos: {r2.numero} (suma {r2.suma})\n");

        // Suma de los primeros n números
        int n = 5;
        Console.WriteLine($"[Recursivo] Suma de los primeros {n} números = {oRecursividad.SumaNRecursivo(n)}");
        Console.WriteLine($"[Iterativo] Suma de los primeros {n} números = {oRecursividad.SumaNIterativo(n)}");

        Console.ReadKey();
    }
}
