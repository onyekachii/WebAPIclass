﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClass.Model.Entities;

namespace WebApiClass.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Task<Customer> GetSingleCustomer(Guid id);
        Task<Customer> GetCustomerByAccountNumber(string accountNumber);
    }
}