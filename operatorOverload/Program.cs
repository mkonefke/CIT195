using System;

public class GameCharacter
{
    public string Name { get; set; }
    public int Level { get; set; }

    public GameCharacter(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public static GameCharacter operator ++(GameCharacter character)
    {
        character.Level++;
        return character;
    }

    public static bool operator >(GameCharacter c1, GameCharacter c2)
    {
        return c1.Level > c2.Level;
    }

    public static bool operator <(GameCharacter c1, GameCharacter c2)
    {
        return c1.Level < c2.Level;
    }

    public static GameCharacter operator +(GameCharacter c1, GameCharacter c2)
    {
        return new GameCharacter($"{c1.Name}-{c2.Name}", c1.Level + c2.Level);
    }

    public override string ToString()
    {
        return $"{Name} (Level {Level})";
    }
}

class Program
{
    static void Main()
    {
        GameCharacter hero = new GameCharacter("SuperMan", 7);
        GameCharacter villain = new GameCharacter("Villain", 9);

        Console.WriteLine("Original Characters:");
        Console.WriteLine(hero);
        Console.WriteLine(villain);

        hero++;
        Console.WriteLine("After Leveling Up Hero:");
        Console.WriteLine(hero);

        Console.WriteLine("Who is stronger?");
        Console.WriteLine(hero > villain ? $"{hero.Name} is stronger" : $"{villain.Name} is stronger");

        GameCharacter fusion = hero + villain;
        Console.WriteLine("Combining Characters:");
        Console.WriteLine(fusion);
    }
}
