using Dorixona.Domain.Abstractions;

namespace Dorixona.Domain.Models.PillModel;

public static class PillError
{
    public static Error NotFound = new(
        "Pill.NotFound",
        "The Pill with the specified identifier was not found");

    public static Error PillNull = new(
        "Pill.Null",
        "It can't create for Pill null");
}
