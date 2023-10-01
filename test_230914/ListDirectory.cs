using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace TestTool
{
    //PC上にあるディレクトリのパスをリスト化する
    internal class ListDirectory
    {
        //追加したディレクトリのパスリスト
        public List<string> _allPathList = new List<string>();
        //検索キーワードを含むディレクトリのパスリスト
        public List<string> _foundPathList = new List<string>();

        public ListDirectory()
        {
        }
        public void CreatePathList(string path)
        {
            _allPathList.Add(path);
        }
        //デバッグ用
        public void ShowAllPathList()
        {
            foreach (var item in _allPathList)
            {
                Console.WriteLine(item);
            }
        }
        public void SearchDirectory(string keyword)
        {
            foreach (var item in _allPathList)
            {
                if (item.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    _foundPathList.Add(item);
                }
            }
            if (_foundPathList.Count > 0)
            {
                foreach (var item in _foundPathList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("一致なし");
            }
        }
    }
}
//{
//    var parentPath = new DirectoryInfo(path);
//    //_allPathList.Add(parentPath.FullName);
//    try
//    {
//        foreach (var childPath in parentPath.GetDirectories())
//        {
//            _allPathList.Add(childPath.FullName);
//            //CreatePathList(childPath.FullName);
//            //Console.WriteLine(childPath.FullName);
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("エラー：" + ex.Message);
//    }
//}

