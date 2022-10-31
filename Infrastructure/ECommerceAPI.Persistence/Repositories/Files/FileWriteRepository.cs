using ECommerceAPI.Application.Repositories.Files;
using ECommerceAPI.Persistence.Contexts;
using F = ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Persistence.Repositories.Files
{
    public class FileWriteRepository : WriteRepository<F::File>, IFileWriteRepository
    {
        public FileWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
