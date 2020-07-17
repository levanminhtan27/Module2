using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace IBook
{
    class Book :Ibook
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string PublishDate { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }

        private float averagePrice;
  
        public int[] PriceList = new int[5];
        public Book()
        {
        }
        public Book(int ID, string name,string PublishDate,string Author,string Language)
        {
            this.ID = ID;
            this.name = name;
            this.PublishDate = PublishDate;
            this.Author = Author;
            this.Language = Language;
            
        }
        public void Display()
        {
            Console.WriteLine($"id {ID} \t name : {name} \t PublishDate : {PublishDate} \t" +
                $" Author : {Author}\t Language : {Language} \t AveragePrice : {averagePrice}");
        }

        public float Calculate(int[] PriceList)
        {
            float tong = 0;
            for (int i = 0; i <PriceList.Length; i++)
            {
                tong += PriceList[i];
            }
            return averagePrice = tong / PriceList.Length;
        }

      /*  //internal float Calculate()
        //{
        //    return averagePrice;
        //}*/
    }
}
