using Dorixona.Application.Abstractions.Messages;
using Dorixona.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Application.Homes.Query.EmployeQuery
{
    internal sealed class GetEmployeQueryHandle : IQueryHandle<GetEmployeQuery, GetEmployeResponse>
    {
        public Task<Result<GetEmployeResponse>> Handle(GetEmployeQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
