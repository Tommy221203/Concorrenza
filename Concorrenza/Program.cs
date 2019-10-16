using System;

namespace Concorrenza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci l'importo da pagare:");
            double totale = double.Parse(Console.ReadLine());
            if (totale<=300)
            {
                double sconto1 = (totale * 10) / 100;
                double parziale1 = totale - sconto1;
                Console.WriteLine($"lo sconto è di {sconto1:c} e l'importo totale è di {parziale1:c}");
            }
            if (totale>300)
            {
                double sottrazione = totale - 300;
                double sconto1 = (totale * 10) / 100;
                double sconto2 = (totale * 20) / 100;
                double sconto = sconto1 + sconto2;
                double parziale2 = totale - sconto;
                Console.WriteLine($"lo sconto è di {sconto:c} e l'ilporto totaale è di {parziale2:c}");
            }
            Console.ReadLine();

        }
    }
}
