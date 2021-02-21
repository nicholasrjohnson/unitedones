using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace unitedones
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
            services.AddDistributedMemoryCache();
            services.AddSession( options => {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.Cookie.Name = ".unitedones.Session";
            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "register",
                    pattern: "{controller=Home}/{action=Register}/{id?}");
                endpoints.MapControllerRoute(
                    name: "altertrip",
                    pattern: "{controller=Driver}/{action=AlterTrip}/{id?}");
                endpoints.MapControllerRoute(
                    name: "driverconfigure",
                    pattern: "{controller=Driver}/{action=Register}/{id?}");
                endpoints.MapControllerRoute(
                    name: "maketrip",
                    pattern: "{controller=Driver}/{action=MakeTrip}/{id?}");
                endpoints.MapControllerRoute(
                    name: "raterider",
                    pattern: "{controller=Driver}/{action=RateRider}/{id?}");
                endpoints.MapControllerRoute(
                    name: "setupvehicle",
                    pattern: "{controller=Driver}/{action=SetupVehicle}/{id?}");
                endpoints.MapControllerRoute(
                    name: "driverviewratings",
                    pattern: "{controller=Driver}/{action=ViewRatings}/{id?}");
                endpoints.MapControllerRoute(
                    name: "viewrider",
                    pattern: "{controller=Driver}/{action=ViewRider}/{id?}");
                endpoints.MapControllerRoute(
                    name: "veiwriderrating",
                    pattern: "{controller=Driver}/{action=ViewRiderRating}/{id?}");
                endpoints.MapControllerRoute(
                    name: "editprisons",
                    pattern: "{controller=Admin}/{action=AlterTrip}/{id?}");
                endpoints.MapControllerRoute(
                    name: "reviewdriver",
                    pattern: "{controller=Admin}/{action=ReviewDriver}/{id?}");
                endpoints.MapControllerRoute(
                    name: "reviewpayment",
                    pattern: "{controller=Admin}/{action=ReviewPayment}/{id?}");
                endpoints.MapControllerRoute(
                    name: "reviewratings",
                    pattern: "{controller=Admin}/{action=ReviewRatings}/{id?}");
                endpoints.MapControllerRoute(
                    name: "reviewrider",
                    pattern: "{controller=Admin}/{action=ReviewRider}/{id?}");
                endpoints.MapControllerRoute(
                    name: "reviewvehicle",
                    pattern: "{controller=Admin}/{action=ReviewVehicle}/{id?}");
                endpoints.MapControllerRoute(
                    name: "viewalltrips",
                    pattern: "{controller=Admin}/{action=ViewAllTrips}/{id?}");
                endpoints.MapControllerRoute(
                    name: "riderconfigure",
                    pattern: "{controller=Rider}/{action=ConfigurePreferences}/{id?}");
                endpoints.MapControllerRoute(
                    name: "ratedriver",
                    pattern: "{controller=Rider}/{action=RateDriver}/{id?}");
                endpoints.MapControllerRoute(
                    name: "selecttrip",
                    pattern: "{controller=Rider}/{action=SelectTrip}/{id?}");
                endpoints.MapControllerRoute(
                    name: "viewdriver",
                    pattern: "{controller=Rider}/{action=ViewDriver}/{id?}");
                endpoints.MapControllerRoute(
                    name: "viewdriverrating",
                    pattern: "{controller=Rider}/{action=ViewDriverRating}/{id?}");
                endpoints.MapControllerRoute(
                    name: "riderviewratings",
                    pattern: "{controller=Rider{action=ViewRatings}/{id?}");
                endpoints.MapControllerRoute(
                    name: "driverconfigure",
                    pattern: "{controller=Driver}/{action=Register}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "register",
                    pattern: "{controller=Home}/{action=Register}/{id?}");
                endpoints.MapControllerRoute(
                    name: "altertrip",
                    pattern: "{controller=Driver}/{action=AlterTrip}/{id?}");
                endpoints.MapControllerRoute(
                    name: "driverconfigure",
                    pattern: "{controller=Driver}/{action=Register}/{id?}");
            });
        }
    }
}
