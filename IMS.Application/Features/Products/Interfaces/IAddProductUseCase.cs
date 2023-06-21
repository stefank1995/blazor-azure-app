﻿using IMS.Domain.Entities;

namespace IMS.Application.Features.Products.Interfaces
{
    public interface IAddProductUseCase
    {
        Task ExecuteAsync(Product product);
    }
}