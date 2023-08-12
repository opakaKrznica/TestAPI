using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using TESTapi.MojaBaza2;

var builder = WebApplication.CreateBuilder(args);
//var dbConnectionString = builder.Configuration.
//    GetValue<string>("ConnectionString");

// Add services to the container.
builder.Services.AddDbContext<PonovoWebShopVjezbaContext>
    (options => options.
    UseSqlServer("Data Source=DESKTOP-JE9G202;Initial Catalog=ponovoWebShopVjezba;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));


builder.Services.AddControllers();

builder.Services.AddDirectoryBrowser();
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

app.UseStaticFiles();

app.UseFileServer(
    new FileServerOptions
    {
        FileProvider = new
        PhysicalFileProvider(
            Path.Combine(builder.Environment
            .ContentRootPath, "WebShopPictures")),
        RequestPath = "/WebShopPictures",
        EnableDirectoryBrowsing = true
    }
    );

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
