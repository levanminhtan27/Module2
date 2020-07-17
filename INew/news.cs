using System;
using System.Collections.Generic;
using System.Text;

namespace INew
{
    class News : INew
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string PublishDate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }

        private float averageRate;
        public News()
        {
        }
        public News(string Title,string PublishDate,string Author,string Content)
        {
            /*this.ID = ID;*/
            this.Title = Title;
            this.PublishDate = PublishDate;
            this.Author = Author;
            this.Content = Content; 
        }
        
        public void DisPlay()
        {
            Console.WriteLine($"title : {Title}  PublishDate: {PublishDate}" +
                $" Author : {Author} Content : {Content} AverageRate : {AverageRate}");
        }

        public float AverageRate
        {
            get => this.averageRate;
        }
        public void Calculate (int [] RateList)
        {
            int sum = 0;
            for (int i=0; i < RateList.Length; i++)
            {
                sum += RateList[i];
            }
            this.averageRate = sum / RateList.Length;
        }

    }
}
