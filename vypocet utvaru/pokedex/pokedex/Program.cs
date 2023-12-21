
string[] pokemons = File.ReadAllLines("pokedex.txt");
foreach (string pokemon in pokemons)
{
    string[] parts = pokemon.Split((char)44);
    Console.WriteLine("Number in Pokedex: " + parts[0]);
    Console.WriteLine("Name: " + parts[1]);
    Console.WriteLine("Type 1: " + parts[2]);
    Console.WriteLine("Type 2: " + parts[3]);
    Console.WriteLine("Total stats: " + parts[4]);
    Console.WriteLine("HP: " + parts[5]);
    Console.WriteLine("Attack: " + parts[6]);
    Console.WriteLine("Defence: " + parts[7]);
    Console.WriteLine("Sp. attack: " + parts[8]);
    Console.WriteLine("Sp. defence: " + parts[9]);
    Console.WriteLine("Speed: " + parts[10]);
    Console.WriteLine("Generation: " + parts[11]);
    Console.WriteLine("Legendary: " + parts[12]);
    Console.WriteLine();
    Console.WriteLine();
}
