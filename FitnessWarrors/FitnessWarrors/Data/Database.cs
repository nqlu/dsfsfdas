using System;
using FitnessWarrors.Model;
using FitnessWarrors.Data;
using MarcTron.Plugin.MTSql;
using SQLite;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace FitnessWarrors.Data
{
    public class Database
    {
        public SQLiteAsyncConnection CF_database { get; private set; }
        public Database()
        {
            CF_database = MTSql.Current.GetConnectionAsync("w7lab.db");
            CF_database.CreateTableAsync<Session>().Wait();
            CF_database.InsertAsync(new Session { Food = "Beef" ,Calories = "252kcal in 100gram" });
            CF_database.InsertAsync(new Session { Food = "Pork" ,Calories = "262kcal in 100gram" });
            CF_database.InsertAsync(new Session { Food = "Rice" ,Calories = "354kcal in 100gram" });
            CF_database.InsertAsync(new Session { Food = "Chicken", Calories = "182kcal in 100gram" });
        }
        public async Task<List<Session>> GetAllSessionAsync()
        {
            return await CF_database.Table<Session>().ToListAsync();
        }
        public async Task AddSessionsAsync(Session newSession)
        {
            await CF_database.InsertAsync(newSession);
        }
    }
}
