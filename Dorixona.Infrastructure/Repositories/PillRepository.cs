using Dorixona.Domain.Models.PillModel;
using Dorixona.Domain.Models.PillModel.PillRepository;

namespace Dorixona.Infrastructure.Repositories;

public class PillRepository : Repository<Pill>, IPillRepository
{
    public PillRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
