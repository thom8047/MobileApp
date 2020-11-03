using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace Example2
{
    public class LinkDatabase 
    {
        readonly SQLiteAsyncConnection database;

        public LinkDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Link>().Wait();
        }

        public Task<List<Link>> GetItemsAsync()
        {
            return database.Table<Link>().ToListAsync();
        }

        public Task<List<Link>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Link>("SELECT * FROM [Link] WHERE [Done] = 0");
        }

        public Task<Link> GetItemAsync(int id)
        {
            return database.Table<Link>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Link item) 
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Link item)
        {
            return database.DeleteAsync(item);
        }
    }
}
