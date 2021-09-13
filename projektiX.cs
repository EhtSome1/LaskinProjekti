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
                if (o < 1 && o > 2)
                {
                    Console.WriteLine("Väärä vastaus!");
                    o = o - o;
                }
                break;
            }
            while (o == 0);
            int vast = 0;
            int c = 0;
            int x;
            int y;
            if (o == 1)
            {
                do
                {
                    Console.WriteLine("Minkälainen lasku? 1 - pluslasku     2 - miinuslasku     3 - kertolasku      4 - jakolasku");
                    vast = Convert.ToInt32(Console.ReadLine());
                    if (vast == 1)
                    {
                        Console.WriteLine("Anna 2 laskettavaa numeroa:");
                        x = Convert.ToInt32(Console.ReadLine());
                        y = Convert.ToInt32(Console.ReadLine());
                        Laskin olio1 = new Laskin();
                        olio1.PlusL(x, y);
                    }
                    if (vast == 2)
                    {
                        Console.WriteLine("Anna 2 laskettavaa numeroa:");
                        x = Convert.ToInt32(Console.ReadLine());
                        y = Convert.ToInt32(Console.ReadLine());
                        Laskin olio2 = new Laskin();
                        olio2.MiinusL(x, y);
                    }
                    if (vast == 3)
                    {
                        Console.WriteLine("Anna kerrottava ja kertoja:");
                        x = Convert.ToInt32(Console.ReadLine());
                        y = Convert.ToInt32(Console.ReadLine());
                        Laskin olio3 = new Laskin();
                        olio3.KertL(x, y);
                    }
                    if (vast == 4)
                    {
                        Console.WriteLine("Anna jaettava ja jakaja:");
                        x = Convert.ToInt32(Console.ReadLine());
                        y = Convert.ToInt32(Console.ReadLine());
                        Laskin olio4 = new Laskin();
                        olio4.JakoL(x, y);
                    }
                    if (vast < 1 && vast > 4)
                    {
                        Console.WriteLine("Väärä vastaus");
                        vast = vast - vast;
                    }
                    do
                    {
                        if (c == 0)
                        {
                            vast = vast - vast;
                            Console.WriteLine("Jatketaanko laskemista? 1 - kyllä        2 - ei");
                            vast = Convert.ToInt32(Console.ReadLine());
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