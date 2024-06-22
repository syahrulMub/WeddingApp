using WeddingApp.BusinessLogic.DatabaseContext.BaseEntity;

namespace WeddingApp.BusinessLogic.Entity;

public class Item : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int ItemTypeId { get; set; }
    public virtual ItemType ItemType { get; set; } = null!;
    public virtual ICollection<EventItem> EventItems { get; set; } = null!;
}
