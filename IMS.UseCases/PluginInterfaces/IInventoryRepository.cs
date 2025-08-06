using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces;

public interface IInventoryRepository
{
    Task AddInventoryRepositoryAsync(Inventory inventory);
    Task DeleteInventoryByIdAsync(int inventoryId);
    Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
    Task<Inventory> GetInventoryByIdAsync(int inventoryId);
    Task<IEnumerable<Inventory>> GetProductsByNameAsync(string name);
    Task UpdateInventoryAsync(Inventory inventory);
}