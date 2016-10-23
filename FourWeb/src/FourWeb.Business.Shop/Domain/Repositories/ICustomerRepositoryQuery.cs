﻿using FourWeb.Abstraction.Domain.Interfaces.Repositories;
using FourWeb.Business.Shop.Domain.Entities;

namespace FourWeb.Business.Shop.Domain.Repositories
{
    public interface ICustomerRepositoryQuery : IRepositoryQueryBase<Customer>
    {
        Customer GetByEmail(string email);
    }
}
