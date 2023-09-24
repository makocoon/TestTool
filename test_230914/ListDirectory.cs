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
        public List<string> _allPathList = new List<string>();
        public ListDirectory()
        {
            CreatePathList(@"C:\");
        }
        //foreach (var item in PathList)
        //{
        //    Console.WriteLine(item);
        //}

        private void CreatePathList(string path)
        {
            var parentPath = new DirectoryInfo(path);
            //_allPathList.Add(parentPath.FullName);
            try
            {
                foreach (var childPath in parentPath.GetDirectories())
                {
                    _allPathList.Add(childPath.FullName);
                    CreatePathList(childPath.FullName);
                    Console.WriteLine(childPath.FullName);
                }
                //デバッグ用
                foreach (var item in _allPathList)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("エラー：" + ex.Message);
            }
        }
    }
}
