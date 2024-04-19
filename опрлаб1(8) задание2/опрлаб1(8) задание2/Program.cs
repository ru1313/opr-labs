using System;

class Money
{
    private decimal[] denominations = { 0.01m, 0.05m, 0.1m, 0.5m, 1, 2, 5, 10, 50, 100, 500, 1000, 5000 };
    private int[] counts;

    public Money()
    {
        counts = new int[denominations.Length];
    }

    public void InputDenominations()
    {
        for (int i = 0; i < denominations.Length; i++)
        {
            if (i < 4)
            {
                Console.Write($"Введите количество монет номиналом {denominations[i]}: ");
            }
            else
            {
                Console.Write($"Введите количество купюр номиналом {denominations[i]}: ");
            }
            string input = Console.ReadLine();
            int count;
            if (!int.TryParse(input, out count) || count < 0)
            {
                Console.WriteLine("Ошибка: Введите положительное целое число.");
                i--; // Возвращаемся на предыдущую итерацию для повторного ввода
            }
            else
            {
                counts[i] = count;
            }
        }
    }

    public decimal GetTotalAmount()
    {
        decimal totalAmount = 0;
        for (int i = 0; i < denominations.Length; i++)
        {
            totalAmount += denominations[i] * counts[i];
        }
        return totalAmount;
    }

    public static decimal Divide(Money money1, Money money2)
    {
        // Умножаем на 100 и переводим в целые числа
        decimal intMoney1 = money1.GetTotalAmount() * 100;
        decimal intMoney2 = money2.GetTotalAmount() * 100;

        // Проводим операцию деления и возвращаем результат
        return intMoney1 / intMoney2;
    }

    public static long Multiply(Money money1, Money money2)
    {
        // Умножаем на 100 и переводим в целые числа
        long intMoney1 = (long)(money1.GetTotalAmount() * 100);
        long intMoney2 = (long)(money2.GetTotalAmount() * 100);

        // Проводим операцию умножения целых чисел
        return intMoney1 * intMoney2;
    }

    public static Money Add(Money money1, Money money2)
    {
        Money result = new Money();
        for (int i = 0; i < money1.counts.Length; i++)
        {
            result.counts[i] = money1.counts[i] + money2.counts[i];
        }
        return result;
    }

    public static Money Subtract(Money money1, Money money2)
    {
        Money result = new Money();
        for (int i = 0; i < money1.counts.Length; i++)
        {
            result.counts[i] = money1.counts[i] - money2.counts[i];
        }
        return result;
    }

    public static bool Compare(Money money1, Money money2)
    {
        decimal totalAmount1 = money1.GetTotalAmount();
        decimal totalAmount2 = money2.GetTotalAmount();

        if (totalAmount1 > totalAmount2)
        {
            Console.WriteLine("Первая сумма больше второй.");
        }
        else if (totalAmount1 < totalAmount2)
        {
            Console.WriteLine("Вторая сумма больше первой.");
        }
        else
        {
            Console.WriteLine("Суммы равны.");
        }

        return totalAmount1 == totalAmount2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Money money1 = new Money();
        Money money2 = new Money();

        Console.WriteLine("Для первой суммы:");
        money1.InputDenominations();

        Console.WriteLine("Для второй суммы:");
        money2.InputDenominations();

        Console.WriteLine($"Первая сумма: {money1.GetTotalAmount()}");
        Console.WriteLine($"Вторая сумма: {money2.GetTotalAmount()}");

        decimal result = Money.Divide(money1, money2);
        Console.WriteLine($"Результат деления первой суммы на вторую: {result}");

        result = Money.Divide(money2, money1);
        Console.WriteLine($"Результат деления второй суммы на первую: {result}");

        long product = Money.Multiply(money1, money2);
        decimal productDecimal = (decimal)product / 10000;
        Console.WriteLine($"Результат умножения первой суммы на вторую: {productDecimal}");

        Money sum = Money.Add(money1, money2);
        Console.WriteLine($"Сумма двух сумм: {sum.GetTotalAmount()}");

        Money difference = Money.Subtract(money1, money2);
        Console.WriteLine($"Разница двух сумм (первая - вторая): {difference.GetTotalAmount()}");

        difference = Money.Subtract(money2, money1);
        Console.WriteLine($"Разница двух сумм (вторая - первая): {difference.GetTotalAmount()}");

        bool areEqual = Money.Compare(money1, money2);
        Console.WriteLine($"Суммы равны: {areEqual}");
    }
}


