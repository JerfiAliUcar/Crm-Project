using AspNetMvc.Crm.Application;
using AspNetMvc.Crm.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//ServiceRegistrations i�inde olu�turdu�umuz extension metodu �a��rarak DB Konfig. yap�ld�.(AddTransient Repository k�sm�n� da Ald�k)
builder.Services.AddEntityFrameworkRegistration(builder.Configuration);

//Application k�sm�ndaki Service Registrrations i�inde olu�turdu�umuz extension metodu �a��rarak AddTransient Service k�s�m�n� ald�k
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
