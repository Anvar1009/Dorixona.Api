namespace Dorixona.Domain.Abstractions;

public record Error(string code, string value)
{
    public static Error None = new Error(string.Empty, string.Empty);

    public static Error NullValue = new Error("Error.NullValue", "Null value was provided");

    public static Error CodeError = new Error("Error.Code", "Failed code");

}
