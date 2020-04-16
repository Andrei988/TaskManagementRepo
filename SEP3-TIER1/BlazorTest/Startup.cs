using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Blazored.Modal;
using BlazorTest.Controllers;
using BlazorTest.Networking;

namespace BlazorTest
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
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<LoginController>();
            services.AddSingleton<RegisterController>();
            services.AddSingleton<UserController>();
            services.AddSingleton<ProjectController>();
            services.AddSingleton<NotificationsController>();
            services.AddSingleton<TasksController>();
            services.AddSingleton<ChannelsController>();
            services.AddSingleton<ChannelChatController>();
            services.AddSingleton<AsyncClient>();
            services.AddSingleton<Services.AppData>();
            services.AddBlazoredModal();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}