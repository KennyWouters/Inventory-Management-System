using IMS.CoreBusiness;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories
{
    public class DeleteInventoryUseCase(IInventoryRepository inventoryRepository): IDeleteInventoryUseCase
    {
        private readonly IInventoryRepository inventoryRepository = inventoryRepository;

        public async Task ExecuteAsync(int inventoryId)
        {
            await this.inventoryRepository.DeleteInventoryByIdAsync(inventoryId);
        }
    }
}
