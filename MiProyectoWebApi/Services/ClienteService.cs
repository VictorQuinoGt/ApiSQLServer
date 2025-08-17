using MiProyectoWebAPI.Models;
using MiProyectoWebAPI.Repositories;

namespace MiProyectoWebAPI.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Cliente>> GetAllAsync() => _repository.GetAllAsync();
        public Task<Cliente?> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
        public Task AddAsync(Cliente cliente) => _repository.AddAsync(cliente);
        public Task UpdateAsync(Cliente cliente) => _repository.UpdateAsync(cliente);
        public Task DeleteAsync(int id) => _repository.DeleteAsync(id);
    }
}
