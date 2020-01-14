using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   //Fase 1
            string nom = "David";
            string cognom1 = "Manyà";
            string cognom2 = "Álvarez";
            int dia = 0;
            string diae = "";
            int mes = 0;
            string mese = "";
            int any = 0;
            string anye = "";
            DateTime data = DateTime.Now;
            string avui = data.ToString("dd/MM/yyyy");
            diae = avui.Substring(0, 2);
            mese = avui.Substring(3, 2);
            anye = avui.Substring(6, 4);

            dia = Convert.ToInt32(diae);
            mes = Convert.ToInt32(mese);
            any = Convert.ToInt32(anye);

            Console.WriteLine($"El meu nom és {cognom1} {cognom2}, " + nom);
            Console.WriteLine($"Avui és {dia}/{mes}/{any}");
            Console.WriteLine($"Avui és {diae}/{mese}/{anye}");
            Console.WriteLine("------------------------------------------");

            //Fase 2
            int anyinici = 1948;
            int naixement;
            int dif;
            int traspas = 4;
            int quants;

            //Demanar que introdueixi any de naixement
            Console.WriteLine("Introdueix el teu any de naixement i prem Enter");
            naixement = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

            //Calculem diferència d'anys i treiem l'introduït si és de traspàs
            dif = naixement - anyinici;
            if (naixement % traspas == 0)
            {
                dif = dif - 1;
            }
            //Calculem quants anys de traspàs hi ha entre 1948 i l'any de naixement introduït
            quants = dif / traspas;
            Console.WriteLine("Entre 1948 i el teu any de naixement hi ha " + quants + " anys de traspàs");

            //Fase 3
            bool estraspas = false;
            int anytraspas;

            if (dif > 4)
            {
                for (int i = 1; i <= quants; i++)
                {
                    anytraspas = anyinici + (traspas * i);
                    if (anytraspas!= naixement)
                    {
                        Console.WriteLine(anytraspas);
                    }
                }
            }

            string sitraspas = "El teu any de naixement és de traspàs";
            string notraspas = "El teu any de naixement NO és de traspàs";

            if (naixement % traspas == 0)
            {
                estraspas = true;
            }

            if (estraspas)
            {
                Console.WriteLine(sitraspas);
            }
            else
            {
                Console.WriteLine(notraspas);
            }

            //Fase 4
            Console.WriteLine("------------------------------------------");

            string dianaixement;
            string mesnaixement;
            string anynaixement;
            string nomsencer;
            nomsencer = ($"{nom} {cognom1} {cognom2}");

            //Recuperem dia naixement i el tractem per si no té dues xifres
            Console.WriteLine("Introdueix el dia del teu naixement");
            dianaixement = Console.ReadLine();
            dia = Convert.ToInt32(dianaixement);
            if ((dia < 10) && (dianaixement.Substring(0,1) != "0"))
            {
                dianaixement = ($"0{dianaixement}");
            }
            //Recuperem mes naixement i el tractem per si no té dues xifres
            Console.WriteLine("Ara introdueix el mes del teu naixement");
            mesnaixement = Console.ReadLine();
            mes = Convert.ToInt32(mesnaixement);
            if ((mes < 10) && (mesnaixement.Substring(0, 1) != "0"))
            {
                mesnaixement = ($"0{mesnaixement}");
            }
            Console.WriteLine("Finalment introdueix l'any del teu naixement");
            anynaixement = Console.ReadLine();

            Console.WriteLine("------------------------------------------");

            Console.WriteLine($"El meu nom és {nomsencer}");
            Console.WriteLine($"Vaig neixer el {dianaixement}/{mesnaixement}/{anynaixement}");
            if (estraspas)
            {
                Console.WriteLine("El meu any de naixement és de traspàs");
            }
            else
            {
                Console.WriteLine("El meu any de naixement NO és de traspàs");
            }
        }
    }
}
