using Dorixona.Application.Abstractions.Messages;

namespace Dorixona.Application.Customers.Query.GetPill;

public record GetPillQuery() : IQuery<List<GetPillResponse>>;
