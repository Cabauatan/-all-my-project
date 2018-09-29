using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_Cabauatan2
{
    class DeclareVariable
    {
        public static double firstnumber, secondnumber, totalsum, totaldifference, totalproduct, totalquotient, totalremainder;
        public void DeclareVariablesDetails()
        {
            System.Console.Write("Enter first number:  ");
            firstnumber = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Enter second number: ");
            secondnumber = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.ReadKey();
        }
    }
}

