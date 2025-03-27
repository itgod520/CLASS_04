using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             判断奇偶
             */
            Console.WriteLine("请输入一个数：");
            string num=Console.ReadLine();
            Console.WriteLine(int.Parse(num)%2);
        }
    }
}
