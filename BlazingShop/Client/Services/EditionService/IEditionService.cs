using BlazingShop.Shared;

namespace BlazingShop.Client.Services.EditionService
{
    public interface IEditionService
    {
        List<Edition> Editions { get; set; }
        Task LoadEditions();
    }
}
