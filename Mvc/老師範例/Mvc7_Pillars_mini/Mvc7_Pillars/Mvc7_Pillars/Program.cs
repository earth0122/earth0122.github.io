var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
                .AddSessionStateTempDataProvider();

builder.Services.AddSession();

//取得組態中資料庫連線設定
string connectionString = builder.Configuration.GetConnectionString("FriendContext");

//註冊EF Core的FriendContext
builder.Services.AddDbContext<FriendContext>(options => options.UseSqlServer(connectionString));


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

app.UseSession();

app.Map("/appversion", () => "ASP.NET Core MVC");
app.Map("/designer", () => "奚江華設計");

//MapControllerRoute用來定義單一路由
//若有多個路由則需定義多個app.MapControllerRoute(...);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
