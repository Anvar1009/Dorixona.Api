using Dapper;
using Dorixona.Application.Abstractions.Data;
using Dorixona.Application.Abstractions.Messages;
using Dorixona.Application.Pattern;
using Dorixona.Domain.Abstractions;
using Dorixona.Domain.Models.UserModel;
using System.Security.Claims;

namespace Dorixona.Application.Homes.Query.Login;

internal sealed class LoginQueryHandle : IQueryHandle<LoginQuery, bool>
{
    private readonly ISqlConnection _connection;

    public LoginQueryHandle(ISqlConnection connection)
    {
        _connection = connection;
    }

    public async Task<Result<bool>> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        using var connect = _connection.ConnectionBuild();

        string username = request.username;
        string password = request.password;

        const string sql = """
               select * from users where "Username" = @username and "Password" = @password
               """;


        var query = await connect.QueryFirstOrDefaultAsync<LoginResponse>(sql, new { username, password });

        if (query != null)
        {
            Singleton.Instance.Id = query.Id;
            return true;
        }

        return false;
    }
}
