﻿using FourWeb.Abstraction.Domain.Interfaces.Repositories;
using FourWeb.Business.Shop.Domain.Entities;

namespace FourWeb.Business.Shop.Domain.Repositories
{
    public interface IShoppingCartRepository : IRepositoryBase<ShoppingCart>
    {
        ShoppingCart GetByCustomer(int id);
    }
}
