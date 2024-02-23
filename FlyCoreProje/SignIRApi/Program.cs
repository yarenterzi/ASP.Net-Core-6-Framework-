using Microsoft.EntityFrameworkCore;
using SignIRApi.DAL;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddSqlServer().AddDbContext<Context>(opt =>

//opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddDbContext<Context>();
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
