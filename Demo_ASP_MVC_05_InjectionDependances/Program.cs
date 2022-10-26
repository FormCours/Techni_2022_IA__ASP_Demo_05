using Demo_ASP_MVC_05_InjectionDependances.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Configuration de l'injection de dépendances

/*
builder.Services.AddSingleton(typeof(DemoSingletonService));
builder.Services.AddSingleton(typeof(DemoScopedService));
builder.Services.AddSingleton(typeof(DemoTransientService));
*/

builder.Services.AddSingleton<DemoSingletonService>();
builder.Services.AddScoped<DemoScopedService>();
builder.Services.AddTransient<DemoTransientService>();

/*
// Type demandé et Type injecté
builder.Services.AddSingleton(typeof(DemoSingletonService), typeof(DemoSingletonService));
builder.Services.AddSingleton<DemoSingletonService, DemoSingletonService>();
*/


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
