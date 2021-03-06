﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace StoreCore.Repository
{
    public class Repozitory<T, Key> : IRepository<T, Key> where T : IIndexable
    {

        private SqlConnection sqlContext;       

        public Repozitory(string databaseName, string serverName, string userName, string password)
        {          
            InitializeRepository(databaseName, serverName, userName, password);
        }

        public IEnumerable<T> GetAll()
        {
            var result = new List<T>();

            return result;
        }

        public T GetById(Key id)
        {
            throw new NotImplementedException();
        }

        public void Add(T element)
        {
            throw new NotImplementedException();
        }

        public void Update(Key id, T element)
        {
            throw new NotImplementedException();
        }

        public void Delete(Key id)
        {
            throw new NotImplementedException();
        }

        private void InitializeRepository(string databaseName, string serverName, string userName, string password)
        {
            var database = new DBContext(databaseName, serverName, userName, password);
            this.sqlContext = database.DbConnection();
        }
    }
}
