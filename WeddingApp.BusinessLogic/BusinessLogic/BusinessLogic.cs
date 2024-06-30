using AutoMapper;
namespace WeddingApp.BusinessLogic.BusinessLogic;

public class BusinessLogic<ModelDto, TEntity> 
{
        public IMapper _mapper;
        public BusinessLogic()
        {
            _mapper = new MapperConfiguration(cfg => {
                cfg.CreateMap<TEntity, ModelDto>().ReverseMap();
            }).CreateMapper();
        }
}
