using Audit.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Ordering.Application.Services.Orders;
using Ordering.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContext, OrderingContext>(config =>
{
    //config.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")).AddInterceptors(new AuditSaveChangesInterceptor());
    config.UseInMemoryDatabase("OrderingDB");
});
// Add services to the container.
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
