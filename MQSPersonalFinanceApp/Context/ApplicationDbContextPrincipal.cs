using Microsoft.EntityFrameworkCore;

namespace MQSPersonalFinanceApp.Context
{
    public class ApplicationDbContextPrincipal : DbContext
    {
        public ApplicationDbContextPrincipal(DbContextOptions<ApplicationDbContextPrincipal> options) : base(options)
        { }
    }
}
