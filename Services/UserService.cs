namespace nutriyummy.Services;

using nutriyummy.Model;
public class UserService: IUserService {

    private IMongoDbService mongoDbService;
    public UserService(IMongoDbService mongoDbService) {
        this.mongoDbService = mongoDbService;
    }

    public void register(UsreModel userModel) {
        mongoDbService.save<UsreModel>(userModel, "UsreModel");
    }

    public List<UsreModel> getAllUsers() {
        return mongoDbService.getAll<UsreModel>("UsreModel");
    }
}