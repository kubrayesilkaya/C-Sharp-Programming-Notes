﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic List

            List<int> sayilar = new List<int>();

            sayilar.Add(10);
            sayilar.Add(20);

            List<string> isimler = new List<string>() { "ali","ahmet","ayşe"};

            List<Product> urunler = new List<Product>();

            urunler.Add(new Product() { Id=1, Title="Iphone 14", Price=40000 });
            urunler.Add(new Product() { Id=2, Title="Iphone 15", Price=50000 });
            urunler.Add(new Product() { Id=3, Title="Iphone 16", Price=60000 });

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Title + " " + urun.Price);
            }

            urunler.Insert(urunler.Count, new Product() { Id = 4, Title = "Iphone 17", Price = 70000 });

            //urunler.RemoveAt(2);
            //urunler.Remove(urunler[0]);   

            foreach(var urun in urunler)
            {
                Console.WriteLine(urun.Title + " " + urun.Price);
            }

            Console.ReadLine();
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
