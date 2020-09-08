using System;
using System.Collections.Generic;
using System.Linq;

namespace ListSearch
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Console.WriteLine("Hello World!");

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


            UdskrivListe(ny_liste_mindre_end_nul_lambda);
            UdskrivListe(ny_liste_mindre_end_syv_lambda);
            UdskrivListe(ny_liste_mindre_end_fire_lambda);


        }

        private static void UdskrivListe(List<int> ny_liste_mindre_end_nul_lambda)
        {
            foreach (var item in ny_liste_mindre_end_nul_lambda)
            {
                Console.WriteLine(item);
            }
        }

        // Cykel minCykel = new Cykel() {Id = 1, Navn = "SCO"}
    }
}
