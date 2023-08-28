// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epicode_U4_W1_D1;


namespace Epicode_U4_W1_D1
{
    internal class Program
    { 
        static void Main(string[] args)
        { 
            Autovetture auto1 = new Autovetture();
            auto1.Marca = "BMW";
            Console.WriteLine(auto1.Marca);


            Autovetture2 auto2 = new Autovetture2();
            auto2.Marca = "Fiat";
            Console.WriteLine(auto2.Marca) ;


            Console.ReadLine();
        }
    }
}


