using ESales.Business.Interfaces;
using ESales.Business.Manager;
using ESales.DataAccess.DataAccess;
using ESales.DataAccess.Helpers;
using ESales.DataAccess.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region DataAccess Injections
builder.Services.AddScoped<IProductDal, NHProductDal>();
builder.Services.AddScoped<ICategoryDal, NHCategoryDal>();
#endregion

builder.Services.AddScoped<SQLDbHelper>();

#region Business Injections
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x.WithOrigins("https://localhost:7266")
               .AllowAnyMethod()
               .AllowAnyHeader()
               .SetIsOriginAllowed(origin => true)
               .AllowCredentials());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
