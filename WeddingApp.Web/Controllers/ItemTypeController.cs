using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Mvc;
using WeddingApp.BusinessLogic.Entity;
using WeddingApp.BusinessLogic.Repository.Interface;

namespace WeddingApp.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemTypeController : ControllerBase
{
    private readonly IItemTypeRepository _itemTypeRepo;
    private readonly ILogger<IItemTypeRepository> _logger;

    public ItemTypeController(IItemTypeRepository itemTypeRepo,ILogger<IItemTypeRepository> logger)
    {
        _itemTypeRepo = itemTypeRepo;
        _logger = logger;
    }
    // [HttpGet]
    // public IActionResult GetAll(DataSourceLoadOptionsBase loader)
    // {
    //     var result = DataSourceLoader.Load(_itemTypeRepo.GetAll(),loader);
    //     return Ok(result);
    // }
    [HttpGet]
    public IActionResult GetAll()
    {
        var result = _itemTypeRepo.GetAll();
        return Ok(result);
    }
    [HttpPost]
    public async Task<IActionResult> Add(ItemType model)
    {
        var result = await _itemTypeRepo.Add(model,1);
        return Ok(result);
    }
    [HttpPut]
    public async Task<IActionResult> Update(int id, ItemType model)
    {
        var result = await _itemTypeRepo.Update(id,model,1);
        return Ok(result);
    }
    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _itemTypeRepo.SoftDelete(id,1);
        return Ok(result);
    }
}
