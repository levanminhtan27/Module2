using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Accessmodifierdemo
{
    class thongtin
    {
        public SanPham[] sanpham1 = new SanPham[0];
        
        public void add (SanPham sanpham)
        {
            Array.Resize(ref sanpham1, sanpham1.Length + 1);
            sanpham1[sanpham1.Length - 1] = sanpham;
        }

        public int search(string code)
        {
            for(int i= 0; i<sanpham1.Length;i++)
            {
                if(sanpham1[i].code.ToUpper() == code.ToUpper())
                {
                    return i;
                }
            }
            return -1;
        }
        public void edit(SanPham sanpham)
        {
            var vitri = search(sanpham.code);
            if (vitri != -1) 
            {
                sanpham1[vitri].name = sanpham.name;
                sanpham1[vitri].price = sanpham.price;
            }
            else
            {
                Console.WriteLine($"code : {sanpham.code} khong tim thay");
            }
        }
        public void delete(string code)
        {
                var vitri = search(code);
                if (vitri != -1)
                {
                    for(int i = vitri; i < sanpham1.Length - 1; i++)
                    {
                        sanpham1[i] = sanpham1[i + 1];
                    }
                    Array.Resize(ref sanpham1, sanpham1.Length - 1);
                }
                else
                {
                    Console.WriteLine($"code : {code} khong tim thay");
                }
        }
        public void show()
        {
          string table =$"name \t code \t price \t date \t \t manufactory";
            for (int i = 0; i < sanpham1.Length; i++)
            {
                table=table + $"\n" + sanpham1[i].ShowProductInfo();
            }
            Console.WriteLine(table);
        }
        
    }
}
