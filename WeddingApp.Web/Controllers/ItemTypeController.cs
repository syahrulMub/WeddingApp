using Microsoft.AspNetCore.Mvc;
using WeddingApp.BusinessLogic.Entity;
using WeddingApp.BusinessLogic.Repository.Interface;

namespace WeddingApp.Web.Controllers;
[ApiController]
[Route("[Controller]")]
public class ItemTypeController : Controller
{
    private readonly IItemTypeRepository _itemTypeRepo;
    private readonly ILogger<ItemTypeController> _logger;
    public ItemTypeController(IItemTypeRepository itemTypeRepo, ILogger<ItemTypeController> logger)
    {
        _itemTypeRepo = itemTypeRepo;
        _logger = logger;
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_itemTypeRepo.GetAll());
    }
    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await _itemTypeRepo.GetById(id));
    }
    [HttpPost]
    public async Task<IActionResult> Add(ItemType itemType)
    {
        return Ok(await _itemTypeRepo.Add(itemType, 1));
    }
    [HttpPut]
    public async Task<IActionResult> Update(ItemType itemType)
    {
        return Ok(await _itemTypeRepo.Update(itemType, 1));
    }
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        return Ok(await _itemTypeRepo.SoftDelete(id, 1));
    }


}
