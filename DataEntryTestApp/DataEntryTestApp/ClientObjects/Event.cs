﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryTestApp
{
    class Event
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
    }
}