using System;
using CompositionVsInheritance.Models;
using c = CompositionVsInheritance.Composition;
using cm = CompositionVsInheritance.Composition_Monster;
using CompositionVsInheritance.Inheritance;
using b = CompositionVsInheritance.Bitwise;
using CompositionVsInheritance.Composition.Interfaces;

namespace CompositionVsInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleType = "inheritance";
            if (args.Length > 0)
                exampleType = args[0];

            if (exampleType == "inheritance")
            {
                UseInheritance();
                return;
            }

            if (exampleType == "composition2")
            {
                UseComposition2();
                return;
            }

            if (exampleType == "composition")
            {
                UseComposition();
                return;
            }

            if (exampleType == "bitwise")
            {
                UseBitwise();
                return;
            }


            Console.WriteLine("nothing to do");
        }

        private static void UseInheritance()
        {
            var animals = new Animal[] {
                    new Dog(),
                    new Cat(),
                    new Duck()
                };

            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}, Sound: {animal.Sound()} ");

                // if (animal is Dog)
                // {
                //     Console.WriteLine($"It's a dog {(animal as Dog).Woof()}");
                //     continue;
                // }

                // if (animal is Cat)
                // {
                //     Console.WriteLine($"It's a cat {(animal as Cat).Mew()}");
                //     continue;
                // }

                // if (animal is Duck)
                // {
                //     Console.WriteLine($"It's a duck {(animal as Duck).Quak()}");
                //     continue;
                // }
            }
        }

        private static void UseComposition2()
        {
            var army = new cm.Monster[] {
                cm.MonsterFactory.CreateMonster (cm.MonsterType.Orc),
                cm.MonsterFactory.CreateMonster (cm.MonsterType.Crocodile),
                cm.MonsterFactory.CreateMonster (cm.MonsterType.Horse)
                };

            foreach (var monster in army)
            {
                Console.WriteLine($"Monster type: {monster.Type}");
                Console.WriteLine("\t* Can bite?: {0}", monster.CanBite ? "Yes" : "No");
                Console.WriteLine("\t* Can kick?: {0}", monster.CanKick ? "Yes" : "No");
                Console.WriteLine("\t* Can punch?: {0}", monster.CanPunch ? "Yes" : "No");
            }
        }

        private static void UseBitwise()
        {
            var army = new b.Monster[] {
                b.MonsterFactory.NewMonster (cm.MonsterType.Orc),
                b.MonsterFactory.NewMonster (cm.MonsterType.Crocodile),
                b.MonsterFactory.NewMonster (cm.MonsterType.Horse)
                };

            foreach (var monster in army)
            {
                Console.WriteLine($"Monster type: {monster.Type}");
                Console.WriteLine("\t* Can bite?: {0}", monster.CanBite ? "Yes" : "No");
                Console.WriteLine("\t* Can kick?: {0}", monster.CanKick ? "Yes" : "No");
                Console.WriteLine("\t* Can punch?: {0}", monster.CanPunch ? "Yes" : "No");
            }
        }

        private static void UseComposition()
        {
            var animals = new IAnimal[]{
                new c.Dog(),
                new c.Cat(),
                new c.Duck()
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Family.Class.Kingdom.Name}, Sound: {animal.Sound()} ");

                // if (animal is c.Dog)
                // {
                //     Console.WriteLine($"It's a dog {(animal as c.Dog).Woof()}");
                //     continue;
                // }

                // if (animal is c.Cat)
                // {
                //     Console.WriteLine($"It's a cat {(animal as c.Cat).Mew()}");
                //     continue;
                // }

                // if (animal is c.Duck)
                // {
                //     Console.WriteLine($"It's a duck {(animal as c.Duck).Quak()}");
                //     continue;
                // }
            }
        }
    }
}