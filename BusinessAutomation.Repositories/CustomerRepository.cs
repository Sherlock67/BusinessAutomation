﻿using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repositories.Abstractions.Products;
using BusinessAutomation.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        BusinessAutomationDbContext db;
        public CustomerRepository(BusinessAutomationDbContext db) : base(db)
        {
            this.db =db;
            
        }
    }
}
