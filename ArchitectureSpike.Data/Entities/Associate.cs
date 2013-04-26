using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArchitectureSpike.Domain.Interfaces;

namespace ArchitectureSpike.Data.Entities
{
    public class Associate : IAssociateEntitie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime Birth { get; set; }
        public virtual string Title { get; set; }
    }
}
