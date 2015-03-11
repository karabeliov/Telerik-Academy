using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Person
{
    private string name;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    private int age;

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    private string hometown;

    public string Hometown
    {
        get { return this.hometown; }
        set { this.hometown = value; }
    }

    private string phoneModel;

    public string PhoneModel
    {
        get { return this.phoneModel; }
        set { this.phoneModel = value; }
    }

    public Person(string name, int age, string hometown, string phoneModel)
    {
        this.name = name;
        this.age = age;
        this.hometown = hometown;
        this.phoneModel = phoneModel;
    }

    public void SayHi()
    {
        Console.WriteLine("Hi!");
    }
}
class DefineClass
{
    static void Main()
    {
        Console.Write("Enter your Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter your Hometown: ");
        string hometown = Console.ReadLine();
        Console.Write("Enter your Phone Model: ");
        string phoneModel = Console.ReadLine();
        Console.Write("Enter your Gender(F or M): ");
        string gender = Console.ReadLine();

        Person person1 = new Person(name, age, hometown, phoneModel);
        Person person2 = new Person(name, age, hometown, phoneModel);
        Person person3 = new Person(name, age, hometown, phoneModel);

        Person[] people = new Person[] { person1, person2, person3 };

        foreach (var person in people)
        {
            Console.WriteLine(person.Name);
            person.SayHi();
        }

    }
}