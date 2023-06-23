﻿using IMS.Application.Contracts.Persistence;
using IMS.Application.Features.Activities.Interfaces;
using IMS.Domain.Entities;

namespace IMS.Application.Features.Activities
{
    public class ProduceProductUseCase : IProduceProductUseCase
    {
        private readonly IProductTransactionRepository productTransactionRepository;
        private readonly IProductRepository productRepository;

        public ProduceProductUseCase(IProductTransactionRepository productTransactionRepository,
            IProductRepository productRepository)
        {
            this.productTransactionRepository = productTransactionRepository;
            this.productRepository = productRepository;
        }

        public async Task ExecuteAsync(string productionNumber, Product product, int quantity, string doneBy)
        {
            //add transaction record
            await this.productTransactionRepository.ProduceAsync(productionNumber, product, quantity, doneBy);

            //decrease the quantity inventories

            //update the quantity of product
            product.Quantity += quantity;
            await this.productRepository.UpdateProductAsync(product);
        }
    }
}
