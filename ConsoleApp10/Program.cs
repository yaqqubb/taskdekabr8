using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Xml;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task 1");
            Console.Write("4 reqemli eded daxil edin:");
        l1:
            string aStr = Console.ReadLine();
            if (int.TryParse(aStr, out int a) && aStr.Length == 4)
            {
                int sum = 0;

                while (a > 0)
                {
                    sum += a % 10;
                    a /= 10;

                }
                Console.WriteLine($"Ededin reqemleri cemi: {sum}");

            }

            else
            {
                Console.WriteLine("Eded 4 reqemli deyil");
                goto l1;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Task 2 ");
            Console.Write("6 reqemli eded daxil edin: ");
        l3:
            string bStr = Console.ReadLine();

            if (int.TryParse(bStr, out int b) && bStr.Length == 6)
            {
                int sum = 0;
                int bninilk3reqemi = b / 1000;
                while (bninilk3reqemi > 0)
                {
                    sum += bninilk3reqemi % 10;
                    bninilk3reqemi /= 10;

                }
                Console.WriteLine("Ilk 3 reqemin cemi: " + sum);
            }

            else
            {
                Console.WriteLine("Eded 6 reqemli deyil!");
                goto l3;
            }

            Console.WriteLine("");
            Console.WriteLine("Task 3");
            Console.WriteLine("9 reqemli eded daxil edin:");
        l4:
            string cStr = Console.ReadLine();

            if (int.TryParse(cStr, out int c) && cStr.Length == 9)
            {
                int sum = 0;
                int cninilk6reqemi = c / 1000;
                int i11 = 0;


                while (cninilk6reqemi > 0 && i11 < 3)
                {


                    sum += cninilk6reqemi % 10;
                    cninilk6reqemi /= 10;
                    i11++;


                }

                Console.WriteLine(sum);

            }
            else
            {
                Console.WriteLine("Eded 9reqemli deyil!");
                goto l4;
            }



            Console.WriteLine(" ");
            Console.WriteLine("Task 4 ");
            Console.Write("5 reqemli eded daxil edin: ");
        l5:
            string dStr = Console.ReadLine();
            if (int.TryParse(dStr, out int d) && dStr.Length == 5)
            {
                int d1 = d % 10;
                int d2 = d / 10000;
                int d3 = (d1 + d2) * (d1 + d2);
                Console.WriteLine("Ilk ve son ededin ceminin kvadrati: " + d3);
            }

            else
            {
                Console.WriteLine("Eded 5 reqemli deyil!");
                goto l5;
            }


            Console.WriteLine(" ");
            Console.WriteLine("Task 5");
            Console.Write("6 reqemli eded daxil edin: ");
            int res = Task5(Console.ReadLine());
            Console.WriteLine(res);



            Console.WriteLine("");
            Console.WriteLine("Task 6");
            Console.Write("8 reqemli eded daxil edin: ");
        l7:
            string fStr = Console.ReadLine();
            if (int.TryParse(fStr, out int f) && fStr.Length == 8)
            {
                int a0 = f % 10000000;
                int b0 = a0 / 10;
                Console.WriteLine("Ilk ve son reqemler legv edilir: " + b0);

            }

            else
            {
                Console.WriteLine("Eded 8 reqemli deyil!");
                goto l7;
            }



            Console.WriteLine("");
            Console.WriteLine("Task 7");
            Console.Write("4 reqemli eded daxil edin: ");
        l8:
            string gStr = Console.ReadLine();
            if (int.TryParse(gStr, out int g) && gStr.Length == 4)
            {

                int a11 = g % 10;
                int a1 = g / 10;
                int b11 = a1 % 10;
                int b1 = g / 100;
                int c11 = b1 % 10;
                int c1 = g / 1000;
                int cem = (a11 * 1000) + (b11 * 100) + (c11 * 10) + c1;
                int cem1 = 800008 + cem * 10;
                Console.WriteLine(cem1);


            }


            else
            {
                Console.WriteLine("Eded 4 reqemli deyil!");
                goto l8;
            }


            Console.WriteLine(" ");
            Console.WriteLine("Task 8");
            Console.WriteLine("Eded daxil edin: ");
        l9:
            string jStr = Console.ReadLine();
            if (int.TryParse(jStr, out int j))
            {
                int a22 = j % 10;
                int b22 = j / 100;
                int b1 = b22 % 10;
                Console.WriteLine($"Axirdan 3cu reqemin ve sonuncu reqemin cemi: {a22 + b1}");


            }

            else
            {
                Console.WriteLine("Eded daxil edin!");
                goto l9;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Task 9");
            Console.Write("9 reqemli eded daxil edin: ");
        l10:
            string pStr = Console.ReadLine();
            if (int.TryParse(pStr, out int p) && pStr.Length == 9)
            {
                int a33 = p % 10;
                int b33 = p / 100; int b1 = b33 % 10;
                int c33 = p / 10000; int c1 = c33 % 10;
                int d33 = p / 1000000; int d1 = d33 % 10;
                int e33 = p / 100000000; int e1 = e33 % 10;
                int cem = (e1 * 10000) + (d1 * 1000) + (c1 * 100) + (b1 * 10) + a33;
                Console.WriteLine(cem);


            }
            else
            {
                Console.WriteLine("Eded 9 reqemli deyil!");
                goto l10;
            }



            Console.WriteLine(" ");
            Console.WriteLine("Task 10");
            Console.Write("9 reqemli eded daxil edin: ");
        l11:
            string hStr = Console.ReadLine();
            if (int.TryParse(hStr, out int h) && hStr.Length == 9)
            {
                int a44 = h % 10;
                int b44 = h / 100; int b444 = b44 % 10;
                int c44 = h / 10000; int c444 = c44 % 10;
                int d44 = h / 1000000; int d144 = d44 % 10;
                int e44 = h / 100000000; int e144 = e44 % 10;
                int cem = (e144 * 10000) + (d144 * 1000) + (c444 * 100) + (b444 * 10) + a44;
                Console.WriteLine($"Ededin tek yerinde duran reqemlerinden eded: {cem}");
                int a1 = h / 10; int a2 = a1 % 10;

                int c2 = h / 1000; int c3 = c2 % 10;
                int d2 = h / 100000; int d3 = d2 % 10;
                int e2 = h / 10000000; int e3 = e2 % 10;
                int cem1 = (e3 * 1000) + (d3 * 100) + (c3 * 10) + a2;
                Console.WriteLine($"Ededin cut yerde duran reqemlerinden eded: {cem1}");
                int cem2 = cem1 + cem;
                Console.WriteLine($"Bu ikisinin cemi: {cem2}");

            }

            else
            {
                Console.WriteLine("Eded 9reqemli deyil!");
                goto l11;
            }



            Console.WriteLine(" ");
            Console.WriteLine("Task 11");
            Console.Write("8 reqemli eded daxil edin: ");
        l12:
            string yStr = Console.ReadLine();
            if (int.TryParse(yStr, out int y) && yStr.Length == 8)
            {
                int a55 = y / 1000000;
                int b55 = y % 100;
                int c55 = (y / 100) % 100;
                int d55 = (y / 10000) % 100;
                Console.WriteLine($"Bu ededin reqemleri iki iki qruplasdirildi: {a55}, {d55}, {c55} ve {b55}");
                int cem = a55 + b55 + c55 + d55;
                Console.WriteLine($"Bu qrupdaki ededlerin cemi tapilir: {cem}");
                int cem99 = cem * 100 + 99;
                Console.WriteLine($"Alinan cavabina axirina 99 artiriq: {cem99}");
                int cem1 = cem99 - (cem99 * 18) / 100;
                Console.WriteLine($"Bu ededden ozunun 18 faizini cixiriq: {cem1} ");
            }

            else
            {
                Console.WriteLine("Eded 9reqemli deyil!");
                goto l12;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Task 12");
            Console.Write("Ilk 5 reqemli ededi daxil edin: ");
        l13:
            string f1Str = Console.ReadLine();
            Console.Write("Ikinci 5 reqemli ededi daxil edin: ");
            string lStr = Console.ReadLine();
            if (int.TryParse(lStr, out int l) && int.TryParse(f1Str, out int f1) && lStr.Length == 5 && f1Str.Length == 5)
            {
                int lninaxirincireqemi = l % 10;
                int sum = 0;
                while (l > 0)
                {
                    sum += l % 10;
                    l /= 10;

                }
                int sum1 = 1;
                while (f1 > 0)
                {
                    sum1 *= f1 % 10;
                    f1 /= 10;
                }
                Console.WriteLine($"Ilk ededin reqemleri cemi: {sum}");
                Console.WriteLine($"Ikinci ededin reqemleri hasili: {sum1}");
                int sum2 = sum + sum1;
                Console.WriteLine($"Cem ve hasilin cemi: {sum2}");
                int sum3 = sum2 * 10 + lninaxirincireqemi;
                Console.WriteLine($"Son aldigimiz ededin axirina ilk daxil etdiyimiz ededin son reqemini gelirik: {sum3}");

            }

            else
            {
                Console.WriteLine("Ededlerin ikisi de 5reqemli olmalidir!");
                goto l13;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Task 13");
            Console.Write("Ilk 5 reqemli ededi daxil edin: ");
        l15:
            string mStr = Console.ReadLine();
            Console.Write("Ikinci 5 reqemli ededi daxil edin: ");
            string oStr = Console.ReadLine();
            Console.Write("Ucuncu 5 reqemli ededi daxil edin: ");
            string iStr = Console.ReadLine();
            if (int.TryParse(mStr, out int m) && int.TryParse(oStr, out int o) && int.TryParse(iStr, out int i) && iStr.Length == 5 && oStr.Length == 5 && iStr.Length == 5)
            {
                int a88 = m % 10;
                int a1 = m / 10000;
                int b88 = o % 10;
                int b1 = o / 10000;
                int c88 = i % 10;
                int c1 = i / 10000;
                int aa = a1 * 10 + a88;
                int bb = b1 * 10 + b88;
                int cc = c1 * 10 + c88;
                Console.WriteLine($"Bu ededlerin her birinin ilk ve son reqeminden ededler duzeldilir: {aa} ve {bb} ve {cc}");
                int cem = aa + bb + cc;
                Console.WriteLine($"Bu ededlerin cemi tapilir: {cem}");
                int cem1 = cem / 2 + cem;
                Console.WriteLine($"Bu cemin uzerine oz 50 faizini gelirik: {cem1}");
            }
            else
            {
                Console.WriteLine("Ededlerin hamisi 5 reqemli olmalidir! ");
                goto l15;
            }



            Console.WriteLine(" ");
            Console.WriteLine("Task 14");
            Console.Write("Ilk 6 reqemli ededi daxil edin: ");
        l20:
            string vStr = Console.ReadLine();
            if (int.TryParse(vStr, out int v) && vStr.Length == 6)
            {
                Console.Write("Ikinci 6 reqemli ededi daxil edin: ");
            l21: string xStr = Console.ReadLine();


                if (int.TryParse(xStr, out int x) && xStr.Length == 6)
                {
                    Console.Write("Ucuncu 6 reqemli ededi daxil edin: ");
                l22: string c1Str = Console.ReadLine();
                    if (int.TryParse(c1Str, out int c1) && c1Str.Length == 6)
                    {
                        Console.Write("7 reqemli eded daxil edin: ");
                    l23: string h1Str = Console.ReadLine();
                        if (int.TryParse(h1Str, out int h1) && h1Str.Length == 7)
                        {
                            int v1 = v / 1000;
                            int x1 = x / 1000;
                            int c321 = c / 1000;

                            Console.WriteLine($"6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededler: {v1} ve {x1} ve {c321}");
                            int cem = v1 + x1 + c321;
                            Console.WriteLine($"Bu ededlerin cemi: {cem} ");
                            int h2 = h1 % 10000;
                            Console.WriteLine($"7 reqemli ededin son 4 reqemi: {h2}");
                            int cem1 = cem + h2;
                            Console.WriteLine($"Bu ededin ve 7 reqemli ededin son 4 reqeminden alinan ededin cemi: {cem1}");
                            int h3 = h / 10000;
                            Console.WriteLine($"7 reqemli ededin ilk 3 reqemi: {h3}");
                            int sum1 = 1;
                            while (h3 > 0)
                            {
                                sum1 *= h3 % 10;
                                h3 /= 10;
                            }
                            Console.WriteLine($"7 reqemli ededin ilk 3 reqeminin hasili: {sum1} ");
                            int ferq = cem1 - sum1;
                            Console.WriteLine($"Ilk 3 reqemin hasili ile bayaqki cemin ferqi: {ferq}");
                            int h4 = (ferq * 60) / 100;
                            Console.WriteLine($"Bu ededin 60 faizi: {h4}");
                            int h5 = (h4 * 100) + 60;
                            Console.WriteLine($"Bu ededin axirina 60 artirildi: {h5}");
                            int h6 = h5 - (h5 * 18) / 100;
                            Console.WriteLine($"Bu ededden ozunun 18 faizini cixiriq: {h6}");

                        }
                        else
                        {
                            Console.WriteLine("Eded 7 reqemli deyil!");
                            goto l23;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Eded 6 reqemli deyil!");
                        goto l22;

                    }

                }
                else
                {
                    Console.WriteLine("Eded 6 reqemli deyil!");
                    goto l21;

                }
            }
            else
            {
                Console.WriteLine("Eded 6 reqemli deyil!");
                goto l20;
            }


            Console.WriteLine(" ");
            Console.WriteLine("Task 15");
            Console.Write("3 reqemli ilk ededi daxil edin: ");
        l30:
            string uuStr = Console.ReadLine();
            if (int.TryParse(uuStr, out int uu) && uuStr.Length == 3)
            {
                Console.Write("3 reqemli ikinci ededi daxil edin: ");
            l31:
                string kkStr = Console.ReadLine();
                if (int.TryParse(kkStr, out int kk) && kkStr.Length == 3)
                {
                    Console.Write("6 reqemli ilk ededi daxil edin: ");
                l32:
                    string ooStr = Console.ReadLine();
                    if (int.TryParse(ooStr, out int oo) && ooStr.Length == 6)
                    {
                        Console.Write("6 reqemli ilk ededi daxil edin: ");
                    l33:
                        string bbStr = Console.ReadLine();
                        if (int.TryParse(bbStr, out int bb) && bbStr.Length == 6)
                        {
                            Console.Write("7 reqemli eded daxil edin: ");
                        l34:
                            string ccStr = Console.ReadLine();
                            if (int.TryParse(ccStr, out int cc) && ccStr.Length == 7)
                            {

                                int aaa = kk + uu;
                                int aaa1 = aaa % 100;
                                int aaa2 = aaa1 * aaa1;
                                int aaa3 = kk * 1000 + uu;
                                int cem = aaa3 + aaa2;
                                int son5reqem = cc % 100000;
                                int ferq = son5reqem - cem;
                                int cem6 = bb + oo;
                                int cem66 = cem6 % 1000;
                             
                                
                                int sum71 = cc % 10;
                                int sum72 = (cc / 10) % 10;
                                int sum73 = (cc /100) % 10;
                                int sum74 = ( cc / 1000) % 10;
                                int sum75 = (cc / 10000) % 10;
                                int sum76 = (cc / 100000) % 10;
                                int sum77 = (cc / 1000000) % 10;
                                int soneded = sum77 * 1000000 + sum76 * 100000 + sum75 * 10000 + sum74 * 1000 + sum73 * 100 + sum72 * 10 + sum71;

                                Console.WriteLine($"3 reqemli ededlerin cemini tapiriq: {aaa}");
                                Console.WriteLine($"Cemin axirdan 2 reqeminin kvadratini tapiriq: {aaa2}");
                                Console.WriteLine($"Cavabin ustune is 3reqemli ededlerin bir birine yapisdirilmasindan emele gelen ededi gelirik: {cem}");
                                Console.WriteLine($"7 reqemli ededin son 5 reqemini tapiriq: {son5reqem}");
                                Console.WriteLine($"Bu ededi bayaqki cavabdan cixiriq: {ferq}");
                                Console.WriteLine($"6 reqemli ededlerin cemini tapiriq: {cem6}");
                                Console.WriteLine($"6 reqemli ededin son 3 reqemini tapiriq: {cem66}");
                                
                                  int sum7 = 0;
                                while (cc > 0)
                                {
                                    sum7 += cc % 10;
                                    cc /= 10;


                                }
                                Console.WriteLine($"7 reqemli ededin reqemlerinin cemini tapiriq: {sum7}");
                                
                                Console.WriteLine($"{sum71} + {sum72} + {sum73} + {sum74} + {sum75} + {sum76} + {sum77}");
                                Console.WriteLine($"7 reqemli ededin reqemlerinin ceminin tersine yazisilisi: {soneded} ");
                                
                            }
                            else
                            {
                                Console.WriteLine("Eded 7 reqemli deyil!");
                                goto l34;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Eded 6 reqemli deyil!");
                            goto l33;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Eded 6 reqemli deyil!");
                        goto l32;
                    }
                }

                else
                {
                    Console.WriteLine("Eded 3 reqemli deyil!");
                    goto l31;
                }


            }

            else
            {
                Console.WriteLine("Eded 3 reqemli deyil!");
                goto l30;
            }































            Console.ReadKey();
                

            
        }

        static int Task5(string eStr)
        {

            int e;
            
            while (!int.TryParse(eStr, out e) || !(eStr.Length == 6))
            {

                Console.WriteLine("Eded 6 reqemli deyil!");
                eStr = Console.ReadLine();
            }

            int a77 = e / 100000;
            int a777 = e - (a77 * 100000);
            int b77 = a777 * 10 + a77;

   
            return b77 ;
        }
    }

}
