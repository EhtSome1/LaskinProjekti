using System; 

  
namespace ProjektiX 

{ 

    public class Program 

    { 

        static void Main(string[] args) 

        { 

            int o = 0; 

            do 

            { 

                Console.WriteLine("Hei! Haluatko että lasken laskun puolestasi? 1 - Kyllä       2 - Ei"); 

                o = Convert.ToInt32(Console.ReadLine()); 

                if (o < 1 || o > 2) 

                { 

                    Console.WriteLine("Väärä vastaus!"); 

                    o = o - o; 

                } 

            } 

            while (o == 0); 

  

            int vast = 0; 

            int c = 0; 

            double x; 

            double y; 

            double z; 

            if (o == 1) 

            { 

                do 

                { 

                    Console.WriteLine("Minkälainen lasku? 1 - pluslasku     2 - miinuslasku     3 - kertolasku      4 - jakolasku       5 - neliöjuuri"); 

                    vast = Convert.ToInt32(Console.ReadLine()); 

                    switch (vast) 

                    { 

                        case 1: 

                             

                            Console.WriteLine("Anna 2 laskettavaa numeroa:"); 

                            x = Convert.ToDouble(Console.ReadLine()); 

                            y = Convert.ToDouble(Console.ReadLine()); 

                            projektiX.Laskin olio1 = new projektiX.Laskin(); 

                            olio1.PlusL(x, y); 

                            break; 

  

                        case 2: 

                            Console.WriteLine("Anna 2 laskettavaa numeroa:"); 

                            x = Convert.ToDouble(Console.ReadLine()); 

                            y = Convert.ToDouble(Console.ReadLine()); 

                            projektiX.Laskin olio2 = new projektiX.Laskin(); 

                            olio2.MiinusL(x, y); 

                            break; 

  

                        case 3: 

                            Console.WriteLine("Anna kerrottava ja kertoja:"); 

                            x = Convert.ToDouble(Console.ReadLine()); 

                            y = Convert.ToDouble(Console.ReadLine()); 

                            projektiX.Laskin olio3 = new projektiX.Laskin(); 

                            olio3.KertL(x, y); 

                            break; 

  

                        case 4: 

                            Console.WriteLine("Anna jaettava ja jakaja:"); 

                            x = Convert.ToDouble(Console.ReadLine()); 

                            y = Convert.ToDouble(Console.ReadLine()); 

                            projektiX.Laskin olio4 = new projektiX.Laskin(); 

                            olio4.JakoL(x, y); 

                            break; 

  

                        case 5: 

                            Console.WriteLine("Anna laskettava numero"); 

                            z = Convert.ToDouble(Console.ReadLine()); 

                            projektiX.Laskin olio5 = new projektiX.Laskin(); 

                            olio5.NeliJ(z); 

                            break; 

  

                        case 0: 

                            Console.WriteLine("Väärä vastaus"); 

                            break; 

                        default: 

                            Console.WriteLine("Väärä vastaus"); 

                            vast = vast - vast; 

                            break; 

                    } 

                    do 

                    { 

                        if (c == 0) 

                        { 

                            vast = vast - vast; 

                            Console.WriteLine("Jatketaanko laskemista? 1 - kyllä        2 - ei"); 

                            vast = Convert.ToInt32(Console.ReadLine()); 

                        } 

                        if (vast == 0) 

                        { 

                            Console.WriteLine("Väärä Vastaus"); 

                        } 

                        if (vast == 1) 

                        { 

                            vast = vast - vast; 

                        } 

                        if (vast == 2) 

                        { 

                            Console.WriteLine("Ei sitten. :("); 

                        } 

                        if (vast < 1 && vast > 2) 

                        { 

                            Console.WriteLine("Väärä vastaus"); 

                            c = c - c; 

                        } 

                        break; 

                    } 

                    while (c == 0); 

                } 

                while (vast == 0); 

            } 

            if (o == 2) 

            { 

                Console.WriteLine("Ei sitten. :("); 

            } 

        } 

    } 

} 



using System;
using System.Collections.Generic;
using System.Text;

namespace projektiX
{
    public class Laskin
    {
        public void PlusL(double x, double y)
        {
            Console.WriteLine(x + y);
        }
        public void MiinusL(double x, double y)
        {
            Console.WriteLine(x - y);
        }
        public void KertL(double x, double y)
        {
            Console.WriteLine(x * y);
        }
        public void JakoL(double x, double y)
        {
            Console.WriteLine(x / y);
        }
        public void NeliJ(double z)
        {
            Console.WriteLine(Math.Sqrt(z));
        }
    }
}
