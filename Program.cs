internal class Program
{
    private static void Main(string[] args)
    {
        //P1();
        //P2();
        //P3();
        //P4();
        //P5();
        //P6();
        //P7();
        //P8();
        //P9();
        //P10();
        //P11();
        //P12();
        //P13();
        //P14();
        //P15();
        //P16();
        //P17();
        Console.ReadKey();
    }

    private static void P12()
    {
        int n, predecesor = 0, cuvinte = 0, cuvantCurent = 0;
        Console.Write("Lungimea secventei n: ");
        n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            int i = int.Parse(Console.ReadLine());
            if (i != 0)
            {
                cuvantCurent++;
            }
            else
            {
                if (predecesor != 0)
                {
                    cuvinte++;
                    cuvantCurent = 0;
                }
            }
            predecesor = i;
            n--;
        }

        if (predecesor != 0)
        {
            cuvinte++;
        }

        Console.WriteLine($"Numarul de cuvinte din secventa n este {cuvinte}");
    }

    private static void P11()
    {
        int n, predecesor = -1;
        float sumaInv = 0;
        Console.Write("Lungimea secventei n: ");
        n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            float i = float.Parse(Console.ReadLine());
            sumaInv += 1 / i;
            n--;
        }
        Console.WriteLine($"Suma inverselor numerelor din secventa este {sumaInv}");
    }

    private static void P10()
    {
        int n, predecesor = -1, secventaCurentaNrEgale = 0, maxSecventaNrEgale = 0;
        Console.Write("Lungimea secventei n: ");
        n = int.Parse(Console.ReadLine());


        if (n > 0)
        {
            predecesor = int.Parse(Console.ReadLine());
            secventaCurentaNrEgale = 1;
            maxSecventaNrEgale = 1;
            n--;
        }

        while (n > 0)
        {
            int i = int.Parse(Console.ReadLine());
            if (predecesor == i)
            {
                secventaCurentaNrEgale++;
            }
            else secventaCurentaNrEgale = 1;

            if (secventaCurentaNrEgale > maxSecventaNrEgale)
            {
                maxSecventaNrEgale = secventaCurentaNrEgale;
            }
            predecesor = i;
            n--;
        }
        Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este {maxSecventaNrEgale}");
    }

    private static void P9()
    {
        int n, max = int.MinValue, min = int.MaxValue, predecesor = -1, secventa = 0;
        Console.Write("Lungimea secventei n: ");
        n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            int i = int.Parse(Console.ReadLine());
            if ((predecesor < i) && (i > max))
            {
                secventa++;
                predecesor = i;
                max = i;
            }
            else
                if ((predecesor > i) && (i < min))
                {   
                    secventa++;
                    min = i;
                    predecesor = i;
                }
                else
                {
                    secventa = 0;
                    Console.WriteLine("Secventa n nu e monotona.");
                    break;
                }
            n--;
        }
        if (secventa > 0) Console.WriteLine("Secventa n e monotona.");
    }

    private static void P8()
    {
        int n, k, f = 0, a = 0, b = 1;
        Console.WriteLine("Al catelea element din sirul lui Fibonacci vrei sa il aflii?");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            f = a + b;
            a = b;
            b = f;
        }

        Console.WriteLine($"Al {n}-lea element din sirul lui fibonacci este {f}");
    }

    private static void P7()
    {
        int n, min = int.MaxValue, max = int.MinValue;
        Console.Write("Lungimea secventei n: ");
        n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            int i;
            i = int.Parse(Console.ReadLine());
            if (min >= i)
                min = i;
            if (max <= i)
                max = i;
            n--;
        }

        Console.WriteLine($"Maximul este {max}, minimul este {min}");
    }

    private static void P6()
    {
        int n, maxim = -1;
        Console.Write("Lungimea secventei: ");
        n = int.Parse(Console.ReadLine());

        bool ordonat = true;
        while (n > 0)
        {
            int i;
            i = int.Parse(Console.ReadLine());
            if (maxim <= i)
                maxim = i;
            else
                ordonat = false;
            n--;
        }

        if (ordonat)
            Console.WriteLine("Secventa e ordonata crescator.");
        else
            Console.WriteLine("Secventa nu e ordonata crescator.");
    }

    private static void P5()
    {
        int n, pos = 0, nrCautate = 0;
        Console.Write("Lungimea secventei: ");
        n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            int i;
            i = int.Parse(Console.ReadLine());

            if (pos == i)
                nrCautate++;

            pos++;
            n--;
        }

        Console.WriteLine($"Sunt {nrCautate} numere care au pozitia egala cu valoarea lui.");
    }

    private static void P4()
    {
        int n, a;
        Console.Write("Lungimea secventei n: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Numarul pe care il cautati in secventa: ");
        a = int.Parse(Console.ReadLine());

        int pos = 0, posCautata = 0;
        while (n > 0)
        {
            int i;
            i = int.Parse(Console.ReadLine());
            if (a == i)
            {
                posCautata = pos;
            }
            pos++;
            n--;
        }

        if (posCautata == 0)
            Console.WriteLine($"{a} nu se afla in secventa.");
        else
            Console.WriteLine($"Pozitia lui {a} in secventa este {posCautata}.");
    }

    private static void P3()
    {
        int n, sum = 0, prod = 1;
        Console.Write("Dati un nr n: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            sum += i;
            prod *= i;
        }
        Console.WriteLine($"Suma numerelor de la 1 la {n} este {sum}, " +
            $"iar produsul lor este {prod}");
    }

    private static void P2()
    {
        double n, nrNeg = 0, nrPoz = 0, zerouri = 0;
        Console.Write("Lungimea secventei n: ");
        n = double.Parse(Console.ReadLine());

        while (n > 0)
        {
            double j;
            j = double.Parse(Console.ReadLine());
            if (j < 0)
                nrNeg++;
            else if (j > 0)
                nrPoz++;
            else
                zerouri++;
            n--;
        }

        Console.WriteLine($"Sunt {nrNeg} nr negative, {nrPoz} nr pozitive si " +
            $"{zerouri} zerouri in secventa.");
    }

    private static void P1()
    {
        int n, nrPare = 0;
        Console.Write("Lungimea secventei n: ");
        n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            int i = int.Parse(Console.ReadLine());
            if (i % 2 == 0) nrPare++;
            n--;
        }

        Console.WriteLine($"Sunt {nrPare} numere pare in secventa n");
    }
}