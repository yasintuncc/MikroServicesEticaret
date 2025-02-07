using tunc.Services.ShoppingCartAPI.Models.Dto;

namespace tunc.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
