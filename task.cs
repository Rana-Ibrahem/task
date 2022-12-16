using System;


namespace Program;
public  class Person
{
    public string Name;

    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void print() { Console.WriteLine($"My name is {Name},my age is {Age}"); }

}

public class Student : Person
{
    public int Year;
    public float Gpa;

    public Student(string name, int age, int year, float gpa) : base(name, age)
    {
        Name = name;
        Age = age;
        Year = year;
        Gpa = gpa;

    }
    public override void print()
    {
        Console.WriteLine($"My name is {Name} , my age is {Age} and my gpa is {Gpa}");
    }

}


public class Database
{
    private static int _currentIndex;

    public static Person[] people = new Person[50];
    public static void AddStudent(Student student)
    {
        people[_currentIndex++] = student;

    }

    public static void AddSalary(Staff staff)
    {
        people[_currentIndex++] = staff;
    }

    public static void AddPerson(Person person)
    {
        people[_currentIndex++] = person;
    }

        public static void PrintAll()
    {
        for (var i = 0; i <= _currentIndex; i++)
        {
            people[i].print();
        }
    }

}


public class Staff : Person
{
    double Salary;
    int JoinYear;

    public Staff(string name, int age, double salary, int joinyear) : base(name, age)
    {
        Salary = salary;
        JoinYear = joinyear;
    }

    public override void print()
    {
        Console.WriteLine($"My name is {Name} , my age is {Age} and my salary is {Salary}");
    }
}

public class program
{
    private static void Main()
    {
        var database = new Database();

        while (true)
        {
            Console.WriteLine("1) student 2)staff  3)person 4) print all.");
            Console.WriteLine("option: ");
            var option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Name:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Age:");
                    var age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Year:");
                    var year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Gpa:");
                    var gpa = Convert.ToSingle(Console.ReadLine());
                    Student student1 = new Student(name, age, year, gpa);
                    Database.AddStudent(student1);
                    break;

                case 2:
                    Console.WriteLine("Name:");
                    var name2 = Console.ReadLine();
                    Console.WriteLine("Age:");
                    var age2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("salary:");
                    var salary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("join year:");
                    var joinyear = Convert.ToInt32(Console.ReadLine());
                    var staff = new Staff(name2, age2, salary, joinyear);
                    Database.AddSalary(staff);
                    break;

             
                case 3:
                    Console.WriteLine("Name :");
                    var name3 = Console.ReadLine();
                    Console.WriteLine("Age :");
                    var age3 = Convert.ToInt32(Console.ReadLine());
                    var person = new Person(name3, age3);
                    Database.AddPerson(person);
                    break;


                case 4:
                    Database.PrintAll();
                    break;

                default:
                    return;
            }
        }
    }
}

