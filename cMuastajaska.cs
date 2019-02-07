using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttisimulaatio
{
    class cMuastajaska
    {
        
        public cPokeriKäsi pelaaja = new cPokeriKäsi("Pelaaja");
        public cPokeriKäsi jakaja = new cPokeriKäsi("Jakaja");
        
        public string nimi;
        
        public cMuastajaska(string NIMI)
        {
            nimi = NIMI;
            
            
        }
        
       
        public void peli(cKorttipakka pakka)
        {
            
            pakka.muutablackjackiks();
            Console.WriteLine("Tervetuloa pelaamaan Blackjackia");
            Console.WriteLine();
            pakka.lisääkortti(pelaaja);
            pakka.lisääkortti(jakaja);
            pakka.lisääkortti(pelaaja);
            Console.WriteLine("Pelaajan käsi");
            Console.WriteLine();
            pelaaja.show();
            Console.WriteLine();
            pelaaja.laske();
            pelaaja.arvo();
            Console.WriteLine("Jakajan käsi");
            Console.WriteLine();
            jakaja.show();
            Console.WriteLine();
            jakaja.laske();
            jakaja.arvo();
            Console.WriteLine();
            pelaaja.tilanne(jakaja,pakka,pelaaja);
            Console.WriteLine();
            
            














        }
       
        
    }
}
