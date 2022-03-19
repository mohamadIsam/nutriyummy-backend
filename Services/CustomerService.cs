namespace nutriyummy.Services;

using nutriyummy.Model;

public class CustomerService : ICustomerService
{
    IMongoDbService mongoDbService;

    public CustomerService(IMongoDbService mongoDbService)
    {
        this.mongoDbService = mongoDbService;
    }

    public List<CustomerModel> getAllCustomers()
    {
        return this.mongoDbService.getAll<CustomerModel>("CustomerModel");

    }

    public void registerCustomer(CustomerModel customerModel) { 
        this.mongoDbService.save<CustomerModel>(customerModel, "CustomerModel");
    }

}