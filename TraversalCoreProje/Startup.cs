using BusinessLayer.Container;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Razor;
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
            //typeof(Startup) dedi�imiz k�s�mda startup dosyas�yla ayn� namespacede olan dosyalar i�in verdi�imiz dependency injection �al��s�n demek istiyoruz.

            services.AddLogging(x =>
            {
                x.ClearProviders();
                x.SetMinimumLevel(LogLevel.Debug);
                x.AddDebug();
            });
            services.AddDbContext<Context>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>().AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).AddEntityFrameworkStores<Context>();

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

            services.AddLocalization(opt =>
            {
                opt.ResourcesPath = "Resources";
            });

            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();

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
            // Bu kodu app.UseAuthorization(); den �nce kullanmam�z�n sebebi ;

            /* Authentication,bir kullan�c�n�n herhangi bir kayna�a eri�imde kimli�inin do�rulanmas� i�lemidir. 
           Kullan�c�ya Kimsin sorusu sorulur? Bu sorunun cevab� genellikle kullan�c�n�n kullan�c�  ad� ve  �ifre �eklinde cevap vermesiyle yan�tlan�r.
           Authentication,authorization'dan �nce gelmektedir.
           Authorization ise,kimli�i do�rulanan kullan�c�n�n eri�mek istedi�i kaynak �zerindeki yetkilerini tan�mlar.
           Peki authentication i�lemi yap�lmadan authorization i�lemi yap�lamaz m�?

           Kimsin sorusunun sorulmamas� demek herhangi birisi anlam�na gelir. 
           Dolay�s� ile kimli�i do�rulanmayan yani anonim kullan�c�lara izin verilece�i durumlarda bu i�lem ger�ekle�tirilir. */

            var suppertesCultures = new[] { "en", "fr", "es", "gr", "tr", "de" };
            var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(suppertesCultures[4]).AddSupportedCultures(suppertesCultures).AddSupportedUICultures(suppertesCultures);
            app.UseRequestLocalization(localizationOptions);

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
