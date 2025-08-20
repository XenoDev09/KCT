
using KCT.Data;
using KCT.Interfaces;
using KCT.Repositories;
using KCT.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<KCTContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("KCTContext") ?? throw new InvalidOperationException("Connection string 'KCTContext' not found.")));

builder.Services.AddDbContext<KCTContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("KCTContext") ?? throw new InvalidOperationException("Connection string 'KCTContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IStudentRepository, EFStudentRepository>();
builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<IRegistrationRepository, EFRegistrationRepository>();
builder.Services.AddScoped<RegistrationService>();


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
    pattern: "{controller=Student}/{action=Index}/{id?}");



app.Run();
