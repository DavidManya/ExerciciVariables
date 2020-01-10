using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
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


        }
    }
}
