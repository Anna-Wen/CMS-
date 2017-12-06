﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClassManagementSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",

                    //template: "{controller=Student}/{action=StudentCourseHome}/{id?}");
                    //template: "{controller=Teacher}/{action=NewSeminar}/{id?}");
                    //template: "{controller=Teacher}/{action=CheckClassInfo}/{id?}");
                    //template: "{controller=Teacher}/{action=CreateClass}/{id?}");
                    //template: "{controller=Teacher}/{action=CreateCourse}/{id?}");
                    template: "{controller=Teacher}/{action=CreateSeminar}/{id?}");
                //template: "{controller=Teacher}/{action=CheckTopicBeforeClass}/{id?}");
                //template: "{controller=Teacher}/{action=Bind}/{id?}");
                //template: "{controller=Home}/{action=AccountLoginPage}/{id?}");
                //template: "{controller=Home}/{action=Register}/{id?}");
                //template: "{controller=Home}/{action=AccountLogin}/{id?}");

            });
        }
    }
}
