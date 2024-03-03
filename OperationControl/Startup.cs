//using Microsoft.EntityFrameworkCore;
//using OperationControl.Models;

//namespace OperationControl
//{
    //public class Startup
    //{
        //public IConfiguration Configuration { get; }

        //public Startup(IConfiguration configuration)
        //{
            //Configuration = configuration;
        //}

        //public void ConfigureServices(IServiceCollection services)
        //{
            // Adicione o Entity Framework ao serviço
            //services.AddDbContext<AppDbContext>(options =>
                //options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

            // ...
        //}

        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //{
            // ... outras configurações ...

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
                //endpoints.MapRazorPages();
                //endpoints.MapControllerRoute(
                    //name: "default",
                    //pattern: "{controller=Home}/{action=Index}/{id?}");
            //});
        //}
    //}
//}



