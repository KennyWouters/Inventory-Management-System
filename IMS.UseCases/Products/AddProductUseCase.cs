using IMS.UseCases.PluginInterfaces;
using IMS.UseCases.Products.interfaces;

namespace IMS.UseCases.Products
{
    public class AddProductUseCase(IProductRepository productRepository) : IAddProductUseCase
    {
        private readonly IProductRepository productRepository = productRepository;

        public async Task ExecuteAsync(Product product)
        {
            await this.productRepository.AddProductRepositoryAsync(product);
        }



    }

}
