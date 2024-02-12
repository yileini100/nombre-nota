// See https://aka.ms/new-console-template for more information
Console.WriteLine("estudiante y su nota");
Console.WriteLine(); 

// Definir arrays para almacenar nombres y notas
string[] nombres = new string[3];
int[] notas = new int[3];

// ingresar nombres y notas
for (int i = 0; i < 3; i++)
{
    Console.Write("Ingrese el nombre del estudiante: ");
    nombres[i] = Console.ReadLine();

    Console.Write("Ingrese la nota de " + nombres[i] + ": ");
    // Validar la entrada para asegurarse de que sea un número entero
    while (!int.TryParse(Console.ReadLine(), out notas[i]))
    {
        Console.WriteLine("Ingrese una nota válida.");
        Console.Write("Ingrese la nota de " + nombres[i] + ": ");
    }
}

// Mostrar los resultados en pantalla
Console.WriteLine("\nResultados:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(nombres[i] + " tiene " + notas[i] + " puntos.");
}
    