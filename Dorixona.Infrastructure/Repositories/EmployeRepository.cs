using Dorixona.Domain.Models.OrderModel.OrderRepository;
using Dorixona.Domain.Models.OrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dorixona.Domain.Models.EmployeModel;
using Dorixona.Domain.Models.EmployeModel.Repository;

namespace Dorixona.Infrastructure.Repositories
{
    public class EmployeRepository : Repository<Employe>, IEmployeRepository
    {
        public EmployeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

       
    }
}
