using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SplitWiseWebApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SplitWiseWebApp.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SplitWiseWebAppContextConnection") ?? throw new InvalidOperationException("Connection string 'SplitWiseWebAppContextConnection' not found.");

builder.Services.AddDbContext<SplitWiseWebAppContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<SplitWiseWebApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<SplitWiseWebAppContext>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<SqlConnectionConfiguration>();
builder.Services.AddScoped<IGroupService,GroupService>();


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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapRazorPages();

app.Run();
