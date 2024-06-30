namespace WeddingApp.BusinessLogic.Dtos;

public class EventDto : BaseDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public ICollection<EventItemDto>? EventItems { get; set; }
}
