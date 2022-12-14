using AspNetMvc.Crm.Application;
using AspNetMvc.Crm.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//ServiceRegistrations içinde oluþturduðumuz extension metodu çaðýrarak DB Konfig. yapýldý.
builder.Services.AddEntityFrameworkRegistration(builder.Configuration);

//Application kýsmýndaki Service Registrrations içinde oluþturduðumuz extension metodu çaðýrarak AddTransient Service kýsýmýný aldýk
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
