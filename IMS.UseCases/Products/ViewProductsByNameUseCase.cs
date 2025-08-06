using IMS.CoreBusiness;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginInterfaces;
using IMS.UseCases.Products.interfaces;

namespace IMS.UseCases.Products;

public class ViewProductsByNameUseCase(IProductRepository productRepository) : IViewProductsByNameUseCase
{
    private readonly IProductRepository productRepository = productRepository;

    public async Task<IEnumerable<Product>> ExecuteAsync(string name = "")
    {
        return await productRepository.GetProductsByNameAsync(name);
        
    }

}