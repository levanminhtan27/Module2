using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace posts
{
    class Post : IPost
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public float AverageRate { get; private set; }
        public List<int> Counts = new List<int>();

        
        public Post( int ID, string Title, string Content ,string Author, float AverageRate)
        {
            this.ID = ID;
            this.Title = Title;
            this.Content = Content;
            this.Author = Author;
        }

        public Post(string title, string author, string content)
        {
            Title = title;
            Author = author;
            Content = content;
        }

        public void Display()
        {
            Console.WriteLine( $"{ID}\t{Title}\t{Content}\t{Author}\t{Counts}\t{AverageRate}" );       
        }

        public void CalculatorRate()
        {
            float total = 0;
            foreach (var item in Counts)
            {
                total += item;
            }
            AverageRate = total / Counts.Count;
        }
    }
}
