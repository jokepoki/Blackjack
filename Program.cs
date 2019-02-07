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
           //cKortti eka = new cKortti(10, 3);
            //cKortti toka = new cKortti(12, 2);
            //eka.show();
            //toka.show();
            //cKorttipakka jaetutkortit = new cKorttipakka();
            //cKortti yksikortti = new cKortti(0,0);
            //jaetutkortit.pakka[13].show();
            //jaetutkortit.pakka.RemoveAt(18);    //testi onnistui gabe the dogen kanssa :-D
            //jaetutkortit.show();
            //yksikortti = jaetutkortit.annakortti();
            //yksikortti.show();
            //Console.WriteLine("      ");
            //jaetutkortit.show();
            //jaetutkortit.sekoita();
            //jaetutkortit.show();
            cKorttipakka jaetutkortit = new cKorttipakka();
            //cPokeriKäsi kalle = new cPokeriKäsi("Kalle");
            //cPokeriKäsi jaakko = new cPokeriKäsi("Jaakko");
            jaetutkortit.sekoita();
            //for (int i = 1; i <= 5; i++)
            //{
            //kalle.otakortti(jaetutkortit.annakortti());
            
            //}
            cMuastajaska jaska = new cMuastajaska("Jaska");
            
            //kalle.show();
            //Console.WriteLine("--------");
            //jaakko.show();
            //jaetutkortit.annakortti();
            jaska.peli(jaetutkortit);
            
            





        }
    }
}
