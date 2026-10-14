using System;

class Program
{
    static void Main(string[] args)
    {
        using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Woof!");
    }
}

class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main()
    {
        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.Sound();
        cat.Sound();
    }
}
    }
}