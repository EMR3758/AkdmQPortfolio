using Microsoft.EntityFrameworkCore;
using PortfolyoDbContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Uygulamanýn servis container'ýna DbContext ekleniyor
builder.Services.AddDbContext<portfolyodbContext>(options =>

    // DbContext ayarlarý yapýlýyor
    options.UseSqlServer(

        // appsettings.json içindeki
        // "ConnectionStrings" bölümünden
        // "DefaultConnection" adlý baðlantý cümlesi okunuyor
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


//Program cs dediðimiz þey projemiz ilk açýldýðýnda çalýþýcak kodlar
//Proje ilk açýldýðýnda veri tabanýna baðlanmasýný istiyorum
//Bunun için veri tabanýný temsil eden sýnýf(DbContext) bunu burada tanýmlamam gerekiyor