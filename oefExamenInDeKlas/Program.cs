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
            string voornaam, famillienaam, resultaatinput = "", antwoord, voornaamLetter, achternaamLetter;
            byte resultaat = 0, aantalRes = 0, aantaltekort = 0, laagste = 100, hoogste = 0, gemmiddelde;
            ushort totaal = 0, totaalok = 0;

            // VRAAG    voornaam
            Console.WriteLine("wat is uw voornaam?: ");
            voornaam = Console.ReadLine();
            // VRAAG    famillienaam
            Console.WriteLine("wat is uw achternaam?: ");
            famillienaam = Console.ReadLine();
            Console.WriteLine("als u al uw punten heeft ingegeven typ dan 101 en uw resultaten zullen verschijnen. ");

            // HERHAAL  
            do
            {
                //   BEREKEN  hoogste
                //    ALS     res > hoogste
                if (resultaat > hoogste)
                {
                    //    DAN     hoogste = res
                    hoogste = resultaat;
                }
                totaalok = totaal;
                //   VRAAG    res
                Console.WriteLine("wat is uw resultaat?: ");
                resultaat = byte.Parse(Console.ReadLine());


                totaal = 0;
                if (totaal <= 100)
                {


                    //    ALS      res is geldig

                    //    DAN      
                    //   BEREKEN  aantalRes +1
                    aantalRes++;
                    //   BEREKEN  totaal + res
                    totaal = (ushort)(totaalok + resultaat);

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


                    //   ANDERS   toon foutboodschap

                }


                // ZOLANG res niet leeg

                if (resultaat == 101)
                {


                    //BEREKEN   gemmiddelde
                    //ALS totaal / aantalresultaten zijn gevonden
                    gemmiddelde = (byte)(totaal / aantalRes);
                    //BEREKEN
                    //ALS   gemmiddelde > 70, aantaltekort = 0
                    if (gemmiddelde > 70 & aantaltekort == 0)
                    {
                        //DAN   onderscheiding
                        antwoord = $"je bent geslaagd met onderscheiding!";
                        Console.WriteLine($"dit is de conclusie van uw examens : {antwoord}");

                    }
                    //ALS   gemmiddelde < 50 & > 70, aantaltekort <= 1
                    else if (gemmiddelde > 50 & aantaltekort <= 1)
                    {
                        //DAN   voldoende
                        antwoord = $"je bent geslaagd proficiat!";
                        Console.WriteLine($"dit is de conclusie van uw examens : {antwoord}");
                    }
                    //ANDERS   spijtig je bent niet geslaagd
                    if (gemmiddelde < 50 & aantaltekort > 1)
                    {

                        antwoord = $"je bent gebuist.";
                        Console.WriteLine($"dit is de conclusie van uw examens : {antwoord}");
                    }

                    // BEREKEN naam
                    //ALS  voornaam is ingegeven
                    //DAN  eerste letter van voornaam en die letter in hoofdletters
                    voornaamLetter = voornaam.Substring(0, 1);
                    voornaamLetter = voornaamLetter.ToUpper();

                    //ALS  achternaam is ingegeven
                    //DAN  achternaam in hoofdletters
                    achternaamLetter = famillienaam.ToUpper();
                    //TOON alle gevraagde gegevens
                    //grootste getal
                    Console.WriteLine($"{voornaamLetter}.{achternaamLetter} dit zijn alle gegevens van uw examens");
                    Console.WriteLine($"het grootste getal is :{hoogste}");
                    Console.WriteLine($"het laagste getal is : {laagste}");
                    Console.WriteLine($"het aantal cijfers is : {aantalRes}");
                    Console.WriteLine($"het gemmiddelde is : {gemmiddelde}");

                }
            } while (string.IsNullOrEmpty(resultaatinput));



            //WACHTEN
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();

        }
    }
}
