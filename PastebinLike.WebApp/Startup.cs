﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PastebinLike.Core.Repositories;
using PastebinLike.Infrastructure.Accessors;
using PastebinLike.Infrastructure.Persistence;
using PastebinLike.Infrastructure.Persistence.Repositories;
using PastebinLike.WebApp.Services;

namespace PastebinLike.WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();

            services.AddDbContext<PastebinLikeContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Pastebin")));

            services.AddSingleton<FileStorageService>();

            services.AddScoped<IPastebinRepository, PastebinRepository>();
            services.AddScoped<IPastebinService, PastebinService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
