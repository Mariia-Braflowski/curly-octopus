using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoneyShare.Core.DAL.Interfaces;
using MoneyShare.Core.DAL.Models;
using MoneyShare.Core.DAL.Repositories;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using MoneyShare.Core.DAL.Context;
using MoneyShare.Core.BLL.Inrefaces;
using MoneyShare.Core.BLL.Services;
using Microsoft.AspNetCore.Identity;

namespace MoneyShare
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSwaggerGen();

            services.AddDbContext<ApplicationContext> (options =>
                    options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"))
                    );

            services.AddDbContext<IdentityContext>(options =>
                  options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"))
                   );

            services.AddIdentity<User, IdentityRole>(opts => {
                opts.Password.RequiredLength = 5;   // минимальная длина
                opts.Password.RequireNonAlphanumeric = false;   // требуются ли не алфавитно-цифровые символы
                opts.Password.RequireLowercase = false; // требуются ли символы в нижнем регистре
                opts.Password.RequireUppercase = false; // требуются ли символы в верхнем регистре
                opts.Password.RequireDigit = false; // требуются ли цифры
            }).AddEntityFrameworkStores<IdentityContext>(); //TODO how and why

            services.AddTransient<IRepository<Category>, CategoryRepository>();
            services.AddTransient<IRepository<Record>, RecordRepository>();

            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IRecordService, RecordService>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseRouting();   

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Money share");
            });
        }
    }
}
