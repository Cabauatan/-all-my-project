using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_Cabauatan2
{
    class Product
    {
        public void ProductDetails()
        {
            DeclareVariable.totalproduct = DeclareVariable.firstnumber * DeclareVariable.secondnumber;
            System.Console.WriteLine("Product = " + DeclareVariable.totalproduct);

            System.Console.ReadKey();
        }
    }
}
