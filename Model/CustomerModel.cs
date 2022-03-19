namespace nutriyummy.Model;

using MongoDB.Bson;
public class CustomerModel
{
    public ObjectId id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
}