using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repositories.Abstractions.Brands;
using BusinessAutomation.Repositories.Abstractions.Customers;
using BusinessAutomation.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Services.Customers
{
    public class CustomerService : BaseService<Customer>, ICustomerRepository
    {
        ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository) : base(customerRepository)
        {
            this._customerRepository = customerRepository;
        }
    }
}
