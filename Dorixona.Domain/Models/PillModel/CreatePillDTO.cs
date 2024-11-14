namespace Dorixona.Domain.Models.PillModel;

public class CreatePillDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
}
