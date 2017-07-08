using System;

using System;
using System.Collections.Generic;

//A Hashset is a collection of new items that do not allow duplicates. This behavior is useful in a number of scenarios eg. you are keeping a list of employees in a department and need to make sure no employee is added twice in that list. In this kind of scenarios a HashSet will enforce that rule. The most popular and overused generic type - List<T> doesn't help in this case.
namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Acura TSX");
            Showroom.Add("Toyota Prius");
            Showroom.Add("Lexus SE430");
            Showroom.Add("Honda Accord");
            Console.WriteLine("There are " + Showroom.Count + " cars in my showroom.");
            Showroom.Add("Honda Accord");
            Console.WriteLine("After trying to add dup there are " + Showroom.Count + " cars in my showroom.");
            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Acura TL");
            UsedLot.Add("Honda Odyssey");
            Showroom.UnionWith(UsedLot);
            if (Showroom.Contains("Toyota Prius")) {
                Showroom.Remove("Toyota Prius");
            }
            foreach (string car in Showroom)
            {
                 Console.Write(" {0}", car);
            }
            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Acura TSX");
            Junkyard.Add("Toyota Prius");
            Junkyard.Add("Lexus SE430");
            Junkyard.Add("Chevy Trailblazer");
            Showroom.IntersectWith(Junkyard);
            foreach (string car in Showroom)
            {
                Console.WriteLine("Showroom intesect with junkyard: " + car);
            }
            Showroom.UnionWith(Junkyard);
            foreach (string car in Showroom)
            {
                Console.WriteLine("Showroom union with junkyard: " + car);
            }
            Showroom.Remove("Toyota Prius");
            foreach (string car in Showroom)
            {
                Console.WriteLine("Showroom after removing Prius: " + car);
            }
        }
    }
}
