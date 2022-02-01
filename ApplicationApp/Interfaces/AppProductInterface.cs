using ApplicationApp.Interfaces;
using ApplicationApp.OpenApp;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface AppProductInterface : AppGenericInterface<Product>
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
    }
}
