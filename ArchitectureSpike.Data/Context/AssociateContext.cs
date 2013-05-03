using System.Data.Entity;
using ArchitectureSpike.Domain.Models;

namespace ArchitectureSpike.Data.Context
{
    public class AssociateContext: BaseContext<AssociateContext>
    {

        public DbSet<Associate> Associates { get; set; }

    }
}
