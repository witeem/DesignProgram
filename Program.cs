using System.Runtime.InteropServices;
using DesignProgram.FactoryMethod;
using System;

// See https://aka.ms/new-console-template for more information
// Singletion
class MyClass
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("单例模式");
        var signleOne = SignleClass.GetSignle;
        var signleTwo = SignleClass.GetSignle;
        Console.WriteLine(signleOne.GetHashCode());
        Console.WriteLine(signleTwo.GetHashCode());
        Console.WriteLine(signleTwo.Equals(signleOne));

        Console.WriteLine();
        Console.WriteLine("工厂方法模式");
        ICarFactory carFactory = new SportCarFactory();
        carFactory.CreateCar();
        carFactory = new JeepCarFactory();
        carFactory.CreateCar();
    }
}