using Dapper;
using Dorixona.Application.Abstractions.Data;
using Dorixona.Application.Abstractions.Messages;
using Dorixona.Domain.Abstractions;

namespace Dorixona.Application.Customers.Query.GetPill;

internal sealed class GetPillQueryHandle : IQueryHandle<GetPillQuery, List<GetPillResponse>>
{
    private readonly ISqlConnection _connection;

    public GetPillQueryHandle(ISqlConnection connection)
    {
        _connection = connection;
    }

    public async Task<Result<List<GetPillResponse>>> Handle(GetPillQuery request, CancellationToken cancellationToken)
    {
        using var connect = _connection.ConnectionBuild();

        const string sql = """
                           select * from pills
                           """;

        var query = await connect.QueryAsync<GetPillResponse>(sql);

        var resultList = query.ToList();

        return resultList;
    }
}

