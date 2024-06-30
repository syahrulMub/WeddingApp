using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
namespace WeddingApp.BusinessLogic.BusinessLogic;

public interface IBusinessLogic<ModelDto>
{
        Task<ModelDto> Save(ModelDto model, int userId);
        Task<ModelDto> Get(int id);
        Task<List<ModelDto>> GetAll();
        Task<LoadResult> GetAll(DataSourceLoadOptionsBase loadOptions);
        Task<ModelDto> SoftDelete(int id, int userId);
        Task<int> Delete(int id);
}
