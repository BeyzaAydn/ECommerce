using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Repositories.Abstracts.BaseAbstract;
using ECommerce.BLL.Repositories.Concretes;
using ECommerce.BLL.Repositories.Concretes.BaseConcrete;
using ECommerceDAL.Context;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Configuration.GetConnectionString("");

//DbContext
builder.Services.AddDbContext<ECommerceContext>(options=>options.UseSqlServer("server=BEYZA\\SQLEXPRESS; database=Nortwind;Trusted_Connection=True;TrustServerCertificate=true"));

builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<ICategoryService, CategoryService>();//bunu categorycontrollerda inject edeceğiz.

var app = builder.Build();

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

});

//MapControllerRoute=tek bir route o damvc route.Birden fazla ulaşım noktasına ihtiyacımız varsa useendpointi kullanmamız gerekiyor.

app.Run();
