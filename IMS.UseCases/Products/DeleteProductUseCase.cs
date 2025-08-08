using IMS.UseCases.PluginInterfaces;
using IMS.UseCases.Products.interfaces;

namespace IMS.UseCases.Products
{
    public class DeleteProductUseCase(IProductRepository productRepository) : IDeleteProductUseCase
    {
        private readonly IProductRepository productRepository = productRepository;

        public async Task ExecuteAsync(int productId)
        {
            await this.productRepository.DeleteProductByIdAsync(productId);
        }
    }
}
