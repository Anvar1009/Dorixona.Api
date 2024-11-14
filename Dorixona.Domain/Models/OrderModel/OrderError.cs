using Dorixona.Domain.Abstractions;

namespace Dorixona.Domain.Models.OrderModel;

public static class OrderError
{
    public static Error NotFound = new(
        "Order.NotFound",
        "The Order with the specified identifier was not found");

    public static Error OrderNull = new(
        "Order.Null",
        "It can't create for Order null");
}
