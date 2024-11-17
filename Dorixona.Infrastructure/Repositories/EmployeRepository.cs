using Dorixona.Domain.Models.OrderModel.OrderRepository;
using Dorixona.Domain.Models.OrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dorixona.Domain.Models.EmployeModel;
using Dorixona.Domain.Models.EmployeModel.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace Dorixona.Infrastructure.Repositories
{
    public class EmployeRepository : Repository<Employe>, IEmployeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<Employe> CheckId(Guid employe)
        {
            var result = await _context
            .Set<Employe>()
             .FirstOrDefaultAsync(Tmodel => Tmodel.Id == employe );
            if( result == null ) 
                return new Employe();
            return result;
        }
    }
}
