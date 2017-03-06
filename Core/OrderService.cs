using System;
using Core.Dto;
using Core.Interface;
using Entities;
using Entities.Models;
using Repositories.Interface;

namespace Core
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork<DBEntities> _unitOfWork;
        private readonly IRepositoryBase<Order, DBEntities> _orderRepository;

        public OrderService(IUnitOfWork<DBEntities> unitOfWork, IRepositoryBase<Order, DBEntities> orderRepository)
        {
            _unitOfWork = unitOfWork;
            _orderRepository = orderRepository;
        }

        public void SaveAsync(OrderDto dto)
        {
            int status = 1;
            if ((dto.CardExpirationMonth < DateTime.Now.Month) && (dto.CardExpirationYear < DateTime.Now.Year))
            {
                status = 2;
            }

            var order = new Order
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Address = dto.Address,
                City = dto.City,
                State = dto.State,
                Zip = dto.Zip,
                Phone = dto.Phone,
                Email = dto.Email,
                CardNumber = dto.CardNumber,
                CardExpirationMonth = dto.CardExpirationMonth,
                CardExpirationYear = dto.CardExpirationYear,
                CardSecurityCode = dto.CardSecurityCode,
                ProductId = dto.ProductId,
                Price = dto.Price,
                Status = status
            };

            _orderRepository.Insert(order);
            _unitOfWork.Save();
        }
    }
}
