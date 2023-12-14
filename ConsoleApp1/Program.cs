//задание 1 
using System;

public class Spell
{
    public int Mana { get; }
    public string Effect { get; }


public Spell(int mana, string effect)
    {
        Mana = mana;
        Effect = effect;
    }

    public void Use()
    {
        Console.WriteLine(Effect);
    }
}

public class Magician
{
    public string Name { get; }
    public int Mana { get; }

    public Magician(string name, int mana)
    {
        Name = name;
        Mana = mana;
    }

    public void CastSpell(Spell spell)
    {
        if (Mana >= spell.Mana)
        {
            Console.WriteLine($"{Name}");
        }
    }
}

//задание 2 
//using System;

namespace ConsoleApp1
{
    class Package
    {
        public string Description { get; init; }
        public double Weight { get; init; }


      
        public Package(string description, double weight)
        {
            Description = description;
            Weight = weight;
        }
    }

    class ShippingService
    {
        public double WeightLimit { get; init; }
        private double totalWeightShipped;

        public ShippingService(double weightLimit)
        {
            WeightLimit = weightLimit;
            totalWeightShipped = 0;
        }

        public void SendPackage(Package package)
        {
            if (totalWeightShipped + package.Weight <= WeightLimit)
            {
                Console.WriteLine($"Посылка отправлена:\n{package.Description}\nВес: {package.Weight} кг\n");
                totalWeightShipped += package.Weight;
            }
            else
            {
                Console.WriteLine("Превышен весовой лимит!");
            }
        }
    }

    class Program
    {
    
    static void Main(string[] args)
        {
            ShippingService shippingService = new ShippingService(10);

            Package package1 = new Package("Книга", 5);
            shippingService.SendPackage(package1);

            Package package2 = new Package("Коробка конфет", 10);
            shippingService.SendPackage(package2);

            Console.ReadKey();
        }
    }
}

//Задание 3 
//using System;

namespace OrcsGold
{
    class Orc
    {
        private static int TotalGoldCarriedByOrcs { get; set; } = 0;
        private int GoldCarried { get; set; }


        
        public Orc()
        {
            var numberOfOrc = Orc.GetNumberOfOrcs();
            TotalGoldCarriedByOrcs += numberOfOrc * 2;
            GoldCarried = TotalGoldCarriedByOrcs;
        }

        private static int GetNumberOfOrcs()
        {
            int numberOfOrc;
            numberOfOrc = 0;
           

            for (int i = 0; i < 5; i++)
            {
                numberOfOrc++;
            }

            return numberOfOrc;
        }
    }

    class Program
    {
        static void Main()
        {
            Orc orc = new Orc();
            string value = $"Gold carried by {Orc.GetNumberOfOrcs()} Orcs: {orc.GoldCarried}";
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}