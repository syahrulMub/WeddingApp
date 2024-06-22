using System.ComponentModel.DataAnnotations;
using WeddingApp.BusinessLogic.DatabaseContext.Entity.Interface;

namespace WeddingApp.BusinessLogic.DatabaseContext.BaseEntity;

public class BaseEntity : IEntity
{
    [Key]
    public int Id { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CreatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public int? UpdatedBy { get; set; }
}
