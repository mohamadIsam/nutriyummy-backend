namespace nutriyummy.Model;

using MongoDB.Bson;

public class UsreModel
{
    public ObjectId Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public int Rule { get; set; }
}
