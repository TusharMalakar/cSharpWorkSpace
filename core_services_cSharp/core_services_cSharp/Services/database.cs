using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;

namespace core_services_cSharp.Services
{
    public class database
    {

        static void Main(string[] args)
        {
            MongoClient mongoClient = new MongoClient("mongodb://capstone:mongopassword@cluster0-shard-00-00-we2hu.mongodb.net:27017,cluster0-shard-00-01-we2hu.mongodb.net:27017,cluster0-shard-00-02-we2hu.mongodb.net:27017/client_example?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin&retryWrites=true");

            //Get Database and Collection  //hunter_collab.users
            IMongoDatabase db = mongoClient.GetDatabase("hunter_collab");
            var collList = db.ListCollections().ToList();
            Console.WriteLine("The list of collections are :");
            foreach (var item in collList)
            {
                Console.WriteLine(item);
            }

        }

    }
}
