using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_Cabauatan2
{
    class Sum
    {
        public void SumDetails()
        {
            DeclareVariable.totalsum = DeclareVariable.firstnumber + DeclareVariable.secondnumber;
            System.Console.WriteLine("Sum = " + DeclareVariable.totalsum);

            System.Console.ReadKey();

        }
    }
}
