using Core.Dto;

namespace Core.Interface
{
    public interface IOrderService
    {
        void SaveAsync(OrderDto dto);
    }
}
