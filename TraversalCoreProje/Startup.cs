using BusinessLayer.Container;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;
using TraversalCoreProje.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProje.Models;

namespace TraversalCoreProje
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
            services.AddScoped<GetAllDestinationQueryHandler>();
            services.AddScoped<GetDestinationByIDQueryHandler>();
            services.AddScoped<CreateDestinationCommandHandler>();
            services.AddScoped<RemoveDestinationCommandHandler>();
            services.AddScoped<UpdateDestinationCommandHandler>();

            services.AddMediatR(typeof(Startup));
            //typeof(Startup) dediðimiz kýsýmda startup dosyasýyla ayný namespacede olan dosyalar için verdiðimiz dependency injection çalýþsýn demek istiyoruz.

            services.AddLogging(x =>
            {
                x.ClearProviders();
                x.SetMinimumLevel(LogLevel.Debug);
                x.AddDebug();
            });
            services.AddDbContext<Context>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();

            services.AddHttpClient();

            services.ContainerDependencies();

            services.AddAutoMapper(typeof(Startup));

            services.CustomerValidator();

            services.AddControllersWithViews().AddFluentValidation();

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddMvc();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Login/SingIn";
                options.LogoutPath = "/Default/Index";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            var path = Directory.GetCurrentDirectory();
            loggerFactory.AddFile($"{path}\\Logs\\Log1.txt");

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
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code{0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            // Bu kodu app.UseAuthorization(); den önce kullanmamýzýn sebebi ;

            /* Authentication,bir kullanýcýnýn herhangi bir kaynaða eriþimde kimliðinin doðrulanmasý iþlemidir. 
           Kullanýcýya Kimsin sorusu sorulur? Bu sorunun cevabý genellikle kullanýcýnýn kullanýcý  adý ve  þifre þeklinde cevap vermesiyle yanýtlanýr.
           Authentication,authorization'dan önce gelmektedir.
           Authorization ise,kimliði doðrulanan kullanýcýnýn eriþmek istediði kaynak üzerindeki yetkilerini tanýmlar.
           Peki authentication iþlemi yapýlmadan authorization iþlemi yapýlamaz mý?

           Kimsin sorusunun sorulmamasý demek herhangi birisi anlamýna gelir. 
           Dolayýsý ile kimliði doðrulanmayan yani anonim kullanýcýlara izin verileceði durumlarda bu iþlem gerçekleþtirilir. */

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
