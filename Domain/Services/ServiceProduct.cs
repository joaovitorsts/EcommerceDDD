using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _IProduct;
        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }
        public async Task AddProduct(Product product)
        {
            bool nameValidate = product.StringPropertyValidation(product.Name, "Name");
            bool priceValidate = product.DecimalPropertyValidation(product.Value, "Value");
            if(nameValidate && priceValidate)
            {
                product.State = true;
                await _IProduct.Add(product);
            }
        }

        public async Task UpdateProduct(Product product)
        {
            bool nameValidate = product.StringPropertyValidation(product.Name, "Name");
            bool priceValidate = product.DecimalPropertyValidation(product.Value, "Value");
            if (nameValidate && priceValidate)
            {
                product.State = true;
                await _IProduct.Update(product);
            }
        }
    }
}
