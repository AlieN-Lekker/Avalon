using Avalon.Api.Services;

using Avalon.Data;
using Avalon.Core;
using Avalon.Business;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddDbContext<AvalonDbContext>(options =>
{
    options.UseInMemoryDatabase("Avalon");
});
services.AddSingleton<MongoDbContext>();
services.AddScoped<UserLogic>();
services.AddScoped<AvalonEngine>();
services.AddScoped<UserService>();
services.AddScoped<AuthService>();

services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        var key = Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Key"] ?? "secret");
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key)
        };
    });

services.AddAuthorization();

var app = builder.Build();

// seed a default user if collection is empty
var mongo = app.Services.GetRequiredService<MongoDbContext>();
if (mongo.Users.CountDocuments(Builders<Avalon.Domain.User>.Filter.Empty) == 0)
{
    mongo.Users.InsertOne(new Avalon.Domain.User { UserName = "admin", Password = "admin" });
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
