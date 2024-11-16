using Dorixona.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Dorixona.Infrastructure.Repositories;

public abstract class Repository<T> where T : Entity
{
    protected readonly ApplicationDbContext _context;
    protected Repository(ApplicationDbContext dbContext)
    {
        _context = dbContext;
    }

    public async Task<T?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await _context
            .Set<T>()
            .FirstOrDefaultAsync(user => user.Id == id, cancellationToken);
    }

    public void Add(T entity)
    {
        _context.Add(entity);
    }

    public void Update(T entity)
    {
        _context.Update(entity);
    }
}
