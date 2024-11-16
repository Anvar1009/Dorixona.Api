using Dapper;
using Dorixona.Application.Abstractions.Data;
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
       
          private readonly ISqlConnection _connection;

        public GetEmployeQueryHandle(ISqlConnection connection)
        {
            _connection = connection;
        }

        public async Task<Result<GetEmployeResponse?>> Handle(GetEmployeQuery request, CancellationToken cancellationToken)
        {
            using var connect = _connection.ConnectionBuild();

            const string sql = """
                           select 
                               *
                           from public.employe  
                           where "Id"=@employe
                           """
            ;

            var query = await connect.QueryFirstOrDefaultAsync<GetEmployeResponse>(
                sql,
                new
                {
                    employe = request.employeId,
                });

            return query;
        }
    }
}
