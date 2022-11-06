using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy",
        builder => builder.AllowAnyMethod().AllowAnyHeader());
});
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews();

//Identity kodu
builder.Services.AddDbContext<Context>();
//Identity kodu
builder.Services.AddIdentity<AppUser, AppRole>(x => { x.Password.RequireUppercase = false; })
    .AddEntityFrameworkStores<Context>();


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
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
