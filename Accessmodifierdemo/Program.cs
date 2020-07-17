using System;
using System.Dynamic;

namespace Accessmodifierdemo
{   
    class Program
    {
        public static thongtin thongtin = new thongtin();
        static void Main(string[] args)
        {
            CreateProduct();
            CreateProduct();
            thongtin.show();
           /* deletes();
            thongtin.show();*/

            int num = -1;
            do
            {
                Console.WriteLine("nhap 1 de sua");
                Console.WriteLine("nhap 2 de xoa");
                Console.WriteLine("nhap 3 de them");
                Console.WriteLine("nhap 0 de thoat");
                Console.Write("nhap so can su dung");

                num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }
                switch (num)
                {
                    case 1:
                        /*update();
                        thongtin.show();*/
                    case 2:
                        deletes();
                        thongtin.show();
                        break;
                    case 3:
                        CreateProduct();
                        thongtin.show();
                        break;
                }
            }
            while (true);
        }
        public static void CreateProduct()
        {
            Random random = new Random();
            SanPham sanpham1 = new SanPham();

            Console.WriteLine("enter your name : ");
            sanpham1.name = Console.ReadLine();

            sanpham1.code = random.Next(1000, 9999).ToString();

            Console.WriteLine("enter price : ");
            sanpham1.price = double.Parse(Console.ReadLine());

          /*  Console.WriteLine("enter date time : ");*/
            sanpham1.date = DateTime.Now;

            Console.WriteLine("enter manufactory");
            sanpham1.manufactory = Console.ReadLine();

            thongtin.add(sanpham1);

        }
        public static void deletes()
        {
            Console.WriteLine("nhap code muon xoa : ");
            string code = Console.ReadLine();
            thongtin.delete(code);
        }
        public static void update()
        {
            SanPham sanpham = new SanPham();
            Console.Write("nhap ten can sua");
            sanpham.name = Console.ReadLine();
            Console.WriteLine("nhap gia can sua");
            sanpham.price = double.Parse(Console.ReadLine());

            thongtin.edit(sanpham);
        }
    }
}
