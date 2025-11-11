using System;

class Program
{
    static void Main(string[] args)
    {
        Animal someAnimal = new Dog();

        Animal secondAnimal = new Cat();

        Animal thirdAnimal = new Ostrich();

        List<Animal> animals = new List<Animal>();
        animals.Add(someAnimal);
        animals.Add(secondAnimal);
        animals.Add(thirdAnimal);

        foreach (Animal a in animals)
        {
            Console.WriteLine(a.GetSound());
        }
    }

}