using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace posts
{
    class Forum
    {
        public static int increaseID = 0; 
        SortedList<int, Post> Posts = new SortedList<int, Post>(); 
        // tham khao anh Vui!!!
        public void Add()
        {
            increaseID++;
            Console.WriteLine("enter title");
            string title = Console.ReadLine();
            Console.WriteLine("enter Author");
            string author = Console.ReadLine();
            Console.WriteLine("enter content");
            string content = Console.ReadLine();
            Post newpost = new Post(title, author, content);
            newpost.ID = increaseID;
            Posts.Add(newpost.ID,newpost);
        }

        public void Update(int id)
        {
            if (Posts.ContainsKey(id))
            {
                Posts[id].Content = Console.ReadLine();
            }

            else
            {
                Console.WriteLine("not found");
            }
        }

        public void Remove(int id)
        {
            if (Posts.ContainsKey(id))
            { 
                Posts.Remove(id);
            }

            else
            {
                Console.WriteLine("not ID");
            }
        }
        // show ra tất cả những thằng nằm trong danh sách
        //trong danh sách là những đối tượng post
        public void show()
        {//chạy tất cả các key có trong danh sách Posts
            foreach (var key in Posts.Keys)
            {
                //trong sortedlist thì thả key vào [key] chứ ko phải vị trí
                Posts[key].Display();
            }
        }

        public void search(string title)
        {
            int keyfound = 0;
            foreach (var key in Posts.Keys)
            {
                if (Posts[key].Title==title)
                {
                    //nếu tìm thấy title thì lấy cái key của thằng đó
                    //keyfound = key;
                    Posts[key].Display();
                    keyfound++;
                }
            }
            if (keyfound == 0)
            {
                Console.WriteLine("title khong co");
            }
            //key trong danh sách có trường title bằng với title của người dùng nhập vào!
            //Posts[keyfound].Display();
        }
        public void Rating(int id,int rate)
        {
            int keyfound = -1;
            foreach(var key in Posts.Keys)
            {
                if (key == id)
                {
                    keyfound = key;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Post");
                }
            }
            Posts[keyfound].Counts.Add(rate);
        }
        
    }
}
