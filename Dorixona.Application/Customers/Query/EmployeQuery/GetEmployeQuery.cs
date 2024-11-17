using Dorixona.Application.Abstractions.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Application.Customers.Query.EmployeQuery;

public record GetEmployeQuery(Guid employeId) : IQuery<GetEmployeResponse>;
