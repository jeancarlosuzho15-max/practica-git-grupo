Console.Write("Ingresa tu edad: ");
string texto = Console.ReadLine();

int edad = int.Parse(texto);

if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad");
}
else
{
    Console.WriteLine("Eres menor de edad");
}

Console.WriteLine("Presiona ENTER para salir...");
Console.ReadLine();
Console.WriteLine("Cambio desde feature-jean ✅");