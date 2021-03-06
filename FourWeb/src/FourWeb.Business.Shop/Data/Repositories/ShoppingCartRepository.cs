﻿using FourWeb.Abstraction.Data.Repositories;
using FourWeb.Business.Shop.Data.Contexts;
using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.Domain.Repositories;
using System.Linq;

namespace FourWeb.Business.Shop.Data.Repositories
{
    public class ShoppingCartRepository : RepositoryBase<ShoppingCart>, IShoppingCartRepository
    {
        public ShoppingCartRepository(ShopContext context)
            : base(context)
        {
        }

        public ShoppingCart GetByCustomer(int id)
        {
            return Entity.SingleOrDefault(x => x.Customer.Id == id);
        }
    }
}
