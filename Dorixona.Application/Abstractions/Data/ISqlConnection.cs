using System.Data;

namespace Dorixona.Application.Abstractions.Data;

public interface ISqlConnection
{
    IDbConnection ConnectionBuild();
}
