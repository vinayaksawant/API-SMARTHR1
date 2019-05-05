using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APISMARTHR1.Entities;
using APISMARTHR1.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace APISMARTHR1
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddCors(
                options =>
                {
                    options.AddPolicy("CorsPolicy",
                        builder =>
                        builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials()
                        );
                });

            var connectionstring = Configuration["ConnectionStrings:APISMARTHR1DBConnectionString"];
            services.AddDbContext<APISMARTHR1.Entities.EmployerContext>(
                                            options =>
                                            options.UseSqlServer(connectionstring)
                                            );

            services.AddScoped<IEmployer_Repo, Employer_Repo>();

            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entities.Employer, DTO.Employer_DTO>();

                cfg.CreateMap<Entities.EmployeeEvent, DTO.Employee_DTO>(AutoMapper.MemberList.None);

                cfg.CreateMap<Entities.Address, DTO.Address_DTO>()
                .ForMember("AddressType",opt => opt.MapFrom(src => src.AddressType.AddressTypeCode));

                cfg.CreateMap<Entities.Email, DTO.Email_DTO>()
                .ForMember("EmailType", opt => opt.MapFrom(src => src.EmailType.EmailTypeCode));

                cfg.CreateMap<Entities.Phone, DTO.Phone_DTO>()
                .ForMember("PhoneType", opt => opt.MapFrom(src => src.PhoneType.PhoneTypeCode));

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env
            ,EmployerContext employerContext)
        {
            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            //employerContext.EnsureSeedDataForContext();
            app.UseCors("CorsPolicy");
            app.UseHttpsRedirection();

            app.UseMvc();
        }
    }
}
