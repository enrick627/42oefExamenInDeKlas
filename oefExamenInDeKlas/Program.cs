//Enrick De Munter 5ITN nr3 14/1/2020
/*
 * ANALYSE
 * =======
 * VRAAG    voornaam
 * VRAAG    famillienaam
 * 
 * HERHAAL  
 *   VRAAG    res
 *    ALS      res is geldig
 *    DAN      
 *   BEREKEN  aantalRes +1
 *   BEREKEN  totaal + res
 *    ALS      res < 50
 *    DAN      aantaltekort + 1
 *   BEREKEN  laagste
 *    ALS      res < laagste
 *    DAN      laagste = res
 *   BEREKEN  hoogste
 *    ALS     res > hoogste
 *    DAN     hoogste = res
 *   ANDERS   toon foutboodschap
 * ZOLANG res niet leeg
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefExamenInDeKlas
{
    class Program
    {
        static void Main(string[] args)
        {
            //variabelen
            string voornaam, famillienaam, resultaatinput = "";
            byte resultaat, aantalRes = 0, aantaltekort = 0, laagste =100, hoogste = 0, gemmiddelde ;
            ushort totaal = 0;
            // VRAAG    voornaam
            Console.WriteLine("wat is uw voornaam?: ");
            voornaam = Console.ReadLine();
            // VRAAG    famillienaam
            Console.WriteLine("wat is uw achternaam?: ");
            famillienaam = Console.ReadLine();

            // HERHAAL  
            while (string.IsNullOrEmpty(resultaatinput)
            {
                //   VRAAG    res
                Console.WriteLine("wat is uw resultaat?: ");
                //    ALS      res is geldig
                if (byte.TryParse(resultaatinput, out resultaat))
                {
                    //    DAN      
                    //   BEREKEN  aantalRes +1
                    aantalRes++;
                    //   BEREKEN  totaal + res
                    totaal = (ushort)(totaal + resultaat);

                    //    ALS      res < 50
                    if (resultaat < 50)
                    {
                        //    DAN      aantaltekort + 1
                        aantaltekort++;
                    }

                    //   BEREKEN  laagste
                    //    ALS      res < laagste
                    if (resultaat < laagste)
                    {
                        //    DAN      laagste = res
                        laagste = resultaat;

                    }

                    //   BEREKEN  hoogste
                    //    ALS     res > hoogste
                    if (resultaat > hoogste)
                    {
                        //    DAN     hoogste = res
                        hoogste = resultaat;
                    }
                    //   ANDERS   toon foutboodschap
                    else
                    {
                        Console.WriteLine("dit is de foute boodschap");
                    }
                }
                // ZOLANG res niet leeg
            }
            //BEREKEN gemmiddelde
            gemmiddelde = (byte)( totaal / aantalRes);


            //WACHTEN
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();
        }
    }
}
