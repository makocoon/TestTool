using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTool
{
    internal class SearchDirectory
    {
        //private string _keyword;
        //public SearchDirectory(string keyword)
        //{ _keyword = keyword; }

        private ListDirectory _listDirectory = new ListDirectory();
        public List<string> _foundPathList = new List<string>();

        public SearchDirectory(string keyword)
        {
            foreach(var item in _listDirectory._allPathList)
            {
                if(item.Contains(keyword))
                {
                    _foundPathList.Add(item);
                }
            }
            Console.WriteLine(_foundPathList);
        }

    }
}
