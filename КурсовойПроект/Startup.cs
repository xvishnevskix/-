using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace КурсовойПроект
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            // поддержка контроллеров и представлений MVC
            services.AddControllersWithViews()
                //выставление совместимости с asp.net core 3.0
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {   
            //информация об ошибках
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

                //подключение поддержки статичных файлов в приложении (css js и тд)
                app.UseStaticFiles();
            //регистрация нужных маршрутов или эндпоинтов
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                });
            });
        }
    }
}
