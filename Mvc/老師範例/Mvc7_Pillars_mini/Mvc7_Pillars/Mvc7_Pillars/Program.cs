var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
                .AddSessionStateTempDataProvider();

builder.Services.AddSession();

//���o�պA����Ʈw�s�u�]�w
string connectionString = builder.Configuration.GetConnectionString("FriendContext");

//���UEF Core��FriendContext
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
app.Map("/designer", () => "�O���س]�p");

//MapControllerRoute�Ψөw�q��@����
//�Y���h�Ӹ��ѫh�ݩw�q�h��app.MapControllerRoute(...);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
