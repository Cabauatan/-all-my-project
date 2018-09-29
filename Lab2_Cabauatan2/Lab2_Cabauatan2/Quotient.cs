using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_Cabauatan2
{
    class Quotient
    {
        public void QuotientDetails()
        {
            DeclareVariable.totalquotient = DeclareVariable.firstnumber / DeclareVariable.secondnumber;
            System.Console.WriteLine("Quotient = " + DeclareVariable.totalquotient);

            System.Console.ReadKey();
        }
    }
}
