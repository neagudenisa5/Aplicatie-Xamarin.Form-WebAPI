using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Neagu_Denisa_Laborator12.Models;

namespace Neagu_Denisa_Laborator12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
