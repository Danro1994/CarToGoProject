using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car_To_Go.ApplicationService;
using Car_To_Go.DataContext;
using Car_To_Go.DomainService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Car_To_Go
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
            services.AddDbContext<CarToGoDataContext>();
            services.AddScoped<BrandAppService>();
            services.AddScoped<BrandDomainService>();
            services.AddScoped<ConditionAppService>();
            services.AddScoped<ConditionDomainService>();
            services.AddScoped<SellerAppService>();
            services.AddScoped<SellerDomainService>();
            services.AddScoped<PhotoAppService>();
            services.AddScoped<PhotoDomainService>();
            services.AddScoped<StatusAppService>();
            services.AddScoped<StatusDomainService>();
            services.AddScoped<ModelAppService>();
            services.AddScoped<ModelDomainService>();
            services.AddScoped<CarDomainService>();
            services.AddScoped<CarAppService>();

            services.AddMvc()
                 .AddJsonOptions(Options => Options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder =>
            {
                builder.WithOrigins("*");
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            });
            app.UseMvc();
        }
    }
}
