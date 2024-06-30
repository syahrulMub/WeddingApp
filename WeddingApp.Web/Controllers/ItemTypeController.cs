using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Formatting;
using WeddingApp.BusinessLogic.BusinessLogic.Interface;
using WeddingApp.BusinessLogic.Dtos;
using WeddingApp.BusinessLogic.Entity;
using WeddingApp.BusinessLogic.Repository.Interface;

namespace WeddingApp.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemTypeController : ControllerBase
{
    private readonly IItemTypeBusinessLogic _itemTypeBL;
    private readonly ILogger<IItemTypeRepository> _logger;

    public ItemTypeController(IItemTypeBusinessLogic itemTypeBL,ILogger<IItemTypeRepository> logger)
    {
        _itemTypeBL = itemTypeBL;
        _logger = logger;
    }
    // [HttpGet]
    // public IActionResult GetAll(DataSourceLoadOptionsBase loader)
    // {
    //     var result = DataSourceLoader.Load(_itemTypeRepo.GetAll(),loader);
    //     return Ok(result);
    // }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _itemTypeBL.GetAll();
        return Ok(result);
    }
    [HttpPost]
    [Route("Save")]
    public async Task<IActionResult> Save(ItemTypeDto model)
    {
        var result = await _itemTypeBL.Save(model,1);
        return Ok(result);
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _itemTypeBL.SoftDelete(id,1);
        return Ok(result);
    }
}
