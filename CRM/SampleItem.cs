using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FontusHealthCRM
{
    class SampleItem
    {
        //attributes
        public int productID { get; }
        private int sampleID;
        public int quantity { get; }
        public decimal price { get; }
        public string SampleItemSummary { get; }

        //constructor
        public SampleItem(int intproduct, int intsampleID, int intquantity, string itemSummary, decimal decPrice)
        {
            productID = intproduct;
            sampleID = intsampleID;
            quantity = intquantity;
            SampleItemSummary = itemSummary;
            price = decPrice;
        }
    }
}
