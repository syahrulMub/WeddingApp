using WeddingApp.BusinessLogic.Entity;

namespace WeddingApp.BusinessLogic.Dtos;

public class EventItemDto : BaseDto
{
    public int EventId { get; set; }
    public EventDto? Event { get; set; }
    public int ItemId { get; set; }
    public ItemDto? Item { get; set; }
    public int Quantity { get; set; }
    public int Spending { get; set; }
    public StatusItem Status { get; set; }

}
