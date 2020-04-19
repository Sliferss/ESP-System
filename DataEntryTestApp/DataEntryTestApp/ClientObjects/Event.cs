using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataEntryTestApp
{
    [Serializable()]
    public class Event : ISerializable
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

        //returns the total proffit of the event
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

        //returns a store with the specified name
        public Store GetStore(string _storeName)
        {
            return stores.First(foo => foo.storeName == _storeName);
        }

        //returns the index of the store with the chosen name
        private int GetStoreIndex(string _storeName)
        {
            return stores.FindIndex(foo => foo.storeName == _storeName);
        }

        //picks a store by name, and sets its inventory = to passed List<store>
        public void SetStoreInventory(string _storeName, List<StoreItem> _inventory)
        {
            stores.First(foo => foo.storeName == _storeName).SetInventory(_inventory);
        }

        //checks if any stores have been created, returns false if empty
        public bool StoresExist()
        {
            if (stores.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //returns the number of stores at the event
        public int GetStoreCount()
        {
            return stores.Count();
        }

        public int GetItemCount()
        {
            return eventItems.Count();
        }

        //returns the number of staff on the event
        public int GetEmployeeCount()
        {
            return staffMembers.Count();
        }

        //returns the name of the manager
        public string GetManagerName(Store _store)
        {
            return _store.manager.name;
        }

        //returns satff member with name = to the passed in string
        public Staff GetStaffByName(string _foo)
        {
            return staffMembers.First(bar => bar.name == _foo);
        }

        //returns item with name = to the passed in string
        public Item GetItemByName(string _foo)
        {
            return eventItems.First(bar => bar.name == _foo);
        }

        //returns store with name = passed in string
        public Store GetStoreByName(string _foo)
        {
            return stores.First(bar => bar.storeName == _foo);
        }

        //returns store with specified manager
        public Store GetStoreByManagerName(string _foo)
        {
            return stores.First(bar => bar.manager.name == _foo);
        }

        //sets specified staff member = used
        public void SetStaffMemberUsed(Staff _foo)
        {
            staffMembers.First(bar => bar == _foo).used = true;
        }

        //returns the name of the store target staff is working on
        public string GetStoreNameByStaffMember(Staff _foo)
        {
            foreach(Store bar in stores)
            {
                if(bar.staffOnDuty.Contains(_foo))
                {
                    return bar.storeName;
                }
            }
            return "No Data";
        }

       public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("eventName", eventName);
            info.AddValue("stores", stores);
            info.AddValue("staffMembers", staffMembers);
            info.AddValue("eventItems", eventItems);
        }

        public Event(SerializationInfo info, StreamingContext context)
        {
            eventName = (string)info.GetValue("eventName", typeof(string));
            stores = (List<Store>)info.GetValue("stores", typeof(List<Store>));
            staffMembers = (List<Staff>)info.GetValue("staffMembers", typeof(List<Staff>));
            eventItems = (List<Item>)info.GetValue("eventItems", typeof(List<Item>));
        }
    }
}
