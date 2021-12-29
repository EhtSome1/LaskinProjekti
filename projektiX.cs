using System;
using System.Threading;

namespace ProjektiX
{
    public class Program
    {
        static void Main(string[] args)
        {
            int o = 0;
            int kysym;
            do
            {
                Console.WriteLine("Hei! Haluatko että lasken laskun puolestasi?");
                Console.WriteLine("(Kirjoita numero)");
                Console.WriteLine("1 - Kyllä");
                Console.WriteLine("2 - Ei");
                Console.WriteLine("---------");
                o = Convert.ToInt32(Console.ReadLine());
                if (o == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ei sitten :(");
                }
                if (o < 1 || o > 2)
                {
                    Console.WriteLine("Väärä vastaus!");
                    o = o - o;
                }
            }
            while (o == 0);
            Console.WriteLine("Kuinka monta laskua lasken?");
            kysym = Convert.ToInt32(Console.ReadLine());
            projektiX.Laskin olio3 = new projektiX.Laskin();
            int kvast = 0;
            int vast = 0;
            int c = 0;
            int taulukkonum = 0;
            int taulukkonumm = 2;
            int laskuvast;
            double x;
            double y;
            double z;
            double vastaus = 0;
            string[] laskut = new string[kysym];
            for (int i = 0; i < kysym; i++)
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("Minkälainen lasku?");
                    Console.WriteLine("1 - Pluslasku");
                    Console.WriteLine("2 - Miinuslasku");
                    Console.WriteLine("3 - Kertolasku");
                    Console.WriteLine("4 - Jakolasku");
                    Console.WriteLine("5 - Neliöjuuri");
                    Console.WriteLine("6 - Pinta-ala");
                    Console.WriteLine("---------------");
                    vast = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (vast)
                    {
                        case 1:
                            //Pluslasku
                            Console.WriteLine("Anna 2 laskettavaa numeroa:");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("+");
                            y = Convert.ToDouble(Console.ReadLine());
                            Console.Beep(800, 200);
                            Thread.Sleep(500);
                            Console.Beep(800, 200);
                            Thread.Sleep(500);
                            Console.Beep(800, 200);
                            projektiX.Laskin olio1 = new projektiX.Laskin();
                            olio1.PlusL(x, y);
                            vastaus = x + y;
                            laskut[taulukkonum] = "Pluslasku " + x + " + " + y + " = " + vastaus;
                            break;

                        case 2:
                            //Miinuslasku
                            Console.WriteLine("Anna 2 laskettavaa numeroa:");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("-");
                            y = Convert.ToDouble(Console.ReadLine());
                            Console.Beep(800, 200);
                            Thread.Sleep(500);
                            Console.Beep(800, 200);
                            Thread.Sleep(500);
                            Console.Beep(800, 200);
                            projektiX.Laskin olio2 = new projektiX.Laskin();
                            olio2.MiinusL(x, y);
                            vastaus = x - y;
                            laskut[taulukkonum] = "Miinuslasku " + x + " - " + y + " = " + vastaus;
                            break;

                        case 3:
                            //Kertolasku
                            Console.WriteLine("Anna kerrottava ja kertoja:");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("*");
                            y = Convert.ToDouble(Console.ReadLine());
                            Console.Beep(800, 200);
                            Thread.Sleep(500);
                            Console.Beep(800, 200);
                            Thread.Sleep(500);
                            Console.Beep(800, 200);
                            olio3.KertL(x, y);
                            vastaus = x * y;
                            laskut[taulukkonum] = "Kertolasku " + x + " * " + y + " = " + vastaus;
                            break;

                        case 4:
                            //Jakolasku
                            Console.WriteLine("Anna jaettava ja jakaja:");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("/");
                            y = Convert.ToDouble(Console.ReadLine());
                            Console.Beep(800, 200);
                            Thread.Sleep(500);
                            Console.Beep(800, 200);
                            Thread.Sleep(500);
                            Console.Beep(800, 200);
                            projektiX.Laskin olio4 = new projektiX.Laskin();
                            olio4.JakoL(x, y);
                            vastaus = x / y;
                            laskut[taulukkonum] = "Jakolaskulasku " + x + " / " + y + " = " + vastaus;
                            break;
                            

                        case 5:
                            //Neliöjuuri
                            Console.WriteLine("Anna laskettava numero");
                            z = Convert.ToDouble(Console.ReadLine());
                            Console.Beep(800, 200);
                            Thread.Sleep(500);
                            Console.Beep(800, 200);
                            Thread.Sleep(500);
                            Console.Beep(800, 200);
                            projektiX.Laskin olio5 = new projektiX.Laskin();
                            olio5.NeliJ(z);
                            vastaus = Math.Sqrt(z);
                            laskut[taulukkonum] = "Neliöjuuri " + z + " = " + vastaus;
                            break;

                        case 6:
                            //Pinta-ala
                            Console.WriteLine("Minkä kuvion pinta-ala?");
                            Console.WriteLine("1 - Neliö/Suorakulmio");
                            Console.WriteLine("2 - Suorakulmainen kolmio");
                            Console.WriteLine("-------------------------");
                            kvast = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            do
                                switch (kvast)
                                {
                                    case 1:
                                        //Neliö/Suorakulmio
                                        Console.WriteLine("Anna kanta ja korkeus");
                                        x = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("*");
                                        y = Convert.ToDouble(Console.ReadLine());
                                        Console.Beep(800, 200);
                                        Thread.Sleep(500);
                                        Console.Beep(800, 200);
                                        Thread.Sleep(500);
                                        Console.Beep(800, 200);
                                        //projektiX.Laskin olio6 = new projektiX.Laskin();
                                        //olio6.NeliA(x, y);
                                        olio3.KertL(x, y);
                                        vastaus = x * y;
                                        laskut[taulukkonum] = "Neliö/suorakulmio pinta-ala " + x + " * " + y + " = " + vastaus;
                                        break;

                                    case 2:
                                        //Suorakulmainen kolmio
                                        Console.WriteLine("Anna kanta ja korkeus");
                                        Console.WriteLine("(");
                                        x = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("*");
                                        y = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine(")");
                                        Console.WriteLine("/ 2");
                                        Console.Beep(800, 200);
                                        Thread.Sleep(500);
                                        Console.Beep(800, 200);
                                        Thread.Sleep(500);
                                        Console.Beep(800, 200);
                                        projektiX.Laskin olio7 = new projektiX.Laskin();
                                        olio7.SuorKolmiA(x, y);
                                        vastaus = (x * y) / 2;
                                        laskut[taulukkonum] = "Suorakulmainen kolimo pinta-ala " + "(" + x + " * " + y + ")" + " / 2" + " = " + vastaus;
                                        break;

                                    default:
                                        Console.WriteLine("Väärä vastaus!");
                                        kvast = kvast - kvast;
                                        break;
                                }
                            while (kvast == 0);
                            break;

                        default:
                            Console.WriteLine("Väärä vastaus");
                            vast = vast - vast;
                            break;
                    }
                    taulukkonumm++;
                    taulukkonum++;
                    Thread.Sleep(2000);
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("Haluatko nähdä lasketut laskut");
                        Console.WriteLine("1 - Kyllä");
                        Console.WriteLine("2 - Ei");
                        Console.WriteLine("---------");
                        laskuvast = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (laskuvast == 1)
                        {
                            foreach (string m in laskut)
                            {
                                Console.WriteLine(m);
                            }
                        }
                        if (laskuvast == 2)
                        {
                            Console.WriteLine("Ei sitten");
                            Console.Clear();
                        }
                        if (laskuvast < 1 || laskuvast > 2)
                        {
                            Console.WriteLine("Väärä vastaus!");
                            laskuvast = laskuvast - laskuvast;
                        }
                    }
                    while (laskuvast == 0);
                    /*do
                    {
                        if (c == 0)
                        {
                            Console.WriteLine("Jatketaanko laskemista? 1 - kyllä        2 - ei");
                            c = Convert.ToInt32(Console.ReadLine());
                        }
                        if (c == 1)
                        {
                            vast = vast - vast;
                            Console.Clear();

                        }
                        if (c == 2)
                        {
                            Console.WriteLine("Ei sitten. :(");
                        }
                        if (c <= 0 || c >= 3)
                        {
                            Console.WriteLine("Väärä vastaus");
                            c = c - c;
                        }
                    }
                    while (c == 0);
                    */
                }
                while (vast == 0);
            }
        }
    }
}
