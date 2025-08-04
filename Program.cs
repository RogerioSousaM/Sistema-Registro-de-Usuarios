using Microsoft.EntityFrameworkCore;
using RegistrarUsuarios.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure database context only if connection string is available
var connectionString = builder.Configuration.GetConnectionString("ConexaoPadrao");
if (!string.IsNullOrEmpty(connectionString))
{
    builder.Services.AddDbContext<NovoFuncionario>(options =>
        options.UseSqlServer(connectionString));
}
else
{
    // Add a dummy context for development/testing
    builder.Services.AddDbContext<NovoFuncionario>(options =>
        options.UseInMemoryDatabase("TestDatabase"));
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Ensure database is created and migrated only if using real database
if (!string.IsNullOrEmpty(connectionString))
{
    try
    {
        using (var scope = app.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<NovoFuncionario>();
            context.Database.EnsureCreated();
            
            // Apply migrations if they exist
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
        }
    }
    catch (Exception ex)
    {
        // Log the error but don't crash the application
        Console.WriteLine($"Database initialization error: {ex.Message}");
    }
}

app.Run();
