﻿//Enrick De Munter 5ITN nr3 14/1/2020
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
            ushort totaal = 0;
            bool resultaatok;
            // VRAAG    voornaam
            Console.WriteLine("wat is uw voornaam?: ");
            voornaam = Console.ReadLine();
            // VRAAG    famillienaam
            Console.WriteLine("wat is uw achternaam?: ");
            famillienaam = Console.ReadLine();


            // HERHAAL  
            do
            {
                //   VRAAG    res
                Console.WriteLine("wat is uw resultaat?: ");
                resultaat = byte.Parse(Console.ReadLine());
                resultaatok = byte.TryParse(resultaatinput, out resultaat);


                //    ALS      res is geldig
                if (resultaatok == true)
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
            } while (string.IsNullOrEmpty(resultaatinput));

            //BEREKEN   gemmiddelde
            //ALS totaal / aantalresultaten zijn gevonden
            gemmiddelde = (byte)(totaal / aantalRes);
            //BEREKEN
            //ALS   gemmiddelde > 70, aantaltekort = 0
            if (gemmiddelde > 70 & aantaltekort == 0)
            {
                //DAN   onderscheiding
                antwoord = $"je bent geslaagd met onderscheiding";
            }
            //ALS   gemmiddelde < 50 & > 70, aantaltekort <= 1
            if (gemmiddelde < 50 & aantaltekort <= 1)
            {
                //DAN   voldoende
                antwoord = $"je bent geslaagd";
            }
            //ANDERS   spijtig je bent niet geslaagd
            else
            {
                antwoord = $"je bent gebuist";
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
            Console.WriteLine($"dit is de conclusie van uw examens : {antwoord}");




            //WACHTEN
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();

        }
    }
}
