﻿using ApplicationApp.Interfaces;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppProduct : AppProductInterface
    {
        IProduct _IProduct;
        IServiceProduct _IServiceProduct;
        public AppProduct(IProduct IProduct, IServiceProduct IServiceProduct)
        {
            _IProduct = IProduct;
            _IServiceProduct = IServiceProduct;
        }
        public async Task AddProduct(Product product)
        {
            await _IServiceProduct.AddProduct(product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _IServiceProduct.UpdateProduct(product);
        }

        public async Task Add(Product obj)
        {
            await _IProduct.Add(obj);
        }

        public async Task Delete(Product obj)
        {
            await _IProduct.Delete(obj);
        }

        public async Task<Product> GetEntityById(int id)
        {
            return await _IProduct.GetEntityById(id);
        }

        public async Task<List<Product>> List()
        {
             return await _IProduct.List();
        }

        public async Task Update(Product obj)
        {
            await _IProduct.Delete(obj);
        }
    }
}
