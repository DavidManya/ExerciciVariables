﻿using System;

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

            //Fase 2
            int anyinici = 1948;
            int naixement;
            int dif;
            int traspas = 4;
            int quants;

            //Demanar que introdueixi data de naixement
            Console.WriteLine("Introdueix la teva data de naixement i prem Enter");
            naixement = Convert.ToInt32(Console.ReadLine());

            //Calculem diferència d'anys
            dif = naixement - anyinici;
            //Calculem quants anys de traspàs hi ha entre 1948 i l'any de naixement introduït
            quants = dif / traspas;
            Console.WriteLine("Entre 1948 i el teu any de naixement hi ha " + quants + " anys de traspàs");
        }
    }
}
