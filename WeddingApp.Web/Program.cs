using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WeddingApp.BusinessLogic.DatabaseContext;
using WeddingApp.BusinessLogic.DatabaseContext.BaseEntity;
using WeddingApp.BusinessLogic.DatabaseContext.Entity.Interface;
using WeddingApp.BusinessLogic.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc();

// configuring database
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>{
    options.UseSqlite(connectionString);
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEntity, BaseEntity>();
builder.Services.AddScoped<IItemTypeRepository, ItemTypeRepository>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseRouting();
app.UseCors();
// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller}/{action=Index}/{id?}");

// app.MapFallbackToFile("index.html");
app.MapControllers();
app.Run();
