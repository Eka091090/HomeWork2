using System;

class Program
{
    static void Main()
    {
        // EX 1
        System.Console.Write("Enter number a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        if ( a % 7 == 0 && a % 23 == 0)
            System.Console.WriteLine("yes");
        else
            System.Console.WriteLine("no");

        // EX 2

        System.Console.Write("Enter coord X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter coord Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
            System.Console.WriteLine("1");
        else if (x < 0 && y > 0)
            System.Console.WriteLine("2");
        else if (x < 0 && y < 0)
            System.Console.WriteLine("3");
        else if (x > 0 && y < 0)
            System.Console.WriteLine("4");
        else
            System.Console.WriteLine("точка на оси");

        // EX 3

        System.Console.Write("Введите число из отрезка [10, 99]: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int firstNum = number / 10;
        int secondNum = number % 10;

        if (firstNum > secondNum)
            System.Console.WriteLine(firstNum);
        else
            System.Console.WriteLine(secondNum);

        // EX 4

        


    }
}
