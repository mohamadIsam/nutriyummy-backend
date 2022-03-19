namespace nutriyummy.Services;

using nutriyummy.Model;
public interface ICustomerService {

    List<CustomerModel> getAllCustomers();

    void registerCustomer(CustomerModel customerModel);
}