﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MyExpenditures.DbModels;
using MyExpenditures.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using System.Reflection;

namespace MyExpenditures
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
             Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddScoped<IExpendituresService, ExpendituresService>();

            services.AddAutoMapper(
                opt => opt.CreateMissingTypeMaps = true,
                Assembly.GetEntryAssembly());

            services.AddDbContext<ExpenditureDbContext>(options =>
                options.UseSqlServer(
                    Configuration["Data:MyExpenditures:ConnectionString"]));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}