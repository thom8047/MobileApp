using BrightenTheBrain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightenTheBrain.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Marcus Smith", Description="Here is would you write up some notes about the contact" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "John Brown", Description="Here is would you write up some notes about the contact" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Taylor Martin", Description="Here is would you write up some notes about the contact" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Lee Jackson", Description="Here is would you write up some notes about the contact" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Lewis Clark", Description="Here is would you write up some notes about the contact" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "King Flores", Description="Here is would you write up some notes about the contact" }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}