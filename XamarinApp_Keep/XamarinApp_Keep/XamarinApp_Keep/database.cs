﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp_Keep
{
     public class Database
    {
        private SQLiteAsyncConnection database;

        public Database(string dbPath) //inicializace tabulek databáze 
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<keep>().Wait();
            
            database.CreateTableAsync<category>().Wait();
            database.CreateTableAsync<user>().Wait();
            database.CreateTableAsync<pin_password>().Wait();
            database.CreateTableAsync<text_password>().Wait();
            Debug.WriteLine(dbPath);
        }
        

        public Task<List<keep>> GetItemsAsync()
        {
            return database.Table<keep>().ToListAsync();
        }
        public Task<List<category>> GeTItemIDK(string itid)
        {
            return database.QueryAsync<category>("SELECT * FROM [category] WHERE name ='" + itid + "'");
        }

        public Task<List<category>> showKategory()
        {
            return database.QueryAsync<category>("SELECT * FROM [category]");
        }

        public Task<List<user>> back_users()
        {
            return database.QueryAsync<user>("SELECT * FROM [user]");
        }
        public Task<List<pin_password>> login_back_pin()
        {
            return database.QueryAsync<pin_password>("SELECT * FROM [pin_password] WHERE id_user='1'");
        }
        public Task<List<text_password>> login_back_text()
        {
            return database.QueryAsync<text_password>("SELECT * FROM [text_password] WHERE id_user='1'");
        }
        public Task<int> SaveUser(user item)
        {           
                return database.InsertAsync(item);
            
        }
        public Task<int> SaveKeep(keep item)
        {
            return database.InsertAsync(item);

        }
        public Task<int> NewCat(category item)
        {
            return database.InsertAsync(item);

        }
        public Task<int> SavePinPass(pin_password pass)
        {
           
                return database.InsertAsync(pass);
            
        }
        public Task<int> SaveTextPass(text_password pass)
        {
           
            
                return database.InsertAsync(pass);
            
        }

        public Task<List<keep>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<keep>("SELECT * FROM [keep]");
        }

        public Task<keep> GetItemAsync(int id)
        {
            return database.Table<keep>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(keep item)
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

        public Task<int> DeleteItemAsync(keep item)
        {
            return database.DeleteAsync(item);
        }

    }
}
