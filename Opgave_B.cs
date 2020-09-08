using System;
using System.Collections.Generic;
using System.Linq;

namespace ListSearch
{
    class Car
    {
        private static int counter = 0;

        private int id;

        public int Id { get { return id; } }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // Default constukter
        public Car(string model, string brand, int year, int price, string color)
        {
            counter++;
            id      = counter;  // int
            Model   = model;    // string
            Brand   = brand;    // string
            Year    = year;     // int
            Price   = price;    // int
            Color   = color;    // string
        }

        public override string ToString()
        {
            // return base.ToString();
            return $"id: {id}, Model: {model}, Brand: {brand}, Year: {year}, Price: {price}, Color: {color}";
        }

        // public static void UdskrivListe(List<int> input)
        // {
        //     foreach (var item in input)
        //     {
        //         Console.WriteLine(item);
        //     }
        // }        
    }
}