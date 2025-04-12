﻿public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // servis kayıtları
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Hello from Startup.cs!");
            });
        });
    }
}