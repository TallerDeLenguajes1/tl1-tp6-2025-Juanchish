// See https://aka.ms/new-console-template for more information



string? repetir = null;
int resultadoOperacion = 0;

do
{
    Console.WriteLine("\n Ingrese el primer número:");
    string? n1 = Console.ReadLine();

    Console.WriteLine("Ingrese el segundo número:");
    string? n2 = Console.ReadLine();

    bool result1 = int.TryParse(n1, out int num1);

    bool result2 = int.TryParse(n2, out int num2);

    if (result1 && result2)
    {
        Console.WriteLine("\n --Operaciones--");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("Ingrese una opción");

        string? operacion = Console.ReadLine();
        bool resultadoOpcion = int.TryParse(operacion, out int opcion);

        if (resultadoOpcion)
        {
            switch (opcion)
            {
                case 1:
                    resultadoOperacion = num1 + num2;
                    Console.WriteLine("\n Operacion realizada: " + num1 + " + " + num2);
                    break;
                case 2:
                    resultadoOperacion = num1 - num2;
                    Console.WriteLine("\n Operacion realizada: " + num1 + " - " + num2);
                    break;
                case 3:
                    resultadoOperacion = num1 * num2;
                    Console.WriteLine("\n Operacion realizada: " + num1 + " * " + num2);
                    break;
                case 4:
                    resultadoOperacion = num1 / num2;
                    Console.WriteLine("\n Operacion realizada: " + num1 + " / " + num2);
                    break;

                default:
                    Console.WriteLine("Opción ingresada no valida");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Opción ingresada no valida");
            break;
        }
    }
    else
    {
        Console.WriteLine("Números ingresados no validos");
        break;
    }

    Console.WriteLine("\n Resultado: " + resultadoOperacion);

    Console.WriteLine("\n ¿Desea realizar otro calculo? s/n");
    repetir = Console.ReadLine();

} while (repetir == "s");

