using System;
using System.Net.Sockets;

namespace phone
{
    class Program
    {
        public static PhoneBook phonelist = new PhoneBook();
        static void Main(string[] args)
        {

            phonelist.InsertPhone("son","123");
            phonelist.InsertPhone("vui", "456");
            phonelist.InsertPhone("tan","789");
        /*    Enter();
            Enter();
            phonelist.viewPhone();
            delete();
            phonelist.viewPhone();
            Update();
            phonelist.viewPhone();
            Search();*/
            int tim = -1;
            do
            {
                Console.WriteLine("enter number 0 show");
                Console.WriteLine("enter number 1 Insert Phone ");
                Console.WriteLine("enter number 2 Remove Phone");
                Console.WriteLine("enter number 3 Update Phone");
                Console.WriteLine("enter number 4 Search Phone");
                Console.WriteLine("enter number 5 Sort");
                Console.WriteLine("enter number 6 exit");
                Console.WriteLine("Enter the number to search");

                tim = Convert.ToInt32(Console.ReadLine());
                switch (tim)
                {
                    case 0:
                        phonelist.viewPhone();
                        break;
                    case 1:
                        Enter();
                        phonelist.viewPhone();
                        break;
                    case 2:
                        delete();
                        phonelist.viewPhone();
                        break;
                    case 3:
                        Update();
                        phonelist.viewPhone();
                        break;
                    case 4:
                        Search();
                        break;
                    case 5:
                        Sort_();
                        break;
                    case 6:
                        Console.WriteLine("exit....");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("not found");
                        break;
                }
            }
            while (true);

        }

        public static void Enter()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter phone: ");
            string num = Console.ReadLine();
            phonelist.InsertPhone(name, num);
        }
        public static void delete()
        {
            Console.WriteLine("Enter the name you want to delete");
            string namedelete = Console.ReadLine();
            phonelist.RemovePhone(namedelete);

        }
        public static void Search()
        {
            Console.WriteLine("nhap ten can tim");
            string Searchname = Console.ReadLine();
            phonelist.SearchPhone(Searchname);
        }
        public static void Update()
        {
            Console.WriteLine("nhap ten can sua");
            string Name = Console.ReadLine();
            Console.WriteLine("nhap sdt can sua");
            string Phonenumber = Console.ReadLine();
            phonelist.UpdatePhone(Name, Phonenumber);
        }
        public static void Sort_()
        {

        }
    }
}
