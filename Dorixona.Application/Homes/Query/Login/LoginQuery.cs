using Dorixona.Application.Abstractions.Messages;

namespace Dorixona.Application.Homes.Query.Login;

public record LoginQuery(string username, string password) : IQuery<bool>;
