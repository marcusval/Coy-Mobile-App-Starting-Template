﻿using SQLite;
using test2.Models;
using Xamarin.Forms;


namespace test2.Data
{
    public class TokenDatabaseController
    {
        static object locker = new object();
        SQLiteConnection database;
        public TokenDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<TokenDatabaseController>();
        }
        public Token GetToken()
        {
            lock (locker)
            {

                if (database.Table<Token>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Token>().First();
                }
            }
        }

        public int SaveToken(Token token)
        {
            lock (locker)
            {
                if (token.Id != 0)
                {
                    database.Update(token);
                    return token.Id;
                }
                else
                {
                    return database.Insert(token);
                }
            }
        }
        public int DeleteToken(int id)
        {
            lock (locker)
            {
                return database.Delete<Token>(id);
            }
        }

    }
}