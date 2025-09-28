using System;

class Calculate
{
    static void Main()
    {
        Console.Write("1つ目の数値を入力してください: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("2つ目の数値を入力してください: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("演算子を入力してください (+, -, *, /, %): ");
        string op = Console.ReadLine();

        double result = 0;

        if (op == "+")
        {
            result = num1 + num2;
        }
        else if (op == "-")
        {
            result = num1 - num2;
        }
        else if (op == "*")
        {
            result = num1 * num2;
        }
        else if (op == "/")
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("エラー: 0で割ることはできません。");
                return;
            }
        }
        else if (op == "%")
        {
            if (num2 != 0)
            {
                result = num1 % num2;
            }
            else
            {
                Console.WriteLine("エラー: 0で割ることはできません。");
                return;
            }
        }
        else
        {
            Console.WriteLine("エラー: 無効な演算子です。");
            return;
        }
        
        Console.WriteLine($"結果: {num1} {op} {num2} = {result}");
    }
}