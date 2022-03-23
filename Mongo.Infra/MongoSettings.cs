using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace Mongo.Infra
{
    public class MongoSettings
    {
        private MongoClient client;
        private IMongoDatabase database;

        public MongoSettings(AppSettings appsettings)
        {
            this.client = new MongoClient(appsettings.ConnectionString);
            this.database = this.client.GetDatabase(appsettings.DatabaseName);
        }

        public MongoClient Client { get => client; set => client = value; }
        public IMongoDatabase Database { get => database; set => database = value; }
    }
}
