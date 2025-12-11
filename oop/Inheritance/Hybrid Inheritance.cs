using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Inheritance
{
    // Hierarchical base (single inheritance chain)
    class Animall
    {
        public void Eat() => Console.WriteLine("Eating...");
    }

    // Multilevel: Mammal extends Animal
    class Mammal : Animall { }

    // Multiple interfaces + single inheritance = Hybrid
    interface IFlyable { void Fly(); }
    interface ISwimmable { void Swim(); }

    class Dolphin : Mammal, ISwimmable
    {
        public void Swim() => Console.WriteLine("Dolphin swimming");
    }

    class Bat : Mammal, IFlyable
    {
        public void Fly() => Console.WriteLine("Bat flying");
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        Dolphin dolphin = new Dolphin();
    //        dolphin.Eat();  // From Animal (hierarchical)
    //        dolphin.Swim(); // From ISwimmable (multiple)

    //        Bat bat = new Bat();
    //        bat.Eat();  // From Animal  
    //        bat.Fly();  // From IFlyable
    //    }
    //}

}
