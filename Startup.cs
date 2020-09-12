using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ecommerce.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Ecommerce.Services;

namespace Ecommerce
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            /* services.AddDefaultIdentity<IdentityUser>()
                 .AddEntityFrameworkStores<ApplicationDbContext>();*/
            services.AddIdentity<Ecommerce.Models.Utenti, Ruoli>(options => options.Stores.MaxLengthForKeys = 128)
           .AddEntityFrameworkStores<ApplicationDbContext>()
           .AddDefaultUI()
          .AddDefaultTokenProviders();
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<SignInManager<Utenti>, SignInManager<Utenti>>();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdministratorRole", policy => policy.RequireRole("Admin"));
                options.AddPolicy("RequireManagerRole", policy => policy.RequireRole("Manager"));
            });

          
            services.AddMvc()
               .AddRazorPagesOptions(options =>
               {
                   //options.Conventions.AuthorizeFolder("/Account/Manage");
                   options.Conventions.AuthorizeFolder("/Pages");
                   options.Conventions.AuthorizeFolder("/Clienti", "RequireAdministratorRole");
                   options.Conventions.AuthorizePage("/Account/Logout");
                   //options.Conventions.AuthorizePage("/IndexClienti");
                   //options.Conventions.AuthorizePage("/IndexFornitori");
                   //options.Conventions.AuthorizePage("/Prodotti/Edit", "RequireManagerRole");
                   //options.Conventions.AuthorizePage("/Prodotti/Edit", "RequireManagerRole");
                   //options.Conventions.AuthorizePage("/IndexVendite");
                   options.Conventions.AuthorizeFolder("/Admin", "RequireAdministratorRole");
                   //options.Conventions.AuthorizePage("/CreateRuoli", "RequireAdministratorRole");
                   //options.Conventions.AuthorizePage("/IndexRuoli", "RequireAdministratorRole");
                   options.Conventions.AuthorizePage("/Clienti/CreateCliente", "RequireAdministratorRole");
               });
            services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
            });
            services.Configure<IdentityOptions>(options =>
            {
                // Default User settings.
                options.User.AllowedUserNameCharacters =
                        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;

            });
          
            services.AddTransient<Services.EmailSender>();
            services.AddSingleton<Services.EmailSender>();


            //In-Memory Caching
            services.AddMemoryCache();

        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
