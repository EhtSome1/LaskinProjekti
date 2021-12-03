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

            int kvast = 0;
            int vast = 0;
            int c = 0;
            double x;
            double y;
            double z;
            if (o == 1)
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

                        case 6:
                            Console.WriteLine("Minkä kuvion pinta-ala?       1 - Neliö/Suorakulmio       2 - Suorakulmainen kolmio");
                            kvast = Convert.ToInt32(Console.ReadLine());
                            do
                                switch (kvast)
                                {
                                    case 1:
                                        Console.WriteLine("Anna kanta ja korkeus");
                                        x = Convert.ToDouble(Console.ReadLine());
                                        y = Convert.ToDouble(Console.ReadLine());
                                        projektiX.Laskin olio6 = new projektiX.Laskin();
                                        olio6.NeliA(x, y);
                                        break;

                                    case 2:
                                        Console.WriteLine("Anna kanta ja korkeus");
                                        x = Convert.ToDouble(Console.ReadLine());
                                        y = Convert.ToDouble(Console.ReadLine());
                                        projektiX.Laskin olio7 = new projektiX.Laskin();
                                        olio7.SuorKolmiA(x, y);
                                        break;

                                    default:
                                        Console.WriteLine("Väärä vastaus!");
                                        kvast = kvast - kvast;
                                        break;
                                }
                            while (kvast == 0);
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
                        if (c < 1 || c > 2)
                        {
                            Console.WriteLine("Väärä vastaus");
                            c = c - c;
                        }
                    }
                    while (c == 0);
                }
                while (vast == 0);
            }
        }
    }
}
