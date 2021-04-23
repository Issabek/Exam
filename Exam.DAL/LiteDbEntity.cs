using System;
using System.Linq;
using System.Collections.Generic;
using LiteDB;

namespace Exam.DAL
{
    public class LiteDbEntity
    {
        private string ConnectionDb { get; set; }

        public LiteDbEntity(string pathToDb)
        {
            if (string.IsNullOrEmpty(pathToDb))
                throw new Exception("Path is wrong");
            else
                ConnectionDb = pathToDb;
        }

        public List<T> getCollection<T>()
        {
            using (var db = new LiteDatabase(ConnectionDb))
            {
                var myObj = db.GetCollection<T>(typeof(T).Name);

                if (myObj == null)
                    throw new Exception("Object is null");

                return myObj.FindAll().ToList();

            }
        }

        public bool CreateRecords<T>(List<T> datas, out string message)
        {
            try
            {
                using (var db = new LiteDatabase(ConnectionDb))
                {
                    var collection = db.GetCollection<T>(typeof(T).Name);
                    foreach (var item in datas)
                    {
                        collection.Insert(item);
                        collection.EnsureIndex("Id");
                    }
                }
                message = "Success";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
        public bool CreateRecord<T>(T data, out string message)
        {
            try
            {
                using (var db = new LiteDatabase(ConnectionDb))
                {
                    var collection = db.GetCollection<T>(typeof(T).Name);
                    collection.Insert(data);
                    collection.EnsureIndex("Id");
                }
                message = "Success";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
        public bool UpsertRecord<T>(T data, out string message)
        {
            try
            {
                using (var db = new LiteDatabase(ConnectionDb))
                {
                    var collection = db.GetCollection<T>(typeof(T).Name);
                    collection.Upsert(data);
                }
                message = "Success";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public bool UpsertRecords<T>(List<T> datas, out string message)
        {
            try
            {
                using (var db = new LiteDatabase(ConnectionDb))
                {
                    var collection = db.GetCollection<T>(typeof(T).Name);
                    foreach (var item in datas)
                        collection.Upsert(item);
                }
                message = "Success";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public bool UpdateRecord<T>(T data, out string message)
        {
            try
            {
                using (var db = new LiteDatabase(ConnectionDb))
                {
                    var collection = db.GetCollection<T>(typeof(T).Name);
                    collection.Update(data);
                }
                message = "Success";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
        public bool UpdateRecords<T>(List<T> datas, out string message)
        {
            try
            {
                using (var db = new LiteDatabase(ConnectionDb))
                {
                    var collection = db.GetCollection<T>(typeof(T).Name);
                    foreach(var item in datas)
                        collection.Update(item);
                }
                message = "Success";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
    }
}
