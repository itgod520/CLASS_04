using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========请输入两个数值==========");
            Console.WriteLine("输入第一个数值：");
            string num1=Console.ReadLine();
            Console.WriteLine("请输入第二个数值：");
            string num2=Console.ReadLine();
            Console.WriteLine($"{num1+num2}");

            Console.WriteLine(num1+num2);

            Console.WriteLine(int.Parse(num1)+int.Parse(num2));
        }
    }
}
