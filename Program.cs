using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.DataAccess;
using SchoolManagementSystem.DataAccess.Abstract;
using SchoolManagementSystem.DataAccess.Concrete;
using SchoolManagementSystem.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers().AddJsonOptions(options =>
{                                                                   //Bu kisim include fonksiyonunun json loop exception vermesini engelliyor
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

builder.Services.AddDbContext<SchoolDbContext>((options) =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DbConnection"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking); //as no query �zelligini her db islemi icin kullanilir state catismasini �nler
});

builder.Services.AddIdentity<User, IdentityRole>()
                    .AddEntityFrameworkStores<SchoolDbContext>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUserRepository, UserService>();
builder.Services.AddScoped<ITeacherRepository, TeacherService>();
builder.Services.AddScoped<IStudentRepository, StudentService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
