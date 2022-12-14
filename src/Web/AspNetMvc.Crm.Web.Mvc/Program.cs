using AspNetMvc.Crm.Application;
using AspNetMvc.Crm.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//ServiceRegistrations i�inde olu�turdu�umuz extension metodu �a��rarak DB Konfig. yap�ld�.
builder.Services.AddEntityFrameworkRegistration(builder.Configuration);

//Application k�sm�ndaki Service Registrrations i�inde olu�turdu�umuz extension metodu �a��rarak AddTransient Service k�s�m�n� ald�k
builder.Services.AddApplicationRegistration(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
