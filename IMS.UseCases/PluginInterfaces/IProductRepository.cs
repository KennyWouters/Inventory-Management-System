namespace IMS.UseCases.PluginInterfaces
{
    public interface IProductRepository
    {

        Task AddProductRepositoryAsync(Product inventory);
        Task DeleteProductByIdAsync(int inventoryId);
        Task<IEnumerable<Product>> GetProductsByNameAsync(string name);
        Task<Product> GetProductByIdAsync(int inventoryId);
        Task UpdateProductAsync(Product inventory);
    }
}

