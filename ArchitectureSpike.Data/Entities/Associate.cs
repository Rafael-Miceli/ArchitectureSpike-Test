using System;
using ArchitectureSpike.Domain.Interfaces;

namespace ArchitectureSpike.Data.Entities
{
    public class Associate : IAssociateEntitie
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime Birth { get; set; }
        public virtual string Title { get; set; }
    }
}
