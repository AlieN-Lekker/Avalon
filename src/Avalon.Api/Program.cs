using Avalon.Api.Services;
using Avalon.Data;
using Avalon.Core;
using Avalon.Business;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddDbContext<AvalonDbContext>(options => {
    // configure database provider
    options.UseInMemoryDatabase("Avalon");
});
services.AddScoped<UserLogic>();
services.AddScoped<AvalonEngine>();
services.AddScoped<UserService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
