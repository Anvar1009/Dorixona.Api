namespace Dorixona.Domain.Models.OrderModel;

public class CreateOrderDTO
{
    public Guid PillId { get; set; }
    public int PillCount { get; set; }
    public string Address { get; set; }
}
