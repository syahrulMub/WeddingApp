namespace WeddingApp.BusinessLogic.Dtos;

public class ItemTypeDto : BaseDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public ICollection<ItemDto>? Items { get; set; }
}
