using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttisimulaatio
{
    class cKortti
    {
        public int arvo;
        public int arvob;
        public int maa; //1 2 3 4 hertta ruutu risti pata

        public cKortti(int ARVO, int MAA_1_4_he_ru_ri_pa)
        {
            arvo = ARVO;
            maa = MAA_1_4_he_ru_ri_pa;
            arvob = ARVO;
            
        
            
        
    }
        public void show()
        {
            //Console.WriteLine("Hertta 15");
            if (maa == 1) { Console.Write("Hertta "); }
            if (maa == 2) { Console.Write("Ruutu "); }
            if (maa == 3) { Console.Write("Risti "); }
            if (maa == 4) { Console.Write("Pata "); }
            if (maa < 1 || maa > 4) { Console.Write("Error"); }

            switch (arvo)
            {
                case 1:
                    Console.WriteLine("Ässä");
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                
                    Console.WriteLine(arvo);
                    break;
                case 11:
                    Console.WriteLine("Jätkä");
                    break;
                case 12:
                    Console.WriteLine("Kuningatar");
                    break;
                case 13:
                    Console.WriteLine("Kuningas");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
             }
            
        }
    }
}
