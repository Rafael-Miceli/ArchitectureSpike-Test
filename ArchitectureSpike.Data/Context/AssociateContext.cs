using System.Data.Entity;
using ArchitectureSpike.Data.Entities;

namespace ArchitectureSpike.Data.Context
{
    public class AssociateContext: DbContext
    {
        public AssociateContext(): base("")
        {
            
        }

        public DbSet<Associate> Associates { get; set; }
    }
}
