﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ConfigureServicesExample.Services;
using Microsoft.Extensions.Logging;
using ILogger = ConfigureServicesExample.Services.ILogger;

namespace ConfigureServicesExample
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ILogger, Logger>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILogger logger)
        {
            app.Run(async (context) =>
            {
                logger.Log("Logged line - got to Run in Configure");
                await context.Response.WriteAsync("This text was generated by the app. Run middleware.");
            });
        }
    }
}
