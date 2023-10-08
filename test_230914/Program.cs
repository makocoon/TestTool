using System;
using System.IO;
using System.Collections.Generic;

namespace TestTool
{
    internal class DocumentManager
    {
        private static string _inputWord;
        static void Main(string[] args)
        {
            var _listDirectory = new ListDirectory();
            do
            {
                _inputWord = Console.ReadLine();

                if (CheckWords(_inputWord, "add"))
                {
                    // スペースで区切られた単語の配列を取得
                    string[] words = _inputWord.Split(" ");

                    // 最初の単語を除いた残りの単語を配列として抽出
                    var inputPathArray = words.Skip(1);
                    string inputPath = string.Concat(inputPathArray);

                    //入力されたパスをリストに追加
                    _listDirectory.CreatePathList(inputPath);
                }
                else
                {
                    ////検索したいキーワード
                    //SearchDirectory _fileSearcher = new SearchDirectory(_inputWord);
                }
            } while (_inputWord != "おわり");
            _listDirectory.ShowAllPathList();

            //キーワードを検索
            Console.WriteLine("検索したいキーワードを入力してください。");
            string keyword = Console.ReadLine();
            _listDirectory.SearchDirectory(keyword);
        }

        private static bool CheckWords(string input, string prefix)
        {
            // 文字列の先頭から指定した長さだけ切り出し
            string inputPrefix = input.Substring(0, Math.Min(input.Length, prefix.Length));

            // 切り出した部分と指定の文字列を比較
            return inputPrefix.Equals(prefix);
        }

    }
}