using WeddingApp.BusinessLogic.DatabaseContext;
using WeddingApp.BusinessLogic.Entity;

namespace WeddingApp.BusinessLogic.Repository.Interface;

public class ItemTypeRepository : BaseRepository<ItemType>, IItemTypeRepository
{
    public ItemTypeRepository(ApplicationDbContext context) : base(context)
    {
    }
}
