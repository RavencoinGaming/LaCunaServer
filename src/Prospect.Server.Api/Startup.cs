using LaCunaServer.Server.Api.Config;
using LaCunaServer.Server.Api.Converters;
using LaCunaServer.Server.Api.Hubs;
using LaCunaServer.Server.Api.Middleware;
using LaCunaServer.Server.Api.Services.Auth;
using LaCunaServer.Server.Api.Services.CloudScript;
using LaCunaServer.Server.Api.Services.Database;
using LaCunaServer.Server.Api.Services.Qos;
using LaCunaServer.Server.Api.Services.UserData;
using Serilog;

namespace LaCunaServer.Server.Api;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    private IConfiguration Configuration { get; }
        
    public void ConfigureServices(IServiceCollection services)
    {
        services.Configure<AuthTokenSettings>(Configuration.GetSection(nameof(AuthTokenSettings)));
        services.Configure<DatabaseSettings>(Configuration.GetSection(nameof(DatabaseSettings)));
        services.Configure<PlayFabSettings>(Configuration.GetSection(nameof(PlayFabSettings)));

        services.AddSingleton<AuthTokenService>();
        services.AddSingleton<UserDataService>();
        services.AddSingleton<TitleDataService>();
            
        services.AddSingleton<DbUserService>();
        services.AddSingleton<DbEntityService>();
            
        services.AddSingleton<DbUserDataService>();

        services.AddHostedService<QosService>();
        services.AddSingleton<QosServer>();

        services.AddScoped<CloudScriptService>();
        services.AddSingleton<CloudScriptFunctionLoader>();
        
        services.AddAuthentication(_ =>
            {
                    
            })
            .AddUserAuthentication(_ => {})
            .AddEntityAuthentication(_ => {});

        services.AddHttpContextAccessor();

        services.AddSignalR();
        
        services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.Converters.Add(new DateTimeConverter());
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
            
        app.UseSerilogRequestLogging();
        app.UseMiddleware<RequestLoggerMiddleware>();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapHub<CycleHub>("/signalr");
        });
    }
}