using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static void Run()
    {

        List<Mob> mobs = new List<Mob>
        {
            new Mob("Goblin", 10),
            new Mob("Orc", 15),
            new Mob("Troll", 20)
        };

        Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            foreach (var mob in mobs)
            {
                int randomValue = random.Next(0, 100); 
                if (randomValue < 30) 
                {
                    mob.TakeDamage(1); 
                }
            }
        }


        var defeatedMobs = mobs.Where(mob => mob.IsDead);

        Console.WriteLine("Verslagen mobs:");
        foreach (var mob in defeatedMobs)
        {
            Console.WriteLine($"{mob.Name} is verslagen.");
        }
    }
}

class Mob
{
    public string Name { get; set; }
    public int HP { get; private set; }
    public bool IsDead { get; private set; }

    public Mob(string name, int hp)
    {
        Name = name;
        HP = hp;
        IsDead = false;
    }

    public void TakeDamage(int damage)
    {
        HP -= damage;
        if (HP <= 0)
        {
            IsDead = true;
        }
    }
}
