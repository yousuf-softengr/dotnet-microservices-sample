using Catalog.Domain.Entities;

namespace Catalog.Application.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
}
