﻿using ApplicationCore.Entities;
using ApplicationCore.Exceptions;
using ApplicationCore.Interfaces;
using ApplicationCore.Services;
using Ardalis.Specification;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace UnitTests.ApplicationCore.OrderServiceTests
{
    public class Createorder
    {
        public readonly string _demoBuyerId = "This-Is-A-Random-Buyer-Id";
        public readonly Address _demoAddress = new Address()
        {
            City = "London",
            Country = "Uk",
            Street = "221B BakerStreet",
            ZipCode = "NW1 6XE"

        };

        [Fact]
        public async Task ShouldThrowEmptyExceptionIfBasketIsEmpty()
        {
            var mockBasketRepo = new Mock<IRepository<Basket>>();
            var mockProductRepo = new Mock<IRepository<Product>>();
            var mockBasketItemRepo = new Mock<IRepository<BasketItem>>();
            var mockOrderRepo = new Mock<IRepository<Order>>();

            Basket emptyBasket = new Basket() { BuyerId = _demoBuyerId, Items = new List<BasketItem>() };

            mockBasketRepo.Setup(x=>x.FirstOrDefaultAsync(It.IsAny<Specification<Basket>>())).ReturnsAsync(emptyBasket) ;

            var basketRepo = mockBasketRepo.Object;
            var productRepo = mockProductRepo.Object;
            var basketItemRepo = mockBasketItemRepo.Object;
            var orderRepo = mockOrderRepo.Object;


            BasketService basketService = new BasketService(basketRepo, productRepo, basketItemRepo);
            OrderService orderService = new OrderService(basketService, orderRepo);

            await Assert.ThrowsAsync<EmptyBasketException>(async () => await orderService.CreateOrderAsync(_demoBuyerId, _demoAddress));



        }
    }
}
