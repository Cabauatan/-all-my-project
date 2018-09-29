using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_Cabauatan2
{
    class Program
    {
        static void Main(string[] args)
        {
            DeclareVariable a = new DeclareVariable();
            a.DeclareVariablesDetails();

            Sum sum = new Sum();
            sum.SumDetails();

            Difference diff = new Difference();
            diff.DifferenceDetails();

            Product prod = new Product();
            prod.ProductDetails();

            Quotient quo = new Quotient();
            quo.QuotientDetails();

            Remainder remainder = new Remainder();
            remainder.RemainderDetails();

            Console.ReadKey();
        }
    }
}
