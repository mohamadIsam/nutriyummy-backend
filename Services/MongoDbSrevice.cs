using MongoDB.Driver;

using nutriyummy.Model;

namespace nutriyummy.Services;

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

    public void Register(RegiserModel user)
    {
        try
        {
            var collection = database.GetCollection<RegiserModel>("UserModel");
            collection.InsertOne(user);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }

    public List<UsreModel> GetAllUsers()
    {
        try
        {
            var collection = database.GetCollection<UsreModel>("UserModel");
            Console.WriteLine("get Collection");
            var result =  collection.Find(_ => true).ToList();
            Console.WriteLine("get Result");
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        return null;
    }
}