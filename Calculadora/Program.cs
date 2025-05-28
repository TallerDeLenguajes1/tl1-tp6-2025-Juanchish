
Console.WriteLine("\n Ingrese un número:");
string? n1 = Console.ReadLine();

bool result1 = double.TryParse(n1, out double num1);

if (result1)
{
    Console.WriteLine("\n\t ---Segun el número ingresado---");
    // valor absoluto
    double vAbs = Math.Abs(num1);
    Console.WriteLine("Valor absoluto de " + num1 + " es: " + vAbs);

    // cuadrado
    double cuadrado = Math.Pow(num1, 2);
    Console.WriteLine("Cuadrado de " + num1 + " es: " + cuadrado);

    // raiz cuadrada
    double raizCuadrada = Math.Sqrt(num1);
    Console.WriteLine("Raiz cuadrada de " + num1 + " es: " + raizCuadrada);

    // seno
    double seno = Math.Sin(num1);
    Console.WriteLine("Seno de " + num1 + " es: " + seno);

    // coseno
    double coseno = Math.Cos(num1);
    Console.WriteLine("Coseno de " + num1 + " es: " + coseno);

    // Parte entera de un float
    double parteEntera = Math.Truncate(num1);
    Console.WriteLine("Parte entera de " + num1 + " es: " + parteEntera);
}
else
{
    Console.WriteLine("Número ingresado no valido");
}

Console.WriteLine("\n\t-----Maximos y minimos-----");
Console.WriteLine("\nIngrese dos números");
Console.WriteLine("\n Primer número:");
string? numero1 = Console.ReadLine();
Console.WriteLine("\n Segundo número:");
string? numero2 = Console.ReadLine();

bool resultado = double.TryParse(numero1, out double numer1);
bool resultado2 = double.TryParse(numero2, out double numer2);

if (resultado && resultado2)
{
    double max = Math.Max(numer1, numer2);
    double min = Math.Min(numer1, numer2);

    Console.WriteLine("\n El maximo es: " + max);
    Console.WriteLine("\n El minimo es: " + min);
}