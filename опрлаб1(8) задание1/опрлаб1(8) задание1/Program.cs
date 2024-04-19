using System;


public interface ILength
{
    void InputLength();
    void DisplayLength();
    void Add(Length other);
    void Subtract(Length other);
    void Multiply(double factor);
    void Divide(double divisor);
    int CompareTo(Length other);
}


public abstract class Length : ILength
{
    protected double value; 

    public abstract void InputLength();
    public abstract void DisplayLength();

    public void Add(Length other)
    {
        value += other.ToPounds(); 
    }

    public void Subtract(Length other)
    {
        value -= other.ToPounds(); 
    }

    public void Multiply(double factor)
    {
        value *= factor;
    }

    public void Divide(double divisor)
    {
        if (divisor != 0)
            value /= divisor;
        else
            Console.WriteLine("Ошибка: деление на ноль.");
    }

    public int CompareTo(Length other)
    {
        double thisInPounds = this.ToPounds();
        double otherInPounds = other.ToPounds();
        return thisInPounds.CompareTo(otherInPounds);
    }

    
    public abstract double ToPounds();
}


public class PoundsLength : Length
{
    public override void InputLength()
    {
        bool validInput = false;
        do
        {
            Console.Write("Введите длину в фунтах: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double pounds) && pounds >= 0)
            {
                value = pounds;
                validInput = true;
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное значение (неотрицательное число).");
            }
        } while (!validInput);
    }

    public override void DisplayLength()
    {
        Console.WriteLine($"Длина: {value} фунтов");
    }

    public override double ToPounds()
    {
        return value; 
    }
}


public class InchesLength : Length
{
    public override void InputLength()
    {
        bool validInput = false;
        do
        {
            Console.Write("Введите длину в дюймах: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double inches) && inches >= 0)
            {
                value = inches / 12; 
                validInput = true;
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное значение (неотрицательное число).");
            }
        } while (!validInput);
    }

    public override void DisplayLength()
    {
        Console.WriteLine($"Длина: {value * 12} дюймов");
    }

    public override double ToPounds()
    {
        return value; 
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Length length1;
        Length length2;

        Console.WriteLine("Выберите меру длины для объекта 1:");
        Console.WriteLine("1. Фунты");
        Console.WriteLine("2. Дюймы");

        int choice1;
        do
        {
            Console.Write("Ваш выбор: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out choice1) && (choice1 == 1 || choice1 == 2))
                break;
            else
                Console.WriteLine("Ошибка: введите 1 или 2.");
        } while (true);

        if (choice1 == 1)
        {
            length1 = new PoundsLength();
        }
        else
        {
            length1 = new InchesLength();
        }

        Console.WriteLine("Выберите меру длины для объекта 2:");
        Console.WriteLine("1. Фунты");
        Console.WriteLine("2. Дюймы");

        int choice2;
        do
        {
            Console.Write("Ваш выбор: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out choice2) && (choice2 == 1 || choice2 == 2))
                break;
            else
                Console.WriteLine("Ошибка: введите 1 или 2.");
        } while (true);

        if (choice2 == 1)
        {
            length2 = new PoundsLength();
        }
        else
        {
            length2 = new InchesLength();
        }

        length1.InputLength();
        length2.InputLength();

        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        Console.WriteLine("5. Сравнение");

        int operation;
        do
        {
            Console.Write("Ваш выбор: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out operation) && operation >= 1 && operation <= 5)
                break;
            else
                Console.WriteLine("Ошибка: введите число от 1 до 5.");
        } while (true);

        switch (operation)
        {
            case 1:
                length1.Add(length2);
                length1.DisplayLength();
                break;
            case 2:
                length1.Subtract(length2);
                length1.DisplayLength();
                break;
            case 3:
                Console.Write("Введите множитель: ");
                double factor;
                do
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out factor))
                        break;
                    else
                        Console.WriteLine("Ошибка: введите корректное число.");
                } while (true);
                length1.Multiply(factor);
                length1.DisplayLength();
                break;
            case 4:
                Console.Write("Введите делитель: ");
                double divisor;
                do
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out divisor) && divisor != 0)
                        break;
                    else
                        Console.WriteLine("Ошибка: введите корректное число (не равное нулю).");
                } while (true);
                length1.Divide(divisor);
                length1.DisplayLength();
                break;
            case 5:
                int comparison = length1.CompareTo(length2);
                if (comparison < 0)
                    Console.WriteLine("Объект 1 меньше объекта 2.");
                else if (comparison > 0)
                    Console.WriteLine("Объект 1 больше объекта 2.");
                else
                    Console.WriteLine("Объекты 1 и 2 равны.");
                break;
            default:
                Console.WriteLine("Неверный выбор операции.");
                break;
        }
    }
}

