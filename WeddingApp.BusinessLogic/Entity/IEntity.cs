namespace WeddingApp.BusinessLogic.DatabaseContext.Entity.Interface;

public interface IEntity
{
    int Id {get; set;}
    bool IsActive {get; set;}
    DateTime CreatedDate {get; set;}
    int CreatedBy {get; set;}
    DateTime? UpdatedDate {get; set;}
    int? UpdatedBy {get; set;}
}
