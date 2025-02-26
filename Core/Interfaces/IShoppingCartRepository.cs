﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IShoppingCartRepository
    {
        Task<CustomerShoppingCart> GetShoppingCartAsync(string shoppingCartId);
        Task<CustomerShoppingCart> UpdateShoppingCartAsync(CustomerShoppingCart shoppingCart);
        Task<bool> DeleteShoppingCartAsync(string shoppingCartId);
    }
}
