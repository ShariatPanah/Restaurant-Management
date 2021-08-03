using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.BLL
{
    public class Invoice
    {
        public int FoodCode { get; set; }
        public int InvoiceNo { get; set; }
        public string InvoiceType { get; set; }
        public int TableNo { get; set; }
        public long Amount { get; set; }
        public int FoodCount { get; set; }
        public long PriceForOne { get; set; }
        public string InvoiceDate { get; set; }
    }
}
