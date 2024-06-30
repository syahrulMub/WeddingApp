using WeddingApp.BusinessLogic.DatabaseContext.BaseEntity;

namespace WeddingApp.BusinessLogic.Entity;

public class ItemType : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public virtual ICollection<Item>? Items { get; set; }
}
