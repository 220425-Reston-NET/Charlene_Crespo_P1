using RepairShopv2BL;
using RepairShopv2DL;
using RepairShopv2Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// (builder.Configuration.GetConnectionString("Charlene Crespo")
// Environment.GetEnvironmentVariable("Connection_String"


builder.Services.AddScoped<IRepository<Customers>, SQLCustomerRepository>(repo => new SQLCustomerRepository(builder.Configuration.GetConnectionString("Charlene Crespo")));
builder.Services.AddScoped<ICustomersBL, CustomersBL>();
builder.Services.AddScoped<IRepository<Order>, SQLOrderRepository>(repo => new SQLOrderRepository(Environment.GetEnvironmentVariable("Connection_String")));
builder.Services.AddScoped<IOrderBL, OrderBL>();
builder.Services.AddScoped<IRepository<LineItems>, SQLlineitemsRepository>(repo => new SQLlineitemsRepository(Environment.GetEnvironmentVariable("Connection_String")));
builder.Services.AddScoped<ILineItemsBL, LineItemsBL>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
