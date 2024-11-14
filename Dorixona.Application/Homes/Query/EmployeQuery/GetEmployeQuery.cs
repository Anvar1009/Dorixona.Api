using Dorixona.Application.Abstractions.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Application.Homes.Query.EmployeQuery;

public record GetEmployeQuery(Guid employeId) : IQuery<GetEmployeResponse>;
