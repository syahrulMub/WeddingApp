
using WeddingApp.BusinessLogic.DatabaseContext.BaseEntity;
using WeddingApp.BusinessLogic.DatabaseContext.Entity;
using WeddingApp.BusinessLogic.Entity;
namespace WeddingApp.BusinessLogic.Entity;

public class Event : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public ICollection<EventItem>? EventItems { get; set; }
}
