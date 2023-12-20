using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SCP2.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SCP2IdentityDbContextConnection") ?? throw new InvalidOperationException("Connection string 'SCP2IdentityDbContextConnection' not found.");

builder.Services.AddDbContext<SCP2IdentityDbContext>(options => options.UseNpgsql("Host=localhost;Database=SCP2;Username=postgres;Password=postgres"));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<SCP2IdentityDbContext>();

// Add services to the container.
builder.Services.AddRazorPages(options => options.Conventions.AuthorizePage("/Index"));

var app = builder.Build();

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
