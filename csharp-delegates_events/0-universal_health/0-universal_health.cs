using System;

public class Player
{
    // Properties
    private string name;
    private float maxHp;
    private float hp;

    // Constructor
    public Player(string name = "Player", float maxHp = 100f)
    {
        // Ensure the name is not null, default to "Player" if it is.
        this.name = name ?? "Player"; // If name is null, set it to "Player".

        // Check if maxHp is greater than 0, otherwise set to default value
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }

        // Set current hp to maxHp
        this.hp = this.maxHp;
    }

    // Method to print health
    public void PrintHealth()
    {
        // Print the output in the expected format
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
