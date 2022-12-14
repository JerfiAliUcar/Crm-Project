using AspNetMvc.Crm.Application;
using AspNetMvc.Crm.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//ServiceRegistrations içinde oluþturduðumuz extension metodu çaðýrarak DB Konfig. yapýldý.(AddTransient Repository kýsmýný da Aldýk)
builder.Services.AddEntityFrameworkRegistration(builder.Configuration);

//Application kýsmýndaki Service Registrrations içinde oluþturduðumuz extension metodu çaðýrarak AddTransient Service kýsýmýný aldýk
builder.Services.AddApplicationRegistration(builder.Configuration);

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
