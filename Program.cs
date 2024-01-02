using Platform.Data;

namespace Platform
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IDataRepository, MockRepository>();

            //Configure Razor pages
            builder.Services.AddControllersWithViews();

            //Add Cors policy
            builder.Services.AddCors( options =>
            {
                options.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });

            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            /*if (!app.Environment.IsDevelopment())
            {
                app.UseHsts();
            }*/

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action=Index}/{id?}");

            app.MapFallbackToFile("index.html");

            app.UseCors("AllowAll");
            app.Run();
        }
    }
}