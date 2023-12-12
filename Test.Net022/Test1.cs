using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net022
{
    public class Test1<T> where T : struct 
    {
        private List<T> list;

        public Test1()
        {
            list = new List<T>();
        }

        public void AddItem(T item) 
        {
            list.Add(item);
        }

        public T GetValue(int i)
        {
            return list[i];
        }

        public List<T> GetSorted()
        {
            List<T> sortedList = list.OrderByDescending(x => x).ToList();
            return sortedList;
        }
    }
}
