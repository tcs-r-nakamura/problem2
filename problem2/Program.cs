class Program2
{
    /// <summary>
    /// 引数が整数かつ正数か判定
    /// </summary>
    /// <param name="args">引数</param>
    static void Main(string[] args)
    {
        if (!ValidateArgs(args, out int year,out string error))
        {
            Console.WriteLine(error);
            return;
        }
       
        ShowYear(year);
    }
    
    /// <summary>
    /// エラーチェック
    /// </summary>
    /// <param name="args">コマンドライン引数</param>
    /// <param name="year">引数</param>
    /// <returns>整数かつ整数</returns>
    static bool ValidateArgs(string[] args, out int year,out string error)
    {
        year = default;
        error = string.Empty;
        if (args.Length == 0)
        {
            error = "引数が設定されていません";
            return false;
        }
        if (!int.TryParse(args[0], out year))
        {
            error = "整数を入力してください";
            return false;
        }
        if (year < 0)
        {
            error = "正数を入力してください";
            return false;
        }
        return true;
    }

    /// <summary>
    ///  うるう年表示メソッド
    /// </summary>
    /// <param name="year">引数</param>
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

    /// <summary>
    /// うるう年判定メソッド
    /// </summary>
    /// <param name="year">引数</param>
    /// <returns>うるう年</returns>
    static bool IsLeapYear(int year)
    {
        //もし4で割り切れかつ、100で割り切れない、または400で割り切れる
        return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);

    }
}

