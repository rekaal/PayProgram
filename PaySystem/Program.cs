using EmpoyleeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySystem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Empolyee empolyee = new Empolyee();
            int baseSalary = 0;
            int beneFit = 0;
            Console.WriteLine("請輸入該員工底薪：");
            int.TryParse(Console.ReadLine(), out baseSalary);
            empolyee.BaseSalary = baseSalary;
            Console.WriteLine("請輸入該員工獎金：");
            int.TryParse(Console.ReadLine(), out beneFit);
            empolyee.Benefit = beneFit;
            Console.WriteLine("員工總薪資為：" + empolyee.Salary);
            Console.WriteLine("請按任意鍵離開");
            Console.ReadLine();
        }
    }
}