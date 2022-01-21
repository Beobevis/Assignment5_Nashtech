var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "Nashtech/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
name: "default2",
pattern: "Nashtech/{controller=Assignment}/{action=Index}/{id?}");
// app.MapControllerRoute(
// name: "export",
// pattern: "Nashtech/{controller=Assignment}/{action=ExportFile}/{id?}");

app.Run();