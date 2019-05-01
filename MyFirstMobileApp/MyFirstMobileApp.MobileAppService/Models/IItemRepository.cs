﻿using MyFirstMobileApp.Shared.Models;
using System;
using System.Collections.Generic;

namespace MyFirstMobileApp.Models
{
    public interface IItemRepository
    {
        void Add(Item item);
        void Update(Item item);
        Item Remove(string key);
        Item Get(string id);
        IEnumerable<Item> GetAll();
    }
}
