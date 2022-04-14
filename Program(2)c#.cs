// See https://aka.ms/new-console-template for more information
using System;

while (true)
{ 
    Console.Clear();
    double a, b;
    string action;

    
    try
    {

        Console.WriteLine("Введите операнд 1:");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите операнд 2:");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Оператор: '+' '-' '*' '/' ");
        action = Console.ReadLine();
    }
    catch(Exception)
    {
        Console.WriteLine("Операнд должен являться числом !");
        Console.ReadLine();
        continue;
    }
        switch (action)
        {
            case "+":
                Console.WriteLine(a + b);
                break;
            case "-":
                Console.WriteLine(a - b);
                break;
            case "*":
                Console.WriteLine(a * b);
                break;

            case "/":
                if (b == 0)
                {
                    Console.WriteLine("Ошибка!");
                }
                else
                {
                    Console.WriteLine(a / b);
                }
                break;
            
            default:
                Console.WriteLine("Ошибка!");
                break;
        }
    Console.ReadLine();
    
}
