using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//���o�պA����Ʈw�s�u�]�w
string connectionString = builder.Configuration.GetConnectionString("EmployeeContext");

//���UEF Core��EmployeeContext
builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(connectionString));


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

//for the HtmlPages folder
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "HtmlPages")),
    RequestPath = "/HtmlPages"
});

app.UseRouting();

app.UseAuthorization();

//ASP.NET Core ��������
//https://docs.microsoft.com/zh-tw/aspnet/core/fundamentals/routing?view=aspnetcore-7.0
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//�H�U���P
app.MapControllerRoute(
    name: "default_route",
    pattern: "{controller}/{action}/{id?}",
    defaults: new { controller = "Home", action = "Index" });

app.Run();
