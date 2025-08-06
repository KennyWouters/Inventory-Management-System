using IMS.CoreBusiness;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginInterfaces;


namespace IMS.UseCases.Inventories;

public class ViewInventoriesByNameUseCase(IInventoryRepository productRepository) : IViewInventoriesByNameUseCase
{
    private readonly IInventoryRepository productRepository = productRepository;

    public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
    {
        return await productRepository.GetInventoriesByNameAsync(name);
        
    }

}