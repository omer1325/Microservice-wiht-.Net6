
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication().AddJwtBearer("GatewayAuthenticationScheme", options =>
{
    options.Authority = builder.Configuration.GetValue<string>("IdentityServerUrl");
    options.Audience = "resource_gateway";
    options.RequireHttpsMetadata = false;
});

builder.Services.AddOcelot();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseOcelot().Wait();

app.Run();
