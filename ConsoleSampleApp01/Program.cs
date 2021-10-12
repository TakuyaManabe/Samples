using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSampleApp01
{
    /// <summary>
    /// コンソールアプリサンプル０１
    /// 標準入力・標準出力・標準エラー出力
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// メイン関数
        /// </summary>
        /// <param name="args">コマンドライン引数</param>
        static void Main(string[] args)
        {
            // 標準入力から１行読み込む
            var inputText = Console.ReadLine();

            // 標準出力へ入力したテキストを出力する
            Console.WriteLine($"入力されたテキスト = {inputText}");

            // 標準エラー出力へ入力された文字数を出力する
            Console.Error.WriteLine($"入力された文字数 = {inputText.Length}");
        }
    }
}
