using ArchitectureSpike.Domain.Interfaces;
using ArchitectureSpike.Domain.Models;

namespace ArchitectureSpike.Domain.Services
{
    public class AssociateService
    {
        private readonly IGenericRepository<Associate> _repository;

        public AssociateService(IGenericRepository<Associate> repository)
        {
            _repository = repository;
        }

        public Associate GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
