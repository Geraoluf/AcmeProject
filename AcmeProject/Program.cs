using AcmeProject.Data;
using ClassLibrary;
using DataClassLibary.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllersWithViews();

builder.Services.AddScoped <SubmissionService>();


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddDbContext<IdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityConnection")));


builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<IdentityContext>();


builder.Services.AddRazorPages();



var app = builder.Build();



if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


using (var scope = app.Services.CreateScope())  //automatic migratiu and update db
{ 
    var services = scope.ServiceProvider;

    var identityDb = services.GetRequiredService<IdentityContext>();
    identityDb.Database.Migrate();

    var appDb = services.GetRequiredService<AppDbContext>();
    appDb.Database.Migrate();
}

// seed data
static async Task SeedAsync(WebApplication app)   //seed data to Identity db
{
    using var scope = app.Services.CreateScope();

    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    string roleName = "Admin";

    if (!await roleManager.RoleExistsAsync(roleName)) //role only one time
    {
        await roleManager.CreateAsync(new IdentityRole(roleName));
    }

    string adminEmail = "admin@site.dk";
    string adminPassword = "Admin123!";

    var user = await userManager.FindByEmailAsync(adminEmail);

    if (user == null)
    {
        user = new IdentityUser
        {
            UserName = adminEmail,
            Email = adminEmail,
            EmailConfirmed = true
        };

        await userManager.CreateAsync(user, adminPassword);
        await userManager.AddToRoleAsync(user, roleName);
    }
}
await SeedAsync(app);

app.Run();