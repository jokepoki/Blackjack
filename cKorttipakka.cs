using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttisimulaatio
{
    class cKorttipakka
    {
        
        public List<cKortti> pakka;
        public cKorttipakka()
        {
            int MAA = 1;

            pakka = new List<cKortti>(52);
            for (int y = 4; y >= MAA; MAA++)
            {



                for (int i = 1; i <= 13; i++)
                {
                    pakka.Add(new cKortti(i, MAA));
                    
                }
            
            }
            
        }

        public void muutablackjackiks()
        {
            for (int i = 0; i < pakka.Count; i++)
            {
               if(pakka[i].arvob > 10) { pakka[i].arvob = 10; }
               if(pakka[i].arvob == 1) { pakka[i].arvob = 11; }
            }
        }


        public void sekoita()
        {


            Random r = new Random();

            for (int i = 0; i < pakka.Count; i++)
            {
                int y = r.Next(pakka.Count - 1);
                cKortti temp = new cKortti(1, 1);
                temp = pakka[i];
                pakka[i] = pakka[y];
                pakka[y] = temp;

            }
        }
          
        

        public void lisääkortti(cPokeriKäsi pelaaja)
        {
            pelaaja.otakortti(annakortti());
        }

    
        public cKortti annakortti()
        {
            
            cKortti Talteen = pakka[0];
            pakka.RemoveAt(0);
            return Talteen;
             
            
        }
        public void jako(cPokeriKäsi pelaaja1)
        {
            for (int i = 1; i <= 2; i++)
            {
                pelaaja1.otakortti(annakortti());
                
            }
            
        }
        public void reset()
        {

        }
        public void show()
        {
            foreach (cKortti korttix in pakka)
            {
                korttix.show();
            }
        }
    }
}
