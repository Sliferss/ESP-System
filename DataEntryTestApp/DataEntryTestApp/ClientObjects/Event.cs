using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryTestApp
{
    public class Event
    {
        public string eventName;
        public List<Store> stores;
        public List<Staff> staffMembers;
        public List<Item> eventItems; // base items without stock values assigned

        //copy constructor
        public Event(string _eventName, List<Store> _stores, List<Staff> _staffMembers, List<Item> _eventItems)
        {
            eventName = _eventName;
            stores = _stores;
            staffMembers = _staffMembers;
            eventItems = _eventItems;
        }
        //empty constructor
        public Event(string _eventName)
        {
            eventName = _eventName;
            stores = new List<Store>();
            staffMembers = new List<Staff>();
            eventItems = new List<Item>();
        }

        public float GetEventProfit()
        {
            float profit = 0;
            foreach (Store foo in stores)
            {
                profit += foo.GetProfit();
            }
            return profit;
        }

        //gets the ammount of money spent on the entire inventory of the event
        public float GetEventInvestment()
        {
            float cost = 0;
            foreach(Store foo in stores)
            {
                cost += foo.GetInvestmentOnInventory();
            }
            return cost;
        }

        //checks if passed staff member is a normal member of staff, or a manager
        public bool CheckIsManager(Staff _staffMember)
        {
            foreach(Store foo in stores)
            {
                if(foo.manager == _staffMember)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
