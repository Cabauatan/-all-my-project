using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_Cabauatan2
{
    class Difference
    {
        public void DifferenceDetails()
        {
            DeclareVariable.totaldifference = DeclareVariable.firstnumber - DeclareVariable.secondnumber;
            System.Console.WriteLine("Difference = " + DeclareVariable.totaldifference);

            System.Console.ReadKey();
        }
    }
}
