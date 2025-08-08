using IMS.UseCases.PluginInterfaces;
using IMS.UseCases.Products.interfaces;

namespace IMS.UseCases.Products
{
    public class EditProductUseCase(IProductRepository productRepository) : IEditProductUseCase
    {
        private readonly IProductRepository productRepository = productRepository;

        public async Task ExecuteAsync(Product product)
        {
            await this.productRepository.UpdateProductAsync(product);
        }


    }
}
