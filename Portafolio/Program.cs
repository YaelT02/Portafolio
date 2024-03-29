using Portafolio.Infrestructura;
using Portafolio.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Inyecci�n o inversi�n de dependencias
builder.Services.AddTransient<IRepositorioServicios, RepositorioServicios>();

builder.Services.AddTransient<IServiceEmailSendGrid, ServicesEmailSendGrid>();

builder.Services.AddTransient<ServicioTransitorio>();

builder.Services.AddScoped<ServicioDelimitado>();

builder.Services.AddSingleton<ServicioUnico>();

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
