using ArchitectureSpike.Domain.Dto;
using ArchitectureSpike.Domain.Interfaces;

namespace ArchitectureSpike.Domain.Services
{
    public class AssociateService
    {
        private readonly IGenericRepository<IAssociateEntitie> _repository;

        public AssociateService(IGenericRepository<IAssociateEntitie> repository)
        {
            _repository = repository;
        }

        public AssociateDto GetById(int id)
        {
            return (AssociateDto) _repository.GetById(id);
        }
    }
}
