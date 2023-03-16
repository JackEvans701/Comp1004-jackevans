using Microsoft.AspNetCore.Builder;

namespace Comp1004_jackevans
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

            app.UseRouting();

            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}
