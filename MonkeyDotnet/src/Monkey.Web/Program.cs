using Microsoft.EntityFrameworkCore;
using Monkey.Web.Database;
using Monkey.Web.infrastructures.BaseClasses;
using Monkey.Web.Service;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Load configuration from appsettings.json and environment variables
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
    .AddUserSecrets<Program>()
    .AddEnvironmentVariables();

// Add DbContext
builder.Services.AddDbContext<MonkeyDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PsqlConnection")));

var assembly = Assembly.GetExecutingAssembly();

// Register all classes that inherit from ServiceBase
var serviceBaseDerivedTypes = assembly.GetTypes()
    .Where(type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(ServiceBase)))
    .ToArray();
foreach (var type in serviceBaseDerivedTypes)
{
    builder.Services.AddScoped(type);
}

// Setup swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "monkey API",
        Version = "v1"
    });
});

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

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "monkey API V1");
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
