using BlazingShop.Shared;

namespace BlazingShop.Server.Services.EditionService
{
    public interface IEditionService
    {
        Task<List<Edition>> GetEditions();
    }
}
