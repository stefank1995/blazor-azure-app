﻿using IMS.CoreBusiness;

namespace IMS.Application.Features.Products.Interfaces
{
    public interface IViewProductsByNameUseCase
    {
        Task<IEnumerable<Product>> ExecuteAsync(string name);
    }
}