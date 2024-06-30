using System.Text.Json.Serialization;

namespace WeddingApp.BusinessLogic.Dtos;

public interface IDto
{
    int Id { get; set; }
    bool IsActive { get; set; }
    [JsonIgnore]
    DateTime CreatedDate { get; set; }
    int CreatedBy { get; set;}
    [JsonIgnore]
    DateTime? UpdatedDate { get; set; }
    int? UpdatedBy { get; set; }
}
