using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_Cabauatan2
{
    class Remainder
    {
        public void RemainderDetails()
        {
            DeclareVariable.totalremainder = DeclareVariable.firstnumber % DeclareVariable.secondnumber;
            System.Console.WriteLine("Remainder = " + DeclareVariable.totalremainder);

            System.Console.ReadKey();
        }
    }
}
