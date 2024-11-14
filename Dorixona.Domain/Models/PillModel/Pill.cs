using Dorixona.Domain.Abstractions;
using Dorixona.Domain.Models.PillModel.Proporties;

namespace Dorixona.Domain.Models.PillModel;

public sealed class Pill : Entity
{
    private Pill(Guid id, PillDTO pillDTO) : base(id)
    {
        Name = pillDTO.Name;
        Price = pillDTO.Price;
        Count = pillDTO.Count;
    }
    protected Pill() { }
    public Name Name { get; set; }
    public Price Price { get; set; }
    public Count Count { get; set; }
    public static Pill CreatePill(Guid id, PillDTO pillDTO)
    {
        return new Pill(id, pillDTO);
    }
}
