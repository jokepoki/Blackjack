using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttisimulaatio
{
    class Program
    {
        static void Main(string[] args)
        {
           
            cKorttipakka jaetutkortit = new cKorttipakka();
            
            jaetutkortit.sekoita();

            cMuastajaska jaska = new cMuastajaska("Jaska");
            
            jaska.peli(jaetutkortit);
            
            





        }
    }
}
