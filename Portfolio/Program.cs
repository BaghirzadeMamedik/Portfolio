using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
var app = builder.Build();

builder.Services.AddControllersWithViews();

app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}"

    ) ;
app.MapRazorPages();

app.Run();
