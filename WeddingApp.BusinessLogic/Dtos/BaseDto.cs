namespace WeddingApp.BusinessLogic.Dtos;

public class BaseDto : IDto
{
    public int Id { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CreatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public int? UpdatedBy { get; set; }
}
