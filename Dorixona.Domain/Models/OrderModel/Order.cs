using Dorixona.Domain.Abstractions;
using Dorixona.Domain.Models.OrderModel.Proporties;

namespace Dorixona.Domain.Models.OrderModel;

public sealed class Order : Entity
{
    private Order(Guid id, OrderDTO OrderDTO) : base(id)
    {
        CustomerId = OrderDTO.CustomerId;
        CustomerPhoneNumber = OrderDTO.CustomerPhoneNumber;
        PillName = OrderDTO.PillName;
        PillPrice = OrderDTO.PillPrice;
        PillCount = OrderDTO.PillCount;
        Address = OrderDTO.Address;
        OrderTime = OrderDTO.OrderTime;
        OrderType = OrderDTO.OrderType;
    }
    protected Order() { }
    public CustomerId CustomerId { get; set; }
    public CustomerPhoneNumber CustomerPhoneNumber { get; set; }
    public PillName PillName { get; set; }
    public PillPrice PillPrice { get; set; }
    public PillCount PillCount { get; set; }
    public Address Address { get; set; }
    public OrderTime OrderTime { get; set; }
    public OrderType OrderType { get; set; }
    public static Order CreateOrder(Guid Id, OrderDTO order)
    {
        return new Order(Id, order);
    }
}
