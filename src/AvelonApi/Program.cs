using Avelon.Api.Services;

using Avelon.Data;
using Avelon.Engine;
using Avelon.Service;
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

services.AddDbContext<AvelonDbContext>(options =>
{
    options.UseInMemoryDatabase("Avelon");
});
services.AddSingleton<MongoDbContext>();
services.AddScoped<UserLogic>();
services.AddScoped<AvelonEngine>();
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
if (mongo.Users.CountDocuments(Builders<Avelon.Domain.User>.Filter.Empty) == 0)
{
    mongo.Users.InsertOne(new Avelon.Domain.User { UserName = "admin", Password = "admin" });
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
