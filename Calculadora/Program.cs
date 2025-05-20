// See https://aka.ms/new-console-template for more information

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