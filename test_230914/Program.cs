using System;
using System.IO;
using System.Collections.Generic;

namespace TestTool
{
    internal class DocumentManager
    {
        static void Main(string[] args)
        {
            try
            {
                string? keyword = Console.ReadLine();
                SearchDirectory _fileSearcher = new SearchDirectory(keyword);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("メインエラー：" + ex.Message);
            }

        }
    }
}