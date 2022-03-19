namespace nutriyummy.Services;

using nutriyummy.Model;
public interface IUserService {

    void register(UsreModel userModel);

    List<UsreModel> getAllUsers();
}