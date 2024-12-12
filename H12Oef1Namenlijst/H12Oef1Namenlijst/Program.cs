

string[] names = {"Eli","Indy", "Ingrid","Nuri","Dori","Chum", "Simba", "Jamba", "Mama", "Papa", "Iri" };

Console.WriteLine("=== Namen afdrukken ===");
Console.WriteLine();
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Naam {i+1}: {names[i]}");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("=== Namen gesorteerd afdrukken ===");
Console.WriteLine();
Array.Sort(names);
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Naam {i + 1}: {names[i]}");
}