using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CreationalDesignPattern
{
    //AbstractFactory interface
    public interface IContinentFactory
    {
        Iherbivore CreateHerbivore();
        ICarnivore CreateCarnivore();
    }

    //Abstract FActory abstract class

    public interface Iherbivore { }
    public interface ICarnivore
    {
        void Eat(Iherbivore h);
    }

    public class Wildbeast : Iherbivore { }

    public class Lion : ICarnivore
    {
        public void Eat(Iherbivore h) => WriteLine($"{GetType().Name} eats{h.GetType().Name}");
    }

    public class Bison : Iherbivore
    {

    }

    public class Wolf : ICarnivore
    {
        public void Eat(Iherbivore h) => WriteLine($"{GetType().Name} eats {h.GetType().Name}");
    }

    //concrete Class1
    public class Africa : IContinentFactory
    {
        public Iherbivore CreateHerbivore() => new Wildbeast();
        public ICarnivore CreateCarnivore() => new Lion();
    }

    //Concrete class2
    public class America : IContinentFactory
    {
        public Iherbivore CreateHerbivore() => new Bison();
        public ICarnivore CreateCarnivore() => new Wolf();
    }

    // the client Interface

    public interface IAnimalWorld
    {
        void RunFoodChain();
    }

    //Client Class
    public class Animalworld<T> : IAnimalWorld where T : IContinentFactory, new()
    {
        private readonly Iherbivore herbivore;
        private readonly ICarnivore carnivore;

        public Animalworld()
        {
            var factory = new T(); //create new continent factory


            //Factory creates carnivores and hervivores
            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            carnivore.Eat(herbivore);
        }
    }

    public class AbstractFactroy
    {
        //static void Main(string[] args)
        //{
        //    var africa = new Animalworld<Africa>();
        //    africa.RunFoodChain();

        //    var america = new Animalworld<America>();
        //    america.RunFoodChain();

        //    ReadKey();
        //}
    }
}
