using System;

namespace Recursividad.Logica
{
    public class Recursividad
    {
        // Factorial
        public int FactorialRecursivo(int n)
        {
            if (n <= 1) return 1;
            return n * FactorialRecursivo(n - 1);
        }

        public int FactorialIterativo(int n)
        {
            int resultado = 1;
            for (int i = 2; i <= n; i++)
                resultado *= i;
            return resultado;
        }

        // Fibonacci
        public int FibonacciRecursivo(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
        }

        public int FibonacciIterativo(int n)
        {
            if (n < 2) return n;
            int a = 0, b = 1, temp = 0;
            for (int i = 2; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

        // Invertir texto
        public string InvertirRecursivo(string numero)
        {
            if (numero == "") return "";
            return InvertirRecursivo(numero.Substring(1)) + numero[0];
        }

        public string InvertirIterativo(string numero)
        {
            string salida = "";
            for (int i = numero.Length - 1; i >= 0; i--)
                salida += numero[i];
            return salida;
        }

        // Letras
        public void ImprimirAbecedarioRecursivo(char inicio, char fin)
        {
            Console.Write(inicio + " ");
            if (inicio < fin)
                ImprimirAbecedarioRecursivo((char)(inicio + 1), fin);
        }

        public void ImprimirAbecedarioIterativo(char inicio, char fin)
        {
            for (char c = inicio; c <= fin; c++)
                Console.Write(c + " ");
        }

        // Vocales
        public int ContarVocalesRecursivo(string texto, int i = 0)
        {
            if (i == texto.Length) return 0;
            char letra = char.ToLower(texto[i]);
            int esVocal = "aeiou".Contains(letra) ? 1 : 0;
            return esVocal + ContarVocalesRecursivo(texto, i + 1);
        }

        public int ContarVocalesIterativo(string texto)
        {
            int total = 0;
            foreach (char letra in texto.ToLower())
                if ("aeiou".Contains(letra)) total++;
            return total;
        }

        // Dígitos
        public int SumaDigitosRecursivo(int n)
        {
            if (n == 0) return 0;
            return (n % 10) + SumaDigitosRecursivo(n / 10);
        }

        public int SumaDigitosIterativo(int n)
        {
            int total = 0;
            while (n > 0)
            {
                total += n % 10;
                n /= 10;
            }
            return total;
        }

        public (int numero, int suma) MayorSumaRecursivo(int[] lista)
        {
            int mayorNum = 0, mayorSuma = -1;
            foreach (int num in lista)
            {
                int suma = SumaDigitosRecursivo(num);
                if (suma > mayorSuma)
                {
                    mayorSuma = suma;
                    mayorNum = num;
                }
            }
            return (mayorNum, mayorSuma);
        }

        public (int numero, int suma) MayorSumaIterativo(int[] lista)
        {
            int mayorNum = 0, mayorSuma = -1;
            foreach (int num in lista)
            {
                int suma = SumaDigitosIterativo(num);
                if (suma > mayorSuma)
                {
                    mayorSuma = suma;
                    mayorNum = num;
                }
            }
            return (mayorNum, mayorSuma);
        }

        // Suma primeros n números
        public int SumaNRecursivo(int n)
        {
            if (n == 1) return 1;
            return n + SumaNRecursivo(n - 1);
        }

        public int SumaNIterativo(int n)
        {
            int total = 0;
            for (int i = 1; i <= n; i++)
                total += i;
            return total;
        }
    }
}
