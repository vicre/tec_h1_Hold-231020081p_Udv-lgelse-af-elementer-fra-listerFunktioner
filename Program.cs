using System;
using System.Collections.Generic;
using System.Linq;

namespace ListSearch
{
    class Program
    {
        static void Main(string[] args) 
        {
            //
            //----- Opgave A start -----
            //
            List<int> listeAfInt = new List<int>() { 4, 7 , 12, 17, -3, 8, 0, -45, 101};

            // Lambda udtryk
            // Dan liste med alle tal mindre end eller lig 0
            List<int> ny_liste_mindre_end_nul_lambda = listeAfInt.Where(number => number < 0).ToList();
            // Dan liste med alle tal lig 7
            List<int> ny_liste_mindre_end_syv_lambda = listeAfInt.Where(number => number < 0).ToList();
            // Dan liste med alle tal større end 4
            List<int> ny_liste_mindre_end_fire_lambda = listeAfInt.Where(number => number < 0).ToList();

            // konventionelt udtryk
            // Dan liste med alle tal mindre end eller lig 0
            List<int> ny_liste_mindre_end_nul_konvetionel = new List<int>();
            foreach (int item in listeAfInt)
            {
                ny_liste_mindre_end_nul_konvetionel.Add(item);
            }
            // Dan liste med alle tal lig 7
            List<int> ny_liste_mindre_end_syv_konventionel = new List<int>();
            foreach (int item in listeAfInt)
            {
                ny_liste_mindre_end_syv_konventionel.Add(item);
            }
            // Dan liste med alle tal større end 4
            List<int> ny_liste_mindre_end_fire_konventionel = new List<int>();
            foreach (int item in listeAfInt)
            {
                ny_liste_mindre_end_fire_konventionel.Add(item);
            }
            Opgave__A.UdskrivListe(ny_liste_mindre_end_nul_lambda);
            Opgave__A.UdskrivListe(ny_liste_mindre_end_syv_lambda);
            Opgave__A.UdskrivListe(ny_liste_mindre_end_fire_lambda);
            //
            //----- Opgave A slut -----
            //


            //
            //----- Opgave B start -----
            //
            List<Car> cars = new List<Car>
            {
            // model brand year price color
            new Car("Rio", "Kia", 2006, 250000, "Red"),
            new Car("Rio", "Kia", 2007, 265000, "Black"),
            new Car("Panda", "Fiat", 2017, 256000, "Black"),
            new Car("Panda", "Fiat", 2017, 365000, "Yellow"),
            new Car("S40", "Volvo", 2018, 665000, "White"),
            new Car("S65", "Volvo", 2018, 600000, "White"),
            new Car("Gorm", "Ferrari", 2000, 4665000, "White"),
            new Car("Gorm", "Ferrari", 2018, 4665000, "White"),
            };

            // cons

            // Lambda udtryk Udvælg:
            // 1 - alle med Model Rio
            List<Car> ny_liste_alle_med_model_rio_lambda = cars.Where(cars => cars.Model == "Rio").ToList();
            foreach (var item in ny_liste_alle_med_model_rio_lambda)
            {
                System.Console.WriteLine(item.ToString());
            }
            // 2 - alle Brand Ferrari
            List<Car> ny_liste_alle_med_brand_farrari_lambda = cars.Where(cars => cars.Brand == "Ferrari").ToList();
            foreach (var item in ny_liste_alle_med_brand_farrari_lambda)
            {
                System.Console.WriteLine(item.ToString());
            }
            // 3 - alle fra 2010 og frem
            List<Car> ny_liste_alle_fra_2020_og_frem_lambda = cars.Where(cars => cars.Year > 2010).ToList();
            foreach (var item in ny_liste_alle_fra_2020_og_frem_lambda)
            {
                System.Console.WriteLine(item.ToString());
            }
            // 4 - alle hvide biler
            List<Car> ny_liste_alle_hvide_biler_lambda = cars.Where(cars => cars.Color == "White").ToList();
            foreach (var item in ny_liste_alle_hvide_biler_lambda)
            {
                System.Console.WriteLine(item.ToString());
            }
            // 5 - udvælg Car objekt med Id 8
            Car ny_liste_med_bil_nummer_otte_lambda = cars.SingleOrDefault(cars => cars.Id == 8 );
            ny_liste_med_bil_nummer_otte_lambda.ToString();

            //
            //----- Opgave B slut -----
            //
        }
    }
}
