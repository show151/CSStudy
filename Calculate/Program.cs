using System;
using System.Collections.Generic;

class Calculate
{
    static void Main()
    {

        List<string> history = new List<string>();

        while (true)
        {
            Console.WriteLine("==== 電卓 ====");
            Console.Write("1つ目の数値を入力してください: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("2つ目の数値を入力してください: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("演算子を入力してください (+, -, *, /, %): ");
            string op = Console.ReadLine();

            double result = 0;
            string record = "";

            result = Calc(num1, num2, op);

            record = $"{num1} {op} {num2} = {result}";
            Console.WriteLine($"結果: {record}");

            history.Add(record);

            Console.Write("続けますか？ (exitで終了、履歴表示は'history'と入力): ");
            string ans = Console.ReadLine();
            if (ans == "exit")
            {
                break;
            }
            else if (ans == "history")
            {
                Console.WriteLine("==== 計算履歴 ====");
                foreach (var h in history)
                {
                    Console.WriteLine(h);
                }
            }
        }
    }

    static double Calc(double num1, double num2, string op)
    {
        if (op == "+")
        {
            return num1 + num2;
        }
        else if (op == "-")
        {
            return num1 - num2;
        }
        else if (op == "*")
        {
            return num1 * num2;
        }
        else if (op == "/")
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("エラー: 0で割ることはできません。");
                return 0;
            }
        }
        else if (op == "%")
        {
            if (num2 != 0)
            {
                return num1 % num2;
            }
            else
            {
                Console.WriteLine("エラー: 0で割ることはできません。");
                return 0;
            }
        }
        else
        {
            Console.WriteLine("エラー: 無効な演算子です。");
            return 0;
        }
    }
}