using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Core.Dto;
using Core.Interface;
using ProcessOrderDemo.Models;

namespace ProcessOrderDemo.Controllers
{
    public class OrderController : ApiController
    {
        private readonly IOrderService _orderService;      

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public HttpResponseMessage PostProcessOrder(OrderModels order)
        {
            if (ModelState.IsValid)
            {
                var dto = new OrderDto
                {
                    FirstName = order.FirstName,
                    LastName = order.LastName,
                    Address = order.Address,
                    City = order.City,
                    State = order.State,
                    Zip = order.Zip,
                    Phone = order.Phone,
                    Email = order.Email,
                    CardNumber = order.CardNumber,
                    CardExpirationMonth = order.CardExpirationMonth,
                    CardExpirationYear = order.CardExpirationYear,
                    CardSecurityCode = order.CardSecurityCode,
                    ProductId = order.ProductId,
                    Price = order.Price,
                };

                _orderService.SaveAsync(dto);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }
    }
}
