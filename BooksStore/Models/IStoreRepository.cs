using BooksStore.Models;

namespace BookStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}