namespace WeddingApp.BusinessLogic.Dtos;

public class ItemDto : BaseDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int ItemTypeId { get; set; }
    public ItemTypeDto? ItemType { get; set; }
    public ICollection<EventItemDto>? EventItems { get; set; }
}
