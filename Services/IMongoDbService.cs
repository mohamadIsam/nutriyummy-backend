using nutriyummy.Model;

namespace nutriyummy.Services;

public interface IMongoDbService {

    public void Register(RegiserModel user);
    public List<UsreModel> GetAllUsers();
}