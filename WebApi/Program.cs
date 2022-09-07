using WebApi.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var db = new Db();
builder.Services.AddSingleton<Db>(db);

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

//Configure the app to serve static files and enable default file mapping.

app.UseDefaultFiles();
app.UseStaticFiles();
//

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
