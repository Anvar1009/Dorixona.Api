using Dorixona.Domain.Models.OrderModel.Proporties;

namespace Dorixona.Domain.Models.OrderModel;

public class OrderDTO
{
    public CustomerId CustomerId { get; set; }
    public CustomerPhoneNumber CustomerPhoneNumber { get; set; }
    public PillName PillName { get; set; }
    public PillPrice PillPrice { get; set; }
    public PillCount PillCount { get; set; }
    public Address Address { get; set; }
    public OrderTime OrderTime { get; set; }
    public OrderType OrderType { get; set; }
}
