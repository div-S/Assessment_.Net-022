using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace Test.Net022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Test1<int> list = new Test1<int>();
            list.AddItem(5);
            list.AddItem(2);
            list.AddItem(8);

            int itemAtIndex = list.GetValue(1);
            Console.WriteLine(itemAtIndex);

        }
    }
}