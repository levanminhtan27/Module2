using System;
using System.Collections.Generic;
using System.Text;

namespace Accessmodifierdemo
{
    class SanPham
    {

        public string name { get; set; }
        public string code { get; set; }
        public double price { get; set; }
        public DateTime date { get; set; }
        public string manufactory { get; set; }

        public string ShowProductInfo()
        {
            return $"{ name}\t{ code}\t{price}\t{date.ToString("ddd, MM, yyyy")}\t \t {manufactory}";
        }

    }
}
