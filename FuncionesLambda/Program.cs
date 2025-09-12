using FuncionesLambda;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Memoria");
        //int edad = 7;
        //edad++;
        //edad++;
        //Persona pers = new Persona();
        //edad++;

        //Console.WriteLine("Expresión lambda como función");
        //Func<int, int> funcionb=(a) => a * 25;
        //int resultado = funcionb(4);
        //Console.WriteLine("El resultado es: " + resultado);

        //Console.WriteLine("Expresion lambda como funcion");
        //Func<int, int, int> suma = (a, b) => a + b;
        //int resultado = suma(24, 28);
        //Console.WriteLine("El resultado es: " + resultado);

        //Console.WriteLine("Expresion lambda como funcion");
        //Func<int, int, int> mayor = (a, b) =>
        //{
        //    if (a > b)
        //    {
        //        return a;
        //    }
        //    else
        //    {
        //        return b;
        //    }

        //};
        //int res = mayor(4, 52);
        //Console.WriteLine("El mayor es : " + mayor(4, 52));
        //Console.WriteLine("El mayor es: " + res);

        //Console.WriteLine("Expresion lambda como funcion");
        //var numeros = new List<int> {8, 25, 10, 4, 0, -5  };
        //Func<int, bool> ObtenerPares = (num) => num % 2 == 0;
        //var pares = numeros.Where(ObtenerPares);


        //Console.WriteLine("Expresion lambda como funcion");

        //var numeros = new List<int> { 8, 25, 10, 46, 12, 0, -5 };
        //Action<int> mostrar = (num) => Console.WriteLine("Posicion"+ num);

        //mostrar(5);

        Console.WriteLine("Expresion lambda como funcion");

        // 1. Factorial
        Console.Write("Ingrese un número entero para calcular su factorial: ");
        int num = int.Parse(Console.ReadLine());
        long factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("El factorial de " + num + " es: " + factorial);

        // 2. Par o impar
        Console.Write("Ingrese un número entero para verificar si es par: ");
        int numPar = int.Parse(Console.ReadLine());
        if (numPar % 2 == 0)
        {
            Console.WriteLine(numPar + " es par");
        }
        else
        {
            Console.WriteLine(numPar + " es impar");
        }

        // 3. Número menor de un arreglo
        int[] arreglo = { 8, 25, 10, 4, 0, -5 };
        int menor = arreglo[0];
        for (int i = 1; i < arreglo.Length; i++)
        {
            if (arreglo[i] < menor)
            {
                menor = arreglo[i];
            }
        }
        Console.WriteLine("El número menor del arreglo es: " + menor);

        // 4. Función lambda: palabra + número = resultado
        var palabrasANumeros = new Dictionary<string, int>()
            {
                {"cero", 0},
                {"uno", 1},
                {"dos", 2},
                {"tres", 3},
                {"cuatro", 4},
                {"cinco", 5},
                {"seis", 6},
                {"siete", 7},
                {"ocho", 8},
                {"nueve", 9},
                {"diez", 10}
            };

        Func<string, int, string> multiplicarPalabra = (texto, veces) =>
        {
            if (palabrasANumeros.ContainsKey(texto.ToLower()))
            {
                int valor = palabrasANumeros[texto.ToLower()];
                return (valor * veces).ToString();
            }
            else
            {
                return "Palabra no reconocida";
            }
        };

        Console.Write("Escribe un número en palabra ': ");
        string palabra = Console.ReadLine();
        Console.Write("Escribe un número entero para multiplicar: ");
        int entero = int.Parse(Console.ReadLine());

        Console.WriteLine("Resultado: " + multiplicarPalabra(palabra, entero));

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
