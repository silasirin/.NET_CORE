using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCoreFakeRepository.Models.BaseRepository;
using NetCoreFakeRepository.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFakeRepository
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); //bu servis aslinda bir MVC servisidir. Bu sayede ilk olarak controller tetiklenir. AddTransient ile controller'daki constructor'in ilk olarak tetiklenmesini sagliyor.

            //services.AddSingleton<>();
            //services.AddScoped<>();
            //services.AddTransient<>();

            services.AddTransient<IEmployeeRepository, EmployeeData>(); //Ilk parametre interface, ikinci parametre concrete 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(x =>
            {
                x.MapControllerRoute(name: "default", pattern: "{Controller=Home}/{Action=Index}/{id?}");
            });

        }
    }
}
