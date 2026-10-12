/*
    Integrantes:

    Luiz Gustavo Verissimo Monteiro - CB3030326
    Kaik Persike Maiorquino - CB3029689
*/

using CBTSWE2_TP03.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CBTSWE2_TP03Context>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("CBTSWE2_TP03Context")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Produto}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
