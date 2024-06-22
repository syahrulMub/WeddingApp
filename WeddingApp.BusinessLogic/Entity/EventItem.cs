using WeddingApp.BusinessLogic.DatabaseContext.BaseEntity;

namespace WeddingApp.BusinessLogic.Entity;

public class EventItem : BaseEntity
{
    public int EventId { get; set; }
    public virtual Event? Event { get; set; }
    public int ItemId { get; set; }
    public virtual Item? Item { get; set; }
    public int Quantity { get; set; }
    public int Spending { get; set; }
    public StatusItem Status { get; set; }

}
