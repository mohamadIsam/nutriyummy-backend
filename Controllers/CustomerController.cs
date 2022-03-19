namespace nutriyummy.Controllers;

using Microsoft.AspNetCore.Mvc;
using nutriyummy.Model;
using nutriyummy.Services;

[ApiController]
[Route("[controller]")]
public class CustomerController
{

    ICustomerService customerService;

    public CustomerController(ICustomerService customerService)
    {
        this.customerService = customerService;
    }

    [HttpGet]
    [Route("getAllCustomers")]
    public List<CustomerModel> getAllCustomers()
    {
        return customerService.getAllCustomers();
    }

    [HttpPost]
    public void registerCustomer([FromBody] CustomerModel customerModel) {
        customerService.registerCustomer(customerModel);
    }
}