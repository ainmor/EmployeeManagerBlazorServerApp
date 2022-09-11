using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using WireBrainCoffeeEmployeeManager.Data;
using WireBrainCoffeeEmployeeManager.Shared;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContextFactory<ApplicationDbContext>(
    opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<StateContainer>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    await EnsureDatabaseIsMigrated(app.Services);
    
    async Task EnsureDatabaseIsMigrated(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        using var context = scope.ServiceProvider.GetService<ApplicationDbContext>();

        if (context is not null)
        {
           await context.Database.MigrateAsync();
        } 
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();