using ECommerceAPI.Application.Repositories.Files;
using ECommerceAPI.Persistence.Contexts;
using F = ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Persistence.Repositories.Files
{
    public class FileReadRepository : ReadRepository<F::File>, IFileReadRepository
    {
        public FileReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
