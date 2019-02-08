using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttisimulaatio
{
    class cPokeriKäsi
    {
        public int arvoasd = 0;
        public string nimi;
        public List<cKortti> käsi;

        public cPokeriKäsi(string NIMI)
        {
            nimi = NIMI;
            käsi = new List<cKortti>(52);
        }
        public void otakortti (cKortti uusikortti)
        {
            käsi.Add(uusikortti);
        }

        public void show()
        {
            foreach (cKortti korttix in käsi)
            {
                
                korttix.show();
            }
        }
        public void laske()
        {
            arvoasd = 0;
            
            for (int i = 0; i < käsi.Count; i++)
            {
                
                //if ( käsi[i].arvob == 1 && arvoasd < 21) { käsi[i].arvob = 11; }
                arvoasd = arvoasd + käsi[i].arvob;
                
                   
            }
            
            
        }
        public void tarkistaässä()
        {
            
            for (int i = 0; i < käsi.Count; i++)
            {
                if (arvoasd > 21 && käsi[i].arvob == 11) { käsi[i].arvob = 1; }
            }
        }
        public void arvo()
        {

            Console.WriteLine("Korttien yhteenlaskettu arvo on " +arvoasd);
            Console.WriteLine();
            
        }
        public void tilanne(cPokeriKäsi jakaja, cKorttipakka pakka, cPokeriKäsi pelaaja)
        {
            int b = 1;
            
            if (jakaja.arvoasd == 21) { Console.WriteLine("Hävisit pelin"); }
            if (pelaaja.arvoasd == 21 && jakaja.arvoasd < 10) { Console.WriteLine("Blackjack, Voitit pelin"); b = 2; }
            
            string a;
            do
                
            {
            start:
                if (b == 1)
                {
                    Console.WriteLine("Haluatko lisää kortteja? 1 = Kyllä | 2 = Ei");
                    a = Console.ReadLine();

                    if (a != "1" && a != "2" || a == String.Empty) { Console.WriteLine("Virheellinen valinta"); goto start; }

                    if (a == "1" && b == 1)
                    {
                        Console.Clear();
                        pakka.lisääkortti(pelaaja);


                        pelaaja.laske();
                        if (pelaaja.arvoasd > 21) { pelaaja.tarkistaässä(); }
                        pelaaja.laske();
                        Console.WriteLine("Pelaaja:");
                        Console.WriteLine();
                        pelaaja.arvo();                                                
                        pelaaja.show();
                        Console.WriteLine();
                        Console.WriteLine("Jakaja:");
                        jakaja.arvo();
                    }
                    else { break; }
                }
                if (pelaaja.arvoasd > 21) { Console.WriteLine("Hävisit, koska korttiesi yhteenlaskettu arvo on yli 21"); }
                
            } while (b == 1 && pelaaja.arvoasd < 21);
            if (pelaaja.arvoasd <= 21 && b == 1)
            {
                Console.WriteLine("Jakajan vuoro");


                do
                {
                    Console.Clear();
                    pakka.lisääkortti(jakaja);


                    jakaja.laske();
                    if (jakaja.arvoasd > 21) { jakaja.tarkistaässä(); }
                    jakaja.laske();
                    Console.WriteLine("Pelaaja:");
                    Console.WriteLine();
                    pelaaja.arvo();                    
                    pelaaja.show();
                    Console.WriteLine();
                    Console.WriteLine("Jakaja:");
                    Console.WriteLine();
                    jakaja.arvo();                    
                    jakaja.show();
                    System.Threading.Thread.Sleep(3000);
                } while (jakaja.arvoasd < 17);
                
                Console.WriteLine();
                Console.WriteLine("Pelaajan käden arvo on " + pelaaja.arvoasd);
                Console.WriteLine("Jakajan käden arvo on " + jakaja.arvoasd);
                Console.WriteLine();
                System.Threading.Thread.Sleep(3000);
                if (jakaja.arvoasd > pelaaja.arvoasd && jakaja.arvoasd < 22) { Console.WriteLine("Hävisit pelin"); }
                if (jakaja.arvoasd < pelaaja.arvoasd || jakaja.arvoasd > 22 && pelaaja.arvoasd < 22) { Console.WriteLine("Voitit pelin"); }
                if (jakaja.arvoasd == pelaaja.arvoasd && jakaja.arvoasd < 22 && pelaaja.arvoasd < 22) { Console.WriteLine("Tasapeli"); }
                Console.ReadKey();
                
            }
        }

    }
}
