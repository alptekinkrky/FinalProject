﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        
        List<Product> GetAllByCategory(int id);

        List<Product> GetByUnitePrice(decimal min, decimal max);

        List<ProductDetailDto> GetProductDetails();
    }
}
 