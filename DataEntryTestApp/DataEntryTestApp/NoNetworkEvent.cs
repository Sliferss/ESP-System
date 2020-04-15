using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryTestApp
{

    //This class is used for testing when lacking a connection, only for viewing.
    class NoNetworkEvent
    {
        public Event tempEvent;

        //creates a local event that doesnt use the network for demonstration purposes
        public NoNetworkEvent(string _mode)
        {
            if(_mode == "full")
            {
                SetFullEvent();
            }
            else if(_mode == "partial")
            {
                SetPartialEvent();
            }
        }

        private void SetFullEvent()
        {
            tempEvent = new Event("Veggie Traders Union Market");

            tempEvent.eventItems = new List<Item>() { new Item("Banana", 0.90f, 2.50f), new Item("Apple", 0.2f, 0.3f),
                                                     new Item("Pumpkin", 1f, 5.40f), new Item("Orange", 0.3f, 0.4f),
                                                     new Item("Carrot", 0.2f, 0.8f), new Item("Tomato", 0.8f, 0.85f),
                                                     new Item("Avacado", 0.6f, 1.4f), new Item("Hemp", 3.2f, 5.4f),
                                                     new Item("Tofu", 0.3f, 3.2f), new Item("Potato", 0.1f, 0.3f),
                                                     new Item("Leek", 0.5f, 0.9f), new Item("Corriander", 0.3f, 2.01f)};

            tempEvent.staffMembers = new List<Staff>() { new Staff("Chuck Norland", 8.50f), new Staff("Ryan Heyes", 13.23f),
                                                        new Staff("Arnold Grey", 12.50f), new Staff("David Hoppers", 8.50f),
                                                        new Staff("Jim Davies", 8.50f), new Staff("Timmothy Hollands", 8.50f)};

            tempEvent.stores = new List<Store>()
            {
                new Store("Pie Filling Emporium",
                    new List<StoreItem>(){new StoreItem(tempEvent.eventItems[1], 15, 8),
                                            new StoreItem(tempEvent.eventItems[9], 46, 45),
                                            new StoreItem(tempEvent.eventItems[10], 34, 24)},
                    new List<Staff>() { tempEvent.staffMembers[0] },
                    tempEvent.staffMembers[1]),

                new Store("Salads R' Us",
                    new List<StoreItem>(){new StoreItem(tempEvent.eventItems[4], 120, 95),
                                            new StoreItem(tempEvent.eventItems[5], 30, 15),
                                            new StoreItem(tempEvent.eventItems[6], 43, 10),
                                            new StoreItem(tempEvent.eventItems[8], 130, 56),
                                            new StoreItem(tempEvent.eventItems[10], 56, 32),
                                            new StoreItem(tempEvent.eventItems[11], 94, 30)},
                    new List<Staff>() { tempEvent.staffMembers[3], tempEvent.staffMembers[4], tempEvent.staffMembers[5] },
                    tempEvent.staffMembers[2])
            };
        }




        private void SetPartialEvent()
        {
            tempEvent = new Event("Bikini Bottom");

            tempEvent.eventItems =  new List<Item>() { new Item("Crabby Patty", 1f, 5.50f), new Item("Chum Burger", 0.1f, 2f),
                                                     new Item("Kelp Shake", 0.5f, 2.5f), new Item("Kelp Fries", 0.7f, 2f)};

            tempEvent.staffMembers = new List<Staff>() { new Staff("Spongebob Squarepants", 5.5f), new Staff("Eugene Krabs", 120f),
                                                        new Staff("Squidward Tentacles", 5.5f), new Staff("Sheldon Plankton", 0.1f),
                                                        new Staff("Karen Plankton", 8.50f)};

            tempEvent.stores = new List<Store>()
            {
                new Store("The Crusty Crab",
                    new List<StoreItem>(){new StoreItem(tempEvent.eventItems[0], 100),
                                            new StoreItem(tempEvent.eventItems[2], 50),
                                            new StoreItem(tempEvent.eventItems[3], 79)},
                    new List<Staff>() { tempEvent.staffMembers[0], tempEvent.staffMembers[2] },
                    tempEvent.staffMembers[1]),

                new Store("The Chum Bucket",
                    new List<StoreItem>(){new StoreItem(tempEvent.eventItems[1], 300),
                                            new StoreItem(tempEvent.eventItems[2], 15),
                                            new StoreItem(tempEvent.eventItems[3], 1)},
                    new List<Staff>() { tempEvent.staffMembers[4]},
                    tempEvent.staffMembers[3])
            };
        }
    }
}
