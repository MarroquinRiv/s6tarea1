using static System.Runtime.InteropServices.JavaScript.JSType;

try
{
    //1. Crear una función que calcule el área de un círculo, recibiendo como parámetro el radio.
    static void calcular_area_circulo()
    {
        int radio = 0;
        double area = 0;
        const double pi = 3.1416;
        Console.Write("Ingresa el radio de un círculo y te diré su área: ");
        radio = Convert.ToInt32(Console.ReadLine());
        area = pi * Math.Pow(radio, 2);
        Console.WriteLine("El resultado es: " + area + "\n");
    }

    //2. Crear una función que calcule el perímetro de un rectángulo, recibiendo como parámetros el ancho y la altura.
    static void calcular_perimetro_rectangulo()
    {
        double ancho = 0, altura = 0, perimetro;
        Console.Write("Ingresa el ancho y la altura de un rectángulo y te diré su perímetro: \n");
        ancho = Convert.ToInt32(Console.ReadLine());
        altura = Convert.ToInt32(Console.ReadLine());
        perimetro = ancho * 2 + altura * 2;
        Console.WriteLine("El resultado es: " + perimetro + "\n");
    }

    //3. Crear una función que calcule el promedio de una lista de números, recibiendo como parámetro una lista de enteros.
    static void calcular_promedio()
    {
        int n;
        int nlista;
        int promedio = 0;
        Console.Write("Ingresa la cantidad de enteros que irán en una lista y te diré su promedio: ");
        nlista = Convert.ToInt32(Console.ReadLine());
        if (nlista == 0)
        {
            Console.WriteLine("Bueno, no habrá lista lista.\n");
        }
        else
        {
            Console.WriteLine("Ingrese los números de su lista:");
            for (int i = 1; i <= nlista; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                promedio += n;
            }
            promedio /= nlista;
            Console.WriteLine("El resultado es: " + promedio + "\n");
        }
    }

    //4. Crear una función que determine si un número es par o impar, recibiendo como parámetro el número.
    static void par_o_impar()
    {
        int num;
        Console.WriteLine("Ingresa un número y te diré si es par o impar: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("Es par.\n");
        }
        else
        {
            Console.WriteLine("Es impar.\n");
        }
    }

    //5. Crear una función que convierta una cadena a mayúsculas, recibiendo como parámetro la cadena.
    static void cadena_a_mayus()
    {
        string cadena, mayus;
        Console.Write("Ingresa el texto que quieras y te lo diré en mayúsculas: ");
        cadena = Console.ReadLine();
        mayus = cadena.ToUpper();
        Console.WriteLine(mayus);
    }

    //6. Crear una función que calcule la distancia entre dos puntos en un plano cartesiano, recibiendo como parámetros las coordenadas x e y de ambos puntos.
    static void calcular_distancia_puntos()
    {
        int x1, y1, x2, y2;
        double distancia;
        Console.Write("\nIngresa en orden las coordenadas x1 y1 x2 y2 y te diré su distancia: \n");
        x1 = Convert.ToInt32(Console.ReadLine());
        y1 = Convert.ToInt32(Console.ReadLine());
        x2 = Convert.ToInt32(Console.ReadLine());
        y2 = Convert.ToInt32(Console.ReadLine());
        distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine("El resultado es: " + distancia + "\n");
    }

    //7. Crear una función que calcule la suma de los primeros n números naturales, recibiendo como parámetro el número n.
    static void suma_n_numeros()
    {
        Console.WriteLine("Ingresa un número n y te diré la suma de los primeros n números naturales: \n");
        int N, suma = 0;
        N = Convert.ToInt32(Console.ReadLine());
        if (N <= 0)
        {
            Console.Write("\nSi no es mayor que 0 no funcionará...\n");
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                suma += i;
            }

            Console.WriteLine();
            Console.Write(N);

            int n = 1;
            while (n < N)
            {
                Console.Write(" + " + (N - n));
                n++;
            }

            Console.Write(" = " + suma);
            if (N != 1)
            {
                Console.WriteLine("\nEl resultado es la suma de los primeros " + N + " números enteros positivos.\n");
            }
            else
            {
                Console.WriteLine("\nSe supone que tengo que sumar todos los números enteros menores a 1, pero no hay ninguno.:(");
                Console.WriteLine("¡A la próxima prueba con un número mayor!\n");
            }
        }
    }

    //8. Crear una función que calcule el factorial de un número, recibiendo como parámetro el número.
    static void factorial()
    {
        int N, fact = 1;
        Console.WriteLine("Ingresa un número y te diré su factorial: \n");
        N = Convert.ToInt32(Console.ReadLine());
        if (N == 0)
        {
            Console.WriteLine("El resultado es: 1\n");
        }
        else if (N < 0)
        {
            Console.WriteLine("El resultado es indefinido.\n");
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                fact *= i;
            }

            Console.WriteLine();
            Console.Write(N);

            int n = 1;
            while (n < N)
            {
                Console.Write(" * " + (N - n));
                n++;
            }

            Console.Write(" = " + fact);
            Console.WriteLine($"\nEl resultado es " + fact + "\n");
        }
    }

    calcular_area_circulo();
    calcular_perimetro_rectangulo();
    calcular_promedio();
    par_o_impar();
    cadena_a_mayus();
    calcular_distancia_puntos();
    suma_n_numeros();
    factorial();
}
catch (Exception ex)
{
    Console.WriteLine("\nUps, parece que te equivocaste en algo. ¡Pero no te desanimes! Te sugiero que lo intentes de nuevo. <3");
    Console.Write("La excepción es: " + ex.Message + "\n");
}