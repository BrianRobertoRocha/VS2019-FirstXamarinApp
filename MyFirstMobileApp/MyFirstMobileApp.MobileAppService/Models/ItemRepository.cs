﻿using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using MyFirstMobileApp.Shared.Models;

namespace MyFirstMobileApp.Models
{
    public class ItemRepository : IItemRepository
    {
        private static ConcurrentDictionary<string, Item> items =
            new ConcurrentDictionary<string, Item>();

        public ItemRepository()
        {
            Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Item 1", Description = "This is an item description.", Icon = "https://raw.githubusercontent.com/jamesmontemagno/VS2019-FirstXamarinApp/master/advocado.png" });
            Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Item 2", Description = "This is an item description.", Icon = "https://raw.githubusercontent.com/jamesmontemagno/VS2019-FirstXamarinApp/master/advocado.png" });
            Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Item 3", Description = "This is an item description.", Icon = "https://raw.githubusercontent.com/jamesmontemagno/VS2019-FirstXamarinApp/master/advocado.png" });
        }

        public Item Get(string id)
        {
            return items[id];
        }

        public IEnumerable<Item> GetAll()
        {
            return items.Values;
        }

        public void Add(Item item)
        {
            item.Id = Guid.NewGuid().ToString();
            items[item.Id] = item;
        }

        public Item Find(string id)
        {
            Item item;
            items.TryGetValue(id, out item);

            return item;
        }

        public Item Remove(string id)
        {
            Item item;
            items.TryRemove(id, out item);

            return item;
        }

        public void Update(Item item)
        {
            items[item.Id] = item;
        }
    }
}
