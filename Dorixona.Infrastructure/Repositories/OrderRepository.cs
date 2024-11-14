using Dorixona.Domain.Models.OrderModel.OrderRepository;
using Dorixona.Domain.Models.OrderModel;

namespace Dorixona.Infrastructure.Repositories;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    public OrderRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
