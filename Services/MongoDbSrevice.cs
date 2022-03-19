namespace nutriyummy.Services;

using MongoDB.Driver;
using nutriyummy.Model;
public class MongoDbService : IMongoDbService
{
    MongoClient client;
    IMongoDatabase database;
    public MongoDbService()
    {
        client = new MongoClient(
            "mongodb+srv://dbUser:dbUser@cluster0.9bqap.mongodb.net/nutriyummy?retryWrites=true&w=majority"
        );
        database = client.GetDatabase("nutriyummy");
    }
/*  */
    public void save<T>(T document, string collectionName) {
        try
        {
            var collection = database.GetCollection<T>(collectionName);
            collection.InsertOne(document);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }

    public List<T> getAll<T>(string collectionName) {
        try
        {
            var collection = database.GetCollection<T>(collectionName);
            return collection.Find(_ => true).ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        return null;
    }

}