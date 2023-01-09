using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operadores artimeticos
            //int num1 = 10;
            //int num2 = 2;
            //int resultado = num1 + num2;

            //Console.WriteLine(num1 + num2);
            //Console.WriteLine(num1 - num2);
            //Console.WriteLine(num1 * num2);
            //Console.WriteLine(num1 / num2);
            //Console.WriteLine(num1 % num2);
            #endregion

            #region Prioridade de operação
            double num1 = 100;
            double num2 = 10;
            double num3 = 5;

            double res = (num1 + num2) * (num3 / 3);

            Console.WriteLine(res);
            #endregion

            Console.ReadKey();
        }
    }
}
