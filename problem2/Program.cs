using System;
class Program2
{
    static void Main(string[] args)
    {
        int.TryParse(args[0], out var year);
        if (year < 0)
        {
            Console.WriteLine("正数を入力してください");
        }//もし4で割り切れかつ、100で割り切れない、または400で割り切れる
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine("うるう年です");
        }
        else
        {
            Console.WriteLine("うるう年ではありません");
        }
    }
}

