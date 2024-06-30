using AutoMapper;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using Microsoft.EntityFrameworkCore;
using WeddingApp.BusinessLogic.Dtos;
using WeddingApp.BusinessLogic.Entity;
using WeddingApp.BusinessLogic.Repository.Interface;

namespace WeddingApp.BusinessLogic.BusinessLogic.Interface;

public class ItemTypeBusinessLogic : BusinessLogic<ItemTypeDto, ItemType>, IItemTypeBusinessLogic
{
    private readonly IItemTypeRepository _repo;
    public ItemTypeBusinessLogic(IItemTypeRepository repo)
    {
        _repo = repo;
        _mapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<ItemTypeDto, ItemType>().ReverseMap();
        }).CreateMapper();
    }
    public async Task<List<ItemTypeDto>> GetAll()
    {
        var result = await _repo.GetAll().ToListAsync();
        return _mapper.Map<List<ItemTypeDto>>(result);
    }
    public async Task<LoadResult> GetAll(DataSourceLoadOptionsBase loadOptionsBase)
    {
        return await DataSourceLoader.LoadAsync(_repo.GetAll(), loadOptionsBase);
    }

    public async Task<ItemTypeDto> Get(int id)
    {
        var result = await _repo.GetById(id);
        return _mapper.Map<ItemTypeDto>(result);
    }
    public async Task<ItemTypeDto> Save(ItemTypeDto model, int userId)
    {
        try
        {
            var entity = await _repo.GetById(model.Id);
            if (entity == null)
            {
                entity = _mapper.Map<ItemType>(model);
                await _repo.Add(entity, 1);
            }
            else
            {
                entity = _mapper.Map<ItemType>(model);
                await _repo.Update(entity, 1);
            }
            return _mapper.Map<ItemTypeDto>(entity);

        }
        catch (Exception ex) 
        {
             throw new Exception(ex.Message);
        }

    }
    public async Task<ItemTypeDto> SoftDelete(int id, int userId)
    {
        var entity = await _repo.SoftDelete(id, 1);
        return _mapper.Map<ItemTypeDto>(entity);
    }
    public async Task<int> Delete(int id)
    {
        var entity = await _repo.Delete(id, 1);
        return entity;
    }
}
