using System;
using ArchitectureSpike.Domain.Interfaces;

namespace ArchitectureSpike.Domain.Dto
{
    public class AssociateDto: IAssociateEntitie
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string Title { get; set; }
    }
 }
