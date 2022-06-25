using BlazingShop.Server.Data;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Server.Services.EditionService
{
    public class EditionService : IEditionService
    {
        private readonly DataContext _context;

        public EditionService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Edition>> GetEditions()
        {
            return await _context.Editions.ToListAsync();
        }
    }
}
