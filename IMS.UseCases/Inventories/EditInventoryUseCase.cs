using IMS.CoreBusiness;
using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories
{
    public class EditInventoryUseCase(IInventoryRepository inventoryRepository) : IEditInventoryUseCase
    {
        private readonly IInventoryRepository inventoryRepository = inventoryRepository;

        public async Task ExecuteAsync(Inventory inventory)
        {
            await this.inventoryRepository.UpdateInventoryAsync(inventory);
        }


    }
}
