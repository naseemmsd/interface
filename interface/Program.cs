using @interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployees pte = new PartTimeEmployees();
            pte.show();
            Console.ReadLine();
        }
    }
    interface IEmployee
    {
        //int a {  get; set; }
        void show();
        
       // int this [int index] { get; set; }
       // event EventHandler envhndlr;

    }
    class PartTimeEmployees : IEmployee
    {
        public void show()
        {
            Console.WriteLine("This is a  Method of IEmployee Interface");
        }

        
    }
}
