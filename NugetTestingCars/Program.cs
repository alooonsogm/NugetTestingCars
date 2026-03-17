using NugetCarsAGM;

Console.WriteLine("Mis coches del NuGet:");
Garaje g = new Garaje();
List<Coche> coches = g.GetCoches();
foreach (Coche c in coches)
{
    Console.WriteLine(c.Marca + " " + c.Modelo);
}
Console.WriteLine("Fin del programa");