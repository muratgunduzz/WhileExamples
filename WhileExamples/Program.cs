/*1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.*/

using System;

class Program
{
    static void Main()
    {

        //Soru1

        int counter = 0 ;

        while (counter < 5)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            counter++;
        }

        //Soru2

        int num = 1;
        
        while (num < 20)
        {
            Console.WriteLine(num);
            num++;
        }

        //Soru3

        int dnum = 2;

        while (dnum <= 20) 
        { 
            if (dnum %2 == 0)
            {
                Console.WriteLine(dnum);
            }
            dnum++;
        }

        //Soru4

        int tnum = 50;
        int total = 0;

        while (tnum < 150)
        {
            
            total += tnum;
            tnum++;
        }
        Console.WriteLine(total);

        //Soru5

        int ttoplam = 0;
        int ctoplam = 0;
        int ncounter = 1 ;

        while(ncounter <= 120 )
        {
            if (ncounter %2 == 0)
            {
                ctoplam += ncounter;

            }else if (ncounter %2 == 1)
            {
                ttoplam += ncounter;
            }
        ncounter++;
        }
        Console.WriteLine("Çift sayıların toplamı: "+ ctoplam);
        Console.WriteLine("Tek sayıların toplamı: "+ ttoplam);
    }
}