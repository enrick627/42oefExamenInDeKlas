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
            byte resultaat;

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

                    //   BEREKEN  totaal + res

                }

                //    ALS      res < 50
                //    DAN      aantaltekort + 1
                //   BEREKEN  laagste
                //    ALS      res < laagste
                //    DAN      laagste = res
                //   BEREKEN  hoogste
                //    ALS     res > hoogste
                //    DAN     hoogste = res
                //   ANDERS   toon foutboodschap
                // ZOLANG res niet leeg
            }


            //WACHTEN
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();
        }
    }
}
