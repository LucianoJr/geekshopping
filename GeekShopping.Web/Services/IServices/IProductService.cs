﻿using System.Threading.Tasks;
using GeekShopping.Web.Models;
using System.Collections.Generic;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProducts();
        Task<ProductModel> FindProductById(long id);
        Task<ProductModel> CreateProduct(ProductModel model);
        Task<ProductModel> UpdateProduct(ProductModel model);
        Task<bool> DeleteProduct(long id);
        Task DeleteProductById(long id);
    }
}
