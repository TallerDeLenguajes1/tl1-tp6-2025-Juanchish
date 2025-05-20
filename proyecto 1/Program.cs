// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/


Console.WriteLine("Ingrese un número:");
string? num = Console.ReadLine();
int i;
bool result = int.TryParse(num,out i);

if (result)
{
    Console.WriteLine("El numero invertido es:");
    while (i > 0)
    {
        Console.Write(i % 10);
        i /= 10;
    }
} else
{
    Console.WriteLine("El valor ingresado no es un número");
}

