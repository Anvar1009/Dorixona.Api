using Dorixona.Api.Middleware;
using Dorixona.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Dorixona.Api.Extansions
{
    public static class AddMigrationExansion
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();

            using var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            dbContext.Database.Migrate();
        }

        public static void UseCustomExceptionHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
