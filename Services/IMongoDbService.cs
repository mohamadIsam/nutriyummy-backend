namespace nutriyummy.Services;

using nutriyummy.Model;
using MongoDB.Driver;

public interface IMongoDbService
{
    void save<T>(T document, string collectionName);
    List<T> getAll<T>(string collectionName);
}