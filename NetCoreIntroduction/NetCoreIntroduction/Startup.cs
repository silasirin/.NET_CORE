using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIntroduction
{
    public class Startup
    {

        //Configure Service methodu => Projeyi ilk olusturdugumuzda aslinda bir mvc projesi olarak olusturulmuyor. Biz buradaki servisi kullanarak method icerisinde mvc yapisini eklemek icin kullandik.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }


        //Configure methodu  uygulamaya dahil edilen servislerin entegre edildigi ve yapilandirildigi methoddur. Bu method altinda 
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(x =>
            {
                x.MapDefaultControllerRoute(); //Home/Index/ID'yi temsil ediyor.
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}
