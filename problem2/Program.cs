using System;
class Program2
{
    static void Main(string[] args)
    {
        if (!int.TryParse(args[0], out var year))
        {
            Console.WriteLine("整数の年を入力してください");
            return;
        }
        if (year < 0)
        {
            Console.WriteLine("正数を入力してください");
            return;
        }
        ShowYear(year);

    }
    //うるう年表示メソッド
    static void ShowYear(int year)
    {
        if (IsLeapYear(year))
        {
            Console.WriteLine("うるう年です");
        }
        else
        {
            Console.WriteLine("うるう年ではありません");
        }
    }
    //うるう年判定メソッド
    static bool IsLeapYear(int year)
    {
        //もし4で割り切れかつ、100で割り切れない、または400で割り切れる
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
