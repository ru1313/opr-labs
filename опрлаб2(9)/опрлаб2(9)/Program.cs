using System;
using System.Collections.Generic;

abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void Talk();

    ~Animal()
    {
        Console.WriteLine($"Объект {Name} класса {this.GetType().Name} удален.");
    }
}

class Cow : Animal
{
    public Cow(string name, int age) : base(name, age)
    {
    }

    public override void Talk()
    {
        Console.WriteLine($"Я {Name}, мне {Age} лет.");
    }
}

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
    }

    public override void Talk()
    {
        Console.WriteLine($"Я {Name}, мне {Age} лет.");
    }
}

class Horse : Animal
{
    public Horse(string name, int age) : base(name, age)
    {
    }

    public override void Talk()
    {
        Console.WriteLine($"Я {Name}, мне {Age} лет.");
    }
}

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
    }

    public override void Talk()
    {
        Console.WriteLine($"Я {Name}, мне {Age} лет.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить животное");
            Console.WriteLine("2. Удалить животное");
            Console.WriteLine("3. Вызвать метод Talk() для всех животных");
            Console.WriteLine("4. Выйти из программы");
            Console.Write("Ваш выбор: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите имя животного: ");
                    string name = Console.ReadLine();
                    Console.Write("Введите возраст животного: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Выберите тип животного:");
                    Console.WriteLine("1. Корова");
                    Console.WriteLine("2. Собака");
                    Console.WriteLine("3. Лошадь");
                    Console.WriteLine("4. Кошка");
                    Console.Write("Ваш выбор: ");
                    string animalType = Console.ReadLine();

                    Animal newAnimal = null;
                    switch (animalType)
                    {
                        case "1":
                            newAnimal = new Cow(name, age);
                            break;
                        case "2":
                            newAnimal = new Dog(name, age);
                            break;
                        case "3":
                            newAnimal = new Horse(name, age);
                            break;
                        case "4":
                            newAnimal = new Cat(name, age);
                            break;
                        default:
                            Console.WriteLine("Неверный выбор.");
                            break;
                    }

                    if (newAnimal != null)
                    {
                        animals.Add(newAnimal);
                        Console.WriteLine("Животное успешно добавлено.");
                    }
                    break;

                case "2":
                    if (animals.Count == 0)
                    {
                        Console.WriteLine("Нет животных для удаления.");
                    }
                    else
                    {
                        Console.Write("Введите имя животного для удаления: ");
                        string deleteName = Console.ReadLine();

                        Animal animalToDelete = animals.Find(a => a.Name == deleteName);
                        if (animalToDelete != null)
                        {
                            animals.Remove(animalToDelete);
                            Console.WriteLine($"Животное {deleteName} успешно удалено.");
                        }
                        else
                        {
                            Console.WriteLine($"Животное {deleteName} не найдено.");
                        }
                    }
                    break;

                case "3":
                    Console.WriteLine("Метод Talk() для всех животных:");
                    foreach (var animal in animals)
                    {
                        animal.Talk();
                    }
                    break;

                case "4":
                    Console.WriteLine("Программа завершена.");
                    return;

                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
    }
}


