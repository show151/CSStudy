using System;
using System.Collections.Generic;

class Calculate
{
    static void Main()
    {

        List<string> history = new List<string>(); // 計算履歴を保存するリストを作成

        while (true) // 無限ループで電卓処理を継続
        {
            Console.WriteLine("==== 電卓 ===="); // 電卓画面の表示
            Console.Write("1つ目の数値を入力してください: ");
            double num1 = double.Parse(Console.ReadLine()); // 1つ目の数値を入力してもらい、double型に変換

            Console.Write("2つ目の数値を入力してください: ");
            double num2 = double.Parse(Console.ReadLine()); // 2つ目の数値を入力してもらい、double型に変換

            Console.Write("演算子を入力してください (+, -, *, /, %): "); // 演算子を入力してもらう (+, -, *, /, %)
            string op = Console.ReadLine();

            // 計算結果を格納する変数を用意
            double result = 0;
            string record = "";

            result = Calc(num1, num2, op); // Calcメソッドを呼び出して計算

            // 計算結果を文字列に整形して表示
            record = $"{num1} {op} {num2} = {result}";
            Console.WriteLine($"結果: {record}");

            history.Add(record); // 計算結果を履歴リストに追加

            // ユーザーに続行確認を促す
            // "exit" が入力された場合はループを終了してプログラム終了
            // "history" が入力された場合は計算履歴を表示
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

    // Calcメソッド: 指定された演算子に応じて計算を実行
    // num1, num2: 計算対象の数値
    // op: 演算子 (+, -, *, /, %)
    // 0で割ろうとした場合や無効な演算子の場合はエラー表示して0を返す

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