using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using PatikaPratikIdentityAndDataProtection.Context;
using PatikaPratikIdentityAndDataProtection.DataProtection;
using PatikaPratikIdentityAndDataProtection.Managers;
using PatikaPratikIdentityAndDataProtection.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connetctionString = builder.Configuration.GetConnectionString("default");

var keysDirectory = new DirectoryInfo(Path.Combine(builder.Environment.ContentRootPath, "App_Data", "Keys"));

builder.Services.AddDataProtection()
    .SetApplicationName("PatikaPratikIdentityAndDataProtection")
    .PersistKeysToFileSystem(keysDirectory);

builder.Services.AddDbContext<PatikaPratikIdentityAndDataProtectionDbContext>(options => options.UseSqlServer(connetctionString));
builder.Services.AddScoped<IUserService , UserManager>();
builder.Services.AddScoped<IDataProtection, DataProtection>();


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
