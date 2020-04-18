using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryTestApp
{
    public class StoreItem
    {
        public Item item { get; set; } 
        public int stock { get; set; } // the number at the beginning of the event
        public int sold { get; set; } 

        //copy constructor
        public StoreItem( Item _item, int _stock)
        {
            item = _item;
            stock = _stock;
            sold = 0;
        }

        //full Data Constructor
        public StoreItem(Item _item, int _stock, int _sold)
        {
            item = _item;
            stock = _stock;
            sold = _sold;
        }

        public void SetSaleCount(int _sold)
        {
            sold = _sold;
        }

        //returns the number of the item remaining after sales
        public float ItemsRemaining()
        {
            return (float)(stock - sold);
        }

        //gets the proffit of the inventory item
        public float GetProfitOfItem()
        {
            int unsold = stock - sold;
            float profit = item.proffitPerUnit * sold;
            profit -= item.buyPrice * unsold;
            return profit;
        }
    }
}
