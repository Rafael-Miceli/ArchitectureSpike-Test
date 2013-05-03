using System.Data.Entity;

namespace ArchitectureSpike.Data.Context
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        static BaseContext()
        {
            Database.SetInitializer<TContext>(null);
        }

        protected BaseContext() :
            base("DefaultConnection")
        {

        }
    }
}
